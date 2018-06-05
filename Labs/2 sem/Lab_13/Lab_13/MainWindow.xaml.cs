using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Lab_13
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            map = new Map();
        }
        Square square; 
        int xPos = 123, yPos = 123, count = 0;
        Rectangle rectangle = new Rectangle();

        private void createObj_Click(object sender, RoutedEventArgs e)
        {
            if (Square.getInstance())
            {
                square = new Square();
                rectangle.Width = 65;
                rectangle.Height = 65;
                rectangle.Fill = Brushes.Black;
                rectangle.Stroke = Brushes.Blue;
                if (count == 0)
                {
                    canvasPanel.Children.Add(rectangle);
                    Canvas.SetLeft(rectangle, xPos);
                    Canvas.SetTop(rectangle, yPos);
                    count++;
                }
                ConsoleTextBox.Text = "x: " + xPos + " y: " + yPos;
            }
        }

        Map map;

        private void create2_Click(object sender, RoutedEventArgs e)
        {
            square = new Square();
            rectangle.Width = 65;
            rectangle.Height = 65;
            rectangle.Fill = Brushes.Yellow;
            rectangle.Stroke = Brushes.Black;
            if (count == 0)
            {
                canvasPanel.Children.Add(rectangle);
                Canvas.SetLeft(rectangle, xPos);
                Canvas.SetTop(rectangle, yPos);
                count++;
            }
            ConsoleTextBox.Text = "x: " + xPos + " y: " + yPos;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Square\nYellow square");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SquareAdapter adapter = new SquareAdapter(square);
            adapter.MoveAdapter();
            rectangle.Width = 65;
            rectangle.Height = 65;
            if (count == 0)
            {
                canvasPanel.Children.Add(rectangle);
                Canvas.SetLeft(rectangle, xPos);
                Canvas.SetTop(rectangle, yPos);
                count++;
            }
            yPos = xPos += 5;
            Canvas.SetLeft(rectangle, xPos);
            Canvas.SetTop(rectangle, yPos);
            ConsoleTextBox.Text = "x: " + xPos + " y: " + yPos;
        }


        private void buttonUp_Click(object sender, RoutedEventArgs e)
        {
            SquareAdapter adapter = new SquareAdapter(square);
            adapter.MoveAdapter();
            rectangle.Width = 65;
            rectangle.Height = 65;
            if (count == 0)
            {
                canvasPanel.Children.Add(rectangle);
                Canvas.SetLeft(rectangle, xPos);
                Canvas.SetTop(rectangle, yPos);
                count++;
            }
            yPos = xPos -= 5;
            Canvas.SetLeft(rectangle, xPos);
            Canvas.SetTop(rectangle, yPos);
            ConsoleTextBox.Text = "x: " + xPos + " y: " + yPos;
        }
    }
}