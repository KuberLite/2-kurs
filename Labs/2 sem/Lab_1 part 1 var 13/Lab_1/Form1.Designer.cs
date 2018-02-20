namespace Lab_1
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
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_substitution = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_delete_index = new System.Windows.Forms.Button();
            this.btn_length = new System.Windows.Forms.Button();
            this.btn_delete_aa = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_symbol = new System.Windows.Forms.Label();
            this.save_textbox = new System.Windows.Forms.RichTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(12, 70);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(137, 38);
            this.btn_plus.TabIndex = 0;
            this.btn_plus.Text = "Объединение строк";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_substitution
            // 
            this.btn_substitution.Location = new System.Drawing.Point(166, 70);
            this.btn_substitution.Name = "btn_substitution";
            this.btn_substitution.Size = new System.Drawing.Size(137, 38);
            this.btn_substitution.TabIndex = 0;
            this.btn_substitution.Text = "Замена подстроки на подстроку";
            this.btn_substitution.UseVisualStyleBackColor = true;
            this.btn_substitution.Click += new System.EventHandler(this.btn_substitution_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(319, 70);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(137, 38);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Удаление подстрок";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_delete_index
            // 
            this.btn_delete_index.Location = new System.Drawing.Point(12, 114);
            this.btn_delete_index.Name = "btn_delete_index";
            this.btn_delete_index.Size = new System.Drawing.Size(137, 38);
            this.btn_delete_index.TabIndex = 0;
            this.btn_delete_index.Text = "Получение символа по индексу";
            this.btn_delete_index.UseVisualStyleBackColor = true;
            this.btn_delete_index.Click += new System.EventHandler(this.btn_delete_index_Click);
            // 
            // btn_length
            // 
            this.btn_length.Location = new System.Drawing.Point(166, 114);
            this.btn_length.Name = "btn_length";
            this.btn_length.Size = new System.Drawing.Size(137, 38);
            this.btn_length.TabIndex = 0;
            this.btn_length.Text = "Длина строки";
            this.btn_length.UseVisualStyleBackColor = true;
            this.btn_length.Click += new System.EventHandler(this.btn_length_Click);
            // 
            // btn_delete_aa
            // 
            this.btn_delete_aa.Location = new System.Drawing.Point(319, 114);
            this.btn_delete_aa.Name = "btn_delete_aa";
            this.btn_delete_aa.Size = new System.Drawing.Size(137, 38);
            this.btn_delete_aa.TabIndex = 0;
            this.btn_delete_aa.Text = "Удвоение каждого гласного";
            this.btn_delete_aa.UseVisualStyleBackColor = true;
            this.btn_delete_aa.Click += new System.EventHandler(this.btn_delete_aa_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(342, 32);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(114, 20);
            this.textBox4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // lb_symbol
            // 
            this.lb_symbol.AutoSize = true;
            this.lb_symbol.Location = new System.Drawing.Point(149, 35);
            this.lb_symbol.Name = "lb_symbol";
            this.lb_symbol.Size = new System.Drawing.Size(13, 13);
            this.lb_symbol.TabIndex = 4;
            this.lb_symbol.Text = "  ";
            // 
            // save_textbox
            // 
            this.save_textbox.Location = new System.Drawing.Point(12, 158);
            this.save_textbox.Name = "save_textbox";
            this.save_textbox.Size = new System.Drawing.Size(137, 38);
            this.save_textbox.TabIndex = 5;
            this.save_textbox.Text = "";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(319, 159);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(137, 37);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Check";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 217);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.save_textbox);
            this.Controls.Add(this.lb_symbol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_delete_aa);
            this.Controls.Add(this.btn_length);
            this.Controls.Add(this.btn_delete_index);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_substitution);
            this.Controls.Add(this.btn_plus);
            this.Name = "Form1";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_substitution;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_delete_index;
        private System.Windows.Forms.Button btn_length;
        private System.Windows.Forms.Button btn_delete_aa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_symbol;
        private System.Windows.Forms.RichTextBox save_textbox;
        private System.Windows.Forms.Button btn_save;
    }
}

