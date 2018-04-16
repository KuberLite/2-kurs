using Microsoft.Win32;
using System;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows;
using System.Configuration;

namespace Lab_7
{
    public partial class EditAnimal : Window
    {
        string sqlConnection;
        string imagePath = "";
        public EditAnimal()
        {
            InitializeComponent();
            sqlConnection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }


        SqlCommand sqlCommand;
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void editAnimal_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(sqlConnection);
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fs);
                img = binaryReader.ReadBytes((int)fs.Length);
                string sqlQuery = "update Animals set nameAnimal='" + animalName.Text + "', classAnimal='" + animalClass.Text + "', age='" + animalAge.Text + "', receiptDate='" + animalReceiptDate.Text + "', curator='" + animalNameCurator.Text + "', image = @img where Id=" + Convert.ToInt32(animalId.Text) + "";
                if (sqlCon.State != ConnectionState.Open) sqlCon.Open();
                sqlCommand = new SqlCommand(sqlQuery, sqlCon);
                sqlCommand.Parameters.Add(new SqlParameter("@img", img));
                int x = sqlCommand.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show(x.ToString() + " record(s) edit.");
            }
            catch (Exception ex)
            {
                sqlCon.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void loadImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "JPG Files (*.jpg)|*jpg|PNG Files (*.png)|*.png";
            openFile.Title = "Select Images for load";
            if (openFile.ShowDialog() == true)
            {
                imagePath = openFile.FileName.ToString();
                animalImage.Text = imagePath;
            }
        }
    }
}
