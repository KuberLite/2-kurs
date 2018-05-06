using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace Lab_10
{
    public class BankViewModel : INotifyPropertyChanged
    {
        private User selectedUser;

        public ObservableCollection<User> User { get; set; }

        public ObservableCollection<Deposit> Deposit { get; set; }

        public User SelectedUser 
        {
            get { return selectedUser; }
            set
            {
                selectedUser = value;
                OnPropertyChanged("SelectedUser");
            }
        }

        public BankViewModel()
        {
            User = new ObservableCollection<User>
            {
                new User { Name = "Граховский Денис Витальевич", Gender = "мужской", Birthday = "08.03.1999", NumberDeposit = 2288996, Sum = 17322, Currency = "USD" },
                new User { Name = "Житковский Глеб Сергеевич", Gender = "мужской", Birthday = "29.04.1998", NumberDeposit = 3941487, Sum = 84989, Currency = "BYN" },
                new User { Name = "Маргинова Ольга Степановна", Gender = "женский", Birthday = "13.07.1998", NumberDeposit = 6384144, Sum = 1732298, Currency = "RUB" }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
