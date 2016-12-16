using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footap
{
    class Opgaverne
    {
        private string opgaver;
        private string job;

        public ObservableCollection<Opgaverne> Opgavernes { get; set; }
        public string ChefKok { get; set; }
        public string Opvasker { get; set; }
        public string Kok { get; set; }
        public string Name { get; set; }

       
        public Opgaverne(ObservableCollection<Opgaverne> opgavernes, string chefKok, string opvasker, string kok, string name)
        {
            Opgavernes = opgavernes;
            ChefKok = chefKok;
            Opvasker = opvasker;
            Kok = kok;
            Name = name;
        }

        public Opgaverne(string opgaver)
        {
            this.opgaver = opgaver;
        }

        public Opgaverne(string v, string job) : this(v)
        {
            this.job = job;
        }
        
    }
}
