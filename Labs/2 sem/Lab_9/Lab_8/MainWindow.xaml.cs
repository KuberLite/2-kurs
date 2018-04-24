using System;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using Lab_8.DAL.Entities;
using System.Data.Entity;
using System.Collections;
using System.Collections.Generic;
using Lab_8.DAL.Interfaces;
using Lab_8.DAL.Repositories;
using Lab_8.DAL.EF;
using System.Linq;
using System.ComponentModel;

namespace Lab_8
{
    public partial class MainWindow : Window
    {
        private readonly IUnitOfWork _database;

        public MainWindow()
        {
            try
            {
                InitializeComponent();
                _database = new UnitOfWork(new DAL.EF.DBContext());
                FillTable();

                this.Closing += MainWindow_Closing;
                textBox.Text = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillTable()
        {
            _database.context.Animals.Load();
            animalsGrid.ItemsSource = _database.context.Animals.Local.ToBindingList();
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
                string query = textBox.Text;
                Animals result = _database.AnimalRepository.Search(query);
                if (result != null)
                {
                    MessageBox.Show("Ages: " + result.age);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            _database.context.Dispose();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            _database.context.SaveChanges();
            MessageBox.Show("OK");
        }

        private List<Animals> GetSelectedAnimals(IList selectedItems)
        {
            List<Animals> animals = new List<Animals>();
            foreach (var item in selectedItems)
            {
                Animals animal = item as Animals;
                animals.Add(animal);
            }
            return animals;
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            List<Animals> animals = GetSelectedAnimals(animalsGrid.SelectedItems);
            _database.AnimalRepository.DeleteRange(animals);
        }

        private void showButton_Click(object sender, RoutedEventArgs e)
        {
            animalsGrid.ItemsSource = _database.context.Animals.Local.ToBindingList();
        }
    }
}
