using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public partial class Radnik : Form
    {
        public Radnik()
        {
            InitializeComponent();
            Podaci.PopuniGrid(gridview_jela, "Jelo");
            Podaci.PopuniGrid(gridview_prilozi, "Prilog");
            Podaci.PopuniGrid(gridview_racuni, "Racun");
            Podaci.PopuniGrid(gridview_stavke_racuna, "Stavka_racuna");
        }
    }
}
