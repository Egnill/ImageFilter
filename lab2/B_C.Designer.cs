namespace lab2
{
    partial class B_C
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
            this.Bright = new System.Windows.Forms.Label();
            this.Contrast = new System.Windows.Forms.Label();
            this.Scroll_Brightness = new System.Windows.Forms.TrackBar();
            this.Scroll_Contrast = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Scroll_Brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scroll_Contrast)).BeginInit();
            this.SuspendLayout();
            // 
            // Bright
            // 
            this.Bright.AutoSize = true;
            this.Bright.Location = new System.Drawing.Point(12, 9);
            this.Bright.Name = "Bright";
            this.Bright.Size = new System.Drawing.Size(56, 13);
            this.Bright.TabIndex = 0;
            this.Bright.Text = "Brightness";
            // 
            // Contrast
            // 
            this.Contrast.AutoSize = true;
            this.Contrast.Location = new System.Drawing.Point(12, 89);
            this.Contrast.Name = "Contrast";
            this.Contrast.Size = new System.Drawing.Size(46, 13);
            this.Contrast.TabIndex = 1;
            this.Contrast.Text = "Contrast";
            // 
            // Scroll_Brightness
            // 
            this.Scroll_Brightness.Location = new System.Drawing.Point(5, 25);
            this.Scroll_Brightness.Maximum = 150;
            this.Scroll_Brightness.Minimum = -150;
            this.Scroll_Brightness.Name = "Scroll_Brightness";
            this.Scroll_Brightness.Size = new System.Drawing.Size(298, 45);
            this.Scroll_Brightness.TabIndex = 2;
            this.Scroll_Brightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Scroll_Brightness.Scroll += new System.EventHandler(this.Scroll_Brightness_Scroll);
            // 
            // Scroll_Contrast
            // 
            this.Scroll_Contrast.BackColor = System.Drawing.SystemColors.Control;
            this.Scroll_Contrast.Location = new System.Drawing.Point(5, 105);
            this.Scroll_Contrast.Maximum = 100;
            this.Scroll_Contrast.Name = "Scroll_Contrast";
            this.Scroll_Contrast.Size = new System.Drawing.Size(298, 45);
            this.Scroll_Contrast.TabIndex = 3;
            this.Scroll_Contrast.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Scroll_Contrast.Scroll += new System.EventHandler(this.Scroll_Contrast_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "-150";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "150";
            // 
            // B_C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 162);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Scroll_Contrast);
            this.Controls.Add(this.Scroll_Brightness);
            this.Controls.Add(this.Contrast);
            this.Controls.Add(this.Bright);
            this.Name = "B_C";
            this.Text = "Brightness/Contrast";
            ((System.ComponentModel.ISupportInitialize)(this.Scroll_Brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scroll_Contrast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bright;
        private System.Windows.Forms.Label Contrast;
        private System.Windows.Forms.TrackBar Scroll_Brightness;
        private System.Windows.Forms.TrackBar Scroll_Contrast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}