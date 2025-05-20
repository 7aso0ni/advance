using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ClassLibrary.Persistence;
using FormApp.Classes;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Models;
using FormApp.Forms;

namespace FormApp
{
    public partial class RentalRequests : Form
    {
        DBContext context;

        public RentalRequests()
        {
            InitializeComponent();
            context = new DBContext();

            // Display logged-in user
            lblName.Text = UserSession.FullName;

            // Apply role-based permissions
            RoleHelper.ApplyRolePermissions(
                UserSession.RoleID,
                lblPosition,
                lblViewAuditLogs,
                lblDBbackup,
                lblGenerateReport
            );
        }

        // On form load
        private void RentalRequest_Load(object sender, EventArgs e)
        {
            RentalRequestGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RentalRequestGrid.MultiSelect = false;
            RentalRequestGrid.ReadOnly = true;

            LoadRentalRequest(); // Load data into grid
        }

        // Load all rental requests into grid
        private void LoadRentalRequest()
        {
            try
            {
                var requests = context.RentalRequests
                    .Include(r => r.Equipment)
                    .Include(r => r.RentalStatus1)
                    .Select(r => new
                    {
                        r.Id,
                        EquipmentName = r.Equipment.Name,
                        r.StartDate,
                        r.ReturnDate,
                        r.Cost,
                        RentalStatus = r.RentalStatus1.Status
                    })
                    .ToList();

                RentalRequestGrid.DataSource = requests;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Search rental request by ID or name/status
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = requestId.Text.Trim();

                if (string.IsNullOrWhiteSpace(search))
                {
                    MessageBox.Show("Please enter a value to search.");
                    return;
                }

                using (DBContext context = new DBContext())
                {
                    var query = context.RentalRequests
                        .Include(r => r.Equipment)
                        .Include(r => r.RentalStatus1)
                        .AsQueryable();

                    if (int.TryParse(search, out int id))
                    {
                        query = query.Where(r => r.Id == id);
                    }
                    else
                    {
                        query = query.Where(r => r.Equipment.Name.Contains(search) ||
                                                 r.RentalStatus1.Status.Contains(search));
                    }

                    var result = query.Select(r => new
                    {
                        r.Id,
                        EquipmentName = r.Equipment.Name,
                        r.StartDate,
                        r.ReturnDate,
                        r.Cost,
                        RentalStatus = r.RentalStatus1.Status
                    }).ToList();

                    if (result.Count == 0)
                    {
                        MessageBox.Show("No matching record found.");
                        return;
                    }

                    RentalRequestGrid.DataSource = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // Reload all records
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRentalRequest();
        }

        // Reject rental request
        private void btnReject_Click(object sender, EventArgs e)
        {
            if (RentalRequestGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to reject.");
                return;
            }

            try
            {
                int selectedId = Convert.ToInt32(RentalRequestGrid.SelectedRows[0].Cells["Id"].Value);

                var request = context.RentalRequests
                    .Include(r => r.Equipment)
                    .Include(r => r.RentalStatus1)
                    .FirstOrDefault(r => r.Id == selectedId);

                if (request != null)
                {
                    if (request.RentalStatus1.Status != "Pending")
                    {
                        MessageBox.Show("Only requests with status 'Pending' can be rejected.");
                        return;
                    }

                    var rejectedStatus = context.RentalStatuses.FirstOrDefault(s => s.Status == "Rejected");

                    if (rejectedStatus == null)
                    {
                        MessageBox.Show("Rejected status not found in database.");
                        return;
                    }

                    request.RentalStatus = rejectedStatus.Id;
                    context.SaveChanges();

                    // Log the rejection
                    Log log = new Log
                    {
                        UserId = UserSession.UserID,
                        Action = "Reject Rental Request",
                        TimeStamp = DateTime.Now,
                        AffectedData = $"Rental Request ID {request.Id} rejected for Equipment: {request.Equipment?.Name ?? "Unknown"}",
                        Source = "RentalRequests Form"
                    };
                    context.Logs.Add(log);
                    context.SaveChanges();

                    MessageBox.Show("Request rejected.");
                    LoadRentalRequest();
                }
                else
                {
                    MessageBox.Show("Request not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // Accept rental request (open update form)
        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (RentalRequestGrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a rental request to update.");
                    return;
                }

                int selectedId = Convert.ToInt32(RentalRequestGrid.SelectedRows[0].Cells["Id"].Value);

                var request = context.RentalRequests
                    .Include(r => r.Equipment)
                    .Include(r => r.RentalStatus1)
                    .FirstOrDefault(r => r.Id == selectedId);

                if (request != null)
                {
                    // Open update form with selected request
                    UpdateRentalRequest updateForm = new UpdateRentalRequest(request);
                    updateForm.ShowDialog();

                    LoadRentalRequest(); // Refresh grid after update
                }
                else
                {
                    MessageBox.Show("Selected rental request not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // ========== Navigation Labels ==========

        private void label16_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<Dashboard>(this);
        }

        private void lblTransactions_Click(object sender, EventArgs e)
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

        // Placeholder event if needed
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Open the RentalRequestFilter form as a popup
            RentalRequestFilter filterForm = new RentalRequestFilter();

            if (filterForm.ShowDialog() == DialogResult.OK)
            {
                // Start query with includes
                var query = context.RentalRequests
                    .Include(r => r.Equipment)
                    .Include(r => r.RentalStatus1)
                    .AsQueryable();

                // Apply filters only if user provided values

                if (int.TryParse(filterForm.RequestId, out int reqId))
                    query = query.Where(r => r.Id == reqId);

                if (int.TryParse(filterForm.EquipmentId, out int eqId))
                    query = query.Where(r => r.Equipment.Id == eqId);

                if (decimal.TryParse(filterForm.Cost, out decimal cost))
                    query = query.Where(r => r.Cost == cost);

                if (!string.IsNullOrWhiteSpace(filterForm.RentalStatus) && filterForm.RentalStatus != "Select Status")
                    query = query.Where(r => r.RentalStatus1.Status == filterForm.RentalStatus);

                if (DateTime.TryParse(filterForm.StartDate, out DateTime startDate))
                    query = query.Where(r => r.StartDate.Date == startDate.Date);

                if (DateTime.TryParse(filterForm.ReturnDate, out DateTime returnDate))
                    query = query.Where(r => r.ReturnDate.Date == returnDate.Date);

                // Project result to anonymous type and display in DataGridView
                var filtered = query.Select(r => new
                {
                    r.Id,
                    EquipmentName = r.Equipment.Name,
                    r.StartDate,
                    r.ReturnDate,
                    r.Cost,
                    RentalStatus = r.RentalStatus1.Status
                }).ToList();

                if (filtered.Count == 0)
                {
                    MessageBox.Show("No matching records found.");
                    return;
                }

                RentalRequestGrid.DataSource = filtered;
            }
        }
    }
}
