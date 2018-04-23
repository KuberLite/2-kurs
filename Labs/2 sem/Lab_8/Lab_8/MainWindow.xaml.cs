using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows;

namespace Lab_8
{
    public partial class MainWindow : Window
    {
        DBContext dbContext;

        public MainWindow()
        {
            try
            {
                InitializeComponent();
                dbContext = new DBContext();
                dbContext.Animals.Load();
                animalsGrid.ItemsSource = dbContext.Animals.Local.ToBindingList();
                textBox.Text = null;
                textBox2.Text = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Closing += MainWindow_Closing;
        }

        private void transactionButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new DBContext())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Database.ExecuteSqlCommand(
                            @"UPDATE Animals SET Age = 5" +
                                " WHERE nameAnimal LIKE '%Cat%'"
                            );

                        var query = context.Animals.Where(p => p.age >= 5);
                        foreach (var post in query)
                        {
                            post.nameAnimal += "Sample Edit";
                        }

                        context.SaveChanges();

                        dbContextTransaction.Commit();

                        MessageBox.Show("Transaction");
                    }
                    catch (Exception)
                    {
                        dbContextTransaction.Rollback();
                        MessageBox.Show("Error");
                    }
                }
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {   
            try
            {
                if (textBox.Text != null && textBox2.Text != null)
                {
                    int qwe = Int32.Parse(textBox.Text);
                    string asd = textBox2.Text;
                    animalsGrid.ItemsSource = dbContext.Animals.Where(b => b.age == qwe).Where(a => a.nameAnimal == asd).ToList();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addButton1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text != null)
            {
                int qwe = Int32.Parse(textBox.Text);
                animalsGrid.ItemsSource = dbContext.Animals.Where(a => a.age == qwe).ToList();
                textBox.Text = null;
            }

        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            dbContext.Dispose();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            dbContext.SaveChanges();
            MessageBox.Show("OK");
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (animalsGrid.SelectedItems.Count > 0)
            {
                for(int i = 0; i < animalsGrid.SelectedItems.Count; i++)
                {
                    Animals animals = animalsGrid.SelectedItems[i] as Animals;
                    if(animals != null)
                    {
                        dbContext.Animals.Remove(animals);
                    }
                }
            }
            dbContext.SaveChanges();
        }

        private void showButton_Click(object sender, RoutedEventArgs e)
        {
            animalsGrid.ItemsSource = dbContext.Animals.Local.ToBindingList();
        }
    }
}
