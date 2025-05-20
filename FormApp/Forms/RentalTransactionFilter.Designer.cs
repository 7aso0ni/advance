namespace FormApp.Forms
{
    partial class RentalTransactionFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalTransactionFilter));
            pictureBox1 = new PictureBox();
            lblReqId = new Label();
            txtReqId = new TextBox();
            label1 = new Label();
            txtFullName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpPickup = new DateTimePicker();
            dtpReturn = new DateTimePicker();
            cmbPayment = new ComboBox();
            txtFee = new TextBox();
            label6 = new Label();
            cmbRentalStatus = new ComboBox();
            btnApplyFilters = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(311, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 91;
            pictureBox1.TabStop = false;
            // 
            // lblReqId
            // 
            lblReqId.AutoSize = true;
            lblReqId.Location = new Point(26, 210);
            lblReqId.Name = "lblReqId";
            lblReqId.Size = new Size(84, 20);
            lblReqId.TabIndex = 92;
            lblReqId.Text = "Request ID:";
            // 
            // txtReqId
            // 
            txtReqId.BackColor = Color.WhiteSmoke;
            txtReqId.Location = new Point(130, 207);
            txtReqId.Margin = new Padding(2);
            txtReqId.Name = "txtReqId";
            txtReqId.Size = new Size(194, 27);
            txtReqId.TabIndex = 93;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 287);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 94;
            label1.Text = "FullName:";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.WhiteSmoke;
            txtFullName.Location = new Point(130, 287);
            txtFullName.Margin = new Padding(2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(194, 27);
            txtFullName.TabIndex = 95;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(412, 210);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 96;
            label2.Text = "Pickup Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 282);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 97;
            label3.Text = "Return Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 364);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 98;
            label4.Text = "Fee:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(412, 367);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 99;
            label5.Text = "Payment Status:";
            // 
            // dtpPickup
            // 
            dtpPickup.CalendarMonthBackground = Color.WhiteSmoke;
            dtpPickup.Location = new Point(543, 205);
            dtpPickup.Margin = new Padding(2);
            dtpPickup.Name = "dtpPickup";
            dtpPickup.Size = new Size(210, 27);
            dtpPickup.TabIndex = 100;
            // 
            // dtpReturn
            // 
            dtpReturn.CalendarMonthBackground = Color.WhiteSmoke;
            dtpReturn.Location = new Point(543, 282);
            dtpReturn.Margin = new Padding(2);
            dtpReturn.Name = "dtpReturn";
            dtpReturn.Size = new Size(210, 27);
            dtpReturn.TabIndex = 101;
            // 
            // cmbPayment
            // 
            cmbPayment.BackColor = Color.WhiteSmoke;
            cmbPayment.FormattingEnabled = true;
            cmbPayment.Location = new Point(543, 364);
            cmbPayment.Margin = new Padding(2);
            cmbPayment.Name = "cmbPayment";
            cmbPayment.Size = new Size(210, 28);
            cmbPayment.TabIndex = 102;
            // 
            // txtFee
            // 
            txtFee.BackColor = Color.WhiteSmoke;
            txtFee.Location = new Point(130, 365);
            txtFee.Margin = new Padding(2);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(194, 27);
            txtFee.TabIndex = 103;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(226, 442);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 105;
            label6.Text = "Rental Status:";
            label6.Click += label6_Click;
            // 
            // cmbRentalStatus
            // 
            cmbRentalStatus.BackColor = Color.WhiteSmoke;
            cmbRentalStatus.FormattingEnabled = true;
            cmbRentalStatus.Location = new Point(346, 442);
            cmbRentalStatus.Margin = new Padding(2);
            cmbRentalStatus.Name = "cmbRentalStatus";
            cmbRentalStatus.Size = new Size(210, 28);
            cmbRentalStatus.TabIndex = 106;
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.BackColor = Color.FromArgb(249, 115, 22);
            btnApplyFilters.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApplyFilters.ForeColor = Color.White;
            btnApplyFilters.Location = new Point(245, 513);
            btnApplyFilters.Margin = new Padding(2);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(285, 35);
            btnApplyFilters.TabIndex = 107;
            btnApplyFilters.Text = "Apply Filters";
            btnApplyFilters.UseVisualStyleBackColor = false;
            btnApplyFilters.Click += btnApplyFilters_Click_1;
            // 
            // RentalTransactionFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(792, 570);
            Controls.Add(btnApplyFilters);
            Controls.Add(cmbRentalStatus);
            Controls.Add(label6);
            Controls.Add(txtFee);
            Controls.Add(cmbPayment);
            Controls.Add(dtpReturn);
            Controls.Add(dtpPickup);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtFullName);
            Controls.Add(label1);
            Controls.Add(txtReqId);
            Controls.Add(lblReqId);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RentalTransactionFilter";
            Text = "RentalTransactionFilter";
            Load += RentalTransactionFilter_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblReqId;
        private TextBox txtReqId;
        private Label label1;
        private TextBox txtFullName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpPickup;
        private DateTimePicker dtpReturn;
        private ComboBox cmbPayment;
        private TextBox txtFee;
        private Label label6;
        private ComboBox cmbRentalStatus;
        private Button btnApplyFilters;
    }
}