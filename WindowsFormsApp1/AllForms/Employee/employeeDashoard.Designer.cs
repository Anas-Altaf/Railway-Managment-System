namespace WindowsFormsApp1.AllForms.Employee
{
    partial class employeeDashoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.mainTitle = new System.Windows.Forms.Label();
            this.tempInfo = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.adminProfileButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.adminCheckProfileBtn = new System.Windows.Forms.Button();
            this.adminManageProfileBtn = new System.Windows.Forms.Button();
            this.adminManageScheduleBtn = new System.Windows.Forms.Button();
            this.adminRevenueBtn = new System.Windows.Forms.Button();
            this.adminViewTrainsBtn = new System.Windows.Forms.Button();
            this.passengerLogoutBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel14.SuspendLayout();
            this.sideBar.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Enabled = true;
            this.sideBarTimer.Interval = 10;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.adminCheckProfileBtn);
            this.panel2.Location = new System.Drawing.Point(3, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 43);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.adminManageProfileBtn);
            this.panel5.Location = new System.Drawing.Point(3, 107);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(208, 43);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.button7);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Controls.Add(this.adminProfileButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(194, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(788, 52);
            this.panel6.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.backButton);
            this.panel7.Controls.Add(this.mainTitle);
            this.panel7.Controls.Add(this.tempInfo);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(679, 52);
            this.panel7.TabIndex = 0;
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mainTitle.Location = new System.Drawing.Point(85, 11);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(244, 32);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "Employee Dashboard";
            // 
            // tempInfo
            // 
            this.tempInfo.BackColor = System.Drawing.Color.Black;
            this.tempInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tempInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempInfo.ForeColor = System.Drawing.Color.White;
            this.tempInfo.Location = new System.Drawing.Point(301, 18);
            this.tempInfo.Multiline = true;
            this.tempInfo.Name = "tempInfo";
            this.tempInfo.ReadOnly = true;
            this.tempInfo.Size = new System.Drawing.Size(378, 21);
            this.tempInfo.TabIndex = 101;
            this.tempInfo.Text = "Login action declined";
            this.tempInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tempInfo.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.adminManageScheduleBtn);
            this.panel4.Location = new System.Drawing.Point(3, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(208, 43);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.adminRevenueBtn);
            this.panel3.Location = new System.Drawing.Point(3, 205);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 37);
            this.panel3.TabIndex = 2;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.adminViewTrainsBtn);
            this.panel14.Location = new System.Drawing.Point(3, 248);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(208, 37);
            this.panel14.TabIndex = 3;
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
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.MaximumSize = new System.Drawing.Size(211, 450);
            this.sideBar.MinimumSize = new System.Drawing.Size(58, 450);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(194, 450);
            this.sideBar.TabIndex = 6;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.passengerLogoutBtn);
            this.panel15.Location = new System.Drawing.Point(3, 291);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(208, 37);
            this.panel15.TabIndex = 3;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Gold;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_back_25;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(6, 9);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(73, 34);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Dock = System.Windows.Forms.DockStyle.Right;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::WindowsFormsApp1.Properties.Resources.icons8_notification_25;
            this.button7.Location = new System.Drawing.Point(679, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(37, 52);
            this.button7.TabIndex = 3;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Image = global::WindowsFormsApp1.Properties.Resources.icons8_message_25;
            this.button6.Location = new System.Drawing.Point(716, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 52);
            this.button6.TabIndex = 2;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // adminProfileButton
            // 
            this.adminProfileButton.BackColor = System.Drawing.Color.Black;
            this.adminProfileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminProfileButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.adminProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminProfileButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_administrator_male_48;
            this.adminProfileButton.Location = new System.Drawing.Point(748, 0);
            this.adminProfileButton.Name = "adminProfileButton";
            this.adminProfileButton.Size = new System.Drawing.Size(40, 52);
            this.adminProfileButton.TabIndex = 1;
            this.adminProfileButton.UseVisualStyleBackColor = false;
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_menu_50;
            this.menuButton.Location = new System.Drawing.Point(9, 15);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(35, 25);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // adminCheckProfileBtn
            // 
            this.adminCheckProfileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminCheckProfileBtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
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
            // 
            // adminManageProfileBtn
            // 
            this.adminManageProfileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminManageProfileBtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.adminManageProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminManageProfileBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminManageProfileBtn.ForeColor = System.Drawing.Color.White;
            this.adminManageProfileBtn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_money_25;
            this.adminManageProfileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminManageProfileBtn.Location = new System.Drawing.Point(-1, -6);
            this.adminManageProfileBtn.Name = "adminManageProfileBtn";
            this.adminManageProfileBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.adminManageProfileBtn.Size = new System.Drawing.Size(189, 55);
            this.adminManageProfileBtn.TabIndex = 2;
            this.adminManageProfileBtn.Text = "          Salary";
            this.adminManageProfileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminManageProfileBtn.UseVisualStyleBackColor = true;
            // 
            // adminManageScheduleBtn
            // 
            this.adminManageScheduleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminManageScheduleBtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.adminManageScheduleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminManageScheduleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminManageScheduleBtn.ForeColor = System.Drawing.Color.White;
            this.adminManageScheduleBtn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_task_25;
            this.adminManageScheduleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminManageScheduleBtn.Location = new System.Drawing.Point(-1, -10);
            this.adminManageScheduleBtn.Name = "adminManageScheduleBtn";
            this.adminManageScheduleBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.adminManageScheduleBtn.Size = new System.Drawing.Size(189, 56);
            this.adminManageScheduleBtn.TabIndex = 3;
            this.adminManageScheduleBtn.Text = "          View Tasks";
            this.adminManageScheduleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminManageScheduleBtn.UseVisualStyleBackColor = true;
            // 
            // adminRevenueBtn
            // 
            this.adminRevenueBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminRevenueBtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.adminRevenueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminRevenueBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRevenueBtn.ForeColor = System.Drawing.Color.White;
            this.adminRevenueBtn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_help_26;
            this.adminRevenueBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminRevenueBtn.Location = new System.Drawing.Point(-1, -15);
            this.adminRevenueBtn.Name = "adminRevenueBtn";
            this.adminRevenueBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.adminRevenueBtn.Size = new System.Drawing.Size(188, 54);
            this.adminRevenueBtn.TabIndex = 4;
            this.adminRevenueBtn.Text = "          Support/Help";
            this.adminRevenueBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminRevenueBtn.UseVisualStyleBackColor = true;
            // 
            // adminViewTrainsBtn
            // 
            this.adminViewTrainsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminViewTrainsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.adminViewTrainsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminViewTrainsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminViewTrainsBtn.ForeColor = System.Drawing.Color.White;
            this.adminViewTrainsBtn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_tickets_25;
            this.adminViewTrainsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminViewTrainsBtn.Location = new System.Drawing.Point(-1, -14);
            this.adminViewTrainsBtn.Name = "adminViewTrainsBtn";
            this.adminViewTrainsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.adminViewTrainsBtn.Size = new System.Drawing.Size(188, 54);
            this.adminViewTrainsBtn.TabIndex = 5;
            this.adminViewTrainsBtn.Text = "          Sell Tickets";
            this.adminViewTrainsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminViewTrainsBtn.UseVisualStyleBackColor = true;
            // 
            // passengerLogoutBtn
            // 
            this.passengerLogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passengerLogoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.passengerLogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passengerLogoutBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerLogoutBtn.ForeColor = System.Drawing.Color.White;
            this.passengerLogoutBtn.Image = global::WindowsFormsApp1.Properties.Resources.icons8_logout_25;
            this.passengerLogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passengerLogoutBtn.Location = new System.Drawing.Point(-1, -14);
            this.passengerLogoutBtn.Name = "passengerLogoutBtn";
            this.passengerLogoutBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.passengerLogoutBtn.Size = new System.Drawing.Size(188, 54);
            this.passengerLogoutBtn.TabIndex = 6;
            this.passengerLogoutBtn.Text = "          Log Out";
            this.passengerLogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passengerLogoutBtn.UseVisualStyleBackColor = true;
            // 
            // employeeDashoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 427);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.sideBar);
            this.Name = "employeeDashoard";
            this.Text = "employeeDashoard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.sideBar.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.Button adminProfileButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button adminCheckProfileBtn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button adminManageProfileBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.TextBox tempInfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button adminManageScheduleBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button adminRevenueBtn;
        private System.Windows.Forms.Button passengerLogoutBtn;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button adminViewTrainsBtn;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel panel15;
    }
}