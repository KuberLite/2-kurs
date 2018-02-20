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
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_cos = new System.Windows.Forms.Button();
            this.btn_sin = new System.Windows.Forms.Button();
            this.btn_sqrt = new System.Windows.Forms.Button();
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
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(166, 70);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(137, 38);
            this.btn_minus.TabIndex = 0;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_division
            // 
            this.btn_division.Location = new System.Drawing.Point(319, 70);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(137, 38);
            this.btn_division.TabIndex = 0;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.Location = new System.Drawing.Point(12, 114);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(137, 38);
            this.btn_mult.TabIndex = 0;
            this.btn_mult.Text = "x";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // btn_cos
            // 
            this.btn_cos.Location = new System.Drawing.Point(166, 114);
            this.btn_cos.Name = "btn_cos";
            this.btn_cos.Size = new System.Drawing.Size(137, 38);
            this.btn_cos.TabIndex = 0;
            this.btn_cos.Text = "cos";
            this.btn_cos.UseVisualStyleBackColor = true;
            this.btn_cos.Click += new System.EventHandler(this.btn_cos_Click);
            // 
            // btn_sin
            // 
            this.btn_sin.Location = new System.Drawing.Point(319, 114);
            this.btn_sin.Name = "btn_sin";
            this.btn_sin.Size = new System.Drawing.Size(137, 38);
            this.btn_sin.TabIndex = 0;
            this.btn_sin.Text = "sin";
            this.btn_sin.UseVisualStyleBackColor = true;
            this.btn_sin.Click += new System.EventHandler(this.btn_sin_Click);
            // 
            // btn_sqrt
            // 
            this.btn_sqrt.Location = new System.Drawing.Point(166, 158);
            this.btn_sqrt.Name = "btn_sqrt";
            this.btn_sqrt.Size = new System.Drawing.Size(137, 38);
            this.btn_sqrt.TabIndex = 0;
            this.btn_sqrt.Text = "√";
            this.btn_sqrt.UseVisualStyleBackColor = true;
            this.btn_sqrt.Click += new System.EventHandler(this.btn_sqrt_Click);
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
            this.Controls.Add(this.btn_sqrt);
            this.Controls.Add(this.btn_sin);
            this.Controls.Add(this.btn_cos);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Name = "Form1";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_cos;
        private System.Windows.Forms.Button btn_sin;
        private System.Windows.Forms.Button btn_sqrt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_symbol;
        private System.Windows.Forms.RichTextBox save_textbox;
        private System.Windows.Forms.Button btn_save;
    }
}

