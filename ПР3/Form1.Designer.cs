namespace ПР3
{
    partial class ПР3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Inf = new System.Windows.Forms.ToolStripMenuItem();
            this.Programm = new System.Windows.Forms.ToolStripMenuItem();
            this.матрицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Size = new System.Windows.Forms.ToolStripMenuItem();
            this.Completion = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonWrite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 175;
            this.dataGridView1.Size = new System.Drawing.Size(345, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Inf,
            this.матрицаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(345, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Inf
            // 
            this.Inf.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Programm});
            this.Inf.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Inf.Name = "Inf";
            this.Inf.Size = new System.Drawing.Size(88, 24);
            this.Inf.Text = "Сведения";
            // 
            // Programm
            // 
            this.Programm.Name = "Programm";
            this.Programm.Size = new System.Drawing.Size(173, 24);
            this.Programm.Text = "О программе";
            this.Programm.Click += new System.EventHandler(this.Programm_Click);
            // 
            // матрицаToolStripMenuItem
            // 
            this.матрицаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Size,
            this.Completion});
            this.матрицаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.матрицаToolStripMenuItem.Name = "матрицаToolStripMenuItem";
            this.матрицаToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.матрицаToolStripMenuItem.Text = "Матрица";
            // 
            // Size
            // 
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(253, 24);
            this.Size.Text = "Задать/изменить размер";
            this.Size.Click += new System.EventHandler(this.Size_Click);
            // 
            // Completion
            // 
            this.Completion.Name = "Completion";
            this.Completion.Size = new System.Drawing.Size(253, 24);
            this.Completion.Text = "Заполнить";
            this.Completion.Click += new System.EventHandler(this.Completion_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWrite.Location = new System.Drawing.Point(12, 329);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(321, 64);
            this.buttonWrite.TabIndex = 2;
            this.buttonWrite.Text = "Вывести количество положительных чисел в строчках";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // ПР3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(345, 401);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ПР3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ПР3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Inf;
        private System.Windows.Forms.ToolStripMenuItem Programm;
        private System.Windows.Forms.ToolStripMenuItem матрицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Size;
        private System.Windows.Forms.ToolStripMenuItem Completion;
        private System.Windows.Forms.Button buttonWrite;
    }
}

