namespace FormApp.Forms
{
    partial class EditEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEquipment));
            btnSaveChanges = new Button();
            cmbCondition = new ComboBox();
            cmbAvailability = new ComboBox();
            cmbCategory = new ComboBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            txtName = new TextBox();
            lblAddEquipment = new Label();
            btnBack = new Button();
            lblUserName = new Label();
            lblPosition = new Label();
            txtEquipmentID = new TextBox();
            lblDivider = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            picEquipment = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)picEquipment).BeginInit();
            SuspendLayout();
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(249, 115, 22);
            btnSaveChanges.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.Location = new Point(301, 573);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(154, 35);
            btnSaveChanges.TabIndex = 20;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // cmbCondition
            // 
            cmbCondition.ForeColor = Color.Black;
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(441, 488);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(176, 28);
            cmbCondition.TabIndex = 19;
            // 
            // cmbAvailability
            // 
            cmbAvailability.ForeColor = Color.Black;
            cmbAvailability.FormattingEnabled = true;
            cmbAvailability.Location = new Point(155, 488);
            cmbAvailability.Name = "cmbAvailability";
            cmbAvailability.Size = new Size(176, 28);
            cmbAvailability.TabIndex = 18;
            // 
            // cmbCategory
            // 
            cmbCategory.ForeColor = Color.Black;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(155, 402);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(176, 28);
            cmbCategory.TabIndex = 17;
            // 
            // txtPrice
            // 
            txtPrice.ForeColor = Color.Black;
            txtPrice.Location = new Point(441, 407);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(176, 27);
            txtPrice.TabIndex = 16;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.ForeColor = Color.Black;
            txtDescription.Location = new Point(155, 330);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(454, 27);
            txtDescription.TabIndex = 15;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // txtName
            // 
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(433, 254);
            txtName.Name = "txtName";
            txtName.Size = new Size(176, 27);
            txtName.TabIndex = 14;
            // 
            // lblAddEquipment
            // 
            lblAddEquipment.AutoSize = true;
            lblAddEquipment.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAddEquipment.Location = new Point(328, 138);
            lblAddEquipment.Name = "lblAddEquipment";
            lblAddEquipment.Size = new Size(236, 41);
            lblAddEquipment.TabIndex = 13;
            lblAddEquipment.Text = "Edit Equipment";
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
            // txtEquipmentID
            // 
            txtEquipmentID.Location = new Point(152, 254);
            txtEquipmentID.Name = "txtEquipmentID";
            txtEquipmentID.ReadOnly = true;
            txtEquipmentID.Size = new Size(176, 27);
            txtEquipmentID.TabIndex = 21;
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-5, 80);
            lblDivider.Margin = new Padding(2, 0, 2, 0);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(920, 1);
            lblDivider.TabIndex = 66;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 220);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 76;
            label1.Text = "Equipment ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(433, 220);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 77;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 298);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 78;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 379);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 79;
            label4.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(441, 379);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 80;
            label5.Text = "Price:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(433, 462);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 81;
            label6.Text = "Condition:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(155, 454);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 82;
            label7.Text = "Avaibility:";
            // 
            // picEquipment
            // 
            picEquipment.BorderStyle = BorderStyle.FixedSingle;
            picEquipment.Location = new Point(709, 249);
            picEquipment.Name = "picEquipment";
            picEquipment.Size = new Size(150, 150);
            picEquipment.SizeMode = PictureBoxSizeMode.Zoom;
            picEquipment.TabIndex = 83;
            picEquipment.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(249, 115, 22);
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(709, 439);
            button1.Name = "button1";
            button1.Size = new Size(154, 35);
            button1.TabIndex = 84;
            button1.Text = "Browse Image";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EditEquipment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(927, 648);
            Controls.Add(button1);
            Controls.Add(picEquipment);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPosition);
            Controls.Add(lblUserName);
            Controls.Add(lblDivider);
            Controls.Add(txtEquipmentID);
            Controls.Add(btnSaveChanges);
            Controls.Add(cmbCondition);
            Controls.Add(cmbAvailability);
            Controls.Add(cmbCategory);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(lblAddEquipment);
            Controls.Add(btnBack);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditEquipment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditEquipment";
            Load += EditEquipment_Load;
            ((System.ComponentModel.ISupportInitialize)picEquipment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveChanges;
        private ComboBox cmbCondition;
        private ComboBox cmbAvailability;
        private ComboBox cmbCategory;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private TextBox txtName;
        private Label lblAddEquipment;
        private Button btnBack;
        private Label lblUserName;
        private Label lblPosition;
        private TextBox txtEquipmentID;
        private Label lblDivider;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox picEquipment;
        private Button button1;
    }
}