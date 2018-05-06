using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lab_10
{
    public class Deposit : INotifyPropertyChanged
    {
        private int numberDeposit;
        private int sum;
        private string currency;

        public int NumberDeposit
        {
            get { return numberDeposit; }
            set
            {
                numberDeposit = value;
                OnPropertyChanged("NumberDeposit");
            }
        }

        public int Sum
        {
            get { return sum; }
            set
            {
                sum = value;
                OnPropertyChanged("Sum");
            }
        }

        public string Currency
        {
            get { return currency; }
            set
            {
                currency = value;
                OnPropertyChanged("Currency");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}