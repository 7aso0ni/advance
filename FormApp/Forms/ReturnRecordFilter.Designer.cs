namespace FormApp.Forms
{
    partial class ReturnRecordFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnRecordFilter));
            pictureBox1 = new PictureBox();
            cmbCondition = new ComboBox();
            lblRentalStatus = new Label();
            txtLateFee = new TextBox();
            CostId = new Label();
            dtpReturn = new DateTimePicker();
            lblReturnDate = new Label();
            txtEqName = new TextBox();
            EqId = new Label();
            txtReqId = new TextBox();
            btnApplyFilters = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(279, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 102;
            pictureBox1.TabStop = false;
            // 
            // cmbCondition
            // 
            cmbCondition.BackColor = Color.WhiteSmoke;
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(145, 404);
            cmbCondition.Margin = new Padding(2);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(577, 28);
            cmbCondition.TabIndex = 101;
            // 
            // lblRentalStatus
            // 
            lblRentalStatus.AutoSize = true;
            lblRentalStatus.Location = new Point(63, 407);
            lblRentalStatus.Name = "lblRentalStatus";
            lblRentalStatus.Size = new Size(77, 20);
            lblRentalStatus.TabIndex = 100;
            lblRentalStatus.Text = "Condition:";
            // 
            // txtLateFee
            // 
            txtLateFee.BackColor = Color.WhiteSmoke;
            txtLateFee.Location = new Point(512, 320);
            txtLateFee.Margin = new Padding(2);
            txtLateFee.Name = "txtLateFee";
            txtLateFee.Size = new Size(210, 27);
            txtLateFee.TabIndex = 99;
            // 
            // CostId
            // 
            CostId.AutoSize = true;
            CostId.Location = new Point(400, 329);
            CostId.Name = "CostId";
            CostId.Size = new Size(67, 20);
            CostId.TabIndex = 98;
            CostId.Text = "Late Fee:";
            // 
            // dtpReturn
            // 
            dtpReturn.CalendarMonthBackground = Color.WhiteSmoke;
            dtpReturn.Location = new Point(512, 247);
            dtpReturn.Margin = new Padding(2);
            dtpReturn.Name = "dtpReturn";
            dtpReturn.Size = new Size(210, 27);
            dtpReturn.TabIndex = 97;
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Location = new Point(393, 249);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(91, 20);
            lblReturnDate.TabIndex = 95;
            lblReturnDate.Text = "Return Date:";
            // 
            // txtEqName
            // 
            txtEqName.BackColor = Color.WhiteSmoke;
            txtEqName.Location = new Point(145, 329);
            txtEqName.Margin = new Padding(2);
            txtEqName.Name = "txtEqName";
            txtEqName.Size = new Size(194, 27);
            txtEqName.TabIndex = 93;
            // 
            // EqId
            // 
            EqId.AutoSize = true;
            EqId.Location = new Point(38, 252);
            EqId.Name = "EqId";
            EqId.Size = new Size(76, 20);
            EqId.TabIndex = 92;
            EqId.Text = "Record Id:";
            // 
            // txtReqId
            // 
            txtReqId.BackColor = Color.WhiteSmoke;
            txtReqId.Location = new Point(145, 249);
            txtReqId.Margin = new Padding(2);
            txtReqId.Name = "txtReqId";
            txtReqId.Size = new Size(194, 27);
            txtReqId.TabIndex = 91;
            txtReqId.TextChanged += txtReqId_TextChanged;
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.BackColor = Color.FromArgb(249, 115, 22);
            btnApplyFilters.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApplyFilters.ForeColor = Color.White;
            btnApplyFilters.Location = new Point(245, 484);
            btnApplyFilters.Margin = new Padding(2);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(285, 35);
            btnApplyFilters.TabIndex = 103;
            btnApplyFilters.Text = "Apply Filters";
            btnApplyFilters.UseVisualStyleBackColor = false;
            btnApplyFilters.Click += btnApplyFilters_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 336);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 104;
            label1.Text = "Equipment Name:";
            // 
            // ReturnRecordFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(792, 570);
            Controls.Add(label1);
            Controls.Add(btnApplyFilters);
            Controls.Add(pictureBox1);
            Controls.Add(cmbCondition);
            Controls.Add(lblRentalStatus);
            Controls.Add(txtLateFee);
            Controls.Add(CostId);
            Controls.Add(dtpReturn);
            Controls.Add(lblReturnDate);
            Controls.Add(txtEqName);
            Controls.Add(EqId);
            Controls.Add(txtReqId);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReturnRecordFilter";
            Text = "ReturnRecordFilter";
            Load += ReturnRecordFilter_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox cmbCondition;
        private Label lblRentalStatus;
        private TextBox txtLateFee;
        private Label CostId;
        private DateTimePicker dtpReturn;
        private Label lblReturnDate;
        private TextBox txtEqName;
        private Label EqId;
        private TextBox txtReqId;
        private Button btnApplyFilters;
        private Label label1;
    }
}