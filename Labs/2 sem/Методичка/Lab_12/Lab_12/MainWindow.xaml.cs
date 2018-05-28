using Lab_12.AbstractFactory;
using System.Windows;
using System.Windows.Controls;

namespace Lab_12
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            FigureP figureP = new FigureP(new CircleFactory());
            figureP.Color();
            figureP.Edit();

            FigureP figure = new FigureP(new TriangleFactory());
            figure.Color();
            figure.Edit();
        }
    }

    class FigureP
    {
        private EditColor editColor;
        private EditElem editElem;
        TextBox textBox;

        public FigureP(FigureFactory factory)
        {
            editColor = factory.GetEditColor();
            editElem = factory.GetEditElem();
        }

        public void Color()
        {
            editColor.NewColor(textBox);
        }

        public void Edit()
        {
            editElem.EditElem(textBox);
        }
    }
}

