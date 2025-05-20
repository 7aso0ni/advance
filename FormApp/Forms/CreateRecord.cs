using ClassLibrary.Models;
using ClassLibrary.Persistence;
using FormApp.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp.Forms
{
    public partial class CreateRecord : Form
    {
        DBContext context;

        public CreateRecord()
        {
            InitializeComponent();
            context = new DBContext();

            // Display the logged-in user's name
            lblUserName.Text = UserSession.FullName;

            // Apply permissions based on the user's role
            RoleHelper.ApplyRolePermissions(
                UserSession.RoleID,
                lblPosition
            );

            // Set placeholder text in input fields
            PlaceholderService.SetPlaceholder(txtEquipmentId, "Equipment ID");
            PlaceholderService.SetPlaceholder(txtLateFees, "Late Fee Amount");
        }

        private void CreateRecord_Load(object sender, EventArgs e)
        {
            // Load conditions into the dropdown on form load
            LoadConditions();
        }

        private void LoadConditions()
        {
            // Fetch condition status list from database
            var conditions = context.ConditionStatuses
                .Select(cs => new { cs.Id, cs.Status })
                .ToList();

            // Insert placeholder option
            conditions.Insert(0, new { Id = -1, Status = "Select Condition" });

            // Bind to ComboBox
            cmbCondition.DataSource = conditions;
            cmbCondition.DisplayMember = "Status";
            cmbCondition.ValueMember = "Id";
            cmbCondition.SelectedIndex = 0;
        }

        private void ClearControls()
        {
            // Reset all input fields to default state
            txtEquipmentId.Clear();
            cmbCondition.SelectedIndex = 0;
            txtLateFees.Clear();
            dtpReturnDate.Value = DateTime.Today;
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validate all required fields
                if (string.IsNullOrWhiteSpace(txtEquipmentId.Text) ||
                    Convert.ToInt32(cmbCondition.SelectedValue) == -1 ||
                    string.IsNullOrWhiteSpace(txtLateFees.Text))
                {
                    MessageBox.Show("Please fill all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Equipment ID is a valid integer
                if (!int.TryParse(txtEquipmentId.Text.Trim(), out int equipmentId))
                {
                    MessageBox.Show("Invalid Equipment ID entered!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Late Fees is a valid decimal number
                if (!decimal.TryParse(txtLateFees.Text.Trim(), out decimal lateFees))
                {
                    MessageBox.Show("Invalid Late Fee entered!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ensure return date is not in the past
                if (dtpReturnDate.Value.Date < DateTime.Today)
                {
                    MessageBox.Show("Return Date cannot be before today's date!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the provided Equipment ID exists in the database
                bool exists = context.Equipment.Any(e => e.Id == equipmentId);
                if (!exists)
                {
                    MessageBox.Show("Equipment ID not found in the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create a new return record
                ReturnRecord record = new ReturnRecord
                {
                    Equipment = equipmentId,
                    Condition = Convert.ToInt32(cmbCondition.SelectedValue),
                    ReturnDate = dtpReturnDate.Value,
                    LateFees = lateFees
                };

                // Save the return record
                context.ReturnRecords.Add(record);
                context.SaveChanges();

                // Log the creation of the record
                Log log = new Log
                {
                    UserId = UserSession.UserID,
                    Action = "Create Return Record",
                    TimeStamp = DateTime.Now,
                    AffectedData = $"Return Record for Equipment ID: {record.Equipment}, Return Date: {record.ReturnDate.ToShortDateString()}",
                    Source = "CreateRecord Form"
                };

                context.Logs.Add(log);
                context.SaveChanges(); // Save log entry

                // Notify user and reset the form
                MessageBox.Show("Record created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
            }
            catch (Exception ex)
            {
                string innerMessage = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Error creating record:\n" + innerMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Navigate back to Return Records form
            FormHelper.NavigateTo<ReturnRecords>(this);
        }
    }
}
