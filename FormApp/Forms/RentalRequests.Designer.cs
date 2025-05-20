namespace FormApp
{
    partial class RentalRequests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalRequests));
            lblName = new Label();
            lblPosition = new Label();
            lblDivider = new Label();
            label16 = new Label();
            lblRequest = new Label();
            lblTransactions = new Label();
            requestId = new TextBox();
            btnSearch = new Button();
            RentalRequestGrid = new DataGridView();
            btnUpdate = new Button();
            lblLogOut = new Label();
            lblViewAuditLogs = new Label();
            lblDBbackup = new Label();
            lblGenerateReport = new Label();
            lblReturnRecords = new Label();
            lblEquipmentManagement = new Label();
            lblExit = new Label();
            btnRefresh = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            btnFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)RentalRequestGrid).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblName.Location = new Point(4, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(217, 41);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
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
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-5, 80);
            lblDivider.Margin = new Padding(2, 0, 2, 0);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(920, 1);
            lblDivider.TabIndex = 63;
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
            label16.TabIndex = 14;
            label16.Text = "Dashboard";
            label16.Click += label16_Click;
            // 
            // lblRequest
            // 
            lblRequest.AutoSize = true;
            lblRequest.BackColor = Color.FromArgb(249, 115, 22);
            lblRequest.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRequest.ForeColor = Color.White;
            lblRequest.Location = new Point(20, 9);
            lblRequest.Margin = new Padding(18, 9, 9, 12);
            lblRequest.Name = "lblRequest";
            lblRequest.Size = new Size(133, 23);
            lblRequest.TabIndex = 61;
            lblRequest.Text = "Rental Requests";
            // 
            // lblTransactions
            // 
            lblTransactions.AutoSize = true;
            lblTransactions.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactions.Location = new Point(18, 105);
            lblTransactions.Margin = new Padding(18, 10, 9, 12);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(158, 23);
            lblTransactions.TabIndex = 62;
            lblTransactions.Text = "Rental Transactions";
            lblTransactions.Click += lblTransactions_Click;
            // 
            // requestId
            // 
            requestId.ForeColor = Color.Black;
            requestId.Location = new Point(262, 97);
            requestId.Name = "requestId";
            requestId.Size = new Size(304, 27);
            requestId.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(249, 115, 22);
            btnSearch.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(572, 95);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(113, 35);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // RentalRequestGrid
            // 
            RentalRequestGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RentalRequestGrid.Location = new Point(262, 146);
            RentalRequestGrid.Name = "RentalRequestGrid";
            RentalRequestGrid.RowHeadersWidth = 51;
            RentalRequestGrid.Size = new Size(653, 438);
            RentalRequestGrid.TabIndex = 14;
            RentalRequestGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Black;
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(262, 597);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 35);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnAccept_Click;
            // 
            // lblLogOut
            // 
            lblLogOut.AutoSize = true;
            lblLogOut.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogOut.Location = new Point(18, 375);
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
            lblViewAuditLogs.Location = new Point(18, 240);
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
            lblDBbackup.Location = new Point(18, 285);
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
            lblGenerateReport.Location = new Point(18, 330);
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
            lblReturnRecords.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReturnRecords.Location = new Point(18, 150);
            lblReturnRecords.Margin = new Padding(18, 10, 9, 12);
            lblReturnRecords.Name = "lblReturnRecords";
            lblReturnRecords.Size = new Size(128, 23);
            lblReturnRecords.TabIndex = 63;
            lblReturnRecords.Text = "Return Records";
            lblReturnRecords.Click += lblReturnRecords_Click;
            // 
            // lblEquipmentManagement
            // 
            lblEquipmentManagement.AutoSize = true;
            lblEquipmentManagement.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentManagement.Location = new Point(18, 195);
            lblEquipmentManagement.Margin = new Padding(18, 10, 9, 12);
            lblEquipmentManagement.Name = "lblEquipmentManagement";
            lblEquipmentManagement.Size = new Size(201, 23);
            lblEquipmentManagement.TabIndex = 64;
            lblEquipmentManagement.Text = "Equipment Management";
            lblEquipmentManagement.Click += lblEquipmentManagement_Click;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.Location = new Point(18, 420);
            lblExit.Margin = new Padding(18, 10, 9, 12);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(38, 23);
            lblExit.TabIndex = 70;
            lblExit.Text = "Exit";
            lblExit.Click += lblExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(249, 115, 22);
            btnRefresh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(808, 95);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(113, 35);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(label16);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(lblTransactions);
            flowLayoutPanel1.Controls.Add(lblReturnRecords);
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 115, 22);
            panel1.Controls.Add(lblRequest);
            panel1.Location = new Point(0, 45);
            panel1.Margin = new Padding(0, 0, 0, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 40);
            panel1.TabIndex = 72;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(249, 115, 22);
            btnFilter.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(690, 95);
            btnFilter.Margin = new Padding(2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(113, 35);
            btnFilter.TabIndex = 64;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // RentalRequests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(927, 648);
            Controls.Add(btnFilter);
            Controls.Add(lblName);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblPosition);
            Controls.Add(btnUpdate);
            Controls.Add(lblDivider);
            Controls.Add(RentalRequestGrid);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(requestId);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RentalRequests";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RentalRequest";
            Load += RentalRequest_Load;
            ((System.ComponentModel.ISupportInitialize)RentalRequestGrid).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private Label lblPosition;
        private TextBox requestId;
        private Button btnSearch;
        private DataGridView RentalRequestGrid;
        private Button btnUpdate;
        private Label lblLogOut;
        private Label lblViewAuditLogs;
        private Label lblDBbackup;
        private Label lblGenerateReport;
        private Label lblReturnRecords;
        private Label lblEquipmentManagement;
        private Label lblTransactions;
        private Label lblRequest;
        private Label label16;
        private Label lblExit;
        private Button btnRefresh;
        private Button btnFiler;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label lblDivider;
        private Button btnFilter;
    }
}