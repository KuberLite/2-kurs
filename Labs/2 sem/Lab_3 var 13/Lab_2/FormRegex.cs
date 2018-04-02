using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab_2
{
    public partial class FormRegex : Form
    {
        public FormRegex()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            XDocument xDocument = XDocument.Load("E:\\Animals.xml");
            var animals = xDocument.Element("ArrayOfAnimals").Elements("Animals");
            Regex regex = new Regex(@richTextBox1.Text);
            foreach (string str in animals)
            { 
                if (regex.IsMatch(str))
                {
                    richTextBox2.Text += str + "\n\n";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            XDocument xDocument = XDocument.Load("E:\\Animals.xml");
            var animals = xDocument.Element("ArrayOfAnimals").Elements("Animals");
            Regex regex2 = new Regex(@richTextBox1.Text);
            foreach (string str in animals)
            {
                if (regex2.IsMatch(str))
                {
                    richTextBox2.Text += str + "\n\n";
                }
                //MessageBox.Show("You pressing botton");
            }
        }
    }
}
