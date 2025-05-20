using ClassLibrary.Models;
using ClassLibrary.Persistence;
using FormApp.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace FormApp.Forms
{
    public partial class EditEquipment : Form
    {
        DBContext context;
        private Equipment selectedEquipment;
        private byte[] selectedImageBytes = null; // for updated image

        // Constructor receives the selected Equipment object
        public EditEquipment(Equipment equipment)
        {
            InitializeComponent();
            context = new DBContext();
            selectedEquipment = equipment;

            lblUserName.Text = UserSession.FullName;

            RoleHelper.ApplyRolePermissions(
                UserSession.RoleID,
                lblPosition
            );
        }

        // Back button: navigate to Equipment Management form
        private void btnBack_Click(object sender, EventArgs e)
        {
            FormHelper.NavigateTo<EquipmentManagement>(this);
        }

        // Save Changes button: update equipment details in the database
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtDescription.Text) ||
                    string.IsNullOrWhiteSpace(txtPrice.Text) ||
                    cmbCategory.SelectedItem == null ||
                    cmbAvailability.SelectedItem == null ||
                    cmbCondition.SelectedItem == null)
                {
                    MessageBox.Show("Please fill all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ✅ Name validation: No digits allowed
                //if (txtName.Text.Any(char.IsDigit))
                //{
                //    MessageBox.Show("Name must contain only letters. Numbers are not allowed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                // Validate price format
                if (!decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    MessageBox.Show("Invalid Price entered!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update equipment details
                selectedEquipment.Name = txtName.Text.Trim();
                selectedEquipment.Description = txtDescription.Text.Trim();
                selectedEquipment.Price = price;
                selectedEquipment.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                selectedEquipment.AvailableId = Convert.ToInt32(cmbAvailability.SelectedValue);
                selectedEquipment.ConditionId = Convert.ToInt32(cmbCondition.SelectedValue);

                if (selectedImageBytes != null)
                {
                    selectedEquipment.Image = selectedImageBytes;
                }

                context.Entry(selectedEquipment).State = EntityState.Modified;
                context.SaveChanges();

                // Log the update
                Log log = new Log
                {
                    UserId = UserSession.UserID,
                    Action = "Edit Equipment",
                    TimeStamp = DateTime.Now,
                    AffectedData = $"Edited Equipment: {selectedEquipment.Name}, ID: {selectedEquipment.Id}, New Price: {selectedEquipment.Price}",
                    Source = "EditEquipment Form"
                };

                context.Logs.Add(log);
                context.SaveChanges();

                MessageBox.Show("Equipment Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // On form load: populate dropdowns and fill in existing equipment data
        private void EditEquipment_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadAvailability();
            LoadCondition();
            LoadEquipmentData(); // Fill form fields with selected equipment data
        }

        // Load all categories from DB into ComboBox
        private void LoadCategories()
        {
            cmbCategory.DataSource = context.Categories.ToList();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
        }

        // Load availability statuses from DB
        private void LoadAvailability()
        {
            cmbAvailability.DataSource = context.AvailableStatuses.ToList();
            cmbAvailability.DisplayMember = "Status";
            cmbAvailability.ValueMember = "Id";
        }

        // Load condition statuses from DB
        private void LoadCondition()
        {
            cmbCondition.DataSource = context.ConditionStatuses.ToList();
            cmbCondition.DisplayMember = "Status";
            cmbCondition.ValueMember = "Id";
        }

        // Load existing equipment data into fields for editing
        private void LoadEquipmentData()
        {
            txtEquipmentID.Text = selectedEquipment.Id.ToString();
            txtName.Text = selectedEquipment.Name;
            txtDescription.Text = selectedEquipment.Description;
            txtPrice.Text = selectedEquipment.Price.ToString();
            cmbCategory.SelectedValue = selectedEquipment.CategoryId;
            cmbAvailability.SelectedValue = selectedEquipment.AvailableId;
            cmbCondition.SelectedValue = selectedEquipment.ConditionId;
            // Load existing image from database
            if (selectedEquipment.Image != null && selectedEquipment.Image.Length > 0)
            {
                using (var ms = new MemoryStream(selectedEquipment.Image))
                {
                    picEquipment.Image = Image.FromStream(ms);
                }
            }
            else
            {
                picEquipment.Image = null; // Or set a default placeholder image
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Equipment Image";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Display image preview
                    picEquipment.Image = Image.FromFile(ofd.FileName);

                    // Store byte[] to be saved on Save Changes
                    selectedImageBytes = File.ReadAllBytes(ofd.FileName);
                }
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
