using laba_12.AbstractFactory;
using laba_12.Builder;
using laba_12.prototype;
using laba_12.Singleton;
using System;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;


namespace laba_12
{
    
    public partial class MainWindow : Window
    {
        int count;
        

        public MainWindow()
        {
            InitializeComponent();
            Show();
        }

        private void CreateCircle_Click(object sender, RoutedEventArgs e)
        {
            NewObject circle = new NewObject(new DrawCircle());
            circle.draw();
            count++;
            Console_Txb.Text ="Всего объектов: "+count.ToString();
        }

        private void CreateRect_Click(object sender, RoutedEventArgs e)
        {
            NewObject rect = new NewObject(new DrawRect());
            rect.draw();
            count++;
            Console_Txb.Text = "Всего объектов: " +count.ToString();
        }

        private void CreateRhombus_Click(object sender, RoutedEventArgs e)
        {
            Rhombus rhomb = new Rhombus();
            rhomb.Launch(Rhomb_Txb.Text);
            MessageBox.Show("Добавлен объект с именем:"+rhomb.Nameobject.Name);
          
            
        }
       
        private void AddBuilder_Click(object sender, RoutedEventArgs e)
        {
            Baker baker = new Baker();
  
            BreadBuilder builder = new RyeBreadBuilder();
            // выпекаем
            Bread ryeBread = baker.Bake(builder);
            list_txb.Text = ryeBread.ToString();
            count++;
            Console_Txb.Text = count.ToString();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IFigure figure = new prototype.Rectangle(30, 40);
            count++;
            IFigure clonedFigure = figure.Clone();
            count++;
            figure.GetInfo();
            clonedFigure.GetInfo();

            figure = new prototype.Circle(30);
            count++;
            clonedFigure = figure.Clone();
            count++;
            figure.GetInfo();
            clonedFigure.GetInfo();
            Console_Txb.Text = count.ToString();
        }
    }
}
