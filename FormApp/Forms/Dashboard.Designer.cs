namespace FormApp
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            lblName = new Label();
            lblPosition = new Label();
            pnlInfo = new Panel();
            lblOverdueRequests = new Label();
            lblPendingRequests = new Label();
            lblActiveRentals = new Label();
            lblrentedEquipment = new Label();
            lblavEq = new Label();
            lbleqTotal = new Label();
            lblOverdue = new Label();
            lblActiveRental = new Label();
            lblPending = new Label();
            lblRentedEq = new Label();
            lblTotalEq = new Label();
            lblAvailableEq = new Label();
            label2 = new Label();
            label1 = new Label();
            lblRecentEq = new Label();
            recentlyAddedEquipmentGrid = new DataGridView();
            lblRecentRentalReq = new Label();
            latestRentalRequestGrid = new DataGridView();
            label16 = new Label();
            lblRequest = new Label();
            lblTransactions = new Label();
            lblEquipmentManagement = new Label();
            lblReturnRecords = new Label();
            lblGenerateReport = new Label();
            lblDBbackup = new Label();
            lblViewAuditLogs = new Label();
            lblExit = new Label();
            lblLogOut = new Label();
            panel1 = new Panel();
            lblDivider = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recentlyAddedEquipmentGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)latestRentalRequestGrid).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(4, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(217, 41);
            lblName.TabIndex = 0;
            lblName.Text = "Admin";
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
            // pnlInfo
            // 
            pnlInfo.Controls.Add(lblOverdueRequests);
            pnlInfo.Controls.Add(lblPendingRequests);
            pnlInfo.Controls.Add(lblActiveRentals);
            pnlInfo.Controls.Add(lblrentedEquipment);
            pnlInfo.Controls.Add(lblavEq);
            pnlInfo.Controls.Add(lbleqTotal);
            pnlInfo.Controls.Add(lblOverdue);
            pnlInfo.Controls.Add(lblActiveRental);
            pnlInfo.Controls.Add(lblPending);
            pnlInfo.Controls.Add(lblRentedEq);
            pnlInfo.Controls.Add(lblTotalEq);
            pnlInfo.Controls.Add(lblAvailableEq);
            pnlInfo.Controls.Add(label2);
            pnlInfo.Controls.Add(label1);
            pnlInfo.Location = new Point(262, 91);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(660, 156);
            pnlInfo.TabIndex = 2;
            // 
            // lblOverdueRequests
            // 
            lblOverdueRequests.AutoSize = true;
            lblOverdueRequests.Location = new Point(550, 129);
            lblOverdueRequests.Name = "lblOverdueRequests";
            lblOverdueRequests.Size = new Size(18, 20);
            lblOverdueRequests.TabIndex = 13;
            lblOverdueRequests.Text = "...";
            // 
            // lblPendingRequests
            // 
            lblPendingRequests.AutoSize = true;
            lblPendingRequests.Location = new Point(550, 94);
            lblPendingRequests.Name = "lblPendingRequests";
            lblPendingRequests.Size = new Size(18, 20);
            lblPendingRequests.TabIndex = 12;
            lblPendingRequests.Text = "...";
            // 
            // lblActiveRentals
            // 
            lblActiveRentals.AutoSize = true;
            lblActiveRentals.Location = new Point(550, 62);
            lblActiveRentals.Name = "lblActiveRentals";
            lblActiveRentals.Size = new Size(18, 20);
            lblActiveRentals.TabIndex = 11;
            lblActiveRentals.Text = "...";
            // 
            // lblrentedEquipment
            // 
            lblrentedEquipment.AutoSize = true;
            lblrentedEquipment.Location = new Point(222, 126);
            lblrentedEquipment.Name = "lblrentedEquipment";
            lblrentedEquipment.Size = new Size(18, 20);
            lblrentedEquipment.TabIndex = 10;
            lblrentedEquipment.Text = "...";
            lblrentedEquipment.Click += label11_Click;
            // 
            // lblavEq
            // 
            lblavEq.AutoSize = true;
            lblavEq.Location = new Point(222, 94);
            lblavEq.Name = "lblavEq";
            lblavEq.Size = new Size(18, 20);
            lblavEq.TabIndex = 9;
            lblavEq.Text = "...";
            // 
            // lbleqTotal
            // 
            lbleqTotal.AutoSize = true;
            lbleqTotal.Location = new Point(222, 62);
            lbleqTotal.Name = "lbleqTotal";
            lbleqTotal.Size = new Size(18, 20);
            lbleqTotal.TabIndex = 8;
            lbleqTotal.Text = "...";
            lbleqTotal.Click += label9_Click;
            // 
            // lblOverdue
            // 
            lblOverdue.AutoSize = true;
            lblOverdue.Location = new Point(344, 126);
            lblOverdue.Name = "lblOverdue";
            lblOverdue.Size = new Size(128, 20);
            lblOverdue.TabIndex = 7;
            lblOverdue.Text = "Overdue Requests";
//            lblOverdue.Click += lblOverdue_Click;
            // 
            // lblActiveRental
            // 
            lblActiveRental.AutoSize = true;
            lblActiveRental.Location = new Point(347, 62);
            lblActiveRental.Name = "lblActiveRental";
            lblActiveRental.Size = new Size(102, 20);
            lblActiveRental.TabIndex = 6;
            lblActiveRental.Text = "Active Rentals";
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Location = new Point(347, 94);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(125, 20);
            lblPending.TabIndex = 5;
            lblPending.Text = "Pending Requests";
            // 
            // lblRentedEq
            // 
            lblRentedEq.AutoSize = true;
            lblRentedEq.Location = new Point(10, 126);
            lblRentedEq.Name = "lblRentedEq";
            lblRentedEq.Size = new Size(132, 20);
            lblRentedEq.TabIndex = 4;
            lblRentedEq.Text = "Rented Equipment";
            // 
            // lblTotalEq
            // 
            lblTotalEq.AutoSize = true;
            lblTotalEq.Location = new Point(10, 62);
            lblTotalEq.Name = "lblTotalEq";
            lblTotalEq.Size = new Size(108, 20);
            lblTotalEq.TabIndex = 3;
            lblTotalEq.Text = "Total Summary";
            // 
            // lblAvailableEq
            // 
            lblAvailableEq.AutoSize = true;
            lblAvailableEq.Location = new Point(10, 94);
            lblAvailableEq.Name = "lblAvailableEq";
            lblAvailableEq.Size = new Size(147, 20);
            lblAvailableEq.TabIndex = 2;
            lblAvailableEq.Text = "Available Equipment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(347, 5);
            label2.Name = "label2";
            label2.Size = new Size(169, 28);
            label2.TabIndex = 1;
            label2.Text = "Rental Summary";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 4);
            label1.Name = "label1";
            label1.Size = new Size(210, 28);
            label1.TabIndex = 0;
            label1.Text = "Equipment Summary";
            // 
            // lblRecentEq
            // 
            lblRecentEq.AutoSize = true;
            lblRecentEq.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentEq.Location = new Point(262, 270);
            lblRecentEq.Name = "lblRecentEq";
            lblRecentEq.Size = new Size(230, 23);
            lblRecentEq.TabIndex = 3;
            lblRecentEq.Text = "Recently Added Equipment";
            lblRecentEq.Click += lblRecentEq_Click;
            // 
            // recentlyAddedEquipmentGrid
            // 
            recentlyAddedEquipmentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recentlyAddedEquipmentGrid.Location = new Point(262, 297);
            recentlyAddedEquipmentGrid.Name = "recentlyAddedEquipmentGrid";
            recentlyAddedEquipmentGrid.RowHeadersWidth = 51;
            recentlyAddedEquipmentGrid.Size = new Size(660, 140);
            recentlyAddedEquipmentGrid.TabIndex = 4;
            // 
            // lblRecentRentalReq
            // 
            lblRecentRentalReq.AutoSize = true;
            lblRecentRentalReq.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentRentalReq.Location = new Point(262, 466);
            lblRecentRentalReq.Name = "lblRecentRentalReq";
            lblRecentRentalReq.Size = new Size(183, 23);
            lblRecentRentalReq.TabIndex = 5;
            lblRecentRentalReq.Text = "Latest Rental Request";
            // 
            // latestRentalRequestGrid
            // 
            latestRentalRequestGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            latestRentalRequestGrid.Location = new Point(262, 491);
            latestRentalRequestGrid.Name = "latestRentalRequestGrid";
            latestRentalRequestGrid.RowHeadersWidth = 51;
            latestRentalRequestGrid.Size = new Size(660, 140);
            latestRentalRequestGrid.TabIndex = 6;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(249, 115, 22);
            label16.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold);
            label16.ForeColor = Color.White;
            label16.Location = new Point(18, 8);
            label16.Name = "label16";
            label16.Size = new Size(93, 23);
            label16.TabIndex = 14;
            label16.Text = "Dashboard";
            // 
            // lblRequest
            // 
            lblRequest.AutoSize = true;
            lblRequest.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRequest.Location = new Point(18, 60);
            lblRequest.Margin = new Padding(18, 10, 9, 12);
            lblRequest.Name = "lblRequest";
            lblRequest.Size = new Size(133, 23);
            lblRequest.TabIndex = 44;
            lblRequest.Text = "Rental Requests";
            lblRequest.Click += lblRequest_Click;
            // 
            // lblTransactions
            // 
            lblTransactions.AutoSize = true;
            lblTransactions.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactions.Location = new Point(18, 105);
            lblTransactions.Margin = new Padding(18, 10, 9, 12);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(158, 23);
            lblTransactions.TabIndex = 45;
            lblTransactions.Text = "Rental Transactions";
            lblTransactions.Click += lblTransactions_Click;
            // 
            // lblEquipmentManagement
            // 
            lblEquipmentManagement.AutoSize = true;
            lblEquipmentManagement.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentManagement.Location = new Point(18, 195);
            lblEquipmentManagement.Margin = new Padding(18, 10, 9, 12);
            lblEquipmentManagement.Name = "lblEquipmentManagement";
            lblEquipmentManagement.Size = new Size(201, 23);
            lblEquipmentManagement.TabIndex = 47;
            lblEquipmentManagement.Text = "Equipment Management";
            lblEquipmentManagement.Click += lblEquipmentManagement_Click;
            // 
            // lblReturnRecords
            // 
            lblReturnRecords.AutoSize = true;
            lblReturnRecords.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReturnRecords.Location = new Point(18, 150);
            lblReturnRecords.Margin = new Padding(18, 10, 9, 12);
            lblReturnRecords.Name = "lblReturnRecords";
            lblReturnRecords.Size = new Size(128, 23);
            lblReturnRecords.TabIndex = 46;
            lblReturnRecords.Text = "Return Records";
            lblReturnRecords.Click += lblReturnRecords_Click;
            // 
            // lblGenerateReport
            // 
            lblGenerateReport.AutoSize = true;
            lblGenerateReport.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenerateReport.Location = new Point(18, 330);
            lblGenerateReport.Margin = new Padding(18, 10, 9, 12);
            lblGenerateReport.Name = "lblGenerateReport";
            lblGenerateReport.Size = new Size(144, 23);
            lblGenerateReport.TabIndex = 56;
            lblGenerateReport.Text = "Generate Reports";
            lblGenerateReport.Click += lblGenerateReport_Click;
            // 
            // lblDBbackup
            // 
            lblDBbackup.AutoSize = true;
            lblDBbackup.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDBbackup.Location = new Point(18, 285);
            lblDBbackup.Margin = new Padding(18, 10, 9, 12);
            lblDBbackup.Name = "lblDBbackup";
            lblDBbackup.Size = new Size(208, 23);
            lblDBbackup.TabIndex = 57;
            lblDBbackup.Text = "Perform Database Backup";
            lblDBbackup.Click += lblDBbackup_Click;
            // 
            // lblViewAuditLogs
            // 
            lblViewAuditLogs.AutoSize = true;
            lblViewAuditLogs.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewAuditLogs.Location = new Point(18, 240);
            lblViewAuditLogs.Margin = new Padding(18, 10, 9, 12);
            lblViewAuditLogs.Name = "lblViewAuditLogs";
            lblViewAuditLogs.Size = new Size(133, 23);
            lblViewAuditLogs.TabIndex = 48;
            lblViewAuditLogs.Text = "View Audit Logs";
            lblViewAuditLogs.Click += lblViewAuditLogs_Click;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.Location = new Point(18, 420);
            lblExit.Margin = new Padding(18, 10, 9, 12);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(38, 23);
            lblExit.TabIndex = 58;
            lblExit.Text = "Exit";
            lblExit.Click += lblExit_Click;
            // 
            // lblLogOut
            // 
            lblLogOut.AutoSize = true;
            lblLogOut.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogOut.Location = new Point(18, 375);
            lblLogOut.Margin = new Padding(18, 10, 9, 12);
            lblLogOut.Name = "lblLogOut";
            lblLogOut.Size = new Size(72, 23);
            lblLogOut.TabIndex = 59;
            lblLogOut.Text = "Log Out";
            lblLogOut.Click += lblLogOut_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 115, 22);
            panel1.Controls.Add(label16);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0, 0, 0, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 40);
            panel1.TabIndex = 63;
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-5, 80);
            lblDivider.Margin = new Padding(2, 0, 2, 0);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(920, 1);
            lblDivider.TabIndex = 62;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(lblRequest);
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
            flowLayoutPanel1.Margin = new Padding(1);
            flowLayoutPanel1.MinimumSize = new Size(233, 441);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(255, 553);
            flowLayoutPanel1.TabIndex = 39;
            flowLayoutPanel1.WrapContents = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(927, 648);
            Controls.Add(lblPosition);
            Controls.Add(lblName);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblDivider);
            Controls.Add(latestRentalRequestGrid);
            Controls.Add(lblRecentRentalReq);
            Controls.Add(recentlyAddedEquipmentGrid);
            Controls.Add(lblRecentEq);
            Controls.Add(pnlInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recentlyAddedEquipmentGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)latestRentalRequestGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private Label lblPosition;
        private Panel pnlInfo;
        private Label lblRecentEq;
        private DataGridView recentlyAddedEquipmentGrid;
        private Label lblRecentRentalReq;
        private DataGridView latestRentalRequestGrid;
        private Label lblOverdue;
        private Label lblActiveRental;
        private Label lblPending;
        private Label lblRentedEq;
        private Label lblTotalEq;
        private Label lblAvailableEq;
        private Label label2;
        private Label label1;
        private Label lbleqTotal;
        private Label lblOverdueRequests;
        private Label lblPendingRequests;
        private Label lblActiveRentals;
        private Label lblrentedEquipment;
        private Label lblavEq;
        private Label label16;
        private Label lblRequest;
        private Label lblTransactions;
        private Label lblEquipmentManagement;
        private Label lblReturnRecords;
        private Label lblGenerateReport;
        private Label lblDBbackup;
        private Label lblViewAuditLogs;
        private Label lblExit;
        private Label lblLogOut;
        private Label lblDivider;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}