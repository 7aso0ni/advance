using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ClassLibrary.Persistence;
using FormApp.Classes;
using FormApp.Forms;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Models;

namespace FormApp
{
    public partial class Dashboard : Form
    {
        private DBContext context;

        public Dashboard()
        {
            InitializeComponent();

            // Initialize database context
            context = new DBContext();

            // Show current logged-in user's name
            lblName.Text = UserSession.FullName;

            // Apply permissions based on user role
            RoleHelper.ApplyRolePermissions(
                UserSession.RoleID,
                lblPosition,
                lblViewAuditLogs,
                lblDBbackup,
                lblGenerateReport
            );
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Setup DataGridViews
            recentlyAddedEquipmentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            recentlyAddedEquipmentGrid.MultiSelect = false;
            recentlyAddedEquipmentGrid.ReadOnly = true;

            latestRentalRequestGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            latestRentalRequestGrid.MultiSelect = false;
            latestRentalRequestGrid.ReadOnly = true;

            // Load dashboard statistics and data
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                // ===== Equipment Summary =====

                // Total equipment count
                lbleqTotal.Text = context.Equipment.Count().ToString();

                // Available equipment (AvailableId = 1)
                lblavEq.Text = context.Equipment
                    .Where(e => e.AvailableId == 1)
                    .Count().ToString();

                // Rented equipment (AvailableId = 2)
                lblrentedEquipment.Text = context.Equipment
                    .Where(e => e.AvailableId == 2)
                    .Count().ToString();

                // ===== Rental Summary =====

                // Total active rental transactions
                lblActiveRentals.Text = context.RentalTransactions.Count().ToString();

                // Pending rental requests
                lblPendingRequests.Text = context.RentalRequests
                    .Where(r => r.RentalStatus1.Status == "Pending")
                    .Count().ToString();

                // Overdue rentals (ReturnDate earlier than today)
                lblOverdueRequests.Text = context.RentalTransactions
                    .Where(r => r.ReturnDate < DateTime.Today)
                    .Count().ToString();

                // ===== Recently Added Equipment (Top 3) =====
                var recentEquipment = context.Equipment
                    .OrderByDescending(e => e.Id)
                    .Take(3)
                    .Select(e => new
                    {
                        e.Id,
                        e.Name,
                        e.Description,
                        Category = e.Category.Name,
                        Availability = e.Available.Status,
                        Condition = e.Condition.Status
                    }).ToList();

                recentlyAddedEquipmentGrid.DataSource = recentEquipment;

                // ===== Latest Rental Requests (Top 3) =====
                var latestRequests = context.RentalRequests
                    .OrderByDescending(r => r.Id)
                    .Take(3)
                    .Select(r => new
                    {
                        r.Id,
                        EquipmentName = r.Equipment.Name,
                        r.StartDate,
                        r.ReturnDate,
                        Status = r.RentalStatus1.Status
                    }).ToList();

                latestRentalRequestGrid.DataSource = latestRequests;
            }
            catch (Exception ex)
            {
                // Show error message if dashboard data fails to load
                MessageBox.Show("Error loading dashboard data: " + ex.Message);
            }
        }

        // ===================== Navigation Buttons =====================

        private void btnRentalTransactions_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentalTransactions t = new RentalTransactions();
            t.Show();
        }

        private void btnRentalRecords_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnRecords ret = new ReturnRecords();
            ret.Show();
        }

        private void btnEquipmentManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            EquipmentManagement eq = new EquipmentManagement();
            eq.Show();
        }

        private void btnAuditLogs_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuditLogs auditLogs = new AuditLogs();
            auditLogs.Show();
        }

        private void btnDbBackup_Click(object sender, EventArgs e)
        {
            this.Hide(); // Open DB backup form if needed
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            this.Hide(); // Open report generation form if needed
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide(); // Open login screen or exit
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the dashboard
        }

        // ===================== Side Menu Label Clicks =====================

        private void lblTransactions_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<RentalTransactions>(this);
        }

        private void lblReturnRecords_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<ReturnRecords>(this);
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

        // ===================== Placeholder/Unused Events =====================

        private void label9_Click(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e) { }
        private void lblRecentEq_Click(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void label15_Click(object sender, EventArgs e) { }

    }
}
