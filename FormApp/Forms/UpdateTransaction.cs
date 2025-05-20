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
using ClassLibrary.Persistence;
using ClassLibrary.Models;

namespace FormApp.Forms
{
    public partial class UpdateTransaction : Form
    {
        private readonly DBContext _context;
        private readonly int transactionId;

        public UpdateTransaction(int id)
        {
            InitializeComponent();
            transactionId = id;
            _context = new DBContext();

            // display user info
            lblName.Text = UserSession.FullName;

            RoleHelper.ApplyRolePermissions(
            UserSession.RoleID,
            lblRole
            );

            this.StartPosition = FormStartPosition.CenterScreen;

            LoadDropdowns();
            LoadTransactionData(); // load current values
        }

        private void UpdateTransaction_Load(object sender, EventArgs e)
        {

        }

        private void LoadTransactionData()
        {
            var transaction = _context.RentalTransactions.FirstOrDefault(t => t.Id == transactionId);

            if (transaction != null)
            {
                txtUserID.Text = transaction.UserId.ToString();
                dtpPickupDate.Value = transaction.Pickup;
                dtpReturnDate.Value = transaction.ReturnDate;
                txtFee.Text = transaction.Fee.ToString();
                txtDeposit.Text = transaction.Deposit.ToString();
                cmbRentalStatus.SelectedValue = transaction.RentalStatus;
                cmbPaymentStatus.SelectedValue = transaction.PaymentStatus;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
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
                    MessageBox.Show("User ID must be numeric.", "Validation Error");
                    return;
                }

                if (!_context.Users.Any(u => u.Id == userId))
                {
                    MessageBox.Show("User ID does not exist.", "Validation Error");
                    return;
                }

                DateTime pickupDate = dtpPickupDate.Value;
                DateTime returnDate = dtpReturnDate.Value;

                if (returnDate <= pickupDate)
                {
                    MessageBox.Show("Return Date must be after Pickup Date.");
                    return;
                }

                if (!decimal.TryParse(txtFee.Text.Trim(), out decimal fee) ||
                    !decimal.TryParse(txtDeposit.Text.Trim(), out decimal deposit))
                {
                    MessageBox.Show("Fee and Deposit must be valid numbers.");
                    return;
                }

                if (deposit > fee)
                {
                    MessageBox.Show("Deposit cannot be greater than Fee.");
                    return;
                }

                int period = (returnDate - pickupDate).Days;
                int rentalStatusId = Convert.ToInt32(cmbRentalStatus.SelectedValue);
                int paymentStatusId = Convert.ToInt32(cmbPaymentStatus.SelectedValue);

                // Get the transaction
                var transaction = _context.RentalTransactions.FirstOrDefault(t => t.Id == transactionId);
                if (transaction == null)
                {
                    MessageBox.Show("Transaction not found.", "Error");
                    return;
                }

                // Update values
                transaction.UserId = userId;
                transaction.Pickup = pickupDate;
                transaction.ReturnDate = returnDate;
                transaction.Period = period;
                transaction.Fee = fee;
                transaction.Deposit = deposit;
                transaction.RentalStatus = rentalStatusId;
                transaction.PaymentStatus = paymentStatusId;

                _context.SaveChanges();

                // Log the update
                Log log = new Log
                {
                    UserId = UserSession.UserID,
                    Action = "Update Rental Transaction",
                    TimeStamp = DateTime.Now,
                    AffectedData = $"Updated Transaction ID {transactionId} – Fee: {fee}, Return Date: {returnDate:yyyy-MM-dd}",
                    Source = "UpdateTransaction Form"
                };

                _context.Logs.Add(log);
                _context.SaveChanges();

                MessageBox.Show("Transaction updated successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating transaction:\n" + ex.Message, "Error");
            }
        }

        private void LoadDropdowns()
        {
            // Rental Status
            var rentalStatuses = _context.RentalStatuses
                .Select(s => new { s.Id, s.Status })
                .ToList();
            rentalStatuses.Insert(0, new { Id = -1, Status = "Rental Status" });
            cmbRentalStatus.DataSource = rentalStatuses;
            cmbRentalStatus.DisplayMember = "Status";
            cmbRentalStatus.ValueMember = "Id";

            // Payment Status
            var paymentStatuses = _context.PaymentStatuses
                .Select(p => new { p.Id, p.Status })
                .ToList();
            paymentStatuses.Insert(0, new { Id = -1, Status = "Payment Status" });
            cmbPaymentStatus.DataSource = paymentStatuses;
            cmbPaymentStatus.DisplayMember = "Status";
            cmbPaymentStatus.ValueMember = "Id";

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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
