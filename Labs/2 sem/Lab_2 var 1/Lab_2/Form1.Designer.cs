namespace Lab_2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.surname_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.spec = new System.Windows.Forms.ComboBox();
            this.kurs = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groups = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.average_tb = new System.Windows.Forms.TextBox();
            this.btn_in_XML = new System.Windows.Forms.Button();
            this.btn_out_XML = new System.Windows.Forms.Button();
            this.radio_M = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.radio_J = new System.Windows.Forms.RadioButton();
            this.ERROR = new System.Windows.Forms.ErrorProvider(this.components);
            this.date_birthday = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.l_town = new System.Windows.Forms.Label();
            this.town_tb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.index_tb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.street_tb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.house_tb = new System.Windows.Forms.TextBox();
            this.flat_tb = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.company_tb = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.role_tb = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.experience_tb = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERROR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(16, 29);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(190, 20);
            this.name_tb.TabIndex = 1;
            this.name_tb.TextChanged += new System.EventHandler(this.name_tb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Фамилия:";
            // 
            // surname_tb
            // 
            this.surname_tb.Location = new System.Drawing.Point(16, 71);
            this.surname_tb.Name = "surname_tb";
            this.surname_tb.Size = new System.Drawing.Size(190, 20);
            this.surname_tb.TabIndex = 1;
            this.surname_tb.TextChanged += new System.EventHandler(this.surname_tb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Описание:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата поступления:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Специальность:";
            // 
            // spec
            // 
            this.spec.FormattingEnabled = true;
            this.spec.Items.AddRange(new object[] {
            "Клоачные",
            "Сумчатые",
            "Насекомоядные ",
            "Шерстокрылы",
            "Хищные звери",
            "Непарнокрылые",
            "Парнокопытные",
            ""});
            this.spec.Location = new System.Drawing.Point(14, 218);
            this.spec.Name = "spec";
            this.spec.Size = new System.Drawing.Size(121, 21);
            this.spec.TabIndex = 5;
            this.spec.SelectedIndexChanged += new System.EventHandler(this.spec_SelectedIndexChanged);
            // 
            // kurs
            // 
            this.kurs.Location = new System.Drawing.Point(14, 260);
            this.kurs.Name = "kurs";
            this.kurs.Size = new System.Drawing.Size(120, 20);
            this.kurs.TabIndex = 6;
            this.kurs.ValueChanged += new System.EventHandler(this.kurs_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Возраст:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Группа:";
            // 
            // groups
            // 
            this.groups.Location = new System.Drawing.Point(14, 304);
            this.groups.Name = "groups";
            this.groups.Size = new System.Drawing.Size(120, 20);
            this.groups.TabIndex = 9;
            this.groups.ValueChanged += new System.EventHandler(this.groups_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Средний балл:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Тип:";
            // 
            // average_tb
            // 
            this.average_tb.Location = new System.Drawing.Point(14, 344);
            this.average_tb.Name = "average_tb";
            this.average_tb.Size = new System.Drawing.Size(191, 20);
            this.average_tb.TabIndex = 13;
            this.average_tb.TextChanged += new System.EventHandler(this.average_tb_TextChanged);
            // 
            // btn_in_XML
            // 
            this.btn_in_XML.Location = new System.Drawing.Point(502, 13);
            this.btn_in_XML.Name = "btn_in_XML";
            this.btn_in_XML.Size = new System.Drawing.Size(183, 23);
            this.btn_in_XML.TabIndex = 17;
            this.btn_in_XML.Text = "Чтение информации из XML";
            this.btn_in_XML.UseVisualStyleBackColor = true;
            this.btn_in_XML.Click += new System.EventHandler(this.btn_in_XML_Click);
            // 
            // btn_out_XML
            // 
            this.btn_out_XML.Location = new System.Drawing.Point(502, 42);
            this.btn_out_XML.Name = "btn_out_XML";
            this.btn_out_XML.Size = new System.Drawing.Size(183, 23);
            this.btn_out_XML.TabIndex = 18;
            this.btn_out_XML.Text = "Сохранение информации в XML";
            this.btn_out_XML.UseVisualStyleBackColor = true;
            this.btn_out_XML.Click += new System.EventHandler(this.btn_out_XML_Click);
            // 
            // radio_M
            // 
            this.radio_M.AutoSize = true;
            this.radio_M.Location = new System.Drawing.Point(52, 368);
            this.radio_M.Name = "radio_M";
            this.radio_M.Size = new System.Drawing.Size(34, 17);
            this.radio_M.TabIndex = 20;
            this.radio_M.TabStop = true;
            this.radio_M.Text = "M";
            this.radio_M.UseVisualStyleBackColor = true;
            this.radio_M.CheckedChanged += new System.EventHandler(this.radio_M_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Пол:";
            // 
            // radio_J
            // 
            this.radio_J.AutoSize = true;
            this.radio_J.Location = new System.Drawing.Point(93, 368);
            this.radio_J.Name = "radio_J";
            this.radio_J.Size = new System.Drawing.Size(36, 17);
            this.radio_J.TabIndex = 22;
            this.radio_J.TabStop = true;
            this.radio_J.Text = "Ж";
            this.radio_J.UseVisualStyleBackColor = true;
            this.radio_J.CheckedChanged += new System.EventHandler(this.radio_J_CheckedChanged);
            // 
            // ERROR
            // 
            this.ERROR.ContainerControl = this;
            // 
            // date_birthday
            // 
            this.date_birthday.Location = new System.Drawing.Point(15, 178);
            this.date_birthday.Name = "date_birthday";
            this.date_birthday.Size = new System.Drawing.Size(200, 20);
            this.date_birthday.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(262, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Адрес:";
            // 
            // l_town
            // 
            this.l_town.AutoSize = true;
            this.l_town.Location = new System.Drawing.Point(262, 35);
            this.l_town.Name = "l_town";
            this.l_town.Size = new System.Drawing.Size(40, 13);
            this.l_town.TabIndex = 25;
            this.l_town.Text = "Город:";
            // 
            // town_tb
            // 
            this.town_tb.Location = new System.Drawing.Point(316, 28);
            this.town_tb.Name = "town_tb";
            this.town_tb.Size = new System.Drawing.Size(100, 20);
            this.town_tb.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(262, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Индекс:";
            // 
            // index_tb
            // 
            this.index_tb.Location = new System.Drawing.Point(316, 58);
            this.index_tb.Name = "index_tb";
            this.index_tb.Size = new System.Drawing.Size(100, 20);
            this.index_tb.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(262, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Улица:";
            // 
            // street_tb
            // 
            this.street_tb.Location = new System.Drawing.Point(316, 86);
            this.street_tb.Name = "street_tb";
            this.street_tb.Size = new System.Drawing.Size(100, 20);
            this.street_tb.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(256, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Квартира:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(262, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Дом:";
            // 
            // house_tb
            // 
            this.house_tb.Location = new System.Drawing.Point(316, 112);
            this.house_tb.Name = "house_tb";
            this.house_tb.Size = new System.Drawing.Size(100, 20);
            this.house_tb.TabIndex = 33;
            // 
            // flat_tb
            // 
            this.flat_tb.Location = new System.Drawing.Point(316, 138);
            this.flat_tb.Name = "flat_tb";
            this.flat_tb.Size = new System.Drawing.Size(100, 20);
            this.flat_tb.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(259, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Работа:";
            // 
            // company_tb
            // 
            this.company_tb.Location = new System.Drawing.Point(316, 213);
            this.company_tb.Name = "company_tb";
            this.company_tb.Size = new System.Drawing.Size(100, 20);
            this.company_tb.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(249, 216);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Компания:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(242, 238);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "Должность:";
            // 
            // role_tb
            // 
            this.role_tb.Location = new System.Drawing.Point(316, 236);
            this.role_tb.Name = "role_tb";
            this.role_tb.Size = new System.Drawing.Size(100, 20);
            this.role_tb.TabIndex = 39;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(269, 265);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "Стаж:";
            // 
            // experience_tb
            // 
            this.experience_tb.Location = new System.Drawing.Point(316, 262);
            this.experience_tb.Name = "experience_tb";
            this.experience_tb.Size = new System.Drawing.Size(100, 20);
            this.experience_tb.TabIndex = 41;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(486, 94);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(218, 277);
            this.richTextBox1.TabIndex = 43;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(16, 110);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(190, 48);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 515);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.experience_tb);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.role_tb);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.company_tb);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.flat_tb);
            this.Controls.Add(this.house_tb);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.street_tb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.index_tb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.town_tb);
            this.Controls.Add(this.l_town);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.date_birthday);
            this.Controls.Add(this.radio_J);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radio_M);
            this.Controls.Add(this.btn_out_XML);
            this.Controls.Add(this.btn_in_XML);
            this.Controls.Add(this.average_tb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groups);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kurs);
            this.Controls.Add(this.spec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surname_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Объект Животное";
            ((System.ComponentModel.ISupportInitialize)(this.kurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERROR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surname_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox spec;
        private System.Windows.Forms.NumericUpDown kurs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown groups;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox average_tb;
        private System.Windows.Forms.Button btn_in_XML;
        private System.Windows.Forms.Button btn_out_XML;
        private System.Windows.Forms.RadioButton radio_M;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radio_J;
        private System.Windows.Forms.ErrorProvider ERROR;
        private System.Windows.Forms.DateTimePicker date_birthday;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox town_tb;
        private System.Windows.Forms.Label l_town;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox index_tb;
        private System.Windows.Forms.TextBox flat_tb;
        private System.Windows.Forms.TextBox house_tb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox street_tb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox experience_tb;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox role_tb;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox company_tb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

