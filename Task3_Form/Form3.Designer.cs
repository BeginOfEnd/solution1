namespace Task3_Form
{
    partial class Form3
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
            this.StudentsBox = new System.Windows.Forms.TextBox();
            this.FileButton = new System.Windows.Forms.Button();
            this.GroupsBox = new System.Windows.Forms.TextBox();
            this.GroupButton = new System.Windows.Forms.Button();
            this.inputOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.inputSerializeFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SerializeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentsBox
            // 
            this.StudentsBox.Location = new System.Drawing.Point(12, 40);
            this.StudentsBox.Multiline = true;
            this.StudentsBox.Name = "StudentsBox";
            this.StudentsBox.Size = new System.Drawing.Size(272, 475);
            this.StudentsBox.TabIndex = 0;
            // 
            // FileButton
            // 
            this.FileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FileButton.Location = new System.Drawing.Point(12, 543);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(272, 66);
            this.FileButton.TabIndex = 1;
            this.FileButton.Text = "Считать из файла";
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // GroupsBox
            // 
            this.GroupsBox.Location = new System.Drawing.Point(489, 40);
            this.GroupsBox.Multiline = true;
            this.GroupsBox.Name = "GroupsBox";
            this.GroupsBox.Size = new System.Drawing.Size(177, 40);
            this.GroupsBox.TabIndex = 2;
            // 
            // GroupButton
            // 
            this.GroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GroupButton.Location = new System.Drawing.Point(489, 108);
            this.GroupButton.Name = "GroupButton";
            this.GroupButton.Size = new System.Drawing.Size(177, 106);
            this.GroupButton.TabIndex = 3;
            this.GroupButton.Text = "Показать группы со средним баллом ниже среднефакультетского";
            this.GroupButton.UseVisualStyleBackColor = true;
            this.GroupButton.Click += new System.EventHandler(this.GroupButton_Click);
            // 
            // inputOpenFileDialog
            // 
            this.inputOpenFileDialog.DefaultExt = "txt";
            this.inputOpenFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            // 
            // inputSerializeFileDialog
            // 
            this.inputSerializeFileDialog.DefaultExt = "dat";
            this.inputSerializeFileDialog.Filter = "Текстовые файлы (*.dat)|*.dat|Все файлы (*.*)|*.*";
            // 
            // SerializeButton
            // 
            this.SerializeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SerializeButton.Location = new System.Drawing.Point(363, 343);
            this.SerializeButton.Name = "SerializeButton";
            this.SerializeButton.Size = new System.Drawing.Size(202, 102);
            this.SerializeButton.TabIndex = 4;
            this.SerializeButton.Text = "Сериализовать данные из файла";
            this.SerializeButton.UseVisualStyleBackColor = true;
            this.SerializeButton.Click += new System.EventHandler(this.SerializeButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(749, 621);
            this.Controls.Add(this.SerializeButton);
            this.Controls.Add(this.GroupButton);
            this.Controls.Add(this.GroupsBox);
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.StudentsBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StudentsBox;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.TextBox GroupsBox;
        private System.Windows.Forms.Button GroupButton;
        private System.Windows.Forms.OpenFileDialog inputOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog inputSerializeFileDialog;
        private System.Windows.Forms.Button SerializeButton;
    }
}

