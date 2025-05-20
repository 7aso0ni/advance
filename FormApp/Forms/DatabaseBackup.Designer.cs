namespace FormApp.Forms
{
    partial class DatabaseBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseBackup));
            lblGenerateReports = new Label();
            lblPerformDBBackup = new Label();
            gridBackupLogs = new DataGridView();
            btnInitiateBackup = new Button();
            lblExit = new Label();
            lblLogOut = new Label();
            lblAuditLogs = new Label();
            lblEquipmentManagement = new Label();
            lblReturnRecords = new Label();
            lblRentalTransactions = new Label();
            lblRentalRequests = new Label();
            lblDashboard = new Label();
            lblDivider = new Label();
            lblRole = new Label();
            lblName = new Label();
            lblBackup = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)gridBackupLogs).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblGenerateReports
            // 
            lblGenerateReports.AutoSize = true;
            lblGenerateReports.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenerateReports.Location = new Point(18, 324);
            lblGenerateReports.Margin = new Padding(18, 10, 9, 12);
            lblGenerateReports.Name = "lblGenerateReports";
            lblGenerateReports.Size = new Size(144, 23);
            lblGenerateReports.TabIndex = 33;
            lblGenerateReports.Text = "Generate Reports";
            lblGenerateReports.Click += lblGenerateReports_Click;
            // 
            // lblPerformDBBackup
            // 
            lblPerformDBBackup.AutoSize = true;
            lblPerformDBBackup.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerformDBBackup.Location = new Point(947, 342);
            lblPerformDBBackup.Margin = new Padding(2, 0, 2, 0);
            lblPerformDBBackup.Name = "lblPerformDBBackup";
            lblPerformDBBackup.Size = new Size(0, 23);
            lblPerformDBBackup.TabIndex = 32;
            // 
            // gridBackupLogs
            // 
            gridBackupLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridBackupLogs.Location = new Point(262, 146);
            gridBackupLogs.Margin = new Padding(2);
            gridBackupLogs.Name = "gridBackupLogs";
            gridBackupLogs.RowHeadersWidth = 82;
            gridBackupLogs.Size = new Size(653, 491);
            gridBackupLogs.TabIndex = 31;
            // 
            // btnInitiateBackup
            // 
            btnInitiateBackup.BackColor = Color.FromArgb(249, 115, 22);
            btnInitiateBackup.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnInitiateBackup.ForeColor = Color.White;
            btnInitiateBackup.Location = new Point(262, 100);
            btnInitiateBackup.Margin = new Padding(2);
            btnInitiateBackup.Name = "btnInitiateBackup";
            btnInitiateBackup.Size = new Size(203, 35);
            btnInitiateBackup.TabIndex = 30;
            btnInitiateBackup.Text = "Initiate New Backup";
            btnInitiateBackup.UseVisualStyleBackColor = false;
            btnInitiateBackup.Click += btnInitiateBackup_Click;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.Location = new Point(18, 414);
            lblExit.Margin = new Padding(18, 10, 9, 12);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(38, 23);
            lblExit.TabIndex = 28;
            lblExit.Text = "Exit";
            lblExit.Click += lblExit_Click;
            // 
            // lblLogOut
            // 
            lblLogOut.AutoSize = true;
            lblLogOut.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogOut.Location = new Point(18, 369);
            lblLogOut.Margin = new Padding(18, 10, 9, 12);
            lblLogOut.Name = "lblLogOut";
            lblLogOut.Size = new Size(72, 23);
            lblLogOut.TabIndex = 27;
            lblLogOut.Text = "Log Out";
            lblLogOut.Click += lblLogOut_Click;
            // 
            // lblAuditLogs
            // 
            lblAuditLogs.AutoSize = true;
            lblAuditLogs.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuditLogs.Location = new Point(18, 235);
            lblAuditLogs.Margin = new Padding(18, 10, 9, 12);
            lblAuditLogs.Name = "lblAuditLogs";
            lblAuditLogs.Size = new Size(133, 23);
            lblAuditLogs.TabIndex = 26;
            lblAuditLogs.Text = "View Audit Logs";
            lblAuditLogs.Click += lblAuditLogs_Click;
            // 
            // lblEquipmentManagement
            // 
            lblEquipmentManagement.AutoSize = true;
            lblEquipmentManagement.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentManagement.Location = new Point(18, 190);
            lblEquipmentManagement.Margin = new Padding(18, 10, 9, 12);
            lblEquipmentManagement.Name = "lblEquipmentManagement";
            lblEquipmentManagement.Size = new Size(201, 23);
            lblEquipmentManagement.TabIndex = 25;
            lblEquipmentManagement.Text = "Equipment Management";
            lblEquipmentManagement.Click += lblEquipmentManagement_Click;
            // 
            // lblReturnRecords
            // 
            lblReturnRecords.AutoSize = true;
            lblReturnRecords.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReturnRecords.Location = new Point(18, 145);
            lblReturnRecords.Margin = new Padding(18, 10, 9, 12);
            lblReturnRecords.Name = "lblReturnRecords";
            lblReturnRecords.Size = new Size(128, 23);
            lblReturnRecords.TabIndex = 24;
            lblReturnRecords.Text = "Return Records";
            lblReturnRecords.Click += lblReturnRecords_Click;
            // 
            // lblRentalTransactions
            // 
            lblRentalTransactions.AutoSize = true;
            lblRentalTransactions.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalTransactions.Location = new Point(18, 100);
            lblRentalTransactions.Margin = new Padding(18, 10, 9, 12);
            lblRentalTransactions.Name = "lblRentalTransactions";
            lblRentalTransactions.Size = new Size(158, 23);
            lblRentalTransactions.TabIndex = 23;
            lblRentalTransactions.Text = "Rental Transactions";
            lblRentalTransactions.Click += lblRentalTransactions_Click;
            // 
            // lblRentalRequests
            // 
            lblRentalRequests.AutoSize = true;
            lblRentalRequests.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalRequests.Location = new Point(18, 55);
            lblRentalRequests.Margin = new Padding(18, 10, 9, 12);
            lblRentalRequests.Name = "lblRentalRequests";
            lblRentalRequests.Size = new Size(133, 23);
            lblRentalRequests.TabIndex = 22;
            lblRentalRequests.Text = "Rental Requests";
            lblRentalRequests.Click += lblRentalRequests_Click;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(18, 10);
            lblDashboard.Margin = new Padding(18, 10, 9, 12);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(93, 23);
            lblDashboard.TabIndex = 21;
            lblDashboard.Text = "Dashboard";
            lblDashboard.Click += lblDashboard_Click;
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-5, 80);
            lblDivider.Margin = new Padding(2, 0, 2, 0);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(920, 1);
            lblDivider.TabIndex = 19;
            // 
            // lblRole
            // 
            lblRole.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(142, 142, 147);
            lblRole.Location = new Point(10, 60);
            lblRole.Margin = new Padding(2, 0, 2, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(154, 20);
            lblRole.TabIndex = 18;
            lblRole.Text = "Role";
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblName.Location = new Point(4, 9);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(217, 41);
            lblName.TabIndex = 17;
            lblName.Text = "Name";
            // 
            // lblBackup
            // 
            lblBackup.AutoSize = true;
            lblBackup.BackColor = Color.FromArgb(249, 115, 22);
            lblBackup.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBackup.ForeColor = Color.White;
            lblBackup.Location = new Point(18, 8);
            lblBackup.Margin = new Padding(18, 10, 9, 12);
            lblBackup.Name = "lblBackup";
            lblBackup.Size = new Size(208, 23);
            lblBackup.TabIndex = 38;
            lblBackup.Text = "Perform Database Backup";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(lblDashboard);
            flowLayoutPanel1.Controls.Add(lblRentalRequests);
            flowLayoutPanel1.Controls.Add(lblRentalTransactions);
            flowLayoutPanel1.Controls.Add(lblReturnRecords);
            flowLayoutPanel1.Controls.Add(lblEquipmentManagement);
            flowLayoutPanel1.Controls.Add(lblAuditLogs);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(lblGenerateReports);
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
            panel1.Controls.Add(lblBackup);
            panel1.Location = new Point(2, 272);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 40);
            panel1.TabIndex = 40;
            // 
            // DatabaseBackup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(927, 648);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblPerformDBBackup);
            Controls.Add(gridBackupLogs);
            Controls.Add(btnInitiateBackup);
            Controls.Add(lblDivider);
            Controls.Add(lblRole);
            Controls.Add(lblName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "DatabaseBackup";
            Text = "Database Backup";
            Load += DatabaseBackup_Load;
            ((System.ComponentModel.ISupportInitialize)gridBackupLogs).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGenerateReports;
        private Label lblPerformDBBackup;
        private DataGridView gridBackupLogs;
        private Button btnInitiateBackup;
        private Label lblExit;
        private Label lblLogOut;
        private Label lblAuditLogs;
        private Label lblEquipmentManagement;
        private Label lblReturnRecords;
        private Label lblRentalTransactions;
        private Label lblRentalRequests;
        private Label lblDashboard;
        private Label lblDivider;
        private Label lblRole;
        private Label lblName;
        private Label lblBackup;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
    }
}