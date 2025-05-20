namespace FormApp.Forms
{
    partial class RentalRequestFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalRequestFilter));
            lblReqId = new Label();
            txtReqId = new TextBox();
            EqId = new Label();
            txtEquipmentId = new TextBox();
            lblStartDate = new Label();
            lblReturnDate = new Label();
            dtpStart = new DateTimePicker();
            dtpReturn = new DateTimePicker();
            CostId = new Label();
            txtCost = new TextBox();
            lblRentalStatus = new Label();
            cmbStatus = new ComboBox();
            pictureBox1 = new PictureBox();
            btnApplyFilters = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblReqId
            // 
            lblReqId.AutoSize = true;
            lblReqId.Location = new Point(26, 249);
            lblReqId.Name = "lblReqId";
            lblReqId.Size = new Size(84, 20);
            lblReqId.TabIndex = 77;
            lblReqId.Text = "Request ID:";
            // 
            // txtReqId
            // 
            txtReqId.BackColor = Color.WhiteSmoke;
            txtReqId.Location = new Point(144, 249);
            txtReqId.Margin = new Padding(2);
            txtReqId.Name = "txtReqId";
            txtReqId.Size = new Size(194, 27);
            txtReqId.TabIndex = 79;
            // 
            // EqId
            // 
            EqId.AutoSize = true;
            EqId.Location = new Point(26, 329);
            EqId.Name = "EqId";
            EqId.Size = new Size(103, 20);
            EqId.TabIndex = 80;
            EqId.Text = "Equipment ID:";
            EqId.Click += EqId_Click;
            // 
            // txtEquipmentId
            // 
            txtEquipmentId.BackColor = Color.WhiteSmoke;
            txtEquipmentId.Location = new Point(144, 329);
            txtEquipmentId.Margin = new Padding(2);
            txtEquipmentId.Name = "txtEquipmentId";
            txtEquipmentId.Size = new Size(194, 27);
            txtEquipmentId.TabIndex = 81;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(405, 249);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(79, 20);
            lblStartDate.TabIndex = 82;
            lblStartDate.Text = "Start Date:";
            lblStartDate.Click += label2_Click;
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Location = new Point(405, 329);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(91, 20);
            lblReturnDate.TabIndex = 83;
            lblReturnDate.Text = "Return Date:";
            // 
            // dtpStart
            // 
            dtpStart.CalendarMonthBackground = Color.WhiteSmoke;
            dtpStart.Location = new Point(527, 247);
            dtpStart.Margin = new Padding(2);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(210, 27);
            dtpStart.TabIndex = 84;
            // 
            // dtpReturn
            // 
            dtpReturn.CalendarMonthBackground = Color.WhiteSmoke;
            dtpReturn.Location = new Point(527, 327);
            dtpReturn.Margin = new Padding(2);
            dtpReturn.Name = "dtpReturn";
            dtpReturn.Size = new Size(210, 27);
            dtpReturn.TabIndex = 85;
            // 
            // CostId
            // 
            CostId.AutoSize = true;
            CostId.Location = new Point(88, 411);
            CostId.Name = "CostId";
            CostId.Size = new Size(41, 20);
            CostId.TabIndex = 86;
            CostId.Text = "Cost:";
            // 
            // txtCost
            // 
            txtCost.BackColor = Color.WhiteSmoke;
            txtCost.Location = new Point(144, 411);
            txtCost.Margin = new Padding(2);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(194, 27);
            txtCost.TabIndex = 87;
            // 
            // lblRentalStatus
            // 
            lblRentalStatus.AutoSize = true;
            lblRentalStatus.Location = new Point(405, 418);
            lblRentalStatus.Name = "lblRentalStatus";
            lblRentalStatus.Size = new Size(94, 20);
            lblRentalStatus.TabIndex = 88;
            lblRentalStatus.Text = "RentalStatus:";
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.WhiteSmoke;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(527, 415);
            cmbStatus.Margin = new Padding(2);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(210, 28);
            cmbStatus.TabIndex = 89;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(294, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 90;
            pictureBox1.TabStop = false;
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.BackColor = Color.FromArgb(249, 115, 22);
            btnApplyFilters.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApplyFilters.ForeColor = Color.White;
            btnApplyFilters.Location = new Point(248, 488);
            btnApplyFilters.Margin = new Padding(2);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(285, 35);
            btnApplyFilters.TabIndex = 91;
            btnApplyFilters.Text = "Apply Filters";
            btnApplyFilters.UseVisualStyleBackColor = false;
            btnApplyFilters.Click += btnApplyFilters_Click;
            // 
            // RentalRequestFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(792, 570);
            Controls.Add(btnApplyFilters);
            Controls.Add(pictureBox1);
            Controls.Add(cmbStatus);
            Controls.Add(lblRentalStatus);
            Controls.Add(txtCost);
            Controls.Add(CostId);
            Controls.Add(dtpReturn);
            Controls.Add(dtpStart);
            Controls.Add(lblReturnDate);
            Controls.Add(lblStartDate);
            Controls.Add(txtEquipmentId);
            Controls.Add(EqId);
            Controls.Add(txtReqId);
            Controls.Add(lblReqId);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RentalRequestFilter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RentalRequestFilter";
            Load += RentalRequestFilter_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReqId;
        private TextBox txtReqId;
        private Label EqId;
        private TextBox txtEquipmentId;
        private Label lblStartDate;
        private Label lblReturnDate;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpReturn;
        private Label CostId;
        private TextBox txtCost;
        private Label lblRentalStatus;
        private ComboBox cmbStatus;
        private PictureBox pictureBox1;
        private Button btnApplyFilters;
    }
}