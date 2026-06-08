using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    public class Racun
    {
        private int id_racuna;
        private double ukupna_cena;

        public Racun() { }
        public Racun(double ukupna_cena)
        {
            this.ukupna_cena = ukupna_cena;
        }

        public int Id_racuna { get => id_racuna; set => id_racuna = value; }
        public double Ukupna_cena { get => ukupna_cena; set => ukupna_cena = value; }
    }
}
