namespace lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chanleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessContrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pEIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watercolorFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.imageBox1.Location = new System.Drawing.Point(12, 27);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(500, 500);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.imageBox2.Location = new System.Drawing.Point(518, 27);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(500, 500);
            this.imageBox2.TabIndex = 3;
            this.imageBox2.TabStop = false;
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chanleToolStripMenuItem,
            this.blackWhiteToolStripMenuItem,
            this.sepiToolStripMenuItem,
            this.brightnessContrastToolStripMenuItem,
            this.pEIToolStripMenuItem,
            this.hSVToolStripMenuItem,
            this.medianBlurToolStripMenuItem,
            this.windowFilterToolStripMenuItem,
            this.watercolorFilterToolStripMenuItem,
            this.cartoToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // chanleToolStripMenuItem
            // 
            this.chanleToolStripMenuItem.Name = "chanleToolStripMenuItem";
            this.chanleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chanleToolStripMenuItem.Text = "Channle";
            this.chanleToolStripMenuItem.Click += new System.EventHandler(this.chanleToolStripMenuItem_Click);
            // 
            // blackWhiteToolStripMenuItem
            // 
            this.blackWhiteToolStripMenuItem.Name = "blackWhiteToolStripMenuItem";
            this.blackWhiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blackWhiteToolStripMenuItem.Text = "Black-White";
            this.blackWhiteToolStripMenuItem.Click += new System.EventHandler(this.blackWhiteToolStripMenuItem_Click);
            // 
            // sepiToolStripMenuItem
            // 
            this.sepiToolStripMenuItem.Name = "sepiToolStripMenuItem";
            this.sepiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sepiToolStripMenuItem.Text = "Sepia";
            this.sepiToolStripMenuItem.Click += new System.EventHandler(this.sepiToolStripMenuItem_Click);
            // 
            // brightnessContrastToolStripMenuItem
            // 
            this.brightnessContrastToolStripMenuItem.Name = "brightnessContrastToolStripMenuItem";
            this.brightnessContrastToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.brightnessContrastToolStripMenuItem.Text = "Brightness/Contrast";
            this.brightnessContrastToolStripMenuItem.Click += new System.EventHandler(this.brightnessContrastToolStripMenuItem_Click);
            // 
            // pEIToolStripMenuItem
            // 
            this.pEIToolStripMenuItem.Name = "pEIToolStripMenuItem";
            this.pEIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pEIToolStripMenuItem.Text = "AEI";
            this.pEIToolStripMenuItem.Click += new System.EventHandler(this.pEIToolStripMenuItem_Click);
            // 
            // hSVToolStripMenuItem
            // 
            this.hSVToolStripMenuItem.Name = "hSVToolStripMenuItem";
            this.hSVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hSVToolStripMenuItem.Text = "HSV";
            this.hSVToolStripMenuItem.Click += new System.EventHandler(this.hSVToolStripMenuItem_Click);
            // 
            // medianBlurToolStripMenuItem
            // 
            this.medianBlurToolStripMenuItem.Name = "medianBlurToolStripMenuItem";
            this.medianBlurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medianBlurToolStripMenuItem.Text = "Median Blur";
            // 
            // windowFilterToolStripMenuItem
            // 
            this.windowFilterToolStripMenuItem.Name = "windowFilterToolStripMenuItem";
            this.windowFilterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.windowFilterToolStripMenuItem.Text = "Window Filter";
            // 
            // watercolorFilterToolStripMenuItem
            // 
            this.watercolorFilterToolStripMenuItem.Name = "watercolorFilterToolStripMenuItem";
            this.watercolorFilterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.watercolorFilterToolStripMenuItem.Text = "Watercolor Filter";
            // 
            // cartoToolStripMenuItem
            // 
            this.cartoToolStripMenuItem.Name = "cartoToolStripMenuItem";
            this.cartoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cartoToolStripMenuItem.Text = "Cartoon Filter";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "Filter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 534);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Filters";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chanleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackWhiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessContrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pEIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watercolorFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

