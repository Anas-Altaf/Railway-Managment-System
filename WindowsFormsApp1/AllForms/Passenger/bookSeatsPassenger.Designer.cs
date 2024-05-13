namespace WindowsFormsApp1.AllForms.Passenger
{
    partial class bookSeatsPassenger
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.originBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.destBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.trainBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cancelBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.bookBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ticketBox = new System.Windows.Forms.TextBox();
            this.ticket_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.train_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Tickets";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticket_id,
            this.train_id,
            this.origin,
            this.destination});
            this.dataGridView1.Location = new System.Drawing.Point(31, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(733, 117);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Your Ticket";
            // 
            // originBox
            // 
            this.originBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.originBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originBox.Location = new System.Drawing.Point(123, 52);
            this.originBox.Name = "originBox";
            this.originBox.Size = new System.Drawing.Size(187, 20);
            this.originBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Origin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(455, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Destination";
            // 
            // destBox
            // 
            this.destBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.destBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.destBox.Location = new System.Drawing.Point(577, 52);
            this.destBox.Name = "destBox";
            this.destBox.Size = new System.Drawing.Size(187, 20);
            this.destBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter Train ID:";
            // 
            // trainBox
            // 
            this.trainBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trainBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trainBox.Location = new System.Drawing.Point(181, 255);
            this.trainBox.Multiline = true;
            this.trainBox.Name = "trainBox";
            this.trainBox.Size = new System.Drawing.Size(199, 27);
            this.trainBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Enter Ticket ID to cancel a Ticket:";
            // 
            // cancelBox
            // 
            this.cancelBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cancelBox.Location = new System.Drawing.Point(333, 349);
            this.cancelBox.Multiline = true;
            this.cancelBox.Name = "cancelBox";
            this.cancelBox.Size = new System.Drawing.Size(247, 27);
            this.cancelBox.TabIndex = 9;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(689, 200);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 11;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // bookBtn
            // 
            this.bookBtn.Location = new System.Drawing.Point(689, 289);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(75, 23);
            this.bookBtn.TabIndex = 12;
            this.bookBtn.Text = "Book";
            this.bookBtn.UseVisualStyleBackColor = true;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(689, 353);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(307, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cancel Your Ticket";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(397, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "Enter Ticket ID:";
            // 
            // ticketBox
            // 
            this.ticketBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ticketBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticketBox.Location = new System.Drawing.Point(539, 255);
            this.ticketBox.Multiline = true;
            this.ticketBox.Name = "ticketBox";
            this.ticketBox.Size = new System.Drawing.Size(199, 27);
            this.ticketBox.TabIndex = 15;
            // 
            // ticket_id
            // 
            this.ticket_id.HeaderText = "TICKET ID";
            this.ticket_id.Name = "ticket_id";
            this.ticket_id.ReadOnly = true;
            // 
            // train_id
            // 
            this.train_id.HeaderText = "TRAIN ID";
            this.train_id.Name = "train_id";
            this.train_id.ReadOnly = true;
            // 
            // origin
            // 
            this.origin.HeaderText = "ORIGIN";
            this.origin.Name = "origin";
            this.origin.ReadOnly = true;
            // 
            // destination
            // 
            this.destination.HeaderText = "DESTINATION";
            this.destination.Name = "destination";
            this.destination.ReadOnly = true;
            // 
            // bookSeatsPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 397);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ticketBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.bookBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancelBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trainBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.destBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.originBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bookSeatsPassenger";
            this.Text = "bookSeatsPassenger";
            this.Load += new System.EventHandler(this.bookSeatsPassenger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox originBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox destBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox trainBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cancelBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ticketBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticket_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn train_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
    }
}