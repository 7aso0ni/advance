using FormApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ClassLibrary.Persistence;

namespace FormApp.Forms
{
    public partial class AuditLogs : Form
    {
        // DB context for database access
        private readonly DBContext _context;

        public AuditLogs()
        {
            InitializeComponent();

            // Initialize the DB context
            _context = new DBContext();

            // Set placeholder in the search bar
            PlaceholderService.SetPlaceholder(txtSearchBar, "Log ID");

            // Display logged-in user information
            lblName.Text = UserSession.FullName;

            // Apply role-based UI permissions
            RoleHelper.ApplyRolePermissions(
                UserSession.RoleID,
                lblRole,
                lblViewAuditLogs,
                lblPerformDBBackup,
                lblGenerateReports
            );

            // Center the form on screen
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AuditLogs_Load(object sender, EventArgs e)
        {
            // Load logs into grid when form loads
            LoadLogs();
        }

        // Loads logs into the grid view, filtered by optional Log ID
        private void LoadLogs(string searchId = "")
        {
            var logsQuery = _context.Logs.AsQueryable();

            // If search ID is provided and valid, filter the logs
            if (!string.IsNullOrWhiteSpace(searchId) && int.TryParse(searchId, out int id))
            {
                logsQuery = logsQuery.Where(log => log.Id == id);
            }

            // Project relevant log properties into an anonymous object and convert to list
            var logList = logsQuery
                .Select(log => new
                {
                    log.Id,
                    log.UserId,
                    log.Action,
                    log.TimeStamp,
                    log.AffectedData,
                    log.Source
                })
                .ToList();

            // Bind the list to the grid view
            gridLogs.DataSource = logList;
        }

        // Search button click: reload logs filtered by input Log ID
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadLogs(txtSearchBar.Text.Trim());
        }

        // Navigation: Dashboard
        private void lblDashboard_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<Dashboard>(this);
        }

        // Navigation: Rental Requests
        private void lblRentalRequests_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<RentalRequests>(this);
        }

        // Navigation: Rental Transactions
        private void lblRentalTransactions_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<RentalTransactions>(this);
        }

        // Navigation: Return Records
        private void lblReturnRecords_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<ReturnRecords>(this);
        }

        // Navigation: Equipment Management
        private void lblEquipmentManagement_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<EquipmentManagement>(this);
        }

        // Navigation: Perform DB Backup
        private void lblPerformDBBackup_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<DatabaseBackup>(this);
        }

        // Navigation: Generate Reports
        private void lblGenerateReports_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<GenerateReports>(this);
        }

        // Logout the user
        private void lblLogOut_Click(object sender, EventArgs e)
        {
            FormHelper.ConfirmAndLogout(this);
        }

        // Exit the application
        private void lblExit_Click(object sender, EventArgs e)
        {
            FormHelper.ExitApp();
        }

        // Opens the logs filter popup dialog
        private void btnFilter_Click(object sender, EventArgs e)
        {
            LogsFilter filter = new LogsFilter();

            // Show dialog and apply filters if user confirms
            if (filter.ShowDialog() == DialogResult.OK)
            {
                string logId = filter.LogId;
                string userId = filter.UserId;
                string action = filter.ActionSelected;
                string date = filter.Date;

                // Apply user-selected filters to the log list
                ApplyFilters(logId, userId, action, date);
            }
        }

        // Applies multiple filters to logs and updates grid
        private void ApplyFilters(string logId, string userId, string action, string date)
        {
            using (var context = new DBContext())
            {
                var query = context.Logs.AsQueryable();

                // Filter by Log ID
                if (!string.IsNullOrEmpty(logId) && int.TryParse(logId, out int logIdInt))
                {
                    query = query.Where(l => l.Id == logIdInt);
                }

                // Filter by User ID
                if (!string.IsNullOrEmpty(userId) && int.TryParse(userId, out int userIdInt))
                {
                    query = query.Where(l => l.UserId == userIdInt);
                }

                // Filter by Action
                if (!string.IsNullOrEmpty(action) && action != "Select Action")
                {
                    query = query.Where(l => l.Action == action);
                }

                // Filter by Date
                if (!string.IsNullOrEmpty(date) && DateTime.TryParse(date, out DateTime selectedDate))
                {
                    query = query.Where(l => l.TimeStamp.Date == selectedDate.Date);
                }

                // Sort and select filtered results
                var result = query
                    .Select(l => new
                    {
                        l.Id,
                        l.UserId,
                        l.Action,
                        l.TimeStamp,
                        l.AffectedData,
                        l.Source
                    })
                    .OrderByDescending(l => l.TimeStamp)
                    .ToList();

                // Bind result to DataGridView
                gridLogs.DataSource = result;
            }
        }

        // Reloads all logs and resets search bar
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchBar.Text = "";
            PlaceholderService.SetPlaceholder(txtSearchBar, "Log ID");
            LoadLogs(); // reload all logs
        }

        private void gridLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
