using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace MVVM
{
    public class AbitData : INotifyPropertyChanged
    {
        private Abiturient selectedAbiturient;

        public ObservableCollection<Abiturient> Abiturients { get; set; }
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      Abiturient abiturient = new Abiturient();
                      Abiturients.Insert(0, abiturient);
                      SelectedAbiturient = abiturient;
                  }));
            }
        }
        public Abiturient SelectedAbiturient
        {
            get { return selectedAbiturient; }
            set
            {
                selectedAbiturient = value;
                OnPropertyChanged("SelectedAbiturient");
            }
        }

        public AbitData()
        {
            Abiturients = new ObservableCollection<Abiturient>
            {
                new Abiturient {Name="Олег", Surname="Бахматюк", Databirth="10.02.2002", ZNO=140, Bal=6.7, School="Школа номер 3" },
                new Abiturient {Name="Оксана", Surname="Семенюк", Databirth ="03.07.2001", ZNO=156, Bal=8, School="Педагогічний коледж" },
                new Abiturient {Name="В'ячеслав", Surname="Знамеровський", Databirth="22.11.2001", ZNO=128, Bal=5.2, School="14 Училище" },
                new Abiturient {Name="Аліна", Surname="Крайдуба", Databirth="30.05.2002", ZNO=162, Bal=10.1, School="Гімназія" }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}