using Microsoft.Win32;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.IO;
using System.Configuration;

namespace Lab_7
{
    public partial class AddAnimal : Window
    {
        string sqlConnection;
        string imagePath = "";
        SqlCommand sqlCommand;
        public AddAnimal()
        {
            InitializeComponent();
            sqlConnection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void addAnimal_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(sqlConnection);
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fs);
                img = binaryReader.ReadBytes((int)fs.Length);
                string sqlQuery = "insert into Animals (nameAnimal, classAnimal, age, receiptDate, curator, image) values ('" + animalName.Text + "','" + animalClass.Text + "','" + animalAge.Text + "','" + animalReceiptDate.Text + "','" + animalNameCurator.Text + "', @img)";
                if (sqlCon.State != ConnectionState.Open) sqlCon.Open();
                sqlCommand = new SqlCommand(sqlQuery, sqlCon);
                sqlCommand.Parameters.AddWithValue("", animalClass.Text.Trim());
                sqlCommand.Parameters.Add(new SqlParameter("@img", img));
                int x = sqlCommand.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show(x.ToString() + " record(s) saved.");
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

