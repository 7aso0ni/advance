namespace FormApp.Forms
{
    partial class AuditLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuditLogs));
            lblName = new Label();
            lblRole = new Label();
            lblDivider = new Label();
            lblDashboard = new Label();
            lblRentalRequests = new Label();
            lblRentalTransactions = new Label();
            lblReturnRecords = new Label();
            lblEquipmentManagement = new Label();
            lblAuditLogs = new Label();
            lblLogOut = new Label();
            lblExit = new Label();
            btnSearch = new Button();
            gridLogs = new DataGridView();
            lblPerformDBBackup = new Label();
            lblGenerateReports = new Label();
            lblViewAuditLogs = new Label();
            slowbarFlowPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            btnFilter = new Button();
            btnRefresh = new Button();
            txtSearchBar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridLogs).BeginInit();
            slowbarFlowPanel.SuspendLayout();
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
            // lblRole
            // 
            lblRole.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(142, 142, 147);
            lblRole.Location = new Point(10, 60);
            lblRole.Margin = new Padding(2, 0, 2, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(154, 20);
            lblRole.TabIndex = 1;
            lblRole.Text = "Role";
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-5, 80);
            lblDivider.Margin = new Padding(2, 0, 2, 0);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(935, 1);
            lblDivider.TabIndex = 2;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(18, 10);
            lblDashboard.Margin = new Padding(18, 10, 9, 12);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(93, 23);
            lblDashboard.TabIndex = 4;
            lblDashboard.Text = "Dashboard";
            lblDashboard.Click += lblDashboard_Click;
            // 
            // lblRentalRequests
            // 
            lblRentalRequests.AutoSize = true;
            lblRentalRequests.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalRequests.Location = new Point(18, 55);
            lblRentalRequests.Margin = new Padding(18, 10, 9, 12);
            lblRentalRequests.Name = "lblRentalRequests";
            lblRentalRequests.Size = new Size(133, 23);
            lblRentalRequests.TabIndex = 5;
            lblRentalRequests.Text = "Rental Requests";
            lblRentalRequests.Click += lblRentalRequests_Click;
            // 
            // lblRentalTransactions
            // 
            lblRentalTransactions.AutoSize = true;
            lblRentalTransactions.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalTransactions.Location = new Point(18, 100);
            lblRentalTransactions.Margin = new Padding(18, 10, 9, 12);
            lblRentalTransactions.Name = "lblRentalTransactions";
            lblRentalTransactions.Size = new Size(158, 23);
            lblRentalTransactions.TabIndex = 6;
            lblRentalTransactions.Text = "Rental Transactions";
            lblRentalTransactions.Click += lblRentalTransactions_Click;
            // 
            // lblReturnRecords
            // 
            lblReturnRecords.AutoSize = true;
            lblReturnRecords.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReturnRecords.Location = new Point(18, 145);
            lblReturnRecords.Margin = new Padding(18, 10, 9, 12);
            lblReturnRecords.Name = "lblReturnRecords";
            lblReturnRecords.Size = new Size(128, 23);
            lblReturnRecords.TabIndex = 7;
            lblReturnRecords.Text = "Return Records";
            lblReturnRecords.Click += lblReturnRecords_Click;
            // 
            // lblEquipmentManagement
            // 
            lblEquipmentManagement.AutoSize = true;
            lblEquipmentManagement.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentManagement.Location = new Point(18, 190);
            lblEquipmentManagement.Margin = new Padding(18, 10, 9, 12);
            lblEquipmentManagement.Name = "lblEquipmentManagement";
            lblEquipmentManagement.Size = new Size(201, 23);
            lblEquipmentManagement.TabIndex = 8;
            lblEquipmentManagement.Text = "Equipment Management";
            lblEquipmentManagement.Click += lblEquipmentManagement_Click;
            // 
            // lblAuditLogs
            // 
            lblAuditLogs.AutoSize = true;
            lblAuditLogs.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuditLogs.Location = new Point(938, 286);
            lblAuditLogs.Margin = new Padding(2, 0, 2, 0);
            lblAuditLogs.Name = "lblAuditLogs";
            lblAuditLogs.Size = new Size(0, 23);
            lblAuditLogs.TabIndex = 9;
            // 
            // lblLogOut
            // 
            lblLogOut.AutoSize = true;
            lblLogOut.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogOut.Location = new Point(18, 369);
            lblLogOut.Margin = new Padding(18, 10, 9, 12);
            lblLogOut.Name = "lblLogOut";
            lblLogOut.Size = new Size(72, 23);
            lblLogOut.TabIndex = 10;
            lblLogOut.Text = "Log Out";
            lblLogOut.Click += lblLogOut_Click;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.Location = new Point(18, 414);
            lblExit.Margin = new Padding(18, 10, 9, 12);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(38, 23);
            lblExit.TabIndex = 11;
            lblExit.Text = "Exit";
            lblExit.Click += lblExit_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(249, 115, 22);
            btnSearch.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(562, 91);
            btnSearch.Margin = new Padding(2, 2, 2, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(113, 35);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // gridLogs
            // 
            gridLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridLogs.Location = new Point(262, 146);
            gridLogs.Margin = new Padding(2, 2, 2, 2);
            gridLogs.Name = "gridLogs";
            gridLogs.RowHeadersWidth = 82;
            gridLogs.Size = new Size(653, 491);
            gridLogs.TabIndex = 14;
            gridLogs.CellContentClick += gridLogs_CellContentClick;
            // 
            // lblPerformDBBackup
            // 
            lblPerformDBBackup.AutoSize = true;
            lblPerformDBBackup.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerformDBBackup.Location = new Point(18, 279);
            lblPerformDBBackup.Margin = new Padding(18, 10, 9, 12);
            lblPerformDBBackup.Name = "lblPerformDBBackup";
            lblPerformDBBackup.Size = new Size(208, 23);
            lblPerformDBBackup.TabIndex = 15;
            lblPerformDBBackup.Text = "Perform Database Backup";
            lblPerformDBBackup.Click += lblPerformDBBackup_Click;
            // 
            // lblGenerateReports
            // 
            lblGenerateReports.AutoSize = true;
            lblGenerateReports.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenerateReports.Location = new Point(18, 324);
            lblGenerateReports.Margin = new Padding(18, 10, 9, 12);
            lblGenerateReports.Name = "lblGenerateReports";
            lblGenerateReports.Size = new Size(144, 23);
            lblGenerateReports.TabIndex = 16;
            lblGenerateReports.Text = "Generate Reports";
            lblGenerateReports.Click += lblGenerateReports_Click;
            // 
            // lblViewAuditLogs
            // 
            lblViewAuditLogs.AutoSize = true;
            lblViewAuditLogs.BackColor = Color.FromArgb(249, 115, 22);
            lblViewAuditLogs.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewAuditLogs.ForeColor = Color.White;
            lblViewAuditLogs.Location = new Point(20, 8);
            lblViewAuditLogs.Margin = new Padding(18, 10, 9, 12);
            lblViewAuditLogs.Name = "lblViewAuditLogs";
            lblViewAuditLogs.Size = new Size(133, 23);
            lblViewAuditLogs.TabIndex = 18;
            lblViewAuditLogs.Text = "View Audit Logs";
            // 
            // slowbarFlowPanel
            // 
            slowbarFlowPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            slowbarFlowPanel.Controls.Add(lblDashboard);
            slowbarFlowPanel.Controls.Add(lblRentalRequests);
            slowbarFlowPanel.Controls.Add(lblRentalTransactions);
            slowbarFlowPanel.Controls.Add(lblReturnRecords);
            slowbarFlowPanel.Controls.Add(lblEquipmentManagement);
            slowbarFlowPanel.Controls.Add(panel1);
            slowbarFlowPanel.Controls.Add(lblPerformDBBackup);
            slowbarFlowPanel.Controls.Add(lblGenerateReports);
            slowbarFlowPanel.Controls.Add(lblLogOut);
            slowbarFlowPanel.Controls.Add(lblExit);
            slowbarFlowPanel.FlowDirection = FlowDirection.TopDown;
            slowbarFlowPanel.Location = new Point(2, 91);
            slowbarFlowPanel.Margin = new Padding(2, 2, 2, 2);
            slowbarFlowPanel.MinimumSize = new Size(185, 438);
            slowbarFlowPanel.Name = "slowbarFlowPanel";
            slowbarFlowPanel.Size = new Size(255, 553);
            slowbarFlowPanel.TabIndex = 19;
            slowbarFlowPanel.WrapContents = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 115, 22);
            panel1.Controls.Add(lblViewAuditLogs);
            panel1.Location = new Point(2, 227);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 40);
            panel1.TabIndex = 20;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(249, 115, 22);
            btnFilter.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(679, 91);
            btnFilter.Margin = new Padding(2, 2, 2, 2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(113, 35);
            btnFilter.TabIndex = 20;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(249, 115, 22);
            btnRefresh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(796, 91);
            btnRefresh.Margin = new Padding(2, 2, 2, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(113, 35);
            btnRefresh.TabIndex = 21;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearchBar
            // 
            txtSearchBar.BackColor = Color.WhiteSmoke;
            txtSearchBar.Location = new Point(269, 98);
            txtSearchBar.Margin = new Padding(2, 2, 2, 2);
            txtSearchBar.Name = "txtSearchBar";
            txtSearchBar.Size = new Size(285, 27);
            txtSearchBar.TabIndex = 12;
            // 
            // AuditLogs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(927, 648);
            Controls.Add(btnRefresh);
            Controls.Add(btnFilter);
            Controls.Add(slowbarFlowPanel);
            Controls.Add(gridLogs);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchBar);
            Controls.Add(lblAuditLogs);
            Controls.Add(lblDivider);
            Controls.Add(lblRole);
            Controls.Add(lblName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "AuditLogs";
            Text = "Audit Logs";
            Load += AuditLogs_Load;
            ((System.ComponentModel.ISupportInitialize)gridLogs).EndInit();
            slowbarFlowPanel.ResumeLayout(false);
            slowbarFlowPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblRole;
        private Label lblDivider;
        private Label lblDashboard;
        private Label lblRentalRequests;
        private Label lblRentalTransactions;
        private Label lblReturnRecords;
        private Label lblEquipmentManagement;
        private Label lblAuditLogs;
        private Label lblLogOut;
        private Label lblExit;
        private Button btnSearch;
        private DataGridView gridLogs;
        private Label lblPerformDBBackup;
        private Label lblGenerateReports;
        private Label lblViewAuditLogs;
        private FlowLayoutPanel slowbarFlowPanel;
        private Panel panel1;
        private Button btnFilter;
        private Button btnRefresh;
        private TextBox txtSearchBar;
    }
}