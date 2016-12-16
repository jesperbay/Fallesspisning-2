using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.ViewManagement;

namespace Footap
{
    class OpgaverVm : INotifyPropertyChanged
    {

        public string Name { get; set; }
        public string Job { get; set; }
        public ObservableCollection<Opgaverne> Opgavernes { get; set; }
        public int Alder { get; set; }
        public int HusNr { get; set; }
        public OpgaverVm()
        {
            Opgavernes = new ObservableCollection<Opgaverne>();
            Opgavernes.Add(new Opgaverne("Chefkok"));
            Opgavernes.Add(new Opgaverne("Kok"));
            Opgavernes.Add(new Opgaverne("opvasker"));
            Name = "opgaver";
            Opgavernes.Add(new Opgaverne(Job));
        }

        //public BeborereVm()
        //{
        //    AddOpgaverCommand = new RelayCommand(Add);
        //    RemoveBeborerCommand = new RelayCommand(Remove);
        //    GetBeborerCommand = new RelayCommand(LoadBeboreres);
        //    SaveBeborerCommand = new RelayCommand(SaveBeboreres);
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        public void Add(string name, string job)
        {
            Opgavernes.Add(new Opgaverne(name, job));
        }

       

    }
}
