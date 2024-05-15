namespace ПР3
{
    partial class Form3
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
            this.textBoxRow = new System.Windows.Forms.TextBox();
            this.textBoxColumn = new System.Windows.Forms.TextBox();
            this.labelString = new System.Windows.Forms.Label();
            this.labelRow = new System.Windows.Forms.Label();
            this.labelInf = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxRow
            // 
            this.textBoxRow.Location = new System.Drawing.Point(181, 12);
            this.textBoxRow.Name = "textBoxRow";
            this.textBoxRow.Size = new System.Drawing.Size(65, 20);
            this.textBoxRow.TabIndex = 0;
            this.textBoxRow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRow_TextChanged);
            // 
            // textBoxColumn
            // 
            this.textBoxColumn.Location = new System.Drawing.Point(181, 38);
            this.textBoxColumn.Name = "textBoxColumn";
            this.textBoxColumn.Size = new System.Drawing.Size(65, 20);
            this.textBoxColumn.TabIndex = 1;
            this.textBoxColumn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxColumn_TextChanged);
            // 
            // labelString
            // 
            this.labelString.AutoSize = true;
            this.labelString.Location = new System.Drawing.Point(12, 15);
            this.labelString.Name = "labelString";
            this.labelString.Size = new System.Drawing.Size(145, 13);
            this.labelString.TabIndex = 2;
            this.labelString.Text = "Введите количество строк:";
            // 
            // labelRow
            // 
            this.labelRow.AutoSize = true;
            this.labelRow.Location = new System.Drawing.Point(12, 41);
            this.labelRow.Name = "labelRow";
            this.labelRow.Size = new System.Drawing.Size(163, 13);
            this.labelRow.TabIndex = 3;
            this.labelRow.Text = "Введите количество столбцов:";
            // 
            // labelInf
            // 
            this.labelInf.AutoSize = true;
            this.labelInf.Location = new System.Drawing.Point(12, 74);
            this.labelInf.Name = "labelInf";
            this.labelInf.Size = new System.Drawing.Size(237, 13);
            this.labelInf.TabIndex = 4;
            this.labelInf.Text = "*При изменении текущая матрица обнулится";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // buttonOk
            // 
            this.buttonOk.Image = global::ПР3.Properties.Resources.ок;
            this.buttonOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOk.Location = new System.Drawing.Point(171, 90);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 35);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Ок";
            this.buttonOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Image = global::ПР3.Properties.Resources.ex;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExit.Location = new System.Drawing.Point(12, 90);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(85, 35);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Отмена";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 135);
            this.ControlBox = false;
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelInf);
            this.Controls.Add(this.labelRow);
            this.Controls.Add(this.labelString);
            this.Controls.Add(this.textBoxColumn);
            this.Controls.Add(this.textBoxRow);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение размеров матрицы";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRow;
        private System.Windows.Forms.TextBox textBoxColumn;
        private System.Windows.Forms.Label labelString;
        private System.Windows.Forms.Label labelRow;
        private System.Windows.Forms.Label labelInf;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}