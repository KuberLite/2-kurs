using Lab_13.Command;
using Lab_13.Memento;
using Lab_13.State;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Lab_13
{
    
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
        Hero hero = new Hero(State.State.Jump);

        
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

        internal Hero Hero { get => Hero1; set => Hero1 = value; }
        internal Hero Hero1 { get => hero; set => hero = value; }

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

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.A)
            {
                JumpCommand jump = new JumpCommand();
                jump.Move();
            }
           else if (e.Key == Key.S)
            {
                RunCommand run = new RunCommand();
                run.Move();
            }
           else if (e.Key == Key.D)
            {
                SwimCommand swim = new SwimCommand();
                swim.Move();
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           
            Hero.StartFromJump();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
            Hero.StartFromSwim();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Heros hero = new Heros();
            hero.Shoot(); 
            GameHistory game = new GameHistory();
            game.History.Push(hero.SaveState());
            hero.Shoot();
            hero.RestoreState(game.History.Pop());
            hero.Shoot(); 
        }

        private void canvasPanel_KeyDown(object sender, KeyEventArgs e)
        {
            
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