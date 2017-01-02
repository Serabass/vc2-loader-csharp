namespace vc2_loader_csharp
{
    partial class Entity
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entity));
            this.pctLine = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlImg = new System.Windows.Forms.Panel();
            this.pctImage = new System.Windows.Forms.PictureBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pctLine)).BeginInit();
            this.pnlImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLine
            // 
            this.pctLine.BackColor = System.Drawing.Color.DarkGray;
            this.pctLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pctLine.Location = new System.Drawing.Point(15, 46);
            this.pctLine.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.pctLine.Name = "pctLine";
            this.pctLine.Padding = new System.Windows.Forms.Padding(30);
            this.pctLine.Size = new System.Drawing.Size(228, 1);
            this.pctLine.TabIndex = 1;
            this.pctLine.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("HelveticaNeueCyr", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(15, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(228, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "[Title]";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // pnlImg
            // 
            this.pnlImg.Controls.Add(this.pctImage);
            this.pnlImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImg.Location = new System.Drawing.Point(15, 47);
            this.pnlImg.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.pnlImg.Name = "pnlImg";
            this.pnlImg.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.pnlImg.Size = new System.Drawing.Size(228, 219);
            this.pnlImg.TabIndex = 2;
            // 
            // pctImage
            // 
            this.pctImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctImage.BackgroundImage")));
            this.pctImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pctImage.Location = new System.Drawing.Point(0, 3);
            this.pctImage.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.pctImage.Name = "pctImage";
            this.pctImage.Size = new System.Drawing.Size(228, 176);
            this.pctImage.TabIndex = 1;
            this.pctImage.TabStop = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(15, 232);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(228, 34);
            this.pnlFooter.TabIndex = 6;
            // 
            // Entity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlImg);
            this.Controls.Add(this.pctLine);
            this.Controls.Add(this.lblTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(30);
            this.MinimumSize = new System.Drawing.Size(150, 204);
            this.Name = "Entity";
            this.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.Size = new System.Drawing.Size(258, 281);
            this.Load += new System.EventHandler(this.Entity_Load);
            this.MouseEnter += new System.EventHandler(this.Entity_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Entity_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pctLine)).EndInit();
            this.pnlImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pctLine;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlImg;
        private System.Windows.Forms.PictureBox pctImage;
        private System.Windows.Forms.Panel pnlFooter;
    }
}
