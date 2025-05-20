namespace FormApp.Forms
{
    partial class AddEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEquipment));
            lblUserName = new Label();
            lblPosition = new Label();
            btnBack = new Button();
            lblAddEquipment = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            cmbCategory = new ComboBox();
            cmbAvailability = new ComboBox();
            cmbCondition = new ComboBox();
            btnAdd = new Button();
            lblDivider = new Label();
            pictureBoxPreview = new PictureBox();
            btnBrowse = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            SuspendLayout();
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
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(249, 115, 22);
            btnBack.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(9, 96);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(123, 35);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblAddEquipment
            // 
            lblAddEquipment.AutoSize = true;
            lblAddEquipment.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAddEquipment.Location = new Point(348, 153);
            lblAddEquipment.Name = "lblAddEquipment";
            lblAddEquipment.Size = new Size(239, 41);
            lblAddEquipment.TabIndex = 2;
            lblAddEquipment.Text = "Add Equipment";
            // 
            // txtName
            // 
            txtName.BackColor = Color.WhiteSmoke;
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(283, 226);
            txtName.Name = "txtName";
            txtName.Size = new Size(162, 27);
            txtName.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.WhiteSmoke;
            txtDescription.ForeColor = Color.Black;
            txtDescription.Location = new Point(283, 277);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(166, 27);
            txtDescription.TabIndex = 5;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.WhiteSmoke;
            txtPrice.ForeColor = Color.Black;
            txtPrice.Location = new Point(283, 338);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(166, 27);
            txtPrice.TabIndex = 6;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.WhiteSmoke;
            cmbCategory.ForeColor = Color.Black;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(518, 225);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(162, 28);
            cmbCategory.TabIndex = 7;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // cmbAvailability
            // 
            cmbAvailability.BackColor = Color.WhiteSmoke;
            cmbAvailability.DisplayMember = "Status";
            cmbAvailability.ForeColor = Color.Black;
            cmbAvailability.FormattingEnabled = true;
            cmbAvailability.Location = new Point(518, 276);
            cmbAvailability.Name = "cmbAvailability";
            cmbAvailability.Size = new Size(162, 28);
            cmbAvailability.TabIndex = 8;
            // 
            // cmbCondition
            // 
            cmbCondition.BackColor = Color.WhiteSmoke;
            cmbCondition.ForeColor = Color.Black;
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(518, 338);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(162, 28);
            cmbCondition.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(249, 115, 22);
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(408, 570);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 35);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(236, 236, 236);
            lblDivider.Location = new Point(-5, 80);
            lblDivider.Margin = new Padding(2, 0, 2, 0);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(920, 1);
            lblDivider.TabIndex = 63;
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.Location = new Point(294, 384);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(150, 150);
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPreview.TabIndex = 64;
            pictureBoxPreview.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(249, 115, 22);
            btnBrowse.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(524, 427);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(156, 35);
            btnBrowse.TabIndex = 65;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // AddEquipment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(927, 648);
            Controls.Add(btnBrowse);
            Controls.Add(pictureBoxPreview);
            Controls.Add(lblPosition);
            Controls.Add(lblUserName);
            Controls.Add(lblDivider);
            Controls.Add(btnAdd);
            Controls.Add(cmbCondition);
            Controls.Add(cmbAvailability);
            Controls.Add(cmbCategory);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(lblAddEquipment);
            Controls.Add(btnBack);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddEquipment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEquipment";
            Load += AddEquipment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUserName;
        private Label lblPosition;
        private Button btnBack;
        private Label lblAddEquipment;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private ComboBox cmbCategory;
        private ComboBox cmbAvailability;
        private ComboBox cmbCondition;
        private Button btnAdd;
        private Label lblDivider;
        private PictureBox pictureBoxPreview;
        private Button btnBrowse;
    }
}