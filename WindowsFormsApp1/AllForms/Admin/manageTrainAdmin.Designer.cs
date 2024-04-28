namespace WindowsFormsApp1.AllForms.Admin
{
    partial class manageTrainAdmin
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
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.trainEndTimeBox = new System.Windows.Forms.TextBox();
            this.trainStartTimeBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.traintypeBox = new System.Windows.Forms.TextBox();
            this.trainImageBox = new System.Windows.Forms.PictureBox();
            this.trainArrivalBox = new System.Windows.Forms.TextBox();
            this.trainNamebox = new System.Windows.Forms.TextBox();
            this.trainDestinationBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.trainAnnoucementBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.manageTrainAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.trainIdBox = new System.Windows.Forms.TextBox();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageTrainAdminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Orange;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(272, 160);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(60, 23);
            this.button15.TabIndex = 34;
            this.button15.Text = "Update";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Orange;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(366, 160);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(60, 23);
            this.button14.TabIndex = 33;
            this.button14.Text = "Delete";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Orange;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(459, 160);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(60, 23);
            this.button13.TabIndex = 32;
            this.button13.Text = "Clear";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Orange;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(181, 160);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(60, 23);
            this.button12.TabIndex = 31;
            this.button12.Text = "Add";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Controls.Add(this.trainIdBox);
            this.panel13.Controls.Add(this.label2);
            this.panel13.Controls.Add(this.label9);
            this.panel13.Controls.Add(this.label10);
            this.panel13.Controls.Add(this.trainAnnoucementBox);
            this.panel13.Controls.Add(this.trainEndTimeBox);
            this.panel13.Controls.Add(this.trainStartTimeBox);
            this.panel13.Controls.Add(this.label12);
            this.panel13.Controls.Add(this.label8);
            this.panel13.Controls.Add(this.label7);
            this.panel13.Controls.Add(this.label6);
            this.panel13.Controls.Add(this.traintypeBox);
            this.panel13.Controls.Add(this.trainImageBox);
            this.panel13.Controls.Add(this.trainArrivalBox);
            this.panel13.Controls.Add(this.trainNamebox);
            this.panel13.Controls.Add(this.trainDestinationBox);
            this.panel13.Controls.Add(this.label5);
            this.panel13.Controls.Add(this.button15);
            this.panel13.Controls.Add(this.button14);
            this.panel13.Controls.Add(this.button13);
            this.panel13.Controls.Add(this.button12);
            this.panel13.Controls.Add(this.label3);
            this.panel13.Location = new System.Drawing.Point(26, 155);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(720, 191);
            this.panel13.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Train\'s Data:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 105);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(295, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 21);
            this.label9.TabIndex = 61;
            this.label9.Text = "Arrival Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(293, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 21);
            this.label10.TabIndex = 60;
            this.label10.Text = "Announcements:";
            // 
            // trainEndTimeBox
            // 
            this.trainEndTimeBox.Location = new System.Drawing.Point(415, 39);
            this.trainEndTimeBox.Name = "trainEndTimeBox";
            this.trainEndTimeBox.Size = new System.Drawing.Size(158, 20);
            this.trainEndTimeBox.TabIndex = 58;
            // 
            // trainStartTimeBox
            // 
            this.trainStartTimeBox.Location = new System.Drawing.Point(415, 72);
            this.trainStartTimeBox.Name = "trainStartTimeBox";
            this.trainStartTimeBox.Size = new System.Drawing.Size(158, 20);
            this.trainStartTimeBox.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(295, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 21);
            this.label12.TabIndex = 56;
            this.label12.Text = "Dest. Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 21);
            this.label8.TabIndex = 55;
            this.label8.Text = "Destination:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 21);
            this.label7.TabIndex = 54;
            this.label7.Text = "Arrival:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 53;
            this.label6.Text = "Type:";
            // 
            // traintypeBox
            // 
            this.traintypeBox.Location = new System.Drawing.Point(112, 134);
            this.traintypeBox.Name = "traintypeBox";
            this.traintypeBox.Size = new System.Drawing.Size(158, 20);
            this.traintypeBox.TabIndex = 51;
            // 
            // trainImageBox
            // 
            this.trainImageBox.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_train_64;
            this.trainImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trainImageBox.Location = new System.Drawing.Point(593, 33);
            this.trainImageBox.Name = "trainImageBox";
            this.trainImageBox.Size = new System.Drawing.Size(114, 101);
            this.trainImageBox.TabIndex = 52;
            this.trainImageBox.TabStop = false;
            // 
            // trainArrivalBox
            // 
            this.trainArrivalBox.Location = new System.Drawing.Point(112, 108);
            this.trainArrivalBox.Name = "trainArrivalBox";
            this.trainArrivalBox.Size = new System.Drawing.Size(158, 20);
            this.trainArrivalBox.TabIndex = 50;
            // 
            // trainNamebox
            // 
            this.trainNamebox.Location = new System.Drawing.Point(112, 56);
            this.trainNamebox.Name = "trainNamebox";
            this.trainNamebox.Size = new System.Drawing.Size(158, 20);
            this.trainNamebox.TabIndex = 49;
            // 
            // trainDestinationBox
            // 
            this.trainDestinationBox.Location = new System.Drawing.Point(112, 82);
            this.trainDestinationBox.Name = "trainDestinationBox";
            this.trainDestinationBox.Size = new System.Drawing.Size(158, 20);
            this.trainDestinationBox.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "Train Name:";
            // 
            // trainAnnoucementBox
            // 
            this.trainAnnoucementBox.Location = new System.Drawing.Point(297, 119);
            this.trainAnnoucementBox.Multiline = true;
            this.trainAnnoucementBox.Name = "trainAnnoucementBox";
            this.trainAnnoucementBox.Size = new System.Drawing.Size(276, 35);
            this.trainAnnoucementBox.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 30);
            this.label1.TabIndex = 62;
            this.label1.Text = "Trains Data";
            // 
            // manageTrainAdminBindingSource
            // 
            this.manageTrainAdminBindingSource.DataSource = typeof(WindowsFormsApp1.AllForms.Admin.manageTrainAdmin);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 62;
            this.label2.Text = "Train ID:";
            // 
            // trainIdBox
            // 
            this.trainIdBox.Location = new System.Drawing.Point(112, 30);
            this.trainIdBox.Name = "trainIdBox";
            this.trainIdBox.Size = new System.Drawing.Size(158, 20);
            this.trainIdBox.TabIndex = 63;
            // 
            // manageTrainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "manageTrainAdmin";
            this.Text = "manageTrainAdmin";
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageTrainAdminBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox trainAnnoucementBox;
        private System.Windows.Forms.TextBox trainEndTimeBox;
        private System.Windows.Forms.TextBox trainStartTimeBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox traintypeBox;
        private System.Windows.Forms.PictureBox trainImageBox;
        private System.Windows.Forms.TextBox trainArrivalBox;
        private System.Windows.Forms.TextBox trainNamebox;
        private System.Windows.Forms.TextBox trainDestinationBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource manageTrainAdminBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox trainIdBox;
    }
}