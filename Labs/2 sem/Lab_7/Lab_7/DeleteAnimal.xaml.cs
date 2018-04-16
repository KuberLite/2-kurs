using System;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Windows;
using System.Configuration;

namespace Lab_7
{
    /// <summary>
    /// Логика взаимодействия для DeleteAnimal.xaml
    /// </summary>
    public partial class DeleteAnimal : Window
    {
        string sqlConnection;
        SqlCommand sqlCommand;
        public DeleteAnimal()
        {
            InitializeComponent();
            sqlConnection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void delAnimal_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(sqlConnection);
            try
            {
                string sqlQuery = "delete from Animals where Id=" + Convert.ToInt32(animalId.Text) + "";
                if (sqlCon.State != ConnectionState.Open) sqlCon.Open();
                sqlCommand = new SqlCommand(sqlQuery, sqlCon);
                int x = sqlCommand.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show(x.ToString() + " record(s) delete.");
            }
            catch (Exception ex)
            {
                sqlCon.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
