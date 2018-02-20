namespace WindowsFormsApp1
{
    partial class Collection
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
            this.label1 = new System.Windows.Forms.Label();
            this.size_tb = new System.Windows.Forms.TextBox();
            this.btn_sorted_plus = new System.Windows.Forms.Button();
            this.btn_generation = new System.Windows.Forms.Button();
            this.btn_sorted_minus = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.rand_coll = new System.Windows.Forms.RichTextBox();
            this.total_tb = new System.Windows.Forms.RichTextBox();
            this.rand_coll_clear = new System.Windows.Forms.Button();
            this.total_tb_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер коллекции";
            // 
            // size_tb
            // 
            this.size_tb.Location = new System.Drawing.Point(221, 25);
            this.size_tb.Name = "size_tb";
            this.size_tb.Size = new System.Drawing.Size(100, 20);
            this.size_tb.TabIndex = 1;
            // 
            // btn_sorted_plus
            // 
            this.btn_sorted_plus.Location = new System.Drawing.Point(29, 71);
            this.btn_sorted_plus.Name = "btn_sorted_plus";
            this.btn_sorted_plus.Size = new System.Drawing.Size(98, 54);
            this.btn_sorted_plus.TabIndex = 2;
            this.btn_sorted_plus.Text = "Сортировать по возрастанию";
            this.btn_sorted_plus.UseVisualStyleBackColor = true;
            this.btn_sorted_plus.Click += new System.EventHandler(this.btn_sorted_plus_Click);
            // 
            // btn_generation
            // 
            this.btn_generation.Location = new System.Drawing.Point(185, 71);
            this.btn_generation.Name = "btn_generation";
            this.btn_generation.Size = new System.Drawing.Size(198, 54);
            this.btn_generation.TabIndex = 2;
            this.btn_generation.Text = "Сгенерировать коллекцию";
            this.btn_generation.UseVisualStyleBackColor = true;
            this.btn_generation.Click += new System.EventHandler(this.btn_generation_Click);
            // 
            // btn_sorted_minus
            // 
            this.btn_sorted_minus.Location = new System.Drawing.Point(437, 71);
            this.btn_sorted_minus.Name = "btn_sorted_minus";
            this.btn_sorted_minus.Size = new System.Drawing.Size(98, 54);
            this.btn_sorted_minus.TabIndex = 2;
            this.btn_sorted_minus.Text = "Сортировать по убыванию";
            this.btn_sorted_minus.UseVisualStyleBackColor = true;
            this.btn_sorted_minus.Click += new System.EventHandler(this.btn_sorted_minus_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(52, 144);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(116, 56);
            this.btn_1.TabIndex = 3;
            this.btn_1.Text = "Запрос №1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(205, 144);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(116, 56);
            this.btn_2.TabIndex = 3;
            this.btn_2.Text = "Запрос №2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(362, 144);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(116, 56);
            this.btn_3.TabIndex = 3;
            this.btn_3.Text = "Запрос №3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // rand_coll
            // 
            this.rand_coll.Location = new System.Drawing.Point(12, 206);
            this.rand_coll.Name = "rand_coll";
            this.rand_coll.Size = new System.Drawing.Size(219, 163);
            this.rand_coll.TabIndex = 4;
            this.rand_coll.Text = "";
            // 
            // total_tb
            // 
            this.total_tb.Location = new System.Drawing.Point(316, 206);
            this.total_tb.Name = "total_tb";
            this.total_tb.Size = new System.Drawing.Size(219, 163);
            this.total_tb.TabIndex = 4;
            this.total_tb.Text = "";
            // 
            // rand_coll_clear
            // 
            this.rand_coll_clear.Location = new System.Drawing.Point(12, 381);
            this.rand_coll_clear.Name = "rand_coll_clear";
            this.rand_coll_clear.Size = new System.Drawing.Size(219, 23);
            this.rand_coll_clear.TabIndex = 5;
            this.rand_coll_clear.Text = "Очистить";
            this.rand_coll_clear.UseVisualStyleBackColor = true;
            this.rand_coll_clear.Click += new System.EventHandler(this.rand_coll_clear_Click);
            // 
            // total_tb_clear
            // 
            this.total_tb_clear.Location = new System.Drawing.Point(316, 381);
            this.total_tb_clear.Name = "total_tb_clear";
            this.total_tb_clear.Size = new System.Drawing.Size(219, 23);
            this.total_tb_clear.TabIndex = 5;
            this.total_tb_clear.Text = "Очистить";
            this.total_tb_clear.UseVisualStyleBackColor = true;
            this.total_tb_clear.Click += new System.EventHandler(this.total_tb_clear_Click);
            // 
            // Collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(562, 416);
            this.Controls.Add(this.total_tb_clear);
            this.Controls.Add(this.rand_coll_clear);
            this.Controls.Add(this.total_tb);
            this.Controls.Add(this.rand_coll);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_generation);
            this.Controls.Add(this.btn_sorted_minus);
            this.Controls.Add(this.btn_sorted_plus);
            this.Controls.Add(this.size_tb);
            this.Controls.Add(this.label1);
            this.Name = "Collection";
            this.Text = "Collection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox size_tb;
        private System.Windows.Forms.Button btn_sorted_plus;
        private System.Windows.Forms.Button btn_generation;
        private System.Windows.Forms.Button btn_sorted_minus;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.RichTextBox rand_coll;
        private System.Windows.Forms.RichTextBox total_tb;
        private System.Windows.Forms.Button rand_coll_clear;
        private System.Windows.Forms.Button total_tb_clear;
    }
}

