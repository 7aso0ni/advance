namespace FormApp
{
    partial class ReturnRecords
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnRecords));
            lblName = new Label();
            lblPosition = new Label();
            txtReturnRecordId = new TextBox();
            btnSearch = new Button();
            ReturnRecordGrid = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCreate = new Button();
            lblLogOut = new Label();
            lblViewAuditLogs = new Label();
            lblDBbackup = new Label();
            lblGenerateReport = new Label();
            lblReturnRecords = new Label();
            lblEquipmentManagement = new Label();
            lblTransactions = new Label();
            lblRequest = new Label();
            label16 = new Label();
            btnRefresh = new Button();
            lblExit = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel4 = new Panel();
            lblDivider = new Label();
            btnFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)ReturnRecordGrid).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblName.Location = new Point(4, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(217, 41);
            lblName.TabIndex = 0;
            lblName.Text = "Sharmin";
            // 
            // lblPosition
            // 
            lblPosition.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPosition.ForeColor = Color.FromArgb(142, 142, 147);
            lblPosition.Location = new Point(10, 60);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(154, 20);
            lblPosition.TabIndex = 1;
            lblPosition.Text = "Role";
            // 
            // txtReturnRecordId
            // 
            txtReturnRecordId.ForeColor = Color.Black;
            txtReturnRecordId.Location = new Point(262, 97);
            txtReturnRecordId.Name = "txtReturnRecordId";
            txtReturnRecordId.Size = new Size(303, 27);
            txtReturnRecordId.TabIndex = 18;
            txtReturnRecordId.TextChanged += txtReturnRecordId_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(249, 115, 22);
            btnSearch.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(571, 95);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(113, 35);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // ReturnRecordGrid
            // 
            ReturnRecordGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReturnRecordGrid.Location = new Point(262, 146);
            ReturnRecordGrid.Name = "ReturnRecordGrid";
            ReturnRecordGrid.RowHeadersWidth = 51;
            ReturnRecordGrid.Size = new Size(653, 438);
            ReturnRecordGrid.TabIndex = 21;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Black;
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(434, 597);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 35);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(613, 597);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 35);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Black;
            btnCreate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(262, 597);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(113, 35);
            btnCreate.TabIndex = 24;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblLogOut
            // 
            lblLogOut.AutoSize = true;
            lblLogOut.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogOut.Location = new Point(18, 369);
            lblLogOut.Margin = new Padding(18, 10, 9, 12);
            lblLogOut.Name = "lblLogOut";
            lblLogOut.Size = new Size(72, 23);
            lblLogOut.TabIndex = 69;
            lblLogOut.Text = "Log Out";
            lblLogOut.Click += lblLogOut_Click;
            // 
            // lblViewAuditLogs
            // 
            lblViewAuditLogs.AutoSize = true;
            lblViewAuditLogs.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewAuditLogs.Location = new Point(18, 234);
            lblViewAuditLogs.Margin = new Padding(18, 10, 9, 12);
            lblViewAuditLogs.Name = "lblViewAuditLogs";
            lblViewAuditLogs.Size = new Size(133, 23);
            lblViewAuditLogs.TabIndex = 65;
            lblViewAuditLogs.Text = "View Audit Logs";
            lblViewAuditLogs.Click += lblViewAuditLogs_Click;
            // 
            // lblDBbackup
            // 
            lblDBbackup.AutoSize = true;
            lblDBbackup.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDBbackup.Location = new Point(18, 279);
            lblDBbackup.Margin = new Padding(18, 10, 9, 12);
            lblDBbackup.Name = "lblDBbackup";
            lblDBbackup.Size = new Size(208, 23);
            lblDBbackup.TabIndex = 68;
            lblDBbackup.Text = "Perform Database Backup";
            lblDBbackup.Click += lblDBbackup_Click;
            // 
            // lblGenerateReport
            // 
            lblGenerateReport.AutoSize = true;
            lblGenerateReport.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenerateReport.Location = new Point(18, 324);
            lblGenerateReport.Margin = new Padding(18, 10, 9, 12);
            lblGenerateReport.Name = "lblGenerateReport";
            lblGenerateReport.Size = new Size(144, 23);
            lblGenerateReport.TabIndex = 67;
            lblGenerateReport.Text = "Generate Reports";
            lblGenerateReport.Click += lblGenerateReport_Click;
            // 
            // lblReturnRecords
            // 
            lblReturnRecords.AutoSize = true;
            lblReturnRecords.BackColor = Color.FromArgb(249, 115, 22);
            lblReturnRecords.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReturnRecords.ForeColor = Color.White;
            lblReturnRecords.Location = new Point(18, 5);
            lblReturnRecords.Margin = new Padding(18, 10, 9, 12);
            lblReturnRecords.Name = "lblReturnRecords";
            lblReturnRecords.Size = new Size(128, 23);
            lblReturnRecords.TabIndex = 63;
            lblReturnRecords.Text = "Return Records";
            // 
            // lblEquipmentManagement
            // 
            lblEquipmentManagement.AutoSize = true;
            lblEquipmentManagement.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentManagement.Location = new Point(18, 189);
            lblEquipmentManagement.Margin = new Padding(18, 10, 9, 12);
            lblEquipmentManagement.Name = "lblEquipmentManagement";
            lblEquipmentManagement.Size = new Size(201, 23);
            lblEquipmentManagement.TabIndex = 64;
            lblEquipmentManagement.Text = "Equipment Management";
            lblEquipmentManagement.Click += lblEquipmentManagement_Click;
            // 
            // lblTransactions
            // 
            lblTransactions.AutoSize = true;
            lblTransactions.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactions.Location = new Point(18, 100);
            lblTransactions.Margin = new Padding(18, 10, 9, 12);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(158, 23);
            lblTransactions.TabIndex = 62;
            lblTransactions.Text = "Rental Transactions";
            lblTransactions.Click += lblTransactions_Click;
            // 
            // lblRequest
            // 
            lblRequest.AutoSize = true;
            lblRequest.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRequest.Location = new Point(18, 55);
            lblRequest.Margin = new Padding(18, 10, 9, 12);
            lblRequest.Name = "lblRequest";
            lblRequest.Size = new Size(133, 23);
            lblRequest.TabIndex = 61;
            lblRequest.Text = "Rental Requests";
            lblRequest.Click += lblRequest_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(18, 10);
            label16.Margin = new Padding(18, 10, 9, 12);
            label16.Name = "label16";
            label16.Size = new Size(93, 23);
            label16.TabIndex = 60;
            label16.Text = "Dashboard";
            label16.Click += label16_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(249, 115, 22);
            btnRefresh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(807, 97);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(115, 35);
            btnRefresh.TabIndex = 70;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.Location = new Point(18, 414);
            lblExit.Margin = new Padding(18, 10, 9, 12);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(38, 23);
            lblExit.TabIndex = 71;
            lblExit.Text = "Exit";
            lblExit.Click += lblExit_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(label16);
            flowLayoutPanel1.Controls.Add(lblRequest);
            flowLayoutPanel1.Controls.Add(lblTransactions);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(lblEquipmentManagement);
            flowLayoutPanel1.Controls.Add(lblViewAuditLogs);
            flowLayoutPanel1.Controls.Add(lblDBbackup);
            flowLayoutPanel1.Controls.Add(lblGenerateReport);
            flowLayoutPanel1.Controls.Add(lblLogOut);
            flowLayoutPanel1.Controls.Add(lblExit);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(2, 91);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.MinimumSize = new Size(233, 441);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(255, 553);
            flowLayoutPanel1.TabIndex = 39;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(249, 115, 22);
            panel4.Controls.Add(lblReturnRecords);
            panel4.Location = new Point(2, 137);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(253, 40);
            panel4.TabIndex = 72;
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-5, 80);
            lblDivider.Margin = new Padding(2, 0, 2, 0);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(920, 1);
            lblDivider.TabIndex = 71;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(249, 115, 22);
            btnFilter.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(689, 97);
            btnFilter.Margin = new Padding(2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(113, 35);
            btnFilter.TabIndex = 77;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // ReturnRecords
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(927, 648);
            Controls.Add(btnFilter);
            Controls.Add(lblPosition);
            Controls.Add(lblName);
            Controls.Add(lblDivider);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnRefresh);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(ReturnRecordGrid);
            Controls.Add(btnSearch);
            Controls.Add(txtReturnRecordId);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReturnRecords";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnRecords";
            Load += ReturnRecords_Load_1;
            ((System.ComponentModel.ISupportInitialize)ReturnRecordGrid).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private Label lblPosition;
        private TextBox txtReturnRecordId;
        private Button btnSearch;
        private DataGridView ReturnRecordGrid;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCreate;
        private Label lblLogOut;
        private Label lblViewAuditLogs;
        private Label lblDBbackup;
        private Label lblGenerateReport;
        private Label lblReturnRecords;
        private Label lblEquipmentManagement;
        private Label lblTransactions;
        private Label lblRequest;
        private Label label16;
        private Button btnRefresh;
        private Label lblExit;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private Label lblDivider;
        private Button btnFilter;
    }
}