using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Task3_2_2_
{
    public partial class MainForm : Form
    {
        ApplicationContext _context;

        public MainForm()
        {
            InitializeComponent();
            _context = new ApplicationContext();
            _context.Persons.Load();
            ResultDataGrid.DataSource = _context.Persons.Local.ToBindingList();
        }

        private void AgeButton_Click(object sender, EventArgs e)
        {
            ResultDataGrid.DataSource = _context.Persons.Select(age => new { age.Age }).ToList();            
        }

        private void NameButton_Click(object sender, EventArgs e)
        {
            ResultDataGrid.DataSource = _context.Persons.Select(name => new { name.Name }).ToList();
        }
    }
}
