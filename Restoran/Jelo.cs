using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    class Jelo
    {
        private int id_jelo;
        private string naziv;
        private double cena;

        public Jelo() { }
        public Jelo(int id_jelo, string naziv, double cena)
        {
            this.id_jelo = id_jelo;
            this.naziv = naziv;
            this.cena = cena;
        }

        public int Id_jelo { get => id_jelo; set => id_jelo = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public double Cena { get => cena; set => cena = value; }
    }
}
