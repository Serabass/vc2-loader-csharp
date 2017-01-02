namespace vc2_loader_csharp
{
    partial class SocialLink
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
            this.SuspendLayout();
            // 
            // SocialLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximumSize = new System.Drawing.Size(35, 49);
            this.MinimumSize = new System.Drawing.Size(35, 49);
            this.Name = "SocialLink";
            this.Size = new System.Drawing.Size(35, 49);
            this.Click += new System.EventHandler(this.SocialLink_Click);
            this.MouseEnter += new System.EventHandler(this.SocialLink_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.SocialLink_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
