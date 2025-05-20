using ClassLibrary.Persistence;
using FormApp.Classes;
using FormApp.Forms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using ClassLibrary.Models;
using System.Data;

namespace FormApp
{
    public partial class EquipmentManagement : Form
    {
        DBContext context;

        public EquipmentManagement()
        {
            InitializeComponent();
            context = new DBContext();

            // Display user info
            lblName.Text = UserSession.FullName;

            // Apply role-based UI permissions
            RoleHelper.ApplyRolePermissions(
                UserSession.RoleID,
                lblPosition,
                lblViewAuditLogs,
                lblDBbackup,
                lblGenerateReport
            );
        }

        private void EquipmentManagement_Load(object sender, EventArgs e)
        {
            // Setup DataGridView settings
            eqGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            eqGrid.MultiSelect = false;
            eqGrid.ReadOnly = true;

            // Load equipment data on form load
            LoadEquipment();
        }

        // Load all equipment data into grid
        private void LoadEquipment()
        {
            try
            {
                // Create a DataTable to store all equipment info including image
                DataTable table = new DataTable();
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Description", typeof(string));
                table.Columns.Add("Category", typeof(string));
                table.Columns.Add("Availability", typeof(string));
                table.Columns.Add("Condition", typeof(string));
                table.Columns.Add("Price", typeof(decimal));
                table.Columns.Add("Image", typeof(Image)); // Final image column

                // Load from DB including navigation properties
                var equipmentList = context.Equipment
                    .Include(e => e.Category)
                    .Include(e => e.Available)
                    .Include(e => e.Condition)
                    .ToList();

                foreach (var e in equipmentList)
                {
                    Image img = null;

                    // Try converting byte[] to Image
                    if (e.Image != null && e.Image.Length > 0)
                    {
                        try
                        {
                            using (var ms = new MemoryStream(e.Image))
                            {
                                img = Image.FromStream(ms);
                            }
                        }
                        catch
                        {
                            img = null; // fallback if image is broken
                        }
                    }

                    // Add row to table
                    table.Rows.Add(
                        e.Id,
                        e.Name,
                        e.Description,
                        e.Category.Name,
                        e.Available.Status,
                        e.Condition.Status,
                        e.Price,
                        img
                    );
                }

                // Set data source to the DataGridView
                eqGrid.DataSource = table;

                // Format image column
                DataGridViewImageColumn imgCol = (DataGridViewImageColumn)eqGrid.Columns["Image"];
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                eqGrid.RowTemplate.Height = 80;
                eqGrid.Columns["Image"].Width = 100; // optional

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading equipment with images: " + ex.Message);
            }
        }

        // Search functionality based on any field or ID
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    MessageBox.Show("Please enter a value to search.");
                    return;
                }

                var search = txtSearch.Text.ToLower();

                var query = from ee in context.Equipment
                            select ee;

                // If search is numeric → treat as ID
                if (int.TryParse(search, out int id))
                {
                    query = query.Where(ee => ee.Id == id);
                }
                else
                {
                    query = query.Where(ee =>
                        ee.Name.ToLower().Contains(search) ||
                        ee.Description.ToLower().Contains(search) ||
                        ee.Category.Name.ToLower().Contains(search) ||
                        ee.Available.Status.ToLower().Contains(search) ||
                        ee.Condition.Status.ToLower().Contains(search)
                    );
                }

                var result = from ee in query
                             select new
                             {
                                 ee.Id,
                                 ee.Name,
                                 ee.Description,
                                 Category = ee.Category.Name,
                                 Availability = ee.Available.Status,
                                 Condition = ee.Condition.Status,
                                 ee.Price
                             };

                if (!result.Any())
                {
                    MessageBox.Show("No matching record found.");
                }

                eqGrid.DataSource = result.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching data: " + ex.Message);
            }
        }

        // Reload grid data
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEquipment();
        }

        // Delete selected equipment
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (eqGrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a record to delete.");
                    return;
                }

                int id = Convert.ToInt32(eqGrid.SelectedRows[0].Cells["Id"].Value);
                var equipment = context.Equipment.Find(id);

                if (equipment != null)
                {
                    string equipmentName = equipment.Name;

                    context.Equipment.Remove(equipment);
                    context.SaveChanges();

                    // Log deletion
                    Log log = new Log
                    {
                        UserId = UserSession.UserID,
                        Action = "Delete Equipment",
                        TimeStamp = DateTime.Now,
                        AffectedData = $"Deleted Equipment: {equipmentName}, ID: {id}",
                        Source = "EquipmentManagement Form"
                    };

                    context.Logs.Add(log);
                    context.SaveChanges();

                    MessageBox.Show("Record deleted successfully.");
                    LoadEquipment();
                }
            }
            catch (Exception ex)
            {
              // Show inner exception if available
        string message = ex.InnerException?.Message ?? ex.Message;

        MessageBox.Show("Error deleting record: " + message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add new equipment
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<AddEquipment>(this);
        }

        // Edit selected equipment
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (eqGrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a record to edit.");
                    return;
                }

                int id = Convert.ToInt32(eqGrid.SelectedRows[0].Cells["Id"].Value);

                // Get full equipment object with navigation properties
                var equipment = context.Equipment
                    .Include(e => e.Category)
                    .Include(e => e.Available)
                    .Include(e => e.Condition)
                    .FirstOrDefault(e => e.Id == id);

                if (equipment != null)
                {
                    EditEquipment editForm = new EditEquipment(equipment);
                    editForm.ShowDialog();

                    // Refresh grid after editing
                    LoadEquipment();
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

        // ================== Navigation Labels ==================

        private void label16_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<Dashboard>(this);
        }

        private void lblRequest_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<RentalRequests>(this);
        }

        private void lblTransactions_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<RentalTransactions>(this);
        }

        private void lblReturnRecords_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<ReturnRecords>(this);
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

        //private void btnFilter_Click(object sender, EventArgs e)
        //{
            
            
        //}
    }
}
