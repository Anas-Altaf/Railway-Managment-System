namespace WindowsFormsApp1.AllForms.Admin
{
    partial class adminProfile
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
            this.label10 = new System.Windows.Forms.Label();
            this.adminAbout = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.adminName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adminEmail = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 21);
            this.label10.TabIndex = 43;
            this.label10.Text = "About:";
            // 
            // adminAbout
            // 
            this.adminAbout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAbout.Location = new System.Drawing.Point(155, 214);
            this.adminAbout.Multiline = true;
            this.adminAbout.Name = "adminAbout";
            this.adminAbout.ReadOnly = true;
            this.adminAbout.Size = new System.Drawing.Size(305, 90);
            this.adminAbout.TabIndex = 42;
            this.adminAbout.Text = "I am a responsible admin of this railway manament system, Hope will continue serv" +
    "ing till my death.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(59, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 38;
            this.label8.Text = "Email:";
            // 
            // adminName
            // 
            this.adminName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminName.Location = new System.Drawing.Point(155, 104);
            this.adminName.Multiline = true;
            this.adminName.Name = "adminName";
            this.adminName.ReadOnly = true;
            this.adminName.Size = new System.Drawing.Size(305, 31);
            this.adminName.TabIndex = 31;
            this.adminName.Text = "Mr Admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Administrator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 37);
            this.label3.TabIndex = 26;
            this.label3.Text = "My Profile";
            // 
            // adminEmail
            // 
            this.adminEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminEmail.Location = new System.Drawing.Point(155, 153);
            this.adminEmail.Multiline = true;
            this.adminEmail.Name = "adminEmail";
            this.adminEmail.ReadOnly = true;
            this.adminEmail.Size = new System.Drawing.Size(305, 31);
            this.adminEmail.TabIndex = 44;
            this.adminEmail.Text = "admin@rmsdb.com";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Gold;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_back_25;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(589, 278);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(86, 43);
            this.backButton.TabIndex = 45;
            this.backButton.Text = "Logout";
            this.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.icons8_admin_100;
            this.pictureBox2.Location = new System.Drawing.Point(551, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 173);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // adminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 397);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.adminEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.adminAbout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.adminName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminProfile";
            this.Text = "adminCheckProfile";
            this.Load += new System.EventHandler(this.adminProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox adminAbout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox adminName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adminEmail;
        private System.Windows.Forms.Button backButton;
    }
}