using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    public class Pripadnost
    {
        private int id_jelo;
        private int id_prilog;

        public Pripadnost() { }
        public Pripadnost(int id_jelo, int id_prilog)
        {
            this.id_jelo = id_jelo;
            this.id_prilog = id_prilog;
        }

        public int Id_jelo { get => id_jelo; set => id_jelo = value; }
        public int Id_prilog { get => id_prilog; set => id_prilog = value; }
    }
}
