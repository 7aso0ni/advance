namespace FormApp.Forms
{
    partial class GenerateReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateReports));
            lblPerformDBBackup = new Label();
            btnMostRentedEquipment = new Button();
            lblExit = new Label();
            lblLogOut = new Label();
            lblAuditLogs = new Label();
            lblEquipmentManagement = new Label();
            lblReturnRecords = new Label();
            lblRentalTransactions = new Label();
            lblRentalRequests = new Label();
            lblDashboard = new Label();
            label1 = new Label();
            lblDivider = new Label();
            lblRole = new Label();
            lblName = new Label();
            btnActiveCustomers = new Button();
            lblGenerateReports = new Label();
            btnDownload = new Button();
            gridReports = new DataGridView();
            sidebarPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)gridReports).BeginInit();
            sidebarPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPerformDBBackup
            // 
            lblPerformDBBackup.AutoSize = true;
            lblPerformDBBackup.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerformDBBackup.Location = new Point(18, 280);
            lblPerformDBBackup.Margin = new Padding(18, 10, 9, 12);
            lblPerformDBBackup.Name = "lblPerformDBBackup";
            lblPerformDBBackup.Size = new Size(208, 23);
            lblPerformDBBackup.TabIndex = 32;
            lblPerformDBBackup.Text = "Perform Database Backup";
            lblPerformDBBackup.Click += lblPerformDBBackup_Click;
            // 
            // btnMostRentedEquipment
            // 
            btnMostRentedEquipment.BackColor = Color.FromArgb(249, 115, 22);
            btnMostRentedEquipment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostRentedEquipment.ForeColor = Color.White;
            btnMostRentedEquipment.Location = new Point(499, 107);
            btnMostRentedEquipment.Margin = new Padding(2);
            btnMostRentedEquipment.Name = "btnMostRentedEquipment";
            btnMostRentedEquipment.Size = new Size(181, 35);
            btnMostRentedEquipment.TabIndex = 30;
            btnMostRentedEquipment.Text = "Most Rented Equipment";
            btnMostRentedEquipment.UseVisualStyleBackColor = false;
            btnMostRentedEquipment.Click += btnMostRentedEquipment_Click;
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
            // label1
            // 
            label1.BackColor = Color.FromArgb(236, 236, 236);
            label1.Location = new Point(228, 81);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(1, 444);
            label1.TabIndex = 20;
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
            // btnActiveCustomers
            // 
            btnActiveCustomers.BackColor = Color.FromArgb(249, 115, 22);
            btnActiveCustomers.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActiveCustomers.ForeColor = Color.White;
            btnActiveCustomers.Location = new Point(262, 107);
            btnActiveCustomers.Margin = new Padding(2);
            btnActiveCustomers.Name = "btnActiveCustomers";
            btnActiveCustomers.Size = new Size(181, 35);
            btnActiveCustomers.TabIndex = 34;
            btnActiveCustomers.Text = "Active Customers";
            btnActiveCustomers.UseVisualStyleBackColor = false;
            btnActiveCustomers.Click += btnActiveCustomers_Click;
            // 
            // lblGenerateReports
            // 
            lblGenerateReports.AutoSize = true;
            lblGenerateReports.BackColor = Color.FromArgb(249, 115, 22);
            lblGenerateReports.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenerateReports.ForeColor = Color.White;
            lblGenerateReports.Location = new Point(19, 8);
            lblGenerateReports.Margin = new Padding(18, 10, 9, 12);
            lblGenerateReports.Name = "lblGenerateReports";
            lblGenerateReports.Size = new Size(144, 23);
            lblGenerateReports.TabIndex = 37;
            lblGenerateReports.Text = "Generate Reports";
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.Black;
            btnDownload.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDownload.ForeColor = Color.White;
            btnDownload.Location = new Point(734, 107);
            btnDownload.Margin = new Padding(2);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(181, 35);
            btnDownload.TabIndex = 38;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // gridReports
            // 
            gridReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridReports.Location = new Point(262, 146);
            gridReports.Margin = new Padding(2);
            gridReports.Name = "gridReports";
            gridReports.RowHeadersWidth = 82;
            gridReports.Size = new Size(653, 491);
            gridReports.TabIndex = 39;
            // 
            // sidebarPanel
            // 
            sidebarPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sidebarPanel.Controls.Add(lblDashboard);
            sidebarPanel.Controls.Add(lblRentalRequests);
            sidebarPanel.Controls.Add(lblRentalTransactions);
            sidebarPanel.Controls.Add(lblReturnRecords);
            sidebarPanel.Controls.Add(lblEquipmentManagement);
            sidebarPanel.Controls.Add(lblAuditLogs);
            sidebarPanel.Controls.Add(lblPerformDBBackup);
            sidebarPanel.Controls.Add(panel1);
            sidebarPanel.Controls.Add(lblLogOut);
            sidebarPanel.Controls.Add(lblExit);
            sidebarPanel.FlowDirection = FlowDirection.TopDown;
            sidebarPanel.Location = new Point(2, 91);
            sidebarPanel.Margin = new Padding(2);
            sidebarPanel.MinimumSize = new Size(233, 441);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(255, 553);
            sidebarPanel.TabIndex = 40;
            sidebarPanel.WrapContents = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 115, 22);
            panel1.Controls.Add(lblGenerateReports);
            panel1.Location = new Point(2, 317);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 40);
            panel1.TabIndex = 41;
            // 
            // GenerateReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(927, 648);
            Controls.Add(sidebarPanel);
            Controls.Add(gridReports);
            Controls.Add(btnDownload);
            Controls.Add(btnActiveCustomers);
            Controls.Add(btnMostRentedEquipment);
            Controls.Add(label1);
            Controls.Add(lblDivider);
            Controls.Add(lblRole);
            Controls.Add(lblName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "GenerateReports";
            Text = "Generate Reports";
            Load += GenerateReports_Load;
            ((System.ComponentModel.ISupportInitialize)gridReports).EndInit();
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblPerformDBBackup;
        private Button btnMostRentedEquipment;
        private Label lblExit;
        private Label lblLogOut;
        private Label lblAuditLogs;
        private Label lblEquipmentManagement;
        private Label lblReturnRecords;
        private Label lblRentalTransactions;
        private Label lblRentalRequests;
        private Label lblDashboard;
        private Label label1;
        private Label lblDivider;
        private Label lblRole;
        private Label lblName;
        private Button btnActiveCustomers;
        private Label lblGenerateReports;
        private Button btnDownload;
        private DataGridView gridReports;
        private FlowLayoutPanel sidebarPanel;
        private Panel panel1;
    }
}