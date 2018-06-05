using laba_12.AbstractFactory;
using laba_12.Builder;
using laba_12.prototype;
using laba_12.Singleton;
using System.Windows;


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
            circle.draw(list_txb);
            count++;
            Console_Txb.Text = "Count of object: " + count.ToString();
        }

        private void CreateRect_Click(object sender, RoutedEventArgs e)
        {
            NewObject rect = new NewObject(new DrawRect());
            rect.draw(list_txb);
            count++;
            Console_Txb.Text = "Count of object: " + count.ToString();
        }

        private void CreateRhombus_Click(object sender, RoutedEventArgs e)
        {
            Rhombus rhomb = new Rhombus();
            rhomb.Launch(Rhomb_Txb.Text);
            list_txb.Text = "Create object: " + rhomb.Nameobject.Name;
            count++;
            Console_Txb.Text = "Count of object: " + count.ToString();
        }
       
        private void AddBuilder_Click(object sender, RoutedEventArgs e)
        {
            Baker baker = new Baker();
            BreadBuilder builder = new RyeBreadBuilder();
            Bread ryeBread = baker.Bake(builder);
            list_txb.Text = ryeBread.ToString();
            count++;
            Console_Txb.Text = "Count of object: " + count.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IFigure figure = new prototype.Rectangle(30, 40);
            count++;
            IFigure clonedFigure = figure.Clone();
            count++;
            figure.GetInfo(list_txb);
            clonedFigure.GetInfo(list_txb);

            figure = new prototype.Circle(30);
            count++;
            clonedFigure = figure.Clone();
            count++;
            figure.GetInfo(list_txb);
            clonedFigure.GetInfo(list_txb);
            Console_Txb.Text = count.ToString();
        }
    }
}
