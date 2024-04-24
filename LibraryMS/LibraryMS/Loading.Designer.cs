namespace LibraryMS
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.Loading2 = new System.Windows.Forms.PictureBox();
            this.Loading1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lg = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Loading2)).BeginInit();
            this.SuspendLayout();
            // 
            // Loading2
            // 
            this.Loading2.Image = ((System.Drawing.Image)(resources.GetObject("Loading2.Image")));
            this.Loading2.Location = new System.Drawing.Point(-1, -2);
            this.Loading2.Name = "Loading2";
            this.Loading2.Size = new System.Drawing.Size(616, 224);
            this.Loading2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Loading2.TabIndex = 0;
            this.Loading2.TabStop = false;
            // 
            // Loading1
            // 
            this.Loading1.Location = new System.Drawing.Point(-1, 224);
            this.Loading1.Name = "Loading1";
            this.Loading1.Size = new System.Drawing.Size(616, 10);
            this.Loading1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 18;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lg
            // 
            this.lg.BackColor = System.Drawing.SystemColors.GrayText;
            this.lg.Location = new System.Drawing.Point(-1, 224);
            this.lg.Name = "lg";
            this.lg.Size = new System.Drawing.Size(70, 10);
            this.lg.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(418, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Design by Chathura Dilshan";
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 234);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lg);
            this.Controls.Add(this.Loading1);
            this.Controls.Add(this.Loading2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            ((System.ComponentModel.ISupportInitialize)(this.Loading2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Loading2;
        private System.Windows.Forms.Panel Loading1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel lg;
        private System.Windows.Forms.Label label1;
    }
}