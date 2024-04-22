namespace WindowsFormsApp1
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.customPictureBox3 = new WindowsFormsApp1.Static_Resources.CustomPictureBox();
            this.customPictureBox2 = new WindowsFormsApp1.Static_Resources.CustomPictureBox();
            this.customPictureBox1 = new WindowsFormsApp1.Static_Resources.CustomPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.customPictureBox3);
            this.panel1.Controls.Add(this.customPictureBox2);
            this.panel1.Controls.Add(this.customPictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(166, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 364);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(148, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select Category";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(406, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "Railway Managment System";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 47);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome to";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(184, 285);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 35);
            this.button2.TabIndex = 0;
            this.button2.Text = "Admin";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(338, 285);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 35);
            this.button3.TabIndex = 15;
            this.button3.Text = "Employee";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(26, 285);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Passenger";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // customPictureBox3
            // 
            this.customPictureBox3.BackColor = System.Drawing.Color.White;
            this.customPictureBox3.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.customPictureBox3.BorderColor = System.Drawing.Color.RoyalBlue;
            this.customPictureBox3.BorderColor2 = System.Drawing.Color.Crimson;
            this.customPictureBox3.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.customPictureBox3.BorderSize = 3;
            this.customPictureBox3.GradientAngle = 50F;
            this.customPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("customPictureBox3.Image")));
            this.customPictureBox3.Location = new System.Drawing.Point(354, 213);
            this.customPictureBox3.Name = "customPictureBox3";
            this.customPictureBox3.Size = new System.Drawing.Size(69, 69);
            this.customPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customPictureBox3.TabIndex = 14;
            this.customPictureBox3.TabStop = false;
            // 
            // customPictureBox2
            // 
            this.customPictureBox2.BackColor = System.Drawing.Color.White;
            this.customPictureBox2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.customPictureBox2.BorderColor = System.Drawing.Color.RoyalBlue;
            this.customPictureBox2.BorderColor2 = System.Drawing.Color.Crimson;
            this.customPictureBox2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.customPictureBox2.BorderSize = 3;
            this.customPictureBox2.GradientAngle = 50F;
            this.customPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("customPictureBox2.Image")));
            this.customPictureBox2.Location = new System.Drawing.Point(201, 213);
            this.customPictureBox2.Name = "customPictureBox2";
            this.customPictureBox2.Size = new System.Drawing.Size(69, 69);
            this.customPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customPictureBox2.TabIndex = 13;
            this.customPictureBox2.TabStop = false;
            // 
            // customPictureBox1
            // 
            this.customPictureBox1.BackColor = System.Drawing.Color.White;
            this.customPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.customPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.customPictureBox1.BorderColor2 = System.Drawing.Color.Crimson;
            this.customPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.customPictureBox1.BorderSize = 3;
            this.customPictureBox1.GradientAngle = 50F;
            this.customPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("customPictureBox1.Image")));
            this.customPictureBox1.Location = new System.Drawing.Point(48, 213);
            this.customPictureBox1.Name = "customPictureBox1";
            this.customPictureBox1.Size = new System.Drawing.Size(69, 69);
            this.customPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customPictureBox1.TabIndex = 12;
            this.customPictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.high_speed_train_at_station_and_blurred_cityscape_at_night_on_background_postproducted_generative_ai_digital_illustration_of_non_existing_train_model_free_photo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Dashboard";
            this.Text = "Railway Managment System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Static_Resources.CustomPictureBox customPictureBox1;
        private Static_Resources.CustomPictureBox customPictureBox2;
        private Static_Resources.CustomPictureBox customPictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

