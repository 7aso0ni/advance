using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ClassLibrary.Persistence;

namespace FormApp.Forms
{
    public partial class LogsFilter : Form
    {
        private readonly DBContext _context;

        // Public properties to store user input
        public string LogId { get; private set; }
        public string UserId { get; private set; }
        public string ActionSelected { get; private set; }
        public string Date { get; private set; }

        // Constructor
        public LogsFilter()
        {
            _context = new DBContext(); // Initialize DB context
            InitializeComponent();
            LoadActions(); // Load distinct actions into the dropdown
        }

        private void LogsFilter_Load(object sender, EventArgs e)
        {
            // Form Load logic if needed
        }

        // Load unique action types from the Logs table into the combo box
        private void LoadActions()
        {
            try
            {
                using (var context = new DBContext())
                {
                    var actions = context.Logs
                        .Select(l => l.Action)
                        .Distinct()
                        .OrderBy(a => a)
                        .ToList();

                    // Insert default option at top
                    actions.Insert(0, "Select Action");

                    // Bind to combo box
                    cmbAction.DataSource = actions;
                }
            }
            catch (Exception ex)
            {
                // Show error if action list fails to load
                MessageBox.Show("Failed to load actions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Capture user-selected filter values and close the form
        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            // Read input values and assign to public properties
            LogId = txtLogId.Text.Trim();
            UserId = txtUserId.Text.Trim();
            ActionSelected = cmbAction.SelectedItem?.ToString();
            Date = dtpDate.Value.Date.ToString("yyyy-MM-dd"); // Format date for consistency

            // Close the form and return OK to the parent form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
