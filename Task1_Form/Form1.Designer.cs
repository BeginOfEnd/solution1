namespace Task1_Form
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
            this.InputButon = new System.Windows.Forms.Button();
            this.OutputButton = new System.Windows.Forms.Button();
            this.SaveOutput = new System.Windows.Forms.Button();
            this.SaveInput = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.inputSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.outputSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.InputText = new System.Windows.Forms.TextBox();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputButon
            // 
            this.InputButon.Location = new System.Drawing.Point(494, 34);
            this.InputButon.Name = "InputButon";
            this.InputButon.Size = new System.Drawing.Size(188, 55);
            this.InputButon.TabIndex = 2;
            this.InputButon.Text = "Введите текст";
            this.InputButon.UseVisualStyleBackColor = true;
            this.InputButon.Click += new System.EventHandler(this.InputButon_Click);
            // 
            // OutputButton
            // 
            this.OutputButton.Location = new System.Drawing.Point(1181, 34);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(190, 55);
            this.OutputButton.TabIndex = 3;
            this.OutputButton.Text = "Преобразовать текст";
            this.OutputButton.UseVisualStyleBackColor = true;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // SaveOutput
            // 
            this.SaveOutput.Location = new System.Drawing.Point(1181, 104);
            this.SaveOutput.Name = "SaveOutput";
            this.SaveOutput.Size = new System.Drawing.Size(190, 64);
            this.SaveOutput.TabIndex = 4;
            this.SaveOutput.Text = "Сохраните выведенное в файл";
            this.SaveOutput.UseVisualStyleBackColor = true;
            // 
            // SaveInput
            // 
            this.SaveInput.Location = new System.Drawing.Point(494, 113);
            this.SaveInput.Name = "SaveInput";
            this.SaveInput.Size = new System.Drawing.Size(188, 55);
            this.SaveInput.TabIndex = 5;
            this.SaveInput.Text = "Сохраните введённое в файл";
            this.SaveInput.UseVisualStyleBackColor = true;
            this.SaveInput.Click += new System.EventHandler(this.SaveInput_Click);
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(494, 520);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(188, 20);
            this.Number.TabIndex = 8;
            this.Number.TextChanged += new System.EventHandler(this.Number_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(544, 576);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите номер";
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
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(12, 34);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(300, 600);
            this.InputText.TabIndex = 10;
            // 
            // OutputText
            // 
            this.OutputText.Location = new System.Drawing.Point(820, 34);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(300, 600);
            this.OutputText.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1405, 640);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.SaveInput);
            this.Controls.Add(this.SaveOutput);
            this.Controls.Add(this.OutputButton);
            this.Controls.Add(this.InputButon);
            this.Name = "Form1";
            this.Text = "Task1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button InputButon;
        private System.Windows.Forms.Button OutputButton;
        private System.Windows.Forms.Button SaveOutput;
        private System.Windows.Forms.Button SaveInput;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog inputOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog inputSaveFileDialog;
        private System.Windows.Forms.SaveFileDialog outputSaveFileDialog;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.TextBox OutputText;
    }
}

