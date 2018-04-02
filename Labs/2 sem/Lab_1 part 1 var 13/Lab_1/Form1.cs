using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        List<string> save = new List<string>();
        public Form1()
        {
            InitializeComponent();
            plus_click += plus;
            delete_click += delete;
            substitution_click += substitution;
            delete_index_click += delete_index;
            length_click += lengthT;
            mas_click += mas;
            save_click += check;
        }

        event EventHandler plus_click;
        event EventHandler delete_click;
        event EventHandler substitution_click;
        event EventHandler delete_index_click;
        event EventHandler length_click;
        event EventHandler mas_click;
        event EventHandler sqrt_click;
        event EventHandler save_click;

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if(plus_click != null)
            {
                plus(this, EventArgs.Empty);
            }
        }

        private void btn_substitution_Click(object sender, EventArgs e)
        {
            if (substitution_click != null)
            {
                substitution(this, EventArgs.Empty);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (delete_click != null)
            {
                delete(this, EventArgs.Empty);
            }
        }

        private void btn_delete_index_Click(object sender, EventArgs e)
        {
            if (delete_index_click != null)
            {
                delete_index(this, EventArgs.Empty);
            }
        }

        private void btn_length_Click(object sender, EventArgs e)
        {
            if (length_click != null)
            {
                lengthT(this, EventArgs.Empty);
            }
        }

        private void btn_delete_aa_Click(object sender, EventArgs e)
        {
            if (mas_click != null)
            {
                mas(this, EventArgs.Empty);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (save_click != null)
            {
                check(this, EventArgs.Empty);
            }
        }

        #region COUNT
        private void plus(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = textBox1.Text + textBox2.Text;
                save.Add(textBox4.Text);
            }
            catch (FormatException ex)
            {
                textBox4.Text = ex.Message;
            }
        }

        private void substitution(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = textBox1.Text.Replace(textBox2.Text, "NewString");
                save.Add(textBox4.Text);
            }
            catch (FormatException ex)
            {
                textBox4.Text = ex.Message;
            }
        }

        private void delete(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = textBox1.Text.Replace(textBox2.Text, "");
                save.Add(textBox4.Text);
            }
            catch (FormatException ex)
            {
                textBox4.Text = ex.Message;
            }
        }

        private void delete_index(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = textBox1.Text.Substring(Convert.ToInt32(textBox2.Text), 1);
                save.Add(textBox4.Text);
            }
            catch (FormatException ex)
            {
                textBox4.Text = ex.Message;
            }
        }

        private void lengthT(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = textBox1.Text.Length.ToString();
                save.Add(textBox4.Text);
            }
            catch (FormatException ex)
            {
                textBox4.Text = ex.Message;
            }
        }

        private void mas(object sender, EventArgs e)
        {  
            Console.WriteLine("Second string");
            string b = "AaEeiIOoyYUu";

            string res = "";
            foreach (var c in textBox1.Text)
            {
                if (b.IndexOf(c) > -1)
                    res += new string(c, 2);
                else
                    res += c;
            }
            textBox4.Text = res.ToString();
            save.Add(textBox4.Text);
        }

        public void check(object sender, EventArgs e)
        {
            foreach (string i in save)
            {
                save_textbox.Text += i + " ";
            }
        }

        #endregion

        
    }
}