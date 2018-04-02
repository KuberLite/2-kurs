namespace Lab_2
{
    partial class FormFind
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
            this.fnd_class_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_continent_fnd = new System.Windows.Forms.TextBox();
            this.k = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lb_search_fail = new System.Windows.Forms.Label();
            this.rtb_FindForm = new System.Windows.Forms.RichTextBox();
            this.btn_close_FindForm = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_fnd_class = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortedByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortedByToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.costToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regexFound = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fnd_class_tb
            // 
            this.fnd_class_tb.Location = new System.Drawing.Point(72, 26);
            this.fnd_class_tb.Name = "fnd_class_tb";
            this.fnd_class_tb.Size = new System.Drawing.Size(197, 20);
            this.fnd_class_tb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Класс:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата поступления:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Континент/Страна:";
            // 
            // tb_continent_fnd
            // 
            this.tb_continent_fnd.Location = new System.Drawing.Point(75, 114);
            this.tb_continent_fnd.Name = "tb_continent_fnd";
            this.tb_continent_fnd.Size = new System.Drawing.Size(197, 20);
            this.tb_continent_fnd.TabIndex = 5;
            // 
            // k
            // 
            this.k.Location = new System.Drawing.Point(301, 26);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(235, 23);
            this.k.TabIndex = 6;
            this.k.Text = "Поиск";
            this.k.UseVisualStyleBackColor = true;
            this.k.Click += new System.EventHandler(this.k_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // lb_search_fail
            // 
            this.lb_search_fail.AutoSize = true;
            this.lb_search_fail.Location = new System.Drawing.Point(321, 117);
            this.lb_search_fail.Name = "lb_search_fail";
            this.lb_search_fail.Size = new System.Drawing.Size(10, 13);
            this.lb_search_fail.TabIndex = 9;
            this.lb_search_fail.Text = " ";
            // 
            // rtb_FindForm
            // 
            this.rtb_FindForm.Location = new System.Drawing.Point(31, 156);
            this.rtb_FindForm.Name = "rtb_FindForm";
            this.rtb_FindForm.Size = new System.Drawing.Size(587, 163);
            this.rtb_FindForm.TabIndex = 10;
            this.rtb_FindForm.Text = "";
            // 
            // btn_close_FindForm
            // 
            this.btn_close_FindForm.Location = new System.Drawing.Point(505, 325);
            this.btn_close_FindForm.Name = "btn_close_FindForm";
            this.btn_close_FindForm.Size = new System.Drawing.Size(113, 23);
            this.btn_close_FindForm.TabIndex = 11;
            this.btn_close_FindForm.Text = "Закрыть";
            this.btn_close_FindForm.UseVisualStyleBackColor = true;
            this.btn_close_FindForm.Click += new System.EventHandler(this.btn_close_FindForm_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(31, 325);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Очистить";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_fnd_class
            // 
            this.btn_fnd_class.Location = new System.Drawing.Point(301, 56);
            this.btn_fnd_class.Name = "btn_fnd_class";
            this.btn_fnd_class.Size = new System.Drawing.Size(235, 23);
            this.btn_fnd_class.TabIndex = 13;
            this.btn_fnd_class.Text = "Поиск по классу";
            this.btn_fnd_class.UseVisualStyleBackColor = true;
            this.btn_fnd_class.Click += new System.EventHandler(this.btn_fnd_class_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortedByToolStripMenuItem,
            this.saveToXMLToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // sortedByToolStripMenuItem
            // 
            this.sortedByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.classToolStripMenuItem,
            this.areaToolStripMenuItem});
            this.sortedByToolStripMenuItem.Name = "sortedByToolStripMenuItem";
            this.sortedByToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sortedByToolStripMenuItem.Text = "Sorted by ...";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.nameToolStripMenuItem.Text = "Name";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // classToolStripMenuItem
            // 
            this.classToolStripMenuItem.Name = "classToolStripMenuItem";
            this.classToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.classToolStripMenuItem.Text = "Cost";
            this.classToolStripMenuItem.Click += new System.EventHandler(this.classToolStripMenuItem_Click);
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.areaToolStripMenuItem.Text = "Age";
            this.areaToolStripMenuItem.Click += new System.EventHandler(this.areaToolStripMenuItem_Click);
            // 
            // saveToXMLToolStripMenuItem
            // 
            this.saveToXMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.sortedByToolStripMenuItem1});
            this.saveToXMLToolStripMenuItem.Name = "saveToXMLToolStripMenuItem";
            this.saveToXMLToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveToXMLToolStripMenuItem.Text = "Save to XML";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // sortedByToolStripMenuItem1
            // 
            this.sortedByToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem1,
            this.costToolStripMenuItem,
            this.ageToolStripMenuItem});
            this.sortedByToolStripMenuItem1.Name = "sortedByToolStripMenuItem1";
            this.sortedByToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.sortedByToolStripMenuItem1.Text = "Sorted by...";
            // 
            // nameToolStripMenuItem1
            // 
            this.nameToolStripMenuItem1.Name = "nameToolStripMenuItem1";
            this.nameToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.nameToolStripMenuItem1.Text = "Name";
            this.nameToolStripMenuItem1.Click += new System.EventHandler(this.nameToolStripMenuItem1_Click);
            // 
            // costToolStripMenuItem
            // 
            this.costToolStripMenuItem.Name = "costToolStripMenuItem";
            this.costToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.costToolStripMenuItem.Text = "Cost";
            this.costToolStripMenuItem.Click += new System.EventHandler(this.costToolStripMenuItem_Click);
            // 
            // ageToolStripMenuItem
            // 
            this.ageToolStripMenuItem.Name = "ageToolStripMenuItem";
            this.ageToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.ageToolStripMenuItem.Text = "Age";
            this.ageToolStripMenuItem.Click += new System.EventHandler(this.ageToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // regexFound
            // 
            this.regexFound.Location = new System.Drawing.Point(301, 87);
            this.regexFound.Name = "regexFound";
            this.regexFound.Size = new System.Drawing.Size(235, 23);
            this.regexFound.TabIndex = 15;
            this.regexFound.Text = "Регулярные выражения";
            this.regexFound.UseVisualStyleBackColor = true;
            this.regexFound.Click += new System.EventHandler(this.regexFound_Click);
            // 
            // FormFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(650, 357);
            this.Controls.Add(this.regexFound);
            this.Controls.Add(this.btn_fnd_class);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_close_FindForm);
            this.Controls.Add(this.rtb_FindForm);
            this.Controls.Add(this.lb_search_fail);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.k);
            this.Controls.Add(this.tb_continent_fnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fnd_class_tb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(666, 396);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(666, 396);
            this.Name = "FormFind";
            this.Text = "Поиск";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fnd_class_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_continent_fnd;
        private System.Windows.Forms.Button k;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lb_search_fail;
        private System.Windows.Forms.RichTextBox rtb_FindForm;
        private System.Windows.Forms.Button btn_close_FindForm;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_fnd_class;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortedByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortedByToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem costToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ageToolStripMenuItem;
        private System.Windows.Forms.Button regexFound;
    }
}