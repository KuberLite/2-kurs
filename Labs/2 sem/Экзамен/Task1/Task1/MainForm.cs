using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int[] massif= new int[11];

        private void CreateMassif()
        {
            Random random = new Random();
            for(int i = 0; i < massif.Length; i++)
            {
                massif[i] = random.Next(-100, 100);
            }
        }

        private void GetIndexListView(ListView listView)
        {
            int[] indexOf = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int b in indexOf)
            {
                listView.Items.Add(b.ToString());
            }
        }

        private void GetValueListViewValue(ListView listView)
        {
            CreateMassif();
            foreach (int a in massif)
            {
                listView.Items.Add(a.ToString());
            }
        }

        private void FillFindButton_Click(object sender, EventArgs e)
        {
            GetValueListViewValue(ElemListView);
            GetIndexListView(IndexListView);
            GetMaxElem();
        }

        private void GetMaxElem()
        {
            int max = massif.Max();
            int numberOfElem = Array.IndexOf(massif, max);
            MaxElemTextBox.Text = max.ToString();
            NumberOfMaxElemTextBox.Text = numberOfElem.ToString();
        }
    }
}
