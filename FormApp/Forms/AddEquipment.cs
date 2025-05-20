using ClassLibrary.Models;
using ClassLibrary.Persistence;
using FormApp.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp.Forms
{


    public partial class AddEquipment : Form
    {
        private byte[] uploadedImageBytes = null;

        DBContext context;

        public AddEquipment()
        {
            InitializeComponent();
            context = new DBContext();

            // Display user name from session
            lblUserName.Text = UserSession.FullName;

            // Apply role-based permissions
            RoleHelper.ApplyRolePermissions(UserSession.RoleID, lblPosition);

            this.StartPosition = FormStartPosition.CenterScreen;

            // Setting placeholder text for input fields
            PlaceholderService.SetPlaceholder(txtName, "Name");
            PlaceholderService.SetPlaceholder(txtDescription, "Description");
            PlaceholderService.SetPlaceholder(txtPrice, "Price");
        }

        private void AddEquipment_Load(object sender, EventArgs e)
        {
            // Load values into dropdowns
            LoadCategories();
            LoadAvailability();
            LoadCondition();
        }

        private void LoadCategories()
        {
            // Fetch category list from database and bind to ComboBox
            var categories = context.Categories
                .Select(c => new { c.Id, c.Name })
                .ToList();

            // Insert placeholder item
            categories.Insert(0, new { Id = -1, Name = "Category" });

            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategory.SelectedIndex = 0;
        }

        private void LoadCondition()
        {
            // Fetch condition list and bind to ComboBox
            var conditions = context.ConditionStatuses
                .Select(cs => new { cs.Id, cs.Status })
                .ToList();

            // Insert placeholder item
            conditions.Insert(0, new { Id = -1, Status = "Condition" });

            cmbCondition.DataSource = conditions;
            cmbCondition.DisplayMember = "Status";
            cmbCondition.ValueMember = "Id";
            cmbCondition.SelectedIndex = 0;
        }

        private void LoadAvailability()
        {
            // Fetch availability statuses and bind to ComboBox
            var availabilities = context.AvailableStatuses
                .Select(av => new { av.Id, av.Status })
                .ToList();

            // Insert placeholder item
            availabilities.Insert(0, new { Id = -1, Status = "Availability" });

            cmbAvailability.DataSource = availabilities;
            cmbAvailability.DisplayMember = "Status";
            cmbAvailability.ValueMember = "Id";
            cmbAvailability.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtDescription.Text) ||
                    string.IsNullOrWhiteSpace(txtPrice.Text) ||
                    Convert.ToInt32(cmbCategory.SelectedValue) == -1 ||
                    Convert.ToInt32(cmbAvailability.SelectedValue) == -1 ||
                    Convert.ToInt32(cmbCondition.SelectedValue) == -1)
                {
                    MessageBox.Show("Please fill all fields and select dropdowns!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ✅ New validation: ensure name has no numbers
                if (txtName.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Name must contain only letters. Numbers are not allowed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate price input
                if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price))
                {
                    MessageBox.Show("Invalid price entered!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create equipment object
                Equipment newEquipment = new Equipment
                {
                    Name = txtName.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    Price = price,
                    CategoryId = Convert.ToInt32(cmbCategory.SelectedValue),
                    AvailableId = Convert.ToInt32(cmbAvailability.SelectedValue),
                    ConditionId = Convert.ToInt32(cmbCondition.SelectedValue),
                    Image = uploadedImageBytes ?? new byte[0]
                };

                // Save to database
                context.Equipment.Add(newEquipment);
                context.SaveChanges();

                // Log
                Log log = new Log
                {
                    UserId = UserSession.UserID,
                    Action = "Add Equipment",
                    TimeStamp = DateTime.Now,
                    AffectedData = $"Added Equipment: {newEquipment.Name}, ID: {newEquipment.Id}",
                    Source = "AddEquipment Form"
                };

                context.Logs.Add(log);
                context.SaveChanges();

                MessageBox.Show("Equipment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearControls()
        {
            txtName.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            cmbCategory.SelectedIndex = 0;
            cmbAvailability.SelectedIndex = 0;
            cmbCondition.SelectedIndex = 0;
            pictureBoxPreview.Image = null;            // Clear preview
            uploadedImageBytes = null;                 // Clear image bytes
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Navigate back to EquipmentManagement form
            FormHelper.NavigateTo<EquipmentManagement>(this);
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Event handler in case you need logic on category change
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load the image to the PictureBox
                    Image img = Image.FromFile(openFileDialog.FileName);
                    pictureBoxPreview.Image = img;
                    pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;

                    // Convert image to byte[]
                    using (MemoryStream ms = new MemoryStream())
                    {
                        img.Save(ms, img.RawFormat);
                        uploadedImageBytes = ms.ToArray();
                    }
                }
            }
        }
    }
}
