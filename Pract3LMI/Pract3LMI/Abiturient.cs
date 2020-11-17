using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM
{
    public class Abiturient : INotifyPropertyChanged
    {
        private string name;
        private string surname;
        private string datebirth;
        private int zno;
        private double bal;
        private string school;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
                OnPropertyChanged("Surname");
            }
        }
        public string Databirth
        {
            get { return datebirth; }
            set
            {
               datebirth = value;
                OnPropertyChanged("Darabirth");
            }
        }
        public int ZNO
        {
            get { return zno; }
            set
            {
                zno = value;
                OnPropertyChanged("ZNO");
            }
        }
        public double Bal
        {
            get { return bal; }
            set
            {
                bal = value;
                OnPropertyChanged("Bal");
            }
        }
        public string School
        {
            get { return school; }
            set
            {
                school = value;
                OnPropertyChanged("School");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}