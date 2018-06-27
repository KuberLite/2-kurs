namespace Task1
{
    partial class MainForm
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
            this.IndexListView = new System.Windows.Forms.ListView();
            this.ElemListView = new System.Windows.Forms.ListView();
            this.FillFindButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxElemTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfMaxElemTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IndexListView
            // 
            this.IndexListView.Location = new System.Drawing.Point(12, 12);
            this.IndexListView.Name = "IndexListView";
            this.IndexListView.Size = new System.Drawing.Size(184, 302);
            this.IndexListView.TabIndex = 0;
            this.IndexListView.UseCompatibleStateImageBehavior = false;
            // 
            // ElemListView
            // 
            this.ElemListView.Location = new System.Drawing.Point(202, 12);
            this.ElemListView.Name = "ElemListView";
            this.ElemListView.Size = new System.Drawing.Size(201, 302);
            this.ElemListView.TabIndex = 1;
            this.ElemListView.UseCompatibleStateImageBehavior = false;
            // 
            // FillFindButton
            // 
            this.FillFindButton.Location = new System.Drawing.Point(121, 375);
            this.FillFindButton.Name = "FillFindButton";
            this.FillFindButton.Size = new System.Drawing.Size(75, 23);
            this.FillFindButton.TabIndex = 2;
            this.FillFindButton.Text = "fill and find";
            this.FillFindButton.UseVisualStyleBackColor = true;
            this.FillFindButton.Click += new System.EventHandler(this.FillFindButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "max elem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "number of max elem:";
            // 
            // MaxElemTextBox
            // 
            this.MaxElemTextBox.Location = new System.Drawing.Point(72, 318);
            this.MaxElemTextBox.Name = "MaxElemTextBox";
            this.MaxElemTextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxElemTextBox.TabIndex = 5;
            // 
            // NumberOfMaxElemTextBox
            // 
            this.NumberOfMaxElemTextBox.Location = new System.Drawing.Point(122, 348);
            this.NumberOfMaxElemTextBox.Name = "NumberOfMaxElemTextBox";
            this.NumberOfMaxElemTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberOfMaxElemTextBox.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 410);
            this.Controls.Add(this.NumberOfMaxElemTextBox);
            this.Controls.Add(this.MaxElemTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FillFindButton);
            this.Controls.Add(this.ElemListView);
            this.Controls.Add(this.IndexListView);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView IndexListView;
        private System.Windows.Forms.ListView ElemListView;
        private System.Windows.Forms.Button FillFindButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaxElemTextBox;
        private System.Windows.Forms.TextBox NumberOfMaxElemTextBox;
    }
}

