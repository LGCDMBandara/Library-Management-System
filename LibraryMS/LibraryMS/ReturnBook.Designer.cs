namespace LibraryMS
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Refresh = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BName = new System.Windows.Forms.TextBox();
            this.RDate = new System.Windows.Forms.DateTimePicker();
            this.Return = new System.Windows.Forms.Button();
            this.IDate = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.Refresh);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 176);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(11, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1141, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(599, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(334, 2);
            this.panel4.TabIndex = 5;
            // 
            // Refresh
            // 
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.ForeColor = System.Drawing.Color.Black;
            this.Refresh.Location = new System.Drawing.Point(946, 73);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(185, 31);
            this.Refresh.TabIndex = 7;
            this.Refresh.Text = "Search Student";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.White;
            this.Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Search.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(599, 78);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(334, 18);
            this.Search.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID Number";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(130, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(215, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(887, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Data
            // 
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Location = new System.Drawing.Point(6, 183);
            this.Data.Name = "Data";
            this.Data.RowTemplate.Height = 24;
            this.Data.Size = new System.Drawing.Size(1163, 301);
            this.Data.TabIndex = 2;
            this.Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Book Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Book Issued Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Book Return Date";
            // 
            // BName
            // 
            this.BName.BackColor = System.Drawing.Color.White;
            this.BName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BName.Location = new System.Drawing.Point(267, 21);
            this.BName.Name = "BName";
            this.BName.Size = new System.Drawing.Size(512, 27);
            this.BName.TabIndex = 6;
            // 
            // RDate
            // 
            this.RDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.RDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDate.Location = new System.Drawing.Point(267, 159);
            this.RDate.Name = "RDate";
            this.RDate.Size = new System.Drawing.Size(512, 27);
            this.RDate.TabIndex = 8;
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.White;
            this.Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Location = new System.Drawing.Point(887, 46);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(187, 49);
            this.Return.TabIndex = 9;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // IDate
            // 
            this.IDate.BackColor = System.Drawing.Color.White;
            this.IDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDate.Location = new System.Drawing.Point(267, 92);
            this.IDate.Name = "IDate";
            this.IDate.Size = new System.Drawing.Size(512, 27);
            this.IDate.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Return);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.IDate);
            this.panel2.Controls.Add(this.RDate);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.BName);
            this.panel2.Location = new System.Drawing.Point(0, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1176, 220);
            this.panel2.TabIndex = 12;
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 709);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBook";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BName;
        private System.Windows.Forms.DateTimePicker RDate;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.TextBox IDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}