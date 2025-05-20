namespace FormApp.Forms
{
    partial class UpdateRentalRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateRentalRequest));
            lblDivider = new Label();
            btnSave = new Button();
            txtReqId = new TextBox();
            lblUpdateRentalRequest = new Label();
            btnBack = new Button();
            lblUserName = new Label();
            lblPosition = new Label();
            txtEqName = new TextBox();
            dptStartDate = new DateTimePicker();
            dptReturnDate = new DateTimePicker();
            txtCost = new TextBox();
            lblRentalStatus = new Label();
            cmbRentalStatus = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            lblStartDate = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-5, 80);
            lblDivider.Margin = new Padding(2, 0, 2, 0);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(920, 1);
            lblDivider.TabIndex = 74;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(249, 115, 22);
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(370, 517);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 35);
            btnSave.TabIndex = 73;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtReqId
            // 
            txtReqId.BackColor = Color.WhiteSmoke;
            txtReqId.ForeColor = Color.Black;
            txtReqId.Location = new Point(254, 280);
            txtReqId.Name = "txtReqId";
            txtReqId.ReadOnly = true;
            txtReqId.Size = new Size(162, 27);
            txtReqId.TabIndex = 67;
            // 
            // lblUpdateRentalRequest
            // 
            lblUpdateRentalRequest.AutoSize = true;
            lblUpdateRentalRequest.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdateRentalRequest.Location = new Point(283, 174);
            lblUpdateRentalRequest.Name = "lblUpdateRentalRequest";
            lblUpdateRentalRequest.Size = new Size(341, 41);
            lblUpdateRentalRequest.TabIndex = 66;
            lblUpdateRentalRequest.Text = "Update Rental Request";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(249, 115, 22);
            btnBack.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(9, 96);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(123, 35);
            btnBack.TabIndex = 65;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblUserName
            // 
            lblUserName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblUserName.Location = new Point(4, 9);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(217, 41);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Admin";
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
            // txtEqName
            // 
            txtEqName.BackColor = Color.WhiteSmoke;
            txtEqName.ForeColor = Color.Black;
            txtEqName.Location = new Point(493, 280);
            txtEqName.Name = "txtEqName";
            txtEqName.ReadOnly = true;
            txtEqName.Size = new Size(162, 27);
            txtEqName.TabIndex = 77;
            txtEqName.TextChanged += txtEqName_TextChanged;
            // 
            // dptStartDate
            // 
            dptStartDate.Enabled = false;
            dptStartDate.Format = DateTimePickerFormat.Short;
            dptStartDate.Location = new Point(254, 352);
            dptStartDate.Name = "dptStartDate";
            dptStartDate.Size = new Size(162, 27);
            dptStartDate.TabIndex = 79;
            // 
            // dptReturnDate
            // 
            dptReturnDate.Enabled = false;
            dptReturnDate.Format = DateTimePickerFormat.Short;
            dptReturnDate.Location = new Point(493, 352);
            dptReturnDate.Name = "dptReturnDate";
            dptReturnDate.Size = new Size(162, 27);
            dptReturnDate.TabIndex = 81;
            // 
            // txtCost
            // 
            txtCost.BackColor = Color.WhiteSmoke;
            txtCost.ForeColor = Color.Black;
            txtCost.Location = new Point(254, 435);
            txtCost.Name = "txtCost";
            txtCost.ReadOnly = true;
            txtCost.Size = new Size(162, 27);
            txtCost.TabIndex = 83;
            // 
            // lblRentalStatus
            // 
            lblRentalStatus.AutoSize = true;
            lblRentalStatus.Location = new Point(493, 412);
            lblRentalStatus.Name = "lblRentalStatus";
            lblRentalStatus.Size = new Size(98, 20);
            lblRentalStatus.TabIndex = 84;
            lblRentalStatus.Text = "Rental Status:";
            // 
            // cmbRentalStatus
            // 
            cmbRentalStatus.FormattingEnabled = true;
            cmbRentalStatus.Location = new Point(493, 435);
            cmbRentalStatus.Name = "cmbRentalStatus";
            cmbRentalStatus.Size = new Size(162, 28);
            cmbRentalStatus.TabIndex = 85;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(493, 329);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 80;
            label3.Text = "Return Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(493, 257);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 76;
            label2.Text = "Equipment Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(254, 412);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 82;
            label4.Text = "Cost:";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(254, 329);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(79, 20);
            lblStartDate.TabIndex = 78;
            lblStartDate.Text = "Start Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 257);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 75;
            label1.Text = "Request ID:";
            // 
            // UpdateRentalRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(927, 648);
            Controls.Add(lblUserName);
            Controls.Add(cmbRentalStatus);
            Controls.Add(lblPosition);
            Controls.Add(lblRentalStatus);
            Controls.Add(txtCost);
            Controls.Add(label4);
            Controls.Add(dptReturnDate);
            Controls.Add(label3);
            Controls.Add(dptStartDate);
            Controls.Add(lblStartDate);
            Controls.Add(txtEqName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDivider);
            Controls.Add(btnSave);
            Controls.Add(txtReqId);
            Controls.Add(lblUpdateRentalRequest);
            Controls.Add(btnBack);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UpdateRentalRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateRentalRequest";
            Load += UpdateRentalRequest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDivider;
        private Button btnSave;
        private TextBox txtReqId;
        private Label lblUpdateRentalRequest;
        private Button btnBack;
        private Label lblUserName;
        private Label lblPosition;
        private TextBox txtEqName;
        private DateTimePicker dptStartDate;
        private DateTimePicker dptReturnDate;
        private TextBox txtCost;
        private Label lblRentalStatus;
        private ComboBox cmbRentalStatus;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label lblStartDate;
        private Label label1;
    }
}