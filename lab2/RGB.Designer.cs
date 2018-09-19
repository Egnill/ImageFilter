namespace lab2
{
    partial class RGB
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
            this.R = new System.Windows.Forms.Button();
            this.G = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(12, 12);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(59, 53);
            this.R.TabIndex = 0;
            this.R.Text = "R";
            this.R.UseVisualStyleBackColor = true;
            this.R.Click += new System.EventHandler(this.R_Click);
            // 
            // G
            // 
            this.G.Location = new System.Drawing.Point(77, 12);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(59, 53);
            this.G.TabIndex = 1;
            this.G.Text = "G";
            this.G.UseVisualStyleBackColor = true;
            this.G.Click += new System.EventHandler(this.G_Click);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(142, 12);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(59, 53);
            this.B.TabIndex = 2;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // RGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 77);
            this.Controls.Add(this.B);
            this.Controls.Add(this.G);
            this.Controls.Add(this.R);
            this.Name = "RGB";
            this.Text = "RGB";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button R;
        private System.Windows.Forms.Button G;
        private System.Windows.Forms.Button B;
    }
}