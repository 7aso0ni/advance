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
using Microsoft.EntityFrameworkCore;

namespace FormApp.Forms
{
    public partial class RentalTransactionFilter : Form
    {

        // Properties to pass filter values back to the main form
        public string RequestId { get; private set; }
        public string FullName { get; private set; }
        public string Fee { get; private set; }
        public string PickupDate { get; private set; }
        public string ReturnDate { get; private set; }
        public string PaymentStatus { get; private set; }
        public string RentalStatus { get; private set; }

        public RentalTransactionFilter()
        {
            InitializeComponent();
            LoadDropdowns(); // Load combo box values
        }

        // Load available values for Payment Status and Rental Status
        private void LoadDropdowns()
        {
            try
            {
                using (var context = new DBContext())
                {
                    var paymentStatuses = context.PaymentStatuses
                        .Select(p => p.Status)
                        .ToList();
                    paymentStatuses.Insert(0, "Select Payment");
                    cmbPayment.DataSource = paymentStatuses;

                    var rentalStatuses = context.RentalStatuses
                        .Select(r => r.Status)
                        .ToList();
                    rentalStatuses.Insert(0, "Select Rental");
                    cmbRentalStatus.DataSource = rentalStatuses;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dropdowns: " + ex.Message);
            }
        }

        // Apply filter button click
      //  private void btnApplyFilters_Click(object sender, EventArgs e)
        //{
            
                
            
       // }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void RentalTransactionFilter_Load(object sender, EventArgs e)
        {

        }

        private void btnApplyFilters_Click_1(object sender, EventArgs e)
        {
            // Check if all fields are empty
            if (string.IsNullOrWhiteSpace(txtReqId.Text) &&
                string.IsNullOrWhiteSpace(txtFullName.Text) &&
                string.IsNullOrWhiteSpace(txtFee.Text) &&
                cmbPayment.Text == "Select Payment" &&
                cmbRentalStatus.Text == "Select Rental")
            {
                MessageBox.Show("Please enter at least one filter value.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Request ID (if provided)
            if (!string.IsNullOrWhiteSpace(txtReqId.Text) && !int.TryParse(txtReqId.Text.Trim(), out _))
            {
                MessageBox.Show("Request ID must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Fee (if provided)
            if (!string.IsNullOrWhiteSpace(txtFee.Text) && !decimal.TryParse(txtFee.Text.Trim(), out _))
            {
                MessageBox.Show("Fee must be a valid decimal number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Full Name (optional: should not contain digits)
            if (!string.IsNullOrWhiteSpace(txtFullName.Text) &&
                txtFullName.Text.Any(ch => char.IsDigit(ch) || char.IsSymbol(ch)))
            {
                MessageBox.Show("Full name should not contain numbers or special characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var context = new DBContext())
                {
                    var query = context.RentalTransactions
                        .Include(t => t.User)
                        .Include(t => t.PaymentStatusNavigation)
                        .Include(t => t.RentalStatusNavigation)
                        .AsQueryable();

                    // Apply filters
                    if (int.TryParse(txtReqId.Text.Trim(), out int reqId))
                        query = query.Where(t => t.Id == reqId);

                    if (!string.IsNullOrWhiteSpace(txtFullName.Text))
                        query = query.Where(t => t.User.Fname.ToLower().Contains(txtFullName.Text.Trim().ToLower()));

                    if (decimal.TryParse(txtFee.Text.Trim(), out decimal fee))
                        query = query.Where(t => t.Fee == fee);

                    if (!string.IsNullOrWhiteSpace(cmbPayment.Text) && cmbPayment.Text != "Select Payment")
                        query = query.Where(t => t.PaymentStatusNavigation.Status == cmbPayment.Text);

                    if (!string.IsNullOrWhiteSpace(cmbRentalStatus.Text) && cmbRentalStatus.Text != "Select Rental")
                        query = query.Where(t => t.RentalStatusNavigation.Status == cmbRentalStatus.Text);

                    DateTime pickupDate = dtpPickup.Value.Date;
                    DateTime returnDate = dtpReturn.Value.Date;
                    query = query.Where(t => t.Pickup.Date == pickupDate);
                    query = query.Where(t => t.ReturnDate.Date == returnDate);

                    var result = query.ToList();

                    if (result.Count == 0)
                    {
                        MessageBox.Show("No matching records found.", "Filter Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Pass values to parent form
                    RequestId = txtReqId.Text.Trim();
                    FullName = txtFullName.Text.Trim();
                    Fee = txtFee.Text.Trim();
                    PickupDate = pickupDate.ToString("yyyy-MM-dd");
                    ReturnDate = returnDate.ToString("yyyy-MM-dd");
                    PaymentStatus = cmbPayment.Text;
                    RentalStatus = cmbRentalStatus.Text;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during filtering: " + ex.Message);
            }
        }
    }
}
