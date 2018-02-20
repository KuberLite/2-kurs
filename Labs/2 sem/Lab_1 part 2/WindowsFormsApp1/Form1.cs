using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Collection : Form
    {
        public Collection()
        {
            InitializeComponent();
        }
        private List<int> list = new List<int>();
        private Random rnd = new Random();
        
        private void btn_generation_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 1; i <= Convert.ToInt32(size_tb.Text); i++)
                {
                    list.Add(rnd.Next(10, 99));
                }
                foreach (int i in list)
                {
                    rand_coll.Text += i + "\n";
                }
            }
            catch(FormatException ex)
            {
                rand_coll.Text = ex.Message;
            }
        }

        private void btn_sorted_plus_Click(object sender, EventArgs e)
        {
            list.Sort();
            foreach (int i in list)
            {
                total_tb.Text += i + "\n";
            }
        }

        private void btn_sorted_minus_Click(object sender, EventArgs e)
        {
            var sortedMinus = from a in list
                              orderby a descending
                              select a;
            foreach(int i in sortedMinus)
            {
                total_tb.Text += i + "\n";
            }
        }

        private void rand_coll_clear_Click(object sender, EventArgs e)
        {
            rand_coll.Clear();
            list.RemoveAll(n => true);

        }

        private void total_tb_clear_Click(object sender, EventArgs e)
        {
            total_tb.Clear();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            total_tb.Text = list.Min().ToString();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            total_tb.Text = list.Max().ToString();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            IEnumerable<int> ints = list.Select(i => 1);
            foreach (int i in ints)
                total_tb.Text += i + "\n";
        }
    }
}
