using ClassLibrary.Models;
using ClassLibrary.Persistence;
using FormApp.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp.Forms
{
    public partial class CreateTransaction : Form
    {
        private readonly DBContext _context;

        public CreateTransaction()
        {
            InitializeComponent();

            _context = new DBContext();

            lblName.Text = UserSession.FullName;

            RoleHelper.ApplyRolePermissions(
            UserSession.RoleID,
            lblRole
            );

            this.StartPosition = FormStartPosition.CenterScreen;

            LoadDropdowns();
        }

        private void CreateTransaction_Load(object sender, EventArgs e)
        {

        }

        private void LoadDropdowns()
        {
            // rental Status dropdown
            var rentalStatuses = _context.RentalStatuses
                .Select(rs => new { rs.Id, rs.Status })
                .ToList();

            rentalStatuses.Insert(0, new { Id = -1, Status = "Rental Status" });

            cmbRentalStatus.DataSource = rentalStatuses;
            cmbRentalStatus.DisplayMember = "Status";
            cmbRentalStatus.ValueMember = "Id";

            // payment Status dropdown
            var paymentStatuses = _context.PaymentStatuses
                .Select(ps => new { ps.Id, ps.Status })
                .ToList();

            paymentStatuses.Insert(0, new { Id = -1, Status = "Payment Status" });

            cmbPaymentStatus.DataSource = paymentStatuses;
            cmbPaymentStatus.DisplayMember = "Status";
            cmbPaymentStatus.ValueMember = "Id";

            cmbRentalStatus.SelectedIndex = 0;
            cmbPaymentStatus.SelectedIndex = 0;
        }

        // when the create button is clicked
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtUserID.Text) ||
                    string.IsNullOrWhiteSpace(txtFee.Text) ||
                    string.IsNullOrWhiteSpace(txtDeposit.Text) ||
                    Convert.ToInt32(cmbRentalStatus.SelectedValue) == -1 ||
                    Convert.ToInt32(cmbPaymentStatus.SelectedValue) == -1)
                {
                    MessageBox.Show("Please fill all the details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtUserID.Text.Trim(), out int userId))
                {
                    MessageBox.Show("Please enter a valid numeric User ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!_context.Users.Any(u => u.Id == userId))
                {
                    MessageBox.Show("User ID does not exist in the system.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime pickupDate = dtpPickupDate.Value;

                DateTime returnDate = dtpReturnDate.Value;

                if (returnDate <= pickupDate)
                {
                    MessageBox.Show("Return Date must be later than Pickup Date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int period = (returnDate - pickupDate).Days;

                if (!decimal.TryParse(txtFee.Text.Trim(), out decimal fee))
                {
                    MessageBox.Show("Please enter a valid numeric fee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtDeposit.Text.Trim(), out decimal deposit))
                {
                    MessageBox.Show("Please enter a valid numeric deposit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (deposit > fee)
                {
                    MessageBox.Show("Deposit cannot be greater than the fee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int rentalStatusId = Convert.ToInt32(cmbRentalStatus.SelectedValue);
                int paymentStatusId = Convert.ToInt32(cmbPaymentStatus.SelectedValue);

                var newTransaction = new RentalTransaction
                {
                    UserId = userId,
                    RentalStatus = rentalStatusId,
                    Pickup = pickupDate,
                    ReturnDate = returnDate,
                    Period = period,
                    Fee = fee,
                    Deposit = deposit,
                    PaymentStatus = paymentStatusId
                };

                _context.RentalTransactions.Add(newTransaction);
                _context.SaveChanges();

                // Log transaction creation
                Log log = new Log
                {
                    UserId = UserSession.UserID,
                    Action = "Create Rental Transaction",
                    TimeStamp = DateTime.Now,
                    AffectedData = $"Rental Transaction Created for User ID: {newTransaction.UserId}, Period: {newTransaction.Period} days, Fee: {newTransaction.Fee}, Deposit: {newTransaction.Deposit}",
                    Source = "CreateTransaction Form"
                };

                _context.Logs.Add(log);
                _context.SaveChanges(); // Save log entry

                MessageBox.Show("Transaction created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // clear all form fields
        private void ClearFields()
        {
            txtUserID.Clear();
            dtpPickupDate.Value = DateTime.Today;
            dtpReturnDate.Value = DateTime.Today;
            txtFee.Clear();
            txtDeposit.Clear();

            cmbRentalStatus.SelectedIndex = 0;
            cmbPaymentStatus.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // return to rental transactions form
            this.Hide();
            RentalTransactions rentalTransactions = new RentalTransactions();
            rentalTransactions.Show();
        }
    }
}
