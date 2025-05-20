using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ClassLibrary.Persistence;

namespace FormApp.Forms
{
    public partial class RentalRequestFilter : Form
    {

        // Public properties to pass user input to main form
        public string RequestId { get; private set; }
        public string EquipmentId { get; private set; }
        public string Cost { get; private set; }
        public string RentalStatus { get; private set; }
        public string StartDate { get; private set; }
        public string ReturnDate { get; private set; }

        public RentalRequestFilter()
        {
            InitializeComponent();
            LoadRentalStatuses(); // Load values into the combo box
        }

        // Load all distinct rental statuses from the database
        private void LoadRentalStatuses()
        {
            try
            {
                using (var context = new DBContext())
                {
                    var statuses = context.RentalStatuses
                        .Select(s => s.Status)
                        .OrderBy(s => s)
                        .ToList();

                    statuses.Insert(0, "Select Status"); // Default option
                    cmbStatus.DataSource = statuses;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load rental statuses: " + ex.Message);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RentalRequestFilter_Load(object sender, EventArgs e)
        {

        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            // Store user inputs in public properties
            RequestId = txtReqId.Text.Trim();
            EquipmentId = txtEquipmentId.Text.Trim();
            Cost = txtCost.Text.Trim();
            RentalStatus = cmbStatus.SelectedItem?.ToString();
            StartDate = dtpStart.Value.ToString("yyyy-MM-dd");
            ReturnDate = dtpReturn.Value.ToString("yyyy-MM-dd");

            this.DialogResult = DialogResult.OK;
            this.Close(); // Close the form
        }

        private void EqId_Click(object sender, EventArgs e)
        {

        }
    }
}
