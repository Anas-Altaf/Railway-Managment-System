namespace WindowsFormsApp1
{
    partial class AdminDashboard
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
            this.components = new System.ComponentModel.Container();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.adminLogoutBtn = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.adminViewFeedbackBtn = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.adminTasksBtn = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.adminViewTrainsBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminRevenueBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.adminManageScheduleBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.adminManageProfileBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adminCheckProfileBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.centralPanel = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.sideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Enabled = true;
            this.sideBarTimer.Interval = 10;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.backButton);
            this.panel6.Controls.Add(this.button7);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Controls.Add(this.button5);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(194, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(788, 52);
            this.panel6.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Yellow;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(559, 17);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::WindowsFormsApp1.Properties.Resources.icons8_notification_25;
            this.button7.Location = new System.Drawing.Point(646, 14);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(37, 28);
            this.button7.TabIndex = 3;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Image = global::WindowsFormsApp1.Properties.Resources.icons8_message_25;
            this.button6.Location = new System.Drawing.Point(692, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 27);
            this.button6.TabIndex = 2;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::WindowsFormsApp1.Properties.Resources.icons8_administrator_male_48;
            this.button5.Location = new System.Drawing.Point(732, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 40);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(16, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Admin Dashboard";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.adminLogoutBtn);
            this.panel17.Location = new System.Drawing.Point(3, 377);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(208, 37);
            this.panel17.TabIndex = 3;
            // 
            // adminLogoutBtn
            // 
            this.adminLogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminLogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminLogoutBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogoutBtn.ForeColor = System.Drawing.Color.White;
            this.adminLogoutBtn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_logout_25;
            this.adminLogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminLogoutBtn.Location = new System.Drawing.Point(-1, -13);
            this.adminLogoutBtn.Name = "adminLogoutBtn";
            this.adminLogoutBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.adminLogoutBtn.Size = new System.Drawing.Size(188, 54);
            this.adminLogoutBtn.TabIndex = 7;
            this.adminLogoutBtn.Text = "          Log Out";
            this.adminLogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminLogoutBtn.UseVisualStyleBackColor = true;
            this.adminLogoutBtn.Click += new System.EventHandler(this.adminLogoutBtn_Click);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.adminViewFeedbackBtn);
            this.panel16.Location = new System.Drawing.Point(3, 334);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(208, 37);
            this.panel16.TabIndex = 3;
            // 
            // adminViewFeedbackBtn
            // 
            this.adminViewFeedbackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminViewFeedbackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminViewFeedbackBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminViewFeedbackBtn.ForeColor = System.Drawing.Color.White;
            this.adminViewFeedbackBtn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_open_email_25;
            this.adminViewFeedbackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminViewFeedbackBtn.Location = new System.Drawing.Point(-1, -14);
            this.adminViewFeedbackBtn.Name = "adminViewFeedbackBtn";
            this.adminViewFeedbackBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.adminViewFeedbackBtn.Size = new System.Drawing.Size(188, 54);
            this.adminViewFeedbackBtn.TabIndex = 6;
            this.adminViewFeedbackBtn.Text = "          View Feedbacks";
            this.adminViewFeedbackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminViewFeedbackBtn.UseVisualStyleBackColor = true;
            this.adminViewFeedbackBtn.Click += new System.EventHandler(this.adminViewFeedbackBtn_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.adminTasksBtn);
            this.panel15.Location = new System.Drawing.Point(3, 291);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(208, 37);
            this.panel15.TabIndex = 3;
            // 
            // adminTasksBtn
            // 
            this.adminTasksBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminTasksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminTasksBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTasksBtn.ForeColor = System.Drawing.Color.White;
            this.adminTasksBtn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_task_25;
            this.adminTasksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminTasksBtn.Location = new System.Drawing.Point(-1, -14);
            this.adminTasksBtn.Name = "adminTasksBtn";
            this.adminTasksBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.adminTasksBtn.Size = new System.Drawing.Size(188, 54);
            this.adminTasksBtn.TabIndex = 5;
            this.adminTasksBtn.Text = "          Assign Tasks";
            this.adminTasksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminTasksBtn.UseVisualStyleBackColor = true;
            this.adminTasksBtn.Click += new System.EventHandler(this.adminTasksBtn_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.adminViewTrainsBtn);
            this.panel14.Location = new System.Drawing.Point(3, 248);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(208, 37);
            this.panel14.TabIndex = 3;
            // 
            // adminViewTrainsBtn
            // 
            this.adminViewTrainsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminViewTrainsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminViewTrainsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminViewTrainsBtn.ForeColor = System.Drawing.Color.White;
            this.adminViewTrainsBtn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_train_25;
            this.adminViewTrainsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminViewTrainsBtn.Location = new System.Drawing.Point(-1, -14);
            this.adminViewTrainsBtn.Name = "adminViewTrainsBtn";
            this.adminViewTrainsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.adminViewTrainsBtn.Size = new System.Drawing.Size(188, 54);
            this.adminViewTrainsBtn.TabIndex = 4;
            this.adminViewTrainsBtn.Text = "          View Trains";
            this.adminViewTrainsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminViewTrainsBtn.UseVisualStyleBackColor = true;
            this.adminViewTrainsBtn.Click += new System.EventHandler(this.adminViewTrainsBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.adminRevenueBtn);
            this.panel3.Location = new System.Drawing.Point(3, 205);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 37);
            this.panel3.TabIndex = 2;
            // 
            // adminRevenueBtn
            // 
            this.adminRevenueBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminRevenueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminRevenueBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRevenueBtn.ForeColor = System.Drawing.Color.White;
            this.adminRevenueBtn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_pdf_25;
            this.adminRevenueBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminRevenueBtn.Location = new System.Drawing.Point(-1, -15);
            this.adminRevenueBtn.Name = "adminRevenueBtn";
            this.adminRevenueBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.adminRevenueBtn.Size = new System.Drawing.Size(188, 54);
            this.adminRevenueBtn.TabIndex = 3;
            this.adminRevenueBtn.Text = "          Revenue PDF";
            this.adminRevenueBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminRevenueBtn.UseVisualStyleBackColor = true;
            this.adminRevenueBtn.Click += new System.EventHandler(this.adminRevenueBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.adminManageScheduleBtn);
            this.panel4.Location = new System.Drawing.Point(3, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(208, 43);
            this.panel4.TabIndex = 2;
            // 
            // adminManageScheduleBtn
            // 
            this.adminManageScheduleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminManageScheduleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminManageScheduleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminManageScheduleBtn.ForeColor = System.Drawing.Color.White;
            this.adminManageScheduleBtn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_clock_25;
            this.adminManageScheduleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminManageScheduleBtn.Location = new System.Drawing.Point(-1, -10);
            this.adminManageScheduleBtn.Name = "adminManageScheduleBtn";
            this.adminManageScheduleBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.adminManageScheduleBtn.Size = new System.Drawing.Size(189, 56);
            this.adminManageScheduleBtn.TabIndex = 4;
            this.adminManageScheduleBtn.Text = "          Manage Time";
            this.adminManageScheduleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminManageScheduleBtn.UseVisualStyleBackColor = true;
            this.adminManageScheduleBtn.Click += new System.EventHandler(this.adminManageScheduleBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.adminManageProfileBtn);
            this.panel5.Location = new System.Drawing.Point(3, 107);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(208, 43);
            this.panel5.TabIndex = 2;
            // 
            // adminManageProfileBtn
            // 
            this.adminManageProfileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminManageProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminManageProfileBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminManageProfileBtn.ForeColor = System.Drawing.Color.White;
            this.adminManageProfileBtn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_administrator_male_25__1_;
            this.adminManageProfileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminManageProfileBtn.Location = new System.Drawing.Point(-1, -6);
            this.adminManageProfileBtn.Name = "adminManageProfileBtn";
            this.adminManageProfileBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.adminManageProfileBtn.Size = new System.Drawing.Size(189, 55);
            this.adminManageProfileBtn.TabIndex = 0;
            this.adminManageProfileBtn.Text = "          Manage Profiles";
            this.adminManageProfileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminManageProfileBtn.UseVisualStyleBackColor = true;
            this.adminManageProfileBtn.Click += new System.EventHandler(this.adminManageProfileBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.adminCheckProfileBtn);
            this.panel2.Location = new System.Drawing.Point(3, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 43);
            this.panel2.TabIndex = 1;
            // 
            // adminCheckProfileBtn
            // 
            this.adminCheckProfileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminCheckProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminCheckProfileBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminCheckProfileBtn.ForeColor = System.Drawing.Color.White;
            this.adminCheckProfileBtn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_employees_25__1_;
            this.adminCheckProfileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminCheckProfileBtn.Location = new System.Drawing.Point(-1, -2);
            this.adminCheckProfileBtn.Name = "adminCheckProfileBtn";
            this.adminCheckProfileBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.adminCheckProfileBtn.Size = new System.Drawing.Size(188, 55);
            this.adminCheckProfileBtn.TabIndex = 1;
            this.adminCheckProfileBtn.Text = "          Check Profile";
            this.adminCheckProfileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminCheckProfileBtn.UseVisualStyleBackColor = true;
            this.adminCheckProfileBtn.Click += new System.EventHandler(this.adminCheckProfileBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 49);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_menu_50;
            this.menuButton.Location = new System.Drawing.Point(9, 9);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(36, 32);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.Black;
            this.sideBar.Controls.Add(this.panel1);
            this.sideBar.Controls.Add(this.panel2);
            this.sideBar.Controls.Add(this.panel5);
            this.sideBar.Controls.Add(this.panel4);
            this.sideBar.Controls.Add(this.panel3);
            this.sideBar.Controls.Add(this.panel14);
            this.sideBar.Controls.Add(this.panel15);
            this.sideBar.Controls.Add(this.panel16);
            this.sideBar.Controls.Add(this.panel17);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.MaximumSize = new System.Drawing.Size(211, 450);
            this.sideBar.MinimumSize = new System.Drawing.Size(58, 450);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(194, 450);
            this.sideBar.TabIndex = 0;
            // 
            // centralPanel
            // 
            this.centralPanel.BackColor = System.Drawing.Color.Transparent;
            this.centralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centralPanel.Location = new System.Drawing.Point(194, 52);
            this.centralPanel.Name = "centralPanel";
            this.centralPanel.Size = new System.Drawing.Size(788, 397);
            this.centralPanel.TabIndex = 2;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 449);
            this.Controls.Add(this.centralPanel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.sideBar);
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.Activated += new System.EventHandler(this.AdminDashboard_Activated);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button adminLogoutBtn;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button adminViewFeedbackBtn;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button adminTasksBtn;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button adminViewTrainsBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button adminRevenueBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button adminManageScheduleBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button adminManageProfileBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button adminCheckProfileBtn;
        public System.Windows.Forms.Panel centralPanel;
    }
}