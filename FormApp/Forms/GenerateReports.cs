using FormApp.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClassLibrary.Persistence;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Models;

namespace FormApp.Forms
{
    public partial class GenerateReports : Form
    {
        private readonly DBContext _context;
        private string currentReport = ""; // to track current report name for download

        public GenerateReports()
        {
            InitializeComponent();
            _context = new DBContext();

            // Display logged-in user
            lblName.Text = UserSession.FullName;

            // Apply role-based UI permissions
            RoleHelper.ApplyRolePermissions(
                UserSession.RoleID,
                lblRole,
                lblAuditLogs,
                lblPerformDBBackup,
                lblGenerateReports
            );

            // Format grid
            gridReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void GenerateReports_Load(object sender, EventArgs e)
        {
            // No data loaded initially
        }

        // ======================== Report 1: Active Customers ========================
        private void btnActiveCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                // Get users with RoleId = 3 (Customer)
                var customers = _context.Users
                    .Where(u => u.RoleId == 3)
                    .Select(u => new Dictionary<string, object>
                    {
                        { "Full Name", u.Fname + " " + u.Lname },
                        { "Email", u.Email },
                        { "Total Rentals", u.RentalTransactions.Count },
                        { "Total Spent", u.RentalTransactions.Sum(t => (decimal?)t.Fee) ?? 0 }
                    })
                    .ToList();

                // Bind to grid
                gridReports.DataSource = new BindingSource { DataSource = ToDataTable(customers) };
                currentReport = "ActiveCustomers";

                // Log action
                Log log = new Log
                {
                    UserId = UserSession.UserID,
                    Action = "Generate Report",
                    TimeStamp = DateTime.Now,
                    AffectedData = "Generated Active Customers Report",
                    Source = "GenerateReports Form"
                };
                _context.Logs.Add(log);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load customer report:\n" + ex.Message);
            }
        }

        // ======================== Report 2: Most Rented Equipment ========================
        private void btnMostRentedEquipment_Click(object sender, EventArgs e)
        {
            try
            {
                var equipmentData = _context.RentalRequests
                    .Include(r => r.Equipment)
                    .ThenInclude(e => e.Category)
                    .AsEnumerable()
                    .Where(r => r.Equipment != null && r.Equipment.Category != null)
                    .GroupBy(r => new
                    {
                        r.Equipment.Name,
                        Category = r.Equipment.Category.Name
                    })
                    .Select(g => new Dictionary<string, object>
                    {
                        { "Equipment Name", g.Key.Name },
                        { "Category", g.Key.Category },
                        { "Rental Count", g.Count() }
                    })
                    .OrderByDescending(e => (int)e["Rental Count"])
                    .ToList();

                // Bind to grid
                gridReports.DataSource = new BindingSource { DataSource = ToDataTable(equipmentData) };
                currentReport = "MostRentedEquipment";

                // Log action
                Log log = new Log
                {
                    UserId = UserSession.UserID,
                    Action = "Generate Report",
                    TimeStamp = DateTime.Now,
                    AffectedData = "Generated Most Rented Equipment Report",
                    Source = "GenerateReports Form"
                };
                _context.Logs.Add(log);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load equipment report:\n" + ex.Message);
            }
        }

        // ======================== Export Report to CSV ========================
        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (gridReports.DataSource == null)
            {
                MessageBox.Show("No data to download.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = currentReport + "_Report.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var dt = (DataTable)((BindingSource)gridReports.DataSource).DataSource;
                        ExportDataTableToCSV(dt, sfd.FileName);

                        MessageBox.Show("Report downloaded successfully!");

                        // Log download
                        Log log = new Log
                        {
                            UserId = UserSession.UserID,
                            Action = "Download Report",
                            TimeStamp = DateTime.Now,
                            AffectedData = $"Downloaded Report: {currentReport}_Report.csv",
                            Source = "GenerateReports Form"
                        };
                        _context.Logs.Add(log);
                        _context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error downloading file: " + ex.Message);
                    }
                }
            }
        }

        // Converts DataTable to CSV
        private void ExportDataTableToCSV(DataTable dt, string filePath)
        {
            var lines = new List<string>();

            // Header
            string[] columnNames = dt.Columns.Cast<DataColumn>()
                                     .Select(column => column.ColumnName)
                                     .ToArray();
            var header = string.Join(",", columnNames);
            lines.Add(header);

            // Rows
            foreach (DataRow row in dt.Rows)
            {
                string[] fields = row.ItemArray.Select(field => field.ToString()).ToArray();
                lines.Add(string.Join(",", fields));
            }

            File.WriteAllLines(filePath, lines);
        }

        // Converts List<Dictionary<string, object>> to DataTable for grid binding
        private DataTable ToDataTable(List<Dictionary<string, object>> data)
        {
            DataTable table = new DataTable();

            if (data == null || data.Count == 0)
                return table;

            foreach (var key in data[0].Keys)
                table.Columns.Add(key);

            foreach (var dict in data)
            {
                DataRow row = table.NewRow();
                foreach (var key in dict.Keys)
                    row[key] = dict[key] ?? DBNull.Value;
                table.Rows.Add(row);
            }

            return table;
        }

        // ======================== Sidebar Navigation ========================
        private void lblDashboard_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<Dashboard>(this);
        }

        private void lblRentalRequests_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<RentalRequests>(this);
        }

        private void lblRentalTransactions_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<RentalTransactions>(this);
        }

        private void lblReturnRecords_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<ReturnRecords>(this);
        }

        private void lblEquipmentManagement_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<EquipmentManagement>(this);
        }

        private void lblAuditLogs_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<AuditLogs>(this);
        }

        private void lblPerformDBBackup_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<DatabaseBackup>(this);
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            FormHelper.ConfirmAndLogout(this);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            FormHelper.ExitApp();
        }
    }
}
