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
            this.type_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.squad = new System.Windows.Forms.Label();
            this.combo_squad = new System.Windows.Forms.ComboBox();
            this.age = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cost_tb = new System.Windows.Forms.TextBox();
            this.btn_in_XML = new System.Windows.Forms.Button();
            this.btn_out_XML = new System.Windows.Forms.Button();
            this.radio_no = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.radio_yes = new System.Windows.Forms.RadioButton();
            this.ERROR = new System.Windows.Forms.ErrorProvider(this.components);
            this.receipt_date = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.l_town = new System.Windows.Forms.Label();
            this.continent_tb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.width_tb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.height_tb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.district_tb = new System.Windows.Forms.TextBox();
            this.area_tb = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.surname_tb = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.name_curator_tb = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.otchestvo_tb = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.description_rtb = new System.Windows.Forms.RichTextBox();
            this.country_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
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
            // type_tb
            // 
            this.type_tb.Location = new System.Drawing.Point(16, 71);
            this.type_tb.Name = "type_tb";
            this.type_tb.Size = new System.Drawing.Size(190, 20);
            this.type_tb.TabIndex = 1;
            this.type_tb.TextChanged += new System.EventHandler(this.surname_tb_TextChanged);
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
            // squad
            // 
            this.squad.AutoSize = true;
            this.squad.Location = new System.Drawing.Point(13, 201);
            this.squad.Name = "squad";
            this.squad.Size = new System.Drawing.Size(41, 13);
            this.squad.TabIndex = 4;
            this.squad.Text = "Отряд:";
            // 
            // combo_squad
            // 
            this.combo_squad.FormattingEnabled = true;
            this.combo_squad.Items.AddRange(new object[] {
            "Клоачные",
            "Сумчатые",
            "Насекомоядные ",
            "Шерстокрылы",
            "Хищные звери",
            "Непарнокрылые",
            "Парнокопытные",
            ""});
            this.combo_squad.Location = new System.Drawing.Point(14, 218);
            this.combo_squad.Name = "combo_squad";
            this.combo_squad.Size = new System.Drawing.Size(121, 21);
            this.combo_squad.TabIndex = 5;
            this.combo_squad.SelectedIndexChanged += new System.EventHandler(this.spec_SelectedIndexChanged);
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(14, 260);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(120, 20);
            this.age.TabIndex = 6;
            this.age.ValueChanged += new System.EventHandler(this.kurs_ValueChanged);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Стоимость:";
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
            // cost_tb
            // 
            this.cost_tb.Location = new System.Drawing.Point(14, 340);
            this.cost_tb.Name = "cost_tb";
            this.cost_tb.Size = new System.Drawing.Size(191, 20);
            this.cost_tb.TabIndex = 13;
            this.cost_tb.TextChanged += new System.EventHandler(this.average_tb_TextChanged);
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
            // radio_no
            // 
            this.radio_no.AutoSize = true;
            this.radio_no.Location = new System.Drawing.Point(59, 299);
            this.radio_no.Name = "radio_no";
            this.radio_no.Size = new System.Drawing.Size(44, 17);
            this.radio_no.TabIndex = 20;
            this.radio_no.TabStop = true;
            this.radio_no.Text = "Нет";
            this.radio_no.UseVisualStyleBackColor = true;
            this.radio_no.CheckedChanged += new System.EventHandler(this.radio_M_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Занесён в красную книгу:";
            // 
            // radio_yes
            // 
            this.radio_yes.AutoSize = true;
            this.radio_yes.Location = new System.Drawing.Point(17, 299);
            this.radio_yes.Name = "radio_yes";
            this.radio_yes.Size = new System.Drawing.Size(40, 17);
            this.radio_yes.TabIndex = 22;
            this.radio_yes.TabStop = true;
            this.radio_yes.Text = "Да";
            this.radio_yes.UseVisualStyleBackColor = true;
            this.radio_yes.CheckedChanged += new System.EventHandler(this.radio_J_CheckedChanged);
            // 
            // ERROR
            // 
            this.ERROR.ContainerControl = this;
            // 
            // receipt_date
            // 
            this.receipt_date.Location = new System.Drawing.Point(15, 178);
            this.receipt_date.Name = "receipt_date";
            this.receipt_date.Size = new System.Drawing.Size(200, 20);
            this.receipt_date.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(262, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Место обитания:";
            // 
            // l_town
            // 
            this.l_town.AutoSize = true;
            this.l_town.Location = new System.Drawing.Point(262, 35);
            this.l_town.Name = "l_town";
            this.l_town.Size = new System.Drawing.Size(63, 13);
            this.l_town.TabIndex = 25;
            this.l_town.Text = "Континент:";
            // 
            // continent_tb
            // 
            this.continent_tb.Location = new System.Drawing.Point(331, 28);
            this.continent_tb.Name = "continent_tb";
            this.continent_tb.Size = new System.Drawing.Size(100, 20);
            this.continent_tb.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(262, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Широта:";
            // 
            // width_tb
            // 
            this.width_tb.Location = new System.Drawing.Point(331, 53);
            this.width_tb.Name = "width_tb";
            this.width_tb.Size = new System.Drawing.Size(100, 20);
            this.width_tb.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(262, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Долгота:";
            // 
            // height_tb
            // 
            this.height_tb.Location = new System.Drawing.Point(331, 79);
            this.height_tb.Name = "height_tb";
            this.height_tb.Size = new System.Drawing.Size(100, 20);
            this.height_tb.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(262, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Площадь:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(262, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Район:";
            // 
            // district_tb
            // 
            this.district_tb.Location = new System.Drawing.Point(331, 105);
            this.district_tb.Name = "district_tb";
            this.district_tb.Size = new System.Drawing.Size(100, 20);
            this.district_tb.TabIndex = 33;
            // 
            // area_tb
            // 
            this.area_tb.Location = new System.Drawing.Point(331, 131);
            this.area_tb.Name = "area_tb";
            this.area_tb.Size = new System.Drawing.Size(100, 20);
            this.area_tb.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(262, 178);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Куратор:";
            // 
            // surname_tb
            // 
            this.surname_tb.Location = new System.Drawing.Point(331, 201);
            this.surname_tb.Name = "surname_tb";
            this.surname_tb.Size = new System.Drawing.Size(100, 20);
            this.surname_tb.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(262, 204);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Фамилия:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(262, 230);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "Имя:";
            // 
            // name_curator_tb
            // 
            this.name_curator_tb.Location = new System.Drawing.Point(331, 227);
            this.name_curator_tb.Name = "name_curator_tb";
            this.name_curator_tb.Size = new System.Drawing.Size(100, 20);
            this.name_curator_tb.TabIndex = 39;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(262, 256);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "Отчество:";
            // 
            // otchestvo_tb
            // 
            this.otchestvo_tb.Location = new System.Drawing.Point(331, 253);
            this.otchestvo_tb.Name = "otchestvo_tb";
            this.otchestvo_tb.Size = new System.Drawing.Size(100, 20);
            this.otchestvo_tb.TabIndex = 41;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(486, 94);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(218, 322);
            this.richTextBox1.TabIndex = 43;
            this.richTextBox1.Text = "";
            // 
            // description_rtb
            // 
            this.description_rtb.Location = new System.Drawing.Point(16, 110);
            this.description_rtb.Name = "description_rtb";
            this.description_rtb.Size = new System.Drawing.Size(190, 48);
            this.description_rtb.TabIndex = 0;
            this.description_rtb.Text = "";
            // 
            // country_tb
            // 
            this.country_tb.Location = new System.Drawing.Point(331, 283);
            this.country_tb.Name = "country_tb";
            this.country_tb.Size = new System.Drawing.Size(100, 20);
            this.country_tb.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Страна:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 427);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.country_tb);
            this.Controls.Add(this.description_rtb);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.otchestvo_tb);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.name_curator_tb);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.surname_tb);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.area_tb);
            this.Controls.Add(this.district_tb);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.height_tb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.width_tb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.continent_tb);
            this.Controls.Add(this.l_town);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.receipt_date);
            this.Controls.Add(this.radio_yes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radio_no);
            this.Controls.Add(this.btn_out_XML);
            this.Controls.Add(this.btn_in_XML);
            this.Controls.Add(this.cost_tb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.age);
            this.Controls.Add(this.combo_squad);
            this.Controls.Add(this.squad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.type_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Объект Животное";
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERROR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox type_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label squad;
        private System.Windows.Forms.ComboBox combo_squad;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cost_tb;
        private System.Windows.Forms.Button btn_in_XML;
        private System.Windows.Forms.Button btn_out_XML;
        private System.Windows.Forms.RadioButton radio_no;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radio_yes;
        private System.Windows.Forms.ErrorProvider ERROR;
        private System.Windows.Forms.DateTimePicker receipt_date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox continent_tb;
        private System.Windows.Forms.Label l_town;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox width_tb;
        private System.Windows.Forms.TextBox area_tb;
        private System.Windows.Forms.TextBox district_tb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox height_tb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox otchestvo_tb;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox name_curator_tb;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox surname_tb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox description_rtb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox country_tb;
    }
}

