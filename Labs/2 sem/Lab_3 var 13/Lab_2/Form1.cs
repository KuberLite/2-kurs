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
        Timer timer = new Timer();
        public List<Animals> listAnimals = new List<Animals>();
        public Form1()
        {
            InitializeComponent();
            name_tb.Validating += name_tb_Validating;
        }

        private void name_tb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(name_tb.Text))
            {
                ERROR.SetError(name_tb, "Не указано название!");
            }
            else if (name_tb.Text.Length < 4)
            {
                ERROR.SetError(name_tb, "Слишком короткое название!");
            }
            else
            {
                ERROR.Clear();
            }
        }
        
        string GetYESNOString(bool yes)
        {
            if (!yes)
            {
                return "Да";
            }
            return "Нет";
        }

        #region Сериализация
        private void btn_out_XML_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Animals>));
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
                    Cost = this.label_scroll.Text,
                        Continent = this.continent_tb.Text,
                        Width = this.width_tb.Text,
                        Height = this.height_tb.Text,
                        District = this.district_tb.Text,
                        Area = this.area_tb.Text,
                        Surname = this.surname_tb.Text,
                        Name_curator = this.name_curator_tb.Text,
                        Otchestvo = this.otchestvo_tb.Text,
                        Country = this.country_tb.Text
                };

                listAnimals.Add(animals);
                countObject.Text = listAnimals.Count.ToString();
                formatter.Serialize(fs, listAnimals); 

                fs.Close();
            }
        }

        private void btn_in_XML_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("E:\\Animals.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Animals>));
                listAnimals = (List<Animals>)formatter.Deserialize(fs);
                data_grid.DataSource = listAnimals;             
                fs.Close();
            }
        }
        #endregion

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 100;
            trackBar1.Maximum = 1000;
            trackBar1.TickStyle = TickStyle.BottomRight;
            label_scroll.Text = trackBar1.Value.ToString();
        }

        private void btn_closeForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Граховский Денис Витальевич\n\n ©KuberLite.Inc 2018 ", "About");
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFind formFind = new FormFind();
            formFind.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;

            string time = "";

            if (h < 10) time += "0" + h;
            else time += h;
            time += ":";

            if (m < 10) time += "0" + m;
            else time += m;
            time += ":";

            if (s < 10) time += "0" + s;
            else time += s;
            label7.Text = time;
        }

    }
}
