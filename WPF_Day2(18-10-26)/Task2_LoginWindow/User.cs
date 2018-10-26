using System.ComponentModel;

namespace Task2_LoginWindow
{
    public class User : INotifyPropertyChanged
    {
        private string _firstname;
        public string FirstName {
            get { return _firstname; }
            set { _firstname = value;
                RaisePropertyChange("FirstName");
            }
        }

        private string _lastname;
        public event PropertyChangedEventHandler PropertyChanged;

        public string LastName {
            get { return _lastname; }
            set
            {
                _lastname = value;
                RaisePropertyChange("LastName");
            }
        }

        public void RaisePropertyChange(string propertyname) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
