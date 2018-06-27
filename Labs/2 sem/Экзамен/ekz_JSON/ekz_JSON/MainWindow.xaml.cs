using System;
using System.Collections.Generic;
using System.Windows;
using System.Runtime.Serialization.Json;
using System.IO;

namespace ekz_JSON
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string path;
            Department department;
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Department));
            path = @"D:\2 kurs\2 sem\OOP\Экзамен\ekz_JSON\ekz_JSON\bin\Debug\department.txt";
            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                department = (Department)jsonFormatter.ReadObject(stream);
            }
            int year = -1;
            bool result = Int32.TryParse(this.Year.Text, out year);
            if (result)
            {
                foreach (Student s in department.student)
                {
                    if (2018 - year == Convert.ToInt32(s._age))
                    {
                        this.Info.Text += s._age + " " + s._group + " " + s._age + "\n";
                    }
                }
            }
            else
            {
                MessageBox.Show("Проверьте правильность введения числа года");
            }
        }
    }
}
