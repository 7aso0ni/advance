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
    public partial class RentalTransactions : Form
    {
        DBContext context;

        public RentalTransactions()
        {
            InitializeComponent();
            context = new DBContext();

            // Display logged-in user name
            lblName.Text = UserSession.FullName;

            // Apply role-based access control
            RoleHelper.ApplyRolePermissions(
                UserSession.RoleID,
                lblPosition,
                lblViewAuditLogs,
                lblDBbackup,
                lblGenerateReport
            );
        }

        private void RentalTransactions_Load(object sender, EventArgs e)
        {
            // Setup DataGridView properties
            transactionGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            transactionGrid.MultiSelect = false;
            transactionGrid.ReadOnly = true;

            // Load all rental transactions from database
            LoadRentalTransactions();
        }

        // Loads all rental transactions from the database
        private void LoadRentalTransactions()
        {
            try
            {
                var transactions = context.RentalTransactions
                    .Include(t => t.User)
                    .Include(t => t.PaymentStatusNavigation)
                    .Include(t => t.RentalStatusNavigation)
                    .Select(t => new
                    {
                        t.Id,
                        FullName = t.User.Fname,
                        PaymentStatus = t.PaymentStatusNavigation.Status,
                        RentalStatus = t.RentalStatusNavigation.Status,
                        Fee = t.Fee,
                        PickupDate = t.Pickup,
                        ReturnDate = t.ReturnDate
                    }).ToList();

                transactionGrid.DataSource = transactions;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }

        // Deletes selected rental transaction
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (transactionGrid.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(transactionGrid.SelectedRows[0].Cells["Id"].Value);

                    var transaction = context.RentalTransactions.Find(id);

                    if (transaction != null)
                    {
                        var confirm = MessageBox.Show("Are you sure to delete this transaction?", "Confirm Delete", MessageBoxButtons.YesNo);
                        if (confirm == DialogResult.Yes)
                        {
                            context.RentalTransactions.Remove(transaction);
                            context.SaveChanges();

                            // Log the deletion
                            Log log = new Log
                            {
                                UserId = UserSession.UserID,
                                Action = "Delete Rental Transaction",
                                TimeStamp = DateTime.Now,
                                AffectedData = $"Deleted Rental Transaction ID {transaction.Id}",
                                Source = "RentalTransactions Form"
                            };
                            context.Logs.Add(log);
                            context.SaveChanges();

                            MessageBox.Show("Transaction deleted successfully.");
                            LoadRentalTransactions(); // Refresh grid
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
                MessageBox.Show("Error deleting transaction: " + ex.Message);
            }
        }

        // Search for rental transaction by ID or other fields
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtTransactionID.Text.ToLower();

                if (string.IsNullOrWhiteSpace(search))
                {
                    MessageBox.Show("Please enter search value.");
                    return;
                }

                var query = context.RentalTransactions
                    .Include(t => t.User)
                    .Include(t => t.PaymentStatusNavigation)
                    .Include(t => t.RentalStatusNavigation)
                    .AsQueryable();

                if (int.TryParse(search, out int id))
                {
                    query = query.Where(t => t.Id == id);
                }
                else
                {
                    query = query.Where(t =>
                        t.User.Fname.ToLower().Contains(search) ||
                        t.PaymentStatusNavigation.Status.ToLower().Contains(search) ||
                        t.RentalStatusNavigation.Status.ToLower().Contains(search));
                }

                var result = query.Select(t => new
                {
                    t.Id,
                    FullName = t.User.Fname,
                    PaymentStatus = t.PaymentStatusNavigation.Status,
                    RentalStatus = t.RentalStatusNavigation.Status,
                    Fee = t.Fee,
                    PickupDate = t.Pickup,
                    ReturnDate = t.ReturnDate
                }).ToList();

                if (result.Count == 0)
                {
                    MessageBox.Show("No matching record found.");
                }

                transactionGrid.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message);
            }
        }

        // Refresh grid data
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadRentalTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message);
            }
        }

        // Update selected transaction by opening update form
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (transactionGrid.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(transactionGrid.SelectedRows[0].Cells["Id"].Value);

                    this.Hide();
                    UpdateTransaction updateTransaction = new UpdateTransaction(id);
                    updateTransaction.Show();
                    LoadRentalTransactions(); // Optional: Refresh if update form closes
                }
                else
                {
                    MessageBox.Show("Please select a row to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating transaction: " + ex.Message);
            }
        }

        // Navigate to create transaction form
        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<CreateTransaction>(this);
        }

        // ============== Navigation Labels ==============
        private void label16_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<Dashboard>(this);
        }

        private void lblRequest_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<RentalRequests>(this);
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

        // ============== Unused Events (Can remove or use as needed) ==============

        private void lblTransactions_Click(object sender, EventArgs e) { }

        private void panel3_Paint(object sender, PaintEventArgs e) { }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnFilter_Click(object sender, EventArgs e)
        {
             // Open the filter form as dialog
    RentalTransactionFilter filterForm = new RentalTransactionFilter();

    if (filterForm.ShowDialog() == DialogResult.OK)
    {
        // Start base query
        var query = context.RentalTransactions
            .Include(t => t.User)
            .Include(t => t.PaymentStatusNavigation)
            .Include(t => t.RentalStatusNavigation)
            .AsQueryable();

        // Apply filters one by one based on input

        if (int.TryParse(filterForm.RequestId, out int reqId))
            query = query.Where(t => t.Id == reqId);

        if (!string.IsNullOrWhiteSpace(filterForm.FullName))
            query = query.Where(t => t.User.Fname.ToLower().Contains(filterForm.FullName.ToLower()));

        if (decimal.TryParse(filterForm.Fee, out decimal fee))
            query = query.Where(t => t.Fee == fee);

        if (DateTime.TryParse(filterForm.PickupDate, out DateTime pickup))
            query = query.Where(t => t.Pickup.Date == pickup.Date);

        if (DateTime.TryParse(filterForm.ReturnDate, out DateTime ret))
            query = query.Where(t => t.ReturnDate.Date == ret.Date);

        if (!string.IsNullOrWhiteSpace(filterForm.PaymentStatus) && filterForm.PaymentStatus != "Select Payment")
            query = query.Where(t => t.PaymentStatusNavigation.Status == filterForm.PaymentStatus);

        if (!string.IsNullOrWhiteSpace(filterForm.RentalStatus) && filterForm.RentalStatus != "Select Rental")
            query = query.Where(t => t.RentalStatusNavigation.Status == filterForm.RentalStatus);

        // Project results
        var filtered = query.Select(t => new
        {
            t.Id,
            FullName = t.User.Fname,
            PaymentStatus = t.PaymentStatusNavigation.Status,
            RentalStatus = t.RentalStatusNavigation.Status,
            Fee = t.Fee,
            PickupDate = t.Pickup,
            ReturnDate = t.ReturnDate
        }).ToList();

        // Handle no results
        if (filtered.Count == 0)
        {
            MessageBox.Show("No matching records found.");
            return;
        }

        // Display filtered results
        transactionGrid.DataSource = filtered;
    }
        }
    }
}
