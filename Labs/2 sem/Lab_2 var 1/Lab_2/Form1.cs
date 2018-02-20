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
        //XmlSerializer xs;

        //List<Student> ls;
        public Form1()
        {
            InitializeComponent();
            name_tb.Validating += name_tb_Validating;
            surname_tb.Validating += surname_tb_Validating;
            otchestvo_tb.Validating += otchestvo_tb_Validating;
            date_birthday.ValueChanged += date_birthday_ValueChanged;

            //ls = new List<Student>();
            //xs = new XmlSerializer(typeof(List<Student>));
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
            if (String.IsNullOrEmpty(surname_tb.Text))
            {
                ERROR.SetError(surname_tb, "Не указана фамилия!");
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

        private string GetSexString(bool sex)
        {
            if (sex)
            {
                return "Мужчина";
            }
            return "Женщина";
        }

        private void btn_out_XML_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Student));
            using (FileStream fs = new FileStream("E:\\Student.xml", FileMode.OpenOrCreate))
            {
                Student student = new Student()
                { 
                    Name = this.name_tb.Text,
                    Surname = this.surname_tb.Text,
                    Otchestvo = this.otchestvo_tb.Text,
                    Date_birthday = this.date_birthday.Text,
                    Spec = this.spec.Text,
                    Course = this.kurs.Value.ToString(),
                    Group = this.groups.Value.ToString(),
                    Sex = GetSexString(this.radio_M.Checked),
                    Adress = new Adress()
                    {
                        City = this.town_tb.Text,
                        Index = this.index_tb.Text,
                        Street = this.street_tb.Text,
                        House = this.house_tb.Text,
                        Flat = this.flat_tb.Text
                    },

                    CurrentWork = new CurrentWork()
                    {
                        Company = this.company_tb.Text,
                        Role = this.role_tb.Text,
                        Experience = this.experience_tb.Text
                    }

                };

                formatter.Serialize(fs, student); 

                fs.Close();
            }
        }

        private void btn_in_XML_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("E:\\Student.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Student));
                Student newStudent = (Student)formatter.Deserialize(fs);

                richTextBox1.Text += "Имя: " + newStudent.Name + "\n";
                richTextBox1.Text += "Фамилия: " + newStudent.Surname + "\n";
                richTextBox1.Text += "Отчество: " + newStudent.Otchestvo + "\n";
                richTextBox1.Text += "Дата рождения: " + newStudent.Date_birthday + "\n";
                richTextBox1.Text += "Адрес: " + newStudent.Adress.City + "\n";
                richTextBox1.Text += "Специальность: " + newStudent.Spec + "\n";
                richTextBox1.Text += "Курс: " + newStudent.Course + "\n";
                richTextBox1.Text += "Группа: " + newStudent.Group + "\n";
                richTextBox1.Text += "Средний балл: " + newStudent.Average_mark + "\n";
                richTextBox1.Text += "Пол: " + newStudent.Sex + "\n";
                richTextBox1.Text += "Адрес\n" + "Город: " + newStudent.Adress.City + "\n";
                richTextBox1.Text += "Индекс: " + newStudent.Adress.Index + "\n";
                richTextBox1.Text += "Улица: " + newStudent.Adress.Street + "\n";
                richTextBox1.Text += "Дом: " + newStudent.Adress.House + "\n";
                richTextBox1.Text += "Квартира: " + newStudent.Adress.Flat + "\n";
                richTextBox1.Text += "Работа\n" + "Компания: " + newStudent.CurrentWork.Company + "\n";
                richTextBox1.Text += "Должность: " + newStudent.CurrentWork.Role + "\n";
                richTextBox1.Text += "Стаж: " + newStudent.CurrentWork.Experience + "\n";



                fs.Close();
            }
            
        }
    }
}

