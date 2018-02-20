using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Lab_2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            name_tb.Validating += name_tb_Validating;
            type_tb.Validating += surname_tb_Validating;
            receipt_date.ValueChanged += date_birthday_ValueChanged;
        }

        #region FIO
        private void name_tb_TextChanged(object sender, EventArgs e)
        {
           // total_tb.Text = String.Format("Имя: {0}", name_tb.Text);
        }

        private void surname_tb_TextChanged(object sender, EventArgs e)
        {
          //  total_tb.Text = String.Format("Фамилия: {0}", surname_tb.Text);
        }

        private void otchestvo_tb_TextChanged(object sender, EventArgs e)
        {
           // total_tb.Text = String.Format("Отчество: {0}", otchestvo_tb.Text);
        }
        #endregion

        #region Calendar
        private void date_birthday_ValueChanged(object sender, EventArgs e)
        {
            //total_tb.Text = String.Format("Дата рождения: {0}", date_birthday.Value.ToShortDateString());
        }
        #endregion

        #region Validation
        private void name_tb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(name_tb.Text))
            {
                ERROR.SetError(name_tb, "Не указано имя!");
            }
            else if (name_tb.Text.Length < 4)
            {
                ERROR.SetError(name_tb, "Слишком короткое имя!");
            }
            else
            {
                ERROR.Clear();
            }
        }

        private void surname_tb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(type_tb.Text))
            {
                ERROR.SetError(type_tb, "Не указана фамилия!");
            }
            else
            {
                ERROR.Clear();
            }
        }

        private void otchestvo_tb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(otchestvo_tb.Text))
            {
                ERROR.SetError(otchestvo_tb, "Не указано отчество!");
            }
            else
            {
                ERROR.Clear();
            }
        }



        #endregion

        #region Univer
        private void spec_SelectedIndexChanged(object sender, EventArgs e)
        {
           // total_tb.Text = String.Format("Специальность: {0}", spec.Text);
        }

        private void kurs_ValueChanged(object sender, EventArgs e)
        {
           // total_tb.Text = String.Format("Курс: {0}", kurs.Value);
        }

        private void groups_ValueChanged(object sender, EventArgs e)
        {
          //  total_tb.Text = String.Format("Группа: {0}", groups.Value);
        }

        private void average_tb_TextChanged(object sender, EventArgs e)
        {
           // total_tb.Text = String.Format("Средний балл: {0}", average_tb.Text);
        }

        #endregion

        #region Radio_button
        private void radio_J_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
            //    total_tb.Text = String.Format("Пол: {0}", radio_J.Text);
            }
        }

        private void radio_M_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
            //    total_tb.Text = String.Format("Пол: {0}", radio_M.Text);
            }
        }

        #endregion

        private string GetYESNOString(bool sex)
        {
            if (sex)
            {
                return "Да";
            }
            return "Нет";
        }

        private void btn_out_XML_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Animals));
            using (FileStream fs = new FileStream("E:\\Animals.xml", FileMode.OpenOrCreate))
            {
                Animals animals = new Animals()
                {
                    Name = this.name_tb.Text,
                    Type = this.type_tb.Text,
                    Receipt_date = this.receipt_date.Text,
                    Squad = this.combo_squad.Text,
                    Age = this.age.Value.ToString(),
                    Red_Book = GetYESNOString(this.radio_no.Checked),
                    Cost = this.cost_tb.Text,
                    Place = new Place()
                    {
                        Continent = this.continent_tb.Text,
                        Width = this.width_tb.Text,
                        Height = this.height_tb.Text,
                        District = this.district_tb.Text,
                        Area = this.area_tb.Text
                    },

                    Curator_Class = new Curator_class()
                    {
                        Surname = this.surname_tb.Text,
                        Name = this.name_curator_tb.Text,
                        Otchestvo = this.otchestvo_tb.Text,
                        Country = this.country_tb.Text
                    }

                };

                formatter.Serialize(fs, animals); 

                fs.Close();
            }
        }

        private void btn_in_XML_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("E:\\Animals.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Animals));
                Animals newAnimals = (Animals)formatter.Deserialize(fs);

                richTextBox1.Text += "Имя: " + newAnimals.Name + "\n";
                richTextBox1.Text += "Тип: " + newAnimals.Type + "\n";
                richTextBox1.Text += "Описание: " + newAnimals.Description + "\n";
                richTextBox1.Text += "Дата поступления: " + newAnimals.Receipt_date + "\n";
                richTextBox1.Text += "Отряд: " + newAnimals.Squad + "\n";
                richTextBox1.Text += "Возраст: " + newAnimals.Age + "\n";
                richTextBox1.Text += "Занесён в КГ: " + newAnimals.Red_Book + "\n";
                richTextBox1.Text += "Стоимость: " + newAnimals.Cost + "\n";
                richTextBox1.Text += "\nКуратор\n" + "Фамилия: " + newAnimals.Curator_Class.Surname + "\n";
                richTextBox1.Text += "Имя: " + newAnimals.Curator_Class.Name + "\n";
                richTextBox1.Text += "Отчество: " + newAnimals.Curator_Class.Otchestvo + "\n";
                richTextBox1.Text += "Страна: " + newAnimals.Curator_Class.Country + "\n";
                richTextBox1.Text += "\nМесто обитания\n" + "Континент: " + newAnimals.Place.Continent + "\n";
                richTextBox1.Text += "Широта: " + newAnimals.Place.Width + "\n";
                richTextBox1.Text += "Долгота: " + newAnimals.Place.Height + "\n";
                richTextBox1.Text += "Район: " + newAnimals.Place.District + "\n";
                richTextBox1.Text += "Площадь: " + newAnimals.Place.Area + "\n";

                fs.Close();
            }
            
        }

    }
}

