using System.Windows;

namespace Lab_10
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new BankViewModel();
        }
    }
}
