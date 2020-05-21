namespace Задание_1_г
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
            this.Textlabel = new System.Windows.Forms.Label();
            this.Wordlabel = new System.Windows.Forms.Label();
            this.Text = new System.Windows.Forms.TextBox();
            this.Word = new System.Windows.Forms.TextBox();
            this.Islabel = new System.Windows.Forms.Label();
            this.Chek = new System.Windows.Forms.Button();
            this.Is = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Textlabel
            // 
            this.Textlabel.AutoSize = true;
            this.Textlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Textlabel.Location = new System.Drawing.Point(12, 25);
            this.Textlabel.Name = "Textlabel";
            this.Textlabel.Size = new System.Drawing.Size(242, 28);
            this.Textlabel.TabIndex = 0;
            this.Textlabel.Text = "Осмысленный текст";
            // 
            // Wordlabel
            // 
            this.Wordlabel.AutoSize = true;
            this.Wordlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Wordlabel.Location = new System.Drawing.Point(12, 81);
            this.Wordlabel.Name = "Wordlabel";
            this.Wordlabel.Size = new System.Drawing.Size(80, 28);
            this.Wordlabel.TabIndex = 1;
            this.Wordlabel.Text = "Слово";
            // 
            // Text
            // 
            this.Text.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text.Location = new System.Drawing.Point(260, 22);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(528, 36);
            this.Text.TabIndex = 2;
            // 
            // Word
            // 
            this.Word.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Word.Location = new System.Drawing.Point(98, 78);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(196, 36);
            this.Word.TabIndex = 3;
            this.Word.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Word_KeyPress);
            // 
            // Islabel
            // 
            this.Islabel.AutoSize = true;
            this.Islabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Islabel.Location = new System.Drawing.Point(12, 215);
            this.Islabel.Name = "Islabel";
            this.Islabel.Size = new System.Drawing.Size(586, 28);
            this.Islabel.TabIndex = 4;
            this.Islabel.Text = "Содержится ли в введённом тексте заданное слово";
            // 
            // Chek
            // 
            this.Chek.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Chek.Location = new System.Drawing.Point(319, 122);
            this.Chek.Name = "Chek";
            this.Chek.Size = new System.Drawing.Size(182, 66);
            this.Chek.TabIndex = 5;
            this.Chek.Text = "Проверить";
            this.Chek.UseVisualStyleBackColor = true;
            this.Chek.Click += new System.EventHandler(this.Chek_Click);
            // 
            // Is
            // 
            this.Is.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Is.Location = new System.Drawing.Point(623, 212);
            this.Is.Name = "Is";
            this.Is.ReadOnly = true;
            this.Is.Size = new System.Drawing.Size(113, 36);
            this.Is.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 283);
            this.Controls.Add(this.Is);
            this.Controls.Add(this.Chek);
            this.Controls.Add(this.Islabel);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.Wordlabel);
            this.Controls.Add(this.Textlabel);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Textlabel;
        private System.Windows.Forms.Label Wordlabel;
        private System.Windows.Forms.TextBox Text;
        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.Label Islabel;
        private System.Windows.Forms.Button Chek;
        private System.Windows.Forms.TextBox Is;
    }
}

