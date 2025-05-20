using ClassLibrary.Models;
using ClassLibrary.Persistence;
using FormApp.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FormApp.Forms
{
    public partial class UpdateRecord : Form
    {
        DBContext context;
        private ReturnRecord selectedRecord; // Holds the return record to be updated

        // Constructor receives the selected ReturnRecord object
        public UpdateRecord(ReturnRecord record)
        {
            InitializeComponent();
            context = new DBContext();
            selectedRecord = record;

            // Display logged-in user's full name
            lblUserName.Text = UserSession.FullName;

            // Apply role-based permissions
            RoleHelper.ApplyRolePermissions(
                UserSession.RoleID,
                lblPosition
            );
        }

        // Back button - navigate to ReturnRecords screen
        private void btnBack_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<ReturnRecords>(this);
        }

        // Form Load Event - load condition list and existing record data
        private void UpdateRecord_Load(object sender, EventArgs e)
        {
            LoadCondition(); // Load condition dropdown
            LoadData();      // Load selected record data
        }

        // Load condition statuses into ComboBox
        private void LoadCondition()
        {
            cmbCondition.DataSource = context.ConditionStatuses.ToList();
            cmbCondition.DisplayMember = "Status";
            cmbCondition.ValueMember = "Id";
        }

        // Load selected record data into form fields
        private void LoadData()
        {
            txtRecordID.Text = selectedRecord.Id.ToString();
            txtEquipmentID.Text = selectedRecord.Equipment.ToString(); // Equipment is stored as ID
            txtLateFees.Text = selectedRecord.LateFees.ToString();
            cmbCondition.SelectedValue = selectedRecord.Condition;
            dtpReturnDate.Value = selectedRecord.ReturnDate;
        }

        // Save button - update record in database
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // ===== Validation Section =====

                // Check for required fields
                if (cmbCondition.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtLateFees.Text))
                {
                    MessageBox.Show("Please fill all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Late Fees input
                if (!decimal.TryParse(txtLateFees.Text, out decimal lateFees))
                {
                    MessageBox.Show("Invalid Late Fees!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ensure return date is not in the past
                if (dtpReturnDate.Value.Date < DateTime.Today)
                {
                    MessageBox.Show("Return Date cannot be before today's date!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ===== Update Section =====

                // Update the selected record with new values
                selectedRecord.Condition = Convert.ToInt32(cmbCondition.SelectedValue);
                selectedRecord.LateFees = lateFees;
                selectedRecord.ReturnDate = dtpReturnDate.Value;

                // Mark record as modified and save to DB
                context.Entry(selectedRecord).State = EntityState.Modified;
                context.SaveChanges();

                // ===== Logging Section =====

                // Create a log entry for the update action
                Log log = new Log
                {
                    UserId = UserSession.UserID,
                    Action = "Update Return Record",
                    TimeStamp = DateTime.Now,
                    AffectedData = $"Updated Return Record ID {selectedRecord.Id} – Late Fees: {selectedRecord.LateFees}, Return Date: {selectedRecord.ReturnDate.ToShortDateString()}",
                    Source = "UpdateRecord Form"
                };
                context.Logs.Add(log);
                context.SaveChanges(); // Save the log

                // Notify user and close the form
                MessageBox.Show("Record Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
