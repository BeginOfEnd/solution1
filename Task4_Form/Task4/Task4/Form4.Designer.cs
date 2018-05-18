namespace Task4
{
    partial class Form4
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
            this.StartPositionText = new System.Windows.Forms.TextBox();
            this.VerticalMoveText = new System.Windows.Forms.TextBox();
            this.HorizontalMoveText = new System.Windows.Forms.TextBox();
            this.Vertical = new System.Windows.Forms.Label();
            this.Horizontal = new System.Windows.Forms.Label();
            this.NTurns = new System.Windows.Forms.TextBox();
            this.TurnsText = new System.Windows.Forms.TextBox();
            this.Turns = new System.Windows.Forms.Label();
            this.inputOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.inputSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.outputSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TurnsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartPositionText
            // 
            this.StartPositionText.Location = new System.Drawing.Point(22, 40);
            this.StartPositionText.Name = "StartPositionText";
            this.StartPositionText.Size = new System.Drawing.Size(100, 20);
            this.StartPositionText.TabIndex = 0;
            // 
            // VerticalMoveText
            // 
            this.VerticalMoveText.Location = new System.Drawing.Point(225, 184);
            this.VerticalMoveText.Name = "VerticalMoveText";
            this.VerticalMoveText.Size = new System.Drawing.Size(111, 20);
            this.VerticalMoveText.TabIndex = 1;
            // 
            // HorizontalMoveText
            // 
            this.HorizontalMoveText.Location = new System.Drawing.Point(430, 184);
            this.HorizontalMoveText.Name = "HorizontalMoveText";
            this.HorizontalMoveText.Size = new System.Drawing.Size(122, 20);
            this.HorizontalMoveText.TabIndex = 2;
            // 
            // Vertical
            // 
            this.Vertical.AutoSize = true;
            this.Vertical.BackColor = System.Drawing.Color.Lavender;
            this.Vertical.Location = new System.Drawing.Point(222, 237);
            this.Vertical.Name = "Vertical";
            this.Vertical.Size = new System.Drawing.Size(114, 13);
            this.Vertical.TabIndex = 3;
            this.Vertical.Text = "Клетки по вертикали";
            // 
            // Horizontal
            // 
            this.Horizontal.AutoSize = true;
            this.Horizontal.BackColor = System.Drawing.Color.GhostWhite;
            this.Horizontal.Location = new System.Drawing.Point(427, 237);
            this.Horizontal.Name = "Horizontal";
            this.Horizontal.Size = new System.Drawing.Size(125, 13);
            this.Horizontal.TabIndex = 4;
            this.Horizontal.Text = "Клетки по горизонтали";
            // 
            // NTurns
            // 
            this.NTurns.Location = new System.Drawing.Point(672, 51);
            this.NTurns.Multiline = true;
            this.NTurns.Name = "NTurns";
            this.NTurns.Size = new System.Drawing.Size(207, 199);
            this.NTurns.TabIndex = 5;
            // 
            // TurnsText
            // 
            this.TurnsText.Location = new System.Drawing.Point(358, 40);
            this.TurnsText.Name = "TurnsText";
            this.TurnsText.Size = new System.Drawing.Size(100, 20);
            this.TurnsText.TabIndex = 6;
            // 
            // Turns
            // 
            this.Turns.AutoSize = true;
            this.Turns.BackColor = System.Drawing.Color.AliceBlue;
            this.Turns.Location = new System.Drawing.Point(358, 86);
            this.Turns.Name = "Turns";
            this.Turns.Size = new System.Drawing.Size(98, 13);
            this.Turns.TabIndex = 7;
            this.Turns.Text = "Количество ходов";
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
            // TurnsButton
            // 
            this.TurnsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TurnsButton.Location = new System.Drawing.Point(303, 369);
            this.TurnsButton.Name = "TurnsButton";
            this.TurnsButton.Size = new System.Drawing.Size(284, 108);
            this.TurnsButton.TabIndex = 8;
            this.TurnsButton.Text = "Определить позиции";
            this.TurnsButton.UseVisualStyleBackColor = true;
            this.TurnsButton.Click += new System.EventHandler(this.TurnsButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(956, 505);
            this.Controls.Add(this.TurnsButton);
            this.Controls.Add(this.Turns);
            this.Controls.Add(this.TurnsText);
            this.Controls.Add(this.NTurns);
            this.Controls.Add(this.Horizontal);
            this.Controls.Add(this.Vertical);
            this.Controls.Add(this.HorizontalMoveText);
            this.Controls.Add(this.VerticalMoveText);
            this.Controls.Add(this.StartPositionText);
            this.Name = "Form4";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StartPositionText;
        private System.Windows.Forms.TextBox VerticalMoveText;
        private System.Windows.Forms.TextBox HorizontalMoveText;
        private System.Windows.Forms.Label Vertical;
        private System.Windows.Forms.Label Horizontal;
        private System.Windows.Forms.TextBox NTurns;
        private System.Windows.Forms.TextBox TurnsText;
        private System.Windows.Forms.OpenFileDialog inputOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog inputSaveFileDialog;
        private System.Windows.Forms.SaveFileDialog outputSaveFileDialog;
        private System.Windows.Forms.Label Turns;
        private System.Windows.Forms.Button TurnsButton;
    }
}

