using ClassLibrary.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using ClassLibrary.Models;
using FormApp.Forms;
using FormApp.Classes;

namespace FormApp.Forms
{
    public partial class UpdateRentalRequest : Form
    {
        private RentalRequest currentRequest;
        DBContext context;

        // Constructor receives the RentalRequest object to be edited
        public UpdateRentalRequest(RentalRequest request)
        {
            InitializeComponent();
            context = new DBContext();
            currentRequest = request;

            // Display current user info
            lblUserName.Text = UserSession.FullName;

            // Apply role-based access
            RoleHelper.ApplyRolePermissions(
                UserSession.RoleID,
                lblPosition
            );

            // Populate form fields with request data
            txtReqId.Text = request.Id.ToString();
            txtEqName.Text = request.Equipment?.Name ?? "Unknown";
            dptStartDate.Value = request.StartDate;
            dptReturnDate.Value = request.ReturnDate;
            txtCost.Text = request.Cost.ToString("0.00");

            // Load rental statuses into ComboBox
            LoadRentalStatuses();

            // Set current status as selected
            cmbRentalStatus.SelectedValue = request.RentalStatus;
        }

        // Load all rental statuses from DB into ComboBox
        private void LoadRentalStatuses()
        {
            using (var context = new DBContext())
            {
                var statuses = context.RentalStatuses.ToList();
                cmbRentalStatus.DataSource = statuses;
                cmbRentalStatus.DisplayMember = "Status";
                cmbRentalStatus.ValueMember = "Id";
            }
        }

        // Back button: navigate to Rental Requests form
        private void btnBack_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<RentalRequests>(this);
        }

        // Form Load (empty but available if needed)
        private void UpdateRentalRequest_Load(object sender, EventArgs e) { }

        // Save updated rental request details
        private void btnSave_Click(object sender, EventArgs e)
        {
            // ====== Input Validations ======

            // Check that return date is after start date
            if (dptReturnDate.Value < dptStartDate.Value)
            {
                MessageBox.Show("Return date cannot be before start date.");
                return;
            }

            // Validate cost field
            if (!decimal.TryParse(txtCost.Text.Trim(), out decimal cost))
            {
                MessageBox.Show("Please enter a valid numeric cost.");
                return;
            }

            // Ensure rental status is selected
            if (cmbRentalStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a rental status.");
                return;
            }

            // ====== Update Logic ======
            try
            {
                using (var context = new DBContext())
                {
                    var requestToUpdate = context.RentalRequests.FirstOrDefault(r => r.Id == currentRequest.Id);

                    if (requestToUpdate != null)
                    {
                        // Update values from form
                        requestToUpdate.StartDate = dptStartDate.Value;
                        requestToUpdate.ReturnDate = dptReturnDate.Value;
                        requestToUpdate.Cost = cost;
                        requestToUpdate.RentalStatus = Convert.ToInt32(cmbRentalStatus.SelectedValue);

                        // Save changes to DB
                        context.SaveChanges();

                        MessageBox.Show("Rental request updated successfully.");
                        this.Close(); // Close form after successful update
                    }
                    else
                    {
                        MessageBox.Show("Request not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // Show any unexpected errors
            }
        }

        // Unused textbox event (can remove or implement if needed)
        private void txtEqName_TextChanged(object sender, EventArgs e) { }
    }
}
