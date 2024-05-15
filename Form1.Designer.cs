namespace ПР3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Inf = new System.Windows.Forms.ToolStripMenuItem();
            this.InfProgramm = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.матрицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.х4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.х5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.х6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.х7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.х8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Inf,
            this.матрицаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Inf
            // 
            this.Inf.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfProgramm});
            this.Inf.Name = "Inf";
            this.Inf.Size = new System.Drawing.Size(65, 20);
            this.Inf.Text = "Справка";
            // 
            // InfProgramm
            // 
            this.InfProgramm.Name = "InfProgramm";
            this.InfProgramm.Size = new System.Drawing.Size(149, 22);
            this.InfProgramm.Text = "О программе";
            this.InfProgramm.Click += new System.EventHandler(this.InfProgramm_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // матрицаToolStripMenuItem
            // 
            this.матрицаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.матрицаToolStripMenuItem.Name = "матрицаToolStripMenuItem";
            this.матрицаToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.матрицаToolStripMenuItem.Text = "Матрица";
            // 
            // новаяToolStripMenuItem
            // 
            this.новаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.х4ToolStripMenuItem,
            this.х5ToolStripMenuItem,
            this.х6ToolStripMenuItem,
            this.х7ToolStripMenuItem,
            this.х8ToolStripMenuItem});
            this.новаяToolStripMenuItem.Name = "новаяToolStripMenuItem";
            this.новаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.новаяToolStripMenuItem.Text = "Новая";
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            // 
            // х4ToolStripMenuItem
            // 
            this.х4ToolStripMenuItem.Name = "х4ToolStripMenuItem";
            this.х4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.х4ToolStripMenuItem.Text = "4х4";
            // 
            // х5ToolStripMenuItem
            // 
            this.х5ToolStripMenuItem.Name = "х5ToolStripMenuItem";
            this.х5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.х5ToolStripMenuItem.Text = "5х5";
            // 
            // х6ToolStripMenuItem
            // 
            this.х6ToolStripMenuItem.Name = "х6ToolStripMenuItem";
            this.х6ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.х6ToolStripMenuItem.Text = "6х6";
            // 
            // х7ToolStripMenuItem
            // 
            this.х7ToolStripMenuItem.Name = "х7ToolStripMenuItem";
            this.х7ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.х7ToolStripMenuItem.Text = "7х7";
            // 
            // х8ToolStripMenuItem
            // 
            this.х8ToolStripMenuItem.Name = "х8ToolStripMenuItem";
            this.х8ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.х8ToolStripMenuItem.Text = "8х8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Inf;
        private System.Windows.Forms.ToolStripMenuItem InfProgramm;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ToolStripMenuItem матрицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem х4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem х5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem х6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem х7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem х8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
    }
}

