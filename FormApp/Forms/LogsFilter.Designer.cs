namespace FormApp.Forms
{
    partial class LogsFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogsFilter));
            pictureBox1 = new PictureBox();
            txtLogId = new TextBox();
            txtUserId = new TextBox();
            btnApplyFilters = new Button();
            cmbAction = new ComboBox();
            lblLogId = new Label();
            lblUserID = new Label();
            lblDate = new Label();
            lblAction = new Label();
            dtpDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(285, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtLogId
            // 
            txtLogId.BackColor = Color.WhiteSmoke;
            txtLogId.Location = new Point(159, 278);
            txtLogId.Margin = new Padding(2);
            txtLogId.Name = "txtLogId";
            txtLogId.Size = new Size(194, 27);
            txtLogId.TabIndex = 2;
            // 
            // txtUserId
            // 
            txtUserId.BackColor = Color.WhiteSmoke;
            txtUserId.Location = new Point(554, 275);
            txtUserId.Margin = new Padding(2);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(194, 27);
            txtUserId.TabIndex = 3;
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.BackColor = Color.FromArgb(249, 115, 22);
            btnApplyFilters.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApplyFilters.ForeColor = Color.White;
            btnApplyFilters.Location = new Point(247, 491);
            btnApplyFilters.Margin = new Padding(2);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(285, 35);
            btnApplyFilters.TabIndex = 6;
            btnApplyFilters.Text = "Apply Filters";
            btnApplyFilters.UseVisualStyleBackColor = false;
            btnApplyFilters.Click += btnApplyFilters_Click;
            // 
            // cmbAction
            // 
            cmbAction.BackColor = Color.WhiteSmoke;
            cmbAction.FormattingEnabled = true;
            cmbAction.Location = new Point(159, 394);
            cmbAction.Margin = new Padding(2);
            cmbAction.Name = "cmbAction";
            cmbAction.Size = new Size(194, 28);
            cmbAction.TabIndex = 7;
            // 
            // lblLogId
            // 
            lblLogId.AutoSize = true;
            lblLogId.Location = new Point(59, 278);
            lblLogId.Name = "lblLogId";
            lblLogId.Size = new Size(56, 20);
            lblLogId.TabIndex = 76;
            lblLogId.Text = "Log ID:";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(450, 278);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(60, 20);
            lblUserID.TabIndex = 77;
            lblUserID.Text = "User ID:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(450, 397);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(44, 20);
            lblDate.TabIndex = 79;
            lblDate.Text = "Date:";
            // 
            // lblAction
            // 
            lblAction.AutoSize = true;
            lblAction.Location = new Point(60, 400);
            lblAction.Name = "lblAction";
            lblAction.Size = new Size(55, 20);
            lblAction.TabIndex = 78;
            lblAction.Text = "Action:";
            // 
            // dtpDate
            // 
            dtpDate.CalendarMonthBackground = Color.WhiteSmoke;
            dtpDate.Location = new Point(554, 395);
            dtpDate.Margin = new Padding(2);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(194, 27);
            dtpDate.TabIndex = 80;
            // 
            // LogsFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(792, 570);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(lblAction);
            Controls.Add(lblUserID);
            Controls.Add(lblLogId);
            Controls.Add(cmbAction);
            Controls.Add(btnApplyFilters);
            Controls.Add(txtUserId);
            Controls.Add(txtLogId);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "LogsFilter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filter";
            Load += LogsFilter_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox txtLogId;
        private TextBox txtUserId;
        private Button btnApplyFilters;
        private ComboBox cmbAction;
        private Label lblLogId;
        private Label lblUserID;
        private Label lblDate;
        private Label lblAction;
        private DateTimePicker dtpDate;
    }
}