namespace FormApp.Forms
{
    partial class UpdateRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateRecord));
            btnSave = new Button();
            dtpReturnDate = new DateTimePicker();
            cmbCondition = new ComboBox();
            txtRecordID = new TextBox();
            lblAddEquipment = new Label();
            btnBack = new Button();
            lblUserName = new Label();
            lblPosition = new Label();
            txtLateFees = new TextBox();
            txtEquipmentID = new TextBox();
            lblDivider = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(249, 115, 22);
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(389, 500);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 35);
            btnSave.TabIndex = 30;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(254, 430);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(401, 27);
            dtpReturnDate.TabIndex = 29;
            // 
            // cmbCondition
            // 
            cmbCondition.ForeColor = Color.Black;
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(254, 352);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(162, 28);
            cmbCondition.TabIndex = 28;
            // 
            // txtRecordID
            // 
            txtRecordID.ForeColor = Color.Black;
            txtRecordID.Location = new Point(254, 280);
            txtRecordID.Name = "txtRecordID";
            txtRecordID.ReadOnly = true;
            txtRecordID.Size = new Size(162, 27);
            txtRecordID.TabIndex = 26;
            // 
            // lblAddEquipment
            // 
            lblAddEquipment.AutoSize = true;
            lblAddEquipment.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAddEquipment.Location = new Point(343, 169);
            lblAddEquipment.Name = "lblAddEquipment";
            lblAddEquipment.Size = new Size(228, 41);
            lblAddEquipment.TabIndex = 25;
            lblAddEquipment.Text = "Update Record";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(249, 115, 22);
            btnBack.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(9, 96);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(113, 35);
            btnBack.TabIndex = 24;
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
            // txtLateFees
            // 
            txtLateFees.ForeColor = Color.Black;
            txtLateFees.Location = new Point(493, 352);
            txtLateFees.Name = "txtLateFees";
            txtLateFees.Size = new Size(162, 27);
            txtLateFees.TabIndex = 31;
            // 
            // txtEquipmentID
            // 
            txtEquipmentID.ForeColor = Color.Black;
            txtEquipmentID.Location = new Point(493, 280);
            txtEquipmentID.Name = "txtEquipmentID";
            txtEquipmentID.ReadOnly = true;
            txtEquipmentID.Size = new Size(162, 27);
            txtEquipmentID.TabIndex = 32;
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-5, 80);
            lblDivider.Margin = new Padding(2, 0, 2, 0);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(920, 1);
            lblDivider.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 257);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 76;
            label1.Text = "Record ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(493, 257);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 77;
            label2.Text = "Equipment ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 329);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 78;
            label3.Text = "Condition:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(493, 329);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 79;
            label4.Text = "Late Fee:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(254, 407);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 80;
            label5.Text = "Return Date:";
            // 
            // UpdateRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(927, 648);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblUserName);
            Controls.Add(lblDivider);
            Controls.Add(lblPosition);
            Controls.Add(txtEquipmentID);
            Controls.Add(txtLateFees);
            Controls.Add(btnSave);
            Controls.Add(dtpReturnDate);
            Controls.Add(cmbCondition);
            Controls.Add(txtRecordID);
            Controls.Add(lblAddEquipment);
            Controls.Add(btnBack);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UpdateRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateRecord";
            Load += UpdateRecord_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private DateTimePicker dtpReturnDate;
        private ComboBox cmbCondition;
        private TextBox txtRecordID;
        private Label lblAddEquipment;
        private Button btnBack;
        private Label lblUserName;
        private Label lblPosition;
        private TextBox txtLateFees;
        private TextBox txtEquipmentID;
        private Label lblDivider;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}