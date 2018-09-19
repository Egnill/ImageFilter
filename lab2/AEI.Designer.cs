namespace lab2
{
    partial class AEI
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
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.Open = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.Exception = new System.Windows.Forms.Button();
            this.Interseption = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(13, 55);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(500, 500);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(12, 12);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(106, 37);
            this.Open.TabIndex = 3;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(182, 12);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(106, 37);
            this.Addition.TabIndex = 4;
            this.Addition.Text = "Addition";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // Exception
            // 
            this.Exception.Location = new System.Drawing.Point(295, 12);
            this.Exception.Name = "Exception";
            this.Exception.Size = new System.Drawing.Size(106, 37);
            this.Exception.TabIndex = 5;
            this.Exception.Text = "Exception";
            this.Exception.UseVisualStyleBackColor = true;
            this.Exception.Click += new System.EventHandler(this.Exception_Click);
            // 
            // Interseption
            // 
            this.Interseption.Location = new System.Drawing.Point(407, 12);
            this.Interseption.Name = "Interseption";
            this.Interseption.Size = new System.Drawing.Size(106, 37);
            this.Interseption.TabIndex = 6;
            this.Interseption.Text = "Interseption";
            this.Interseption.UseVisualStyleBackColor = true;
            this.Interseption.Click += new System.EventHandler(this.Interseption_Click);
            // 
            // AEI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 566);
            this.Controls.Add(this.Interseption);
            this.Controls.Add(this.Exception);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.imageBox1);
            this.Name = "AEI";
            this.Text = "AEI";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Exception;
        private System.Windows.Forms.Button Interseption;
    }
}