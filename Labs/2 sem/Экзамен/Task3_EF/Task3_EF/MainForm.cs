using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3_EF
{
    public partial class MainForm : Form
    {
        ApplicationContext _context;

        public MainForm()
        {
            InitializeComponent();
            _context = new ApplicationContext();
            _context.Students.Load();
            StudentDataGridView.DataSource = _context.Students.Local.ToBindingList();
            StudentDataGridView.DataSource = _context.Students.Select(i => new { i.SecondName, i.CourseNumber }).ToList();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
        }


    }
}
