using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task1_3_2_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ConfirmPassord()
        {
            Regex regex = new Regex(@"^((?=.*\d)(?=.*[a-z])(?=.*[@#$%]).{6,12})");
            MatchCollection matches = regex.Matches(PassTextBox.Text.Trim());
            if (matches.Count > 0)
            {
                label1.Text = "OK";
            }
            else
            {
                label1.Text = "not ok";
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            ConfirmPassord();
            if (PassTextBox.Text == ConfirmPassTextBox.Text) MessageBox.Show("Good");
            else MessageBox.Show("Not good");
            
        }
    }
}
