using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    class Prilog
    {
        private int id_prilog;
        private string naziv;
        private double cena;

        public Prilog() { }
        public Prilog(int id_prilog, string naziv, double cena)
        {
            this.id_prilog = id_prilog;
            this.naziv = naziv;
            this.cena = cena;
        }

        public int Id_prilog { get => id_prilog; set => id_prilog = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public double Cena { get => cena; set => cena = value; }
    }
}
