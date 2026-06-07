using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    public class Stavka_racuna
    {
        private int id_racuna;
        private int id_jelo;
        private int id_prilog;
        private double cenaJelo;
        private double cenaPrilog;

        public Stavka_racuna() { }
        public Stavka_racuna(int id_racuna, int id_jelo, int id_prilog, double cenaJelo, double cenaPrilog)
        {
            this.id_racuna = id_racuna;
            this.id_jelo = id_jelo;
            this.id_prilog = id_prilog;
            this.cenaJelo = cenaJelo;
            this.cenaPrilog = cenaPrilog;
        }

        public int Id_racuna { get => id_racuna; set => id_racuna = value; }
        public int Id_jelo { get => id_jelo; set => id_jelo = value; }
        public int Id_prilog { get => id_prilog; set => id_prilog = value; }
        public double CenaJelo { get => cenaJelo; set => cenaJelo = value; }
        public double CenaPrilog { get => cenaPrilog; set => cenaPrilog = value; }
    }
}
