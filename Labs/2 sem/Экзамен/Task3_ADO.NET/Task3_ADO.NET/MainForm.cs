using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Task3_ADO.NET
{
    public partial class MainForm : Form
    {
        string connectionString = "";
        SqlDataAdapter sqlDataAdapter;
        DataTable data = new DataTable();

        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand("Select LastName, CourseNumber from [Table]", sqlConnection);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(data);
            StudentDataGridView.DataSource = data;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            sqlDataAdapter.Update(data);
            MessageBox.Show("Updated!!!");
            
        }
    }
}
