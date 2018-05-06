using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lab_10
{
    public class User : INotifyPropertyChanged
    {
        private string name;
        private string gender;
        private string birthday;

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

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Gender
        {
            get { return gender; }
            set
            {
                gender = value;
                OnPropertyChanged("Gender");
            }
        }

        public string Birthday
        {
            get { return birthday; }
            set
            {
                birthday = value;
                OnPropertyChanged("Birthday");
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