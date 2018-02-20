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
        List<double> save = new List<double>();
        public Form1()
        {
            InitializeComponent();
            plus_click += plus;
            multiply_click += multiply;
            minus_click += minus;
            division_click += division;
            cos_click += cos;
            sin_click += sin;
            sqrt_click += sqrt;
            save_click += check;
        }

        event EventHandler plus_click;
        event EventHandler multiply_click;
        event EventHandler minus_click;
        event EventHandler division_click;
        event EventHandler cos_click;
        event EventHandler sin_click;
        event EventHandler sqrt_click;
        event EventHandler save_click;

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if(plus_click != null)
            {
                lb_symbol.Text = btn_plus.Text;
                plus(this, EventArgs.Empty);
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (minus_click != null)
            {
                lb_symbol.Text = btn_minus.Text;
                minus(this, EventArgs.Empty);
            }
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            if (division_click != null)
            {
                lb_symbol.Text = btn_division.Text;
                division(this, EventArgs.Empty);
            }
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            if(multiply_click != null)
            {
                lb_symbol.Text = btn_mult.Text;
                multiply(this, EventArgs.Empty);
            }
        }

        private void btn_cos_Click(object sender, EventArgs e)
        {
            if(cos_click != null)
            {
                lb_symbol.Text = btn_cos.Text;
                cos(this, EventArgs.Empty);
            }
        }

        private void btn_sin_Click(object sender, EventArgs e)
        {
            if (sin_click != null)
            {
                lb_symbol.Text = btn_sin.Text;
                sin(this, EventArgs.Empty);
            }
        }

        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            if (sqrt_click != null)
            {
                lb_symbol.Text = btn_sqrt.Text;
                sqrt(this, EventArgs.Empty);
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
        public void plus(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)).ToString();
                save.Add(Convert.ToDouble(textBox4.Text));
            }
            catch (FormatException ex)
            {
                textBox4.Text = ex.Message;
            }
        }

        public void minus(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = (Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text)).ToString();
                save.Add(Convert.ToDouble(textBox4.Text));
            }
            catch (FormatException ex)
            {
                textBox4.Text = ex.Message;
            }
        }

        public void division(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)).ToString();
                save.Add(Convert.ToDouble(textBox4.Text));
            }
            catch (DivideByZeroException ex)
            {
                textBox4.Text = ex.Message;
            }
            catch (FormatException ex)
            {
                textBox4.Text = ex.Message;
            }
        }

        public void multiply(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)).ToString();
                save.Add(Convert.ToDouble(textBox4.Text));
            }
            catch (FormatException ex)
            {
                textBox4.Text = ex.Message;
            }
        }

        public void cos(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = (Math.Cos(Convert.ToDouble(textBox1.Text))).ToString();
                save.Add(Convert.ToDouble(textBox4.Text));
            }
            catch(FormatException ex)
            {
                textBox4.Text = ex.Message;
            }
        }

        public void sin(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = (Math.Sin(Convert.ToDouble(textBox1.Text))).ToString();
                save.Add(Convert.ToDouble(textBox4.Text));
            }
            catch (FormatException ex)
            {
                textBox4.Text = ex.Message;
            }
        }

        public void sqrt(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = (Math.Sqrt(Convert.ToDouble(textBox1.Text))).ToString();
                save.Add(Convert.ToDouble(textBox4.Text));
            }
            catch (FormatException ex)
            {
                textBox4.Text = ex.Message;
            }
        }

        public void check(object sender, EventArgs e)
        {
            foreach (int i in save)
            {
                save_textbox.Text += i + " ";
            }
        }
        #endregion


    }
}