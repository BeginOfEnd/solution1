namespace Task2_Form
{
    partial class Form2
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
            this.RandomButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InDGV = new System.Windows.Forms.DataGridView();
            this.OutDGV = new System.Windows.Forms.DataGridView();
            this.SizeBox = new System.Windows.Forms.TextBox();
            this.inputOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.inputSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.outputSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ReadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // RandomButton
            // 
            this.RandomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RandomButton.Location = new System.Drawing.Point(470, 26);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(228, 97);
            this.RandomButton.TabIndex = 0;
            this.RandomButton.Text = "Заполните файл";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SortButton.Location = new System.Drawing.Point(470, 474);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(228, 119);
            this.SortButton.TabIndex = 1;
            this.SortButton.Text = "Отсортируйте элементы";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(487, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите количество элементов";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InDGV
            // 
            this.InDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InDGV.Location = new System.Drawing.Point(37, 37);
            this.InDGV.Name = "InDGV";
            this.InDGV.Size = new System.Drawing.Size(240, 150);
            this.InDGV.TabIndex = 3;
            // 
            // OutDGV
            // 
            this.OutDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutDGV.Location = new System.Drawing.Point(854, 26);
            this.OutDGV.Name = "OutDGV";
            this.OutDGV.Size = new System.Drawing.Size(240, 150);
            this.OutDGV.TabIndex = 4;
            // 
            // SizeBox
            // 
            this.SizeBox.Location = new System.Drawing.Point(470, 251);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(228, 20);
            this.SizeBox.TabIndex = 5;
            this.SizeBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inputOpenFileDialog
            // 
            this.inputOpenFileDialog.DefaultExt = "txt";
            this.inputOpenFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            // 
            // inputSaveFileDialog
            // 
            this.inputSaveFileDialog.DefaultExt = "txt";
            this.inputSaveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            // 
            // outputSaveFileDialog
            // 
            this.outputSaveFileDialog.DefaultExt = "txt";
            this.outputSaveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            // 
            // ReadButton
            // 
            this.ReadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ReadButton.Location = new System.Drawing.Point(37, 261);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(240, 102);
            this.ReadButton.TabIndex = 6;
            this.ReadButton.Text = "Введите массив из файла";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1274, 650);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.SizeBox);
            this.Controls.Add(this.OutDGV);
            this.Controls.Add(this.InDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.RandomButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView InDGV;
        private System.Windows.Forms.DataGridView OutDGV;
        private System.Windows.Forms.TextBox SizeBox;
        private System.Windows.Forms.OpenFileDialog inputOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog inputSaveFileDialog;
        private System.Windows.Forms.SaveFileDialog outputSaveFileDialog;
        private System.Windows.Forms.Button ReadButton;
    }
}

