using ClassLibrary.Models;
using ClassLibrary.Persistence;
using FormApp.Classes;
using FormApp.Forms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FormApp
{
    public partial class ReturnRecords : Form
    {
        DBContext context;

        public ReturnRecords()
        {
            InitializeComponent();
            context = new DBContext();

            // Display logged-in user's full name
            lblName.Text = UserSession.FullName;

            // Apply role-based access controls
            RoleHelper.ApplyRolePermissions(
                UserSession.RoleID,
                lblPosition,
                lblViewAuditLogs,
                lblDBbackup,
                lblGenerateReport
            );
        }

        // On form load, set up grid and load data
        private void ReturnRecords_Load(object sender, EventArgs e)
        {
            ReturnRecordGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ReturnRecordGrid.MultiSelect = false;
            ReturnRecordGrid.ReadOnly = true;

            LoadReturnRecord(); // Load records from DB
        }

        // Load all return records from the database
        private void LoadReturnRecord()
        {
            try
            {
                var records = context.ReturnRecords
                    .Include(r => r.EquipmentNavigation)
                    .Include(r => r.ConditionNavigation)
                    .Select(r => new
                    {
                        r.Id,
                        EquipmentName = r.EquipmentNavigation.Name,
                        Condition = r.ConditionNavigation.Status,
                        r.ReturnDate,
                        r.LateFees
                    }).ToList();

                ReturnRecordGrid.DataSource = records;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching records: " + ex.Message);
            }
        }

        // Search return record by ID or name/condition
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtReturnRecordId.Text.ToLower();

                if (string.IsNullOrWhiteSpace(search))
                {
                    MessageBox.Show("Please enter a value to search.");
                    return;
                }

                var query = context.ReturnRecords
                    .Include(r => r.EquipmentNavigation)
                    .Include(r => r.ConditionNavigation)
                    .AsQueryable();

                if (int.TryParse(search, out int id))
                {
                    query = query.Where(r => r.Id == id);
                }
                else
                {
                    query = query.Where(r =>
                        r.EquipmentNavigation.Name.ToLower().Contains(search) ||
                        r.ConditionNavigation.Status.ToLower().Contains(search));
                }

                var result = query.Select(r => new
                {
                    r.Id,
                    EquipmentName = r.EquipmentNavigation.Name,
                    Condition = r.ConditionNavigation.Status,
                    r.ReturnDate,
                    r.LateFees
                }).ToList();

                if (result.Count == 0)
                    MessageBox.Show("No matching record found.");

                ReturnRecordGrid.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message);
            }
        }

        // Delete selected return record
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReturnRecordGrid.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(ReturnRecordGrid.SelectedRows[0].Cells["Id"].Value);
                    var record = context.ReturnRecords.Find(id);

                    if (record != null)
                    {
                        var confirm = MessageBox.Show("Are you sure to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);
                        if (confirm == DialogResult.Yes)
                        {
                            // Get equipment name before deletion
                            var equipmentName = context.Equipment.FirstOrDefault(e => e.Id == record.Equipment)?.Name ?? "Unknown";

                            context.ReturnRecords.Remove(record);
                            context.SaveChanges();

                            // Log the deletion
                            Log log = new Log
                            {
                                UserId = UserSession.UserID,
                                Action = "Delete Return Record",
                                TimeStamp = DateTime.Now,
                                AffectedData = $"Deleted Return Record ID {record.Id} for Equipment: {equipmentName}",
                                Source = "ReturnRecords Form"
                            };

                            context.Logs.Add(log);
                            context.SaveChanges();

                            MessageBox.Show("Record deleted successfully.");
                            LoadReturnRecord();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message);
            }
        }

        // Refresh the return records grid
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadReturnRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message);
            }
        }

        // Update selected return record
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReturnRecordGrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a record to edit.");
                    return;
                }

                int id = Convert.ToInt32(ReturnRecordGrid.SelectedRows[0].Cells["Id"].Value);

                var record = context.ReturnRecords
                    .Include(r => r.EquipmentNavigation)
                    .Include(r => r.ConditionNavigation)
                    .FirstOrDefault(r => r.Id == id);

                if (record != null)
                {
                    UpdateRecord updateForm = new UpdateRecord(record);
                    updateForm.ShowDialog(); // Open update form

                    LoadReturnRecord(); // Refresh after update
                }
                else
                {
                    MessageBox.Show("Record not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening edit form: " + ex.Message);
            }
        }

        // Navigate to create return record form
        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<CreateRecord>(this);
        }

        // ========== Navigation Labels ==========

        private void label16_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<Dashboard>(this);
        }

        private void lblRequest_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<RentalRequests>(this);
        }

        private void lblEquipmentManagement_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<EquipmentManagement>(this);
        }

        private void lblViewAuditLogs_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<AuditLogs>(this);
        }

        private void lblDBbackup_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<DatabaseBackup>(this);
        }

        private void lblGenerateReport_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<GenerateReports>(this);
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            FormHelper.ConfirmAndLogout(this);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            FormHelper.ExitApp();
        }

        private void lblTransactions_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<RentalTransactions>(this);
        }

        // Unused button event
        private void button1_Click(object sender, EventArgs e) { }

        // Duplicate load event handler (can remove)
        private void ReturnRecords_Load_1(object sender, EventArgs e)
        {
            LoadReturnRecord();
        }

        private void txtReturnRecordId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ReturnRecordFilter filterForm = new ReturnRecordFilter();

            if (filterForm.ShowDialog() == DialogResult.OK)
            {
                var query = context.ReturnRecords
                    .Include(r => r.EquipmentNavigation)
                    .Include(r => r.ConditionNavigation)
                    .AsQueryable();

                // Apply filters from filter form
                if (int.TryParse(filterForm.RecordId, out int recordId))
                    query = query.Where(r => r.Id == recordId);

                if (!string.IsNullOrWhiteSpace(filterForm.EquipmentName))
                    query = query.Where(r => r.EquipmentNavigation.Name.ToLower().Contains(filterForm.EquipmentName.ToLower()));

                if (!string.IsNullOrWhiteSpace(filterForm.Condition) && filterForm.Condition != "Select Condition")
                    query = query.Where(r => r.ConditionNavigation.Status == filterForm.Condition);

                if (decimal.TryParse(filterForm.LateFee, out decimal fee))
                    query = query.Where(r => r.LateFees == fee);

                if (filterForm.ReturnDate.HasValue)
                    query = query.Where(r => r.ReturnDate.Date == filterForm.ReturnDate.Value.Date);

                var filtered = query.Select(r => new
                {
                    r.Id,
                    EquipmentName = r.EquipmentNavigation.Name,
                    Condition = r.ConditionNavigation.Status,
                    r.ReturnDate,
                    r.LateFees
                }).ToList();

                // If no results
                if (filtered.Count == 0)
                {
                    MessageBox.Show("No matching records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Display in grid
                ReturnRecordGrid.DataSource = filtered;
            }
        }
    }
}
