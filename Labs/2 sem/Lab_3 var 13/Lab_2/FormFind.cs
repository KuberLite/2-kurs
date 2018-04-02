using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;

namespace Lab_2
{
    public partial class FormFind : Form
    {

        public List<string> found = new List<string>();
        Form1 f1 = new Form1();
        public FormFind()
        {
            InitializeComponent();
            searchAnimals_click += searchAnimals;
            ShowInTaskbar = false;
        }

        event EventHandler searchAnimals_click;

        private void searchAnimals(object sender, EventArgs e)
        {
            try
            {
                XDocument xDocument = XDocument.Load("E:\\Animals.xml");
                var anim = from an in xDocument.Element("ArrayOfAnimals").Elements("Animals")
                           where (an.Element("Receipt_date").Value == dateTimePicker1.Text && an.Element("Continent").Value == tb_continent_fnd.Text && an.Element("Type").Value == fnd_class_tb.Text)
                           select new Animals
                           {
                               Receipt_date = an.Element("Receipt_date").Value,
                               Continent = an.Element("Continent").Value,
                               Name = an.Element("Name").Value
                           };
                foreach (var i in anim)
                {
                    rtb_FindForm.Text += "Название: " + i.Name + "\n";
                    rtb_FindForm.Text += "Дата поступления: " + i.Receipt_date + "\n";
                    rtb_FindForm.Text += "Континент/Страна: " + i.Continent + "\n\n";
                    found.Add(i.Name);
                    found.Add(i.Receipt_date);
                    found.Add(i.Continent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            
        }

        private void btn_fnd_class_Click(object sender, EventArgs e)
        {
            try
            {
                XDocument xDocument = XDocument.Load("E:\\Animals.xml");
                var anim = from an in xDocument.Element("ArrayOfAnimals").Elements("Animals")
                           where (an.Element("Type").Value == fnd_class_tb.Text)
                           select new Animals
                           {
                               Receipt_date = an.Element("Receipt_date").Value,
                               Continent = an.Element("Continent").Value,
                               Name = an.Element("Name").Value
                           };
                foreach (var i in anim)
                {
                    rtb_FindForm.Text += "Название: " + i.Name + "\n";
                    rtb_FindForm.Text += "Дата поступления: " + i.Receipt_date + "\n";
                    rtb_FindForm.Text += "Континент/Страна: " + i.Continent + "\n\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void k_Click(object sender, EventArgs e)
        {
            if (searchAnimals_click != null)
            {
                searchAnimals(this, EventArgs.Empty);
            }
        }

        private void btn_close_FindForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rtb_FindForm.Clear();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Граховский Денис Витальевич\n\n ©KuberLite.Inc 2018 ", "About");
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XDocument xDocument = XDocument.Load("E:\\Animals.xml");
                var animals = from an2 in xDocument.Element("ArrayOfAnimals").Elements("Animals")
                              orderby an2.Element("Name").Value
                              select an2;
                foreach (XElement t in animals)
                {
                    rtb_FindForm.Text += "Название: " + t.Element("Name").Value + "\n";
                    rtb_FindForm.Text += "Класс: " + t.Element("Type").Value + "\n";
                    rtb_FindForm.Text += "ФИО куратора: " + t.Element("Surname").Value + " " + t.Element("Name_curator").Value  + "\n";
                    rtb_FindForm.Text += "Цена: " + t.Element("Cost").Value + "\n\n";
                    found.Add("Имя: " + t.Element("Name").Value);
                    found.Add("Класс: " + t.Element("Type").Value);
                    found.Add("ФИО куратора: " + t.Element("Surname").Value);
                    found.Add("Цена: " + t.Element("Cost").Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XDocument xDocument = XDocument.Load("E:\\Animals.xml");
                var animals = from an2 in xDocument.Element("ArrayOfAnimals").Elements("Animals")
                              orderby an2.Element("Cost").Value
                              select an2;
                foreach (XElement t in animals)
                {
                    rtb_FindForm.Text += "Название: " + t.Element("Name").Value + "\n";
                    rtb_FindForm.Text += "Класс: " + t.Element("Type").Value + "\n";
                    rtb_FindForm.Text += "ФИО Куратора: " + t.Element("Surname").Value + " " + t.Element("Name_curator").Value + "\n";
                    rtb_FindForm.Text += "Цена: " + t.Element("Cost").Value + "\n";
                    rtb_FindForm.Text += "Дата поступления: " + t.Element("Receipt_date").Value + "\n";
                    rtb_FindForm.Text += "Возраст: " + t.Element("Age").Value + "\n\n";
                    found.Add("Имя: " + t.Element("Name").Value);
                    found.Add("Класс: " + t.Element("Type").Value);
                    found.Add("ФИО куратора: " + t.Element("Surname").Value);
                    found.Add("Цена: " + t.Element("Cost").Value);
                    found.Add("Дата поступления: " + t.Element("Receipt_date").Value);
                    found.Add("Возраст: " + t.Element("Age").Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XDocument xDocument = XDocument.Load("E:\\Animals.xml");
                var animals = from an2 in xDocument.Element("ArrayOfAnimals").Elements("Animals")
                              orderby an2.Element("Age").Value
                              select an2;
                foreach (XElement t in animals)
                {
                    rtb_FindForm.Text += "Название: " + t.Element("Name").Value + "\n";
                    rtb_FindForm.Text += "Класс: " + t.Element("Type").Value + "\n";
                    rtb_FindForm.Text += "ФИО Куратора: " + t.Element("Surname").Value + " " + t.Element("Name_curator").Value + "\n";
                    rtb_FindForm.Text += "Цена: " + t.Element("Cost").Value + "\n";
                    rtb_FindForm.Text += "Дата поступления: " + t.Element("Receipt_date").Value + "\n";
                    rtb_FindForm.Text += "Возраст: " + t.Element("Age").Value + "\n\n";
                    found.Add("Имя: " + t.Element("Name").Value);
                    found.Add("Класс: " + t.Element("Type").Value);
                    found.Add("ФИО куратора: " + t.Element("Surname").Value);
                    found.Add("Цена: " + t.Element("Cost").Value);
                    found.Add("Дата поступления: " + t.Element("Receipt_date").Value);
                    found.Add("Возраст: " + t.Element("Age").Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<string>));
            using (FileStream fs = new FileStream("E:\\Animals_save_search.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, found);
                found.RemoveAll(n=>true);
                fs.Close();
            }
        }

        private void nameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<string>));
            using (FileStream fs = new FileStream("E:\\Animals_save_sorted_by_Name.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, found);
                found.RemoveAll(n => true);
                fs.Close();
            }
        }

        private void costToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<string>));
            using (FileStream fs = new FileStream("E:\\Animals_save_sorted_by_Cost.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, found);
                found.RemoveAll(n => true);
                fs.Close();
            }
        }

        private void ageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<string>));
            using (FileStream fs = new FileStream("E:\\Animals_save_sorted_by_Cost.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, found);
                found.RemoveAll(n => true);
                fs.Close();
            }
        }

        private void regexFound_Click(object sender, EventArgs e)
        {
            FormRegex formRegex = new FormRegex();
            formRegex.Show();
        }
    }
}
