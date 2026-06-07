using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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

            Podaci.PopuniCb(cb_naziv_jela, "Jelo", "naziv");
            Podaci.PopuniCb(cb_naziv_priloga, "Prilog", "naziv");
        }

        private void btn_filtriraj_Click(object sender, EventArgs e)
        {
            string putanja = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Restoran.accdb;";

            string jela = "select j.naziv, j.cena from Jelo j where 1=1";
            string prilozi = @"select p.naziv, p.cena
                               from (Prilog p left join Pripadnost pr
                               on p.id_prilog = pr.id_prilog)
                               left join Jelo j
                               on pr.id_jelo = j.id_jelo
                               where 1=1";

            if (trackBar1.Value > trackBar2.Value)
            {
                MessageBox.Show("Morate uneti validan opseg cene jela.", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            if (cb_naziv_jela.SelectedIndex != -1)
            {
                jela += " and j.naziv = ?";
                prilozi += " and j.naziv = ?";
            }

            if (trackBar1.Value != trackBar2.Value)
            {
                jela += " and j.cena between ? and ?";
                prilozi += " and j.cena between ? and ?";
            }

            if (cb_naziv_priloga.SelectedIndex != -1)
            {
                jela = @"select j.naziv, j.cena 
                         from (Jelo j left join Pripadnost pr
                         on j.id_jelo = pr.id_jelo)
                         left join Prilog p
                         on pr.id_prilog = p.id_prilog
                         where 1=1
                         and p.naziv = ?";

                prilozi = "select p.naziv, p.cena from Prilog p where 1=1 and p.naziv = ?";
            }


            using (OleDbConnection konekcija = new OleDbConnection(putanja))
            using (OleDbCommand komanda_jela = new OleDbCommand(jela, konekcija))
            using (OleDbCommand komanda_prilozi = new OleDbCommand(prilozi, konekcija))
            {
                if (cb_naziv_jela.SelectedIndex != -1 && cb_naziv_priloga.SelectedIndex == -1)
                {
                    komanda_jela.Parameters.AddWithValue("?", cb_naziv_jela.Text);
                    komanda_prilozi.Parameters.AddWithValue("?", cb_naziv_jela.Text);
                }

                if (trackBar1.Value != trackBar2.Value && cb_naziv_priloga.SelectedIndex == -1)
                {
                    komanda_jela.Parameters.AddWithValue("?", trackBar1.Value);
                    komanda_jela.Parameters.AddWithValue("?", trackBar2.Value);

                    komanda_prilozi.Parameters.AddWithValue("?", trackBar1.Value);
                    komanda_prilozi.Parameters.AddWithValue("?", trackBar2.Value);
                }

                if (cb_naziv_priloga.SelectedIndex != -1)
                {
                    komanda_jela.Parameters.AddWithValue("?", cb_naziv_priloga.Text);
                    komanda_prilozi.Parameters.AddWithValue("?", cb_naziv_priloga.Text);
                }

                OleDbDataAdapter da1 = new OleDbDataAdapter(komanda_jela);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);

                OleDbDataAdapter da2 = new OleDbDataAdapter(komanda_prilozi);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);

                gridview_jela.DataSource = dt1;
                gridview_prilozi.DataSource = dt2;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbl_od.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            lbl_do.Text = trackBar2.Value.ToString();
        }
    }
}
