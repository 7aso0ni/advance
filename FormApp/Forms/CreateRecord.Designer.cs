namespace FormApp.Forms
{
    partial class CreateRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRecord));
            cmbCondition = new ComboBox();
            txtLateFees = new TextBox();
            txtEquipmentId = new TextBox();
            lblAddEquipment = new Label();
            btnBack = new Button();
            lblUserName = new Label();
            lblPosition = new Label();
            dtpReturnDate = new DateTimePicker();
            btnCreate = new Button();
            lblDivider = new Label();
            SuspendLayout();
            // 
            // cmbCondition
            // 
            cmbCondition.ForeColor = Color.Black;
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(489, 236);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(162, 28);
            cmbCondition.TabIndex = 17;
            // 
            // txtLateFees
            // 
            txtLateFees.ForeColor = Color.Black;
            txtLateFees.Location = new Point(285, 373);
            txtLateFees.Name = "txtLateFees";
            txtLateFees.Size = new Size(366, 27);
            txtLateFees.TabIndex = 16;
            // 
            // txtEquipmentId
            // 
            txtEquipmentId.ForeColor = Color.Black;
            txtEquipmentId.Location = new Point(285, 236);
            txtEquipmentId.Name = "txtEquipmentId";
            txtEquipmentId.Size = new Size(162, 27);
            txtEquipmentId.TabIndex = 14;
            // 
            // lblAddEquipment
            // 
            lblAddEquipment.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAddEquipment.Location = new Point(353, 151);
            lblAddEquipment.Name = "lblAddEquipment";
            lblAddEquipment.Size = new Size(239, 41);
            lblAddEquipment.TabIndex = 13;
            lblAddEquipment.Text = "Create Record";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(249, 115, 22);
            btnBack.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(9, 96);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(113, 35);
            btnBack.TabIndex = 12;
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
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(283, 306);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(368, 27);
            dtpReturnDate.TabIndex = 21;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(249, 115, 22);
            btnCreate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(412, 438);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(113, 35);
            btnCreate.TabIndex = 22;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click_1;
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-5, 80);
            lblDivider.Margin = new Padding(2, 0, 2, 0);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(920, 1);
            lblDivider.TabIndex = 64;
            // 
            // CreateRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(927, 648);
            Controls.Add(lblUserName);
            Controls.Add(lblDivider);
            Controls.Add(lblPosition);
            Controls.Add(btnCreate);
            Controls.Add(dtpReturnDate);
            Controls.Add(cmbCondition);
            Controls.Add(txtLateFees);
            Controls.Add(txtEquipmentId);
            Controls.Add(lblAddEquipment);
            Controls.Add(btnBack);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateRecord";
            Load += CreateRecord_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private ComboBox cmbCondition;
        private ComboBox cmbAvailability;
        private ComboBox cmbCategory;
        private TextBox txtLateFees;
        private TextBox txtDescription;
        private TextBox txtEquipmentId;
        private Label lblAddEquipment;
        private Button btnBack;
        private Label lblUserName;
        private Label lblPosition;
        private DateTimePicker dtpReturnDate;
        private Button btnCreate;
        private Label lblDivider;
    }
}