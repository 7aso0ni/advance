using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.Persistence;

namespace FormApp.Forms
{
    public partial class ReturnRecordFilter : Form
    {

        public string RecordId { get; private set; }
        public string EquipmentName { get; private set; }
        public DateTime? ReturnDate { get; private set; }
        public string LateFee { get; private set; }
        public string Condition { get; private set; }
        public ReturnRecordFilter()
        {
            InitializeComponent();
            LoadConditions();
        }

        // Load conditions from DB
        private void LoadConditions()
        {
            using (var context = new DBContext())
            {
                var list = context.ConditionStatuses.Select(c => c.Status).ToList();
                list.Insert(0, "Select Condition");
                cmbCondition.DataSource = list;
            }
        }
        private void txtReqId_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReturnRecordFilter_Load(object sender, EventArgs e)
        {

        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            // Validation: ensure at least one field is filled
            if (string.IsNullOrWhiteSpace(txtReqId.Text) &&
                string.IsNullOrWhiteSpace(txtEqName.Text) &&
                string.IsNullOrWhiteSpace(txtLateFee.Text) &&
                (cmbCondition.SelectedItem == null || cmbCondition.SelectedItem.ToString() == "Select Condition") &&
                dtpReturn.Value == DateTime.Now.Date) // check if date wasn't changed
            {
                MessageBox.Show("Please enter at least one filter value.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Assign values to public properties
            RecordId = txtReqId.Text.Trim();
            EquipmentName = txtEqName.Text.Trim();
            ReturnDate = dtpReturn.Value.Date;
            LateFee = txtLateFee.Text.Trim();
            Condition = cmbCondition.SelectedItem?.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
