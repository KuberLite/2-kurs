using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Configuration;

namespace Lab_7
{
    public partial class MainWindow : Window
    {
        string sqlConnection;
        SqlConnection sqlCon;

        public MainWindow()
        {
            try
            {
                sqlConnection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                sqlCon = new SqlConnection(sqlConnection);
                sqlCon.Open();
            }
            catch (SqlException)
            {
                MessageBox.Show("DataBase not found!!! Creating new database. Please wait.");
                using (var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Lab_7;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = "CREATE DATABASE ExtraDB";
                    sqlConnection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExtraDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                SqlConnection sql = new SqlConnection(sqlConnection);
                sql.Open();
                string createQuery = "" +
                    "CREATE TABLE Animals" +
                    "(" +
                    "Id int NOT NULL IDENTITY(1,1)," +
                    "nameAnimal nvarchar(50)," +
                    "classAnimal nvarchar(50)," +
                    "age int," +
                    "receiptDate date," +
                    "curator nvarchar(50)," +
                    "image image" +
                    ")";
                SqlCommand sqlCommand = new SqlCommand(createQuery, sql);
                sqlCommand.ExecuteNonQuery();
                sql.Close();
            }
            finally
            {
                InitializeComponent();
            }
        }
        
        private void buttonShow_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sqlCon = new SqlConnection(sqlConnection);
                sqlCon.Open();
                string selectQuery = "select Id[id], nameAnimal[Name Animal], classAnimal[Class Animal], age[Age], receiptDate[Receipt Date], curator[Curator] from Animals";
                SqlCommand sqlCommand = new SqlCommand(selectQuery, sqlCon);
                sqlCommand.ExecuteNonQuery();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable("Animals");
                sqlDataAdapter.Fill(dt);
                animalGrid.ItemsSource = dt.DefaultView;
                sqlDataAdapter.Update(dt);
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            AddAnimal addAnimal = new AddAnimal();
            addAnimal.Show();
        }

        private void showImage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRowView = (DataRowView)animalGrid.SelectedItem;
                string sqlQuery = "select * from Animals where Id = " + dataRowView.Row.ItemArray[0] + "";
                if (sqlCon.State != ConnectionState.Open) sqlCon.Open();
                SqlCommand command = new SqlCommand(sqlQuery, sqlCon);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                byte[] img = (byte[])(reader["image"]);
                BitmapImageFromBytes(img);
                sqlCon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public BitmapImage BitmapImageFromBytes(byte[] bytes)
        {
            BitmapImage image = null;
            MemoryStream stream = null;
            try
            {
                stream = new MemoryStream(bytes);
                stream.Seek(0, SeekOrigin.Begin);
                System.Drawing.Image img = System.Drawing.Image.FromStream(stream);
                image = new BitmapImage();
                image.BeginInit();
                MemoryStream ms = new MemoryStream();
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                ms.Seek(0, SeekOrigin.Begin);
                image.StreamSource = ms;
                image.StreamSource.Seek(0, SeekOrigin.Begin);
                image.EndInit();
                forImage.Source = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                stream.Close();
                stream.Dispose();
            }
            return image;
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            EditAnimal editAnimal = new EditAnimal();
            editAnimal.Show();
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            DeleteAnimal deleteAnimal = new DeleteAnimal();
            deleteAnimal.Show();
        }

        

        private void ButtonUp_Click(object sender, RoutedEventArgs e)
        {
            animalGrid.SelectedIndex -= 1;
        }

        private void ButtonDown_Click(object sender, RoutedEventArgs e)
        {
            animalGrid.SelectedIndex +=1;
        }
    }
}