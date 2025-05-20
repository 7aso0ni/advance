namespace FormApp.Forms
{
    partial class CreateTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTransaction));
            lblDivider = new Label();
            lblRole = new Label();
            lblName = new Label();
            btnBack = new Button();
            lblCreateTransaction = new Label();
            txtUserID = new TextBox();
            cmbRentalStatus = new ComboBox();
            txtFee = new TextBox();
            cmbPaymentStatus = new ComboBox();
            txtDeposit = new TextBox();
            btnCreate = new Button();
            lblUserID = new Label();
            lblRentalStatus = new Label();
            lblPickupDate = new Label();
            lblReturnDate = new Label();
            lblFee = new Label();
            lblDeposit = new Label();
            lblPaymentStatus = new Label();
            dtpPickupDate = new DateTimePicker();
            dtpReturnDate = new DateTimePicker();
            SuspendLayout();
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-8, 128);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(1495, 2);
            lblDivider.TabIndex = 22;
            // 
            // lblRole
            // 
            lblRole.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(142, 142, 147);
            lblRole.Location = new Point(16, 96);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(250, 32);
            lblRole.TabIndex = 21;
            lblRole.Text = "Role";
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblName.Location = new Point(6, 14);
            lblName.Name = "lblName";
            lblName.Size = new Size(353, 66);
            lblName.TabIndex = 20;
            lblName.Text = "Name";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(249, 115, 22);
            btnBack.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(15, 154);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(184, 56);
            btnBack.TabIndex = 35;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblCreateTransaction
            // 
            lblCreateTransaction.AutoSize = true;
            lblCreateTransaction.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCreateTransaction.Location = new Point(535, 222);
            lblCreateTransaction.Name = "lblCreateTransaction";
            lblCreateTransaction.Size = new Size(446, 65);
            lblCreateTransaction.TabIndex = 36;
            lblCreateTransaction.Text = "Create Transaction";
            // 
            // txtUserID
            // 
            txtUserID.BackColor = Color.WhiteSmoke;
            txtUserID.Location = new Point(452, 363);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(261, 39);
            txtUserID.TabIndex = 37;
            // 
            // cmbRentalStatus
            // 
            cmbRentalStatus.BackColor = Color.WhiteSmoke;
            cmbRentalStatus.FormattingEnabled = true;
            cmbRentalStatus.Location = new Point(784, 363);
            cmbRentalStatus.Name = "cmbRentalStatus";
            cmbRentalStatus.Size = new Size(261, 40);
            cmbRentalStatus.TabIndex = 39;
            // 
            // txtFee
            // 
            txtFee.BackColor = Color.WhiteSmoke;
            txtFee.Location = new Point(452, 640);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(261, 39);
            txtFee.TabIndex = 43;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.BackColor = Color.WhiteSmoke;
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Location = new Point(452, 738);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(592, 40);
            cmbPaymentStatus.TabIndex = 45;
            // 
            // txtDeposit
            // 
            txtDeposit.BackColor = Color.WhiteSmoke;
            txtDeposit.Location = new Point(784, 640);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(261, 39);
            txtDeposit.TabIndex = 44;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(249, 115, 22);
            btnCreate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(657, 822);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(184, 56);
            btnCreate.TabIndex = 46;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(452, 326);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(96, 32);
            lblUserID.TabIndex = 47;
            lblUserID.Text = "User ID:";
            // 
            // lblRentalStatus
            // 
            lblRentalStatus.AutoSize = true;
            lblRentalStatus.Location = new Point(784, 326);
            lblRentalStatus.Name = "lblRentalStatus";
            lblRentalStatus.Size = new Size(156, 32);
            lblRentalStatus.TabIndex = 48;
            lblRentalStatus.Text = "Rental Status:";
            // 
            // lblPickupDate
            // 
            lblPickupDate.AutoSize = true;
            lblPickupDate.Location = new Point(452, 419);
            lblPickupDate.Name = "lblPickupDate";
            lblPickupDate.Size = new Size(146, 32);
            lblPickupDate.TabIndex = 49;
            lblPickupDate.Text = "Pickup Date:";
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Location = new Point(452, 510);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(146, 32);
            lblReturnDate.TabIndex = 50;
            lblReturnDate.Text = "Return Date:";
            // 
            // lblFee
            // 
            lblFee.AutoSize = true;
            lblFee.Location = new Point(452, 604);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(57, 32);
            lblFee.TabIndex = 51;
            lblFee.Text = "Fee:";
            // 
            // lblDeposit
            // 
            lblDeposit.AutoSize = true;
            lblDeposit.Location = new Point(784, 604);
            lblDeposit.Name = "lblDeposit";
            lblDeposit.Size = new Size(101, 32);
            lblDeposit.TabIndex = 52;
            lblDeposit.Text = "Deposit:";
            // 
            // lblPaymentStatus
            // 
            lblPaymentStatus.AutoSize = true;
            lblPaymentStatus.Location = new Point(452, 702);
            lblPaymentStatus.Name = "lblPaymentStatus";
            lblPaymentStatus.Size = new Size(182, 32);
            lblPaymentStatus.TabIndex = 53;
            lblPaymentStatus.Text = "Payment Status:";
            // 
            // dtpPickupDate
            // 
            dtpPickupDate.Location = new Point(452, 454);
            dtpPickupDate.Name = "dtpPickupDate";
            dtpPickupDate.Size = new Size(592, 39);
            dtpPickupDate.TabIndex = 54;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(452, 545);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(592, 39);
            dtpReturnDate.TabIndex = 55;
            // 
            // CreateTransaction
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1506, 1037);
            Controls.Add(dtpReturnDate);
            Controls.Add(dtpPickupDate);
            Controls.Add(lblPaymentStatus);
            Controls.Add(lblDeposit);
            Controls.Add(lblFee);
            Controls.Add(lblReturnDate);
            Controls.Add(lblPickupDate);
            Controls.Add(lblRentalStatus);
            Controls.Add(lblUserID);
            Controls.Add(btnCreate);
            Controls.Add(cmbPaymentStatus);
            Controls.Add(txtDeposit);
            Controls.Add(txtFee);
            Controls.Add(cmbRentalStatus);
            Controls.Add(txtUserID);
            Controls.Add(lblCreateTransaction);
            Controls.Add(btnBack);
            Controls.Add(lblDivider);
            Controls.Add(lblRole);
            Controls.Add(lblName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateTransaction";
            Text = "Create Transaction";
            Load += CreateTransaction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDivider;
        private Label lblRole;
        private Label lblName;
        private Button btnBack;
        private Label lblCreateTransaction;
        private TextBox txtUserID;
        private ComboBox cmbRentalStatus;
        private TextBox txtFee;
        private ComboBox cmbPaymentStatus;
        private TextBox txtDeposit;
        private Button btnCreate;
        private Label lblUserID;
        private Label lblRentalStatus;
        private Label lblPickupDate;
        private Label lblReturnDate;
        private Label lblFee;
        private Label lblDeposit;
        private Label lblPaymentStatus;
        private DateTimePicker dtpPickupDate;
        private DateTimePicker dtpReturnDate;
    }
}