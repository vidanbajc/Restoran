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
    public partial class Meni : Form
    {
        int? id_racuna;

        List<Stavka_racuna> lista_stavke_racuna;
        string putanja = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Restoran.accdb;";
        public Meni()
        {
            InitializeComponent();
            lista_stavke_racuna = new List<Stavka_racuna>();

            gridview_jela.AutoGenerateColumns = false;
            gridview_prilozi.AutoGenerateColumns = false;

            gridview_jela.DataSource = Podaci.PopuniGrid("Jelo");
            gridview_prilozi.DataSource = Podaci.PopuniGrid("Prilog");
            cb_naziv_jela.Items.AddRange(Podaci.PopuniCb("Jelo").ToArray());
            cb_naziv_priloga.Items.AddRange(Podaci.PopuniCb("Prilog").ToArray());
        }

        public Meni(int id_racuna)
        {
            InitializeComponent();
            this.id_racuna = id_racuna;
            lista_stavke_racuna = new List<Stavka_racuna>();

            gridview_jela.AutoGenerateColumns = false;
            gridview_prilozi.AutoGenerateColumns = false;

            gridview_jela.DataSource = Podaci.PopuniGrid("Jelo");
            gridview_prilozi.DataSource = Podaci.PopuniGrid("Prilog");
            cb_naziv_jela.Items.AddRange(Podaci.PopuniCb("Jelo").ToArray());
            cb_naziv_priloga.Items.AddRange(Podaci.PopuniCb("Prilog").ToArray());
        }

        private int DodajRacun(OleDbConnection konekcija, double cena)
        {
            int id;
            string dodaj = $@"insert into Racun (ukupna_cena) values (?)";

            using (OleDbCommand komanda = new OleDbCommand(dodaj, konekcija))
            {
                komanda.Parameters.AddWithValue("?", cena);
                komanda.ExecuteNonQuery();
            }

            using (OleDbCommand komanda = new OleDbCommand("select @@identity", konekcija))
            {
                id = Convert.ToInt32(komanda.ExecuteScalar());
                return id;
            }
        }

        private int AzurirajRacun(OleDbConnection konekcija, double cena)
        {
            int id = this.id_racuna.Value;
            string update = "update Racun set ukupna_cena = ? where id_racun = ?";

            using (OleDbCommand komanda = new OleDbCommand(update, konekcija))
            {
                komanda.Parameters.AddWithValue("?", cena);
                komanda.Parameters.AddWithValue("?", id);
                komanda.ExecuteNonQuery();
            }

            return id;
        }

        private void SacuvajStavku(OleDbConnection konekcija, int id_racuna, Stavka_racuna stavka)
        {
            string proveri = $@"select kolicina 
                                from Stavka_racuna 
                                where id_racun = ? 
                                and id_jelo = ? 
                                and id_prilog = ?";

            using (OleDbCommand komanda_proveri = new OleDbCommand(proveri, konekcija))
            {
                komanda_proveri.Parameters.AddWithValue("?", id_racuna);
                komanda_proveri.Parameters.AddWithValue("?", stavka.Id_jelo);
                komanda_proveri.Parameters.AddWithValue("?", stavka.Id_prilog);

                using (OleDbDataReader dr = komanda_proveri.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        int nova_kolicina = Convert.ToInt32(dr["kolicina"]) + stavka.Kolicina;

                        string azuriraj_racun = $@"update Stavka_racuna 
                                                   set kolicina = ?
                                                   where id_racun = ? 
                                                   and id_jelo = ? 
                                                   and id_prilog = ?";

                        using (OleDbCommand komanda_azuriraj_racun = new OleDbCommand(azuriraj_racun, konekcija))
                        {
                            komanda_azuriraj_racun.Parameters.AddWithValue("?", nova_kolicina);
                            komanda_azuriraj_racun.Parameters.AddWithValue("?", id_racuna);
                            komanda_azuriraj_racun.Parameters.AddWithValue("?", stavka.Id_jelo);
                            komanda_azuriraj_racun.Parameters.AddWithValue("?", stavka.Id_prilog);
                            komanda_azuriraj_racun.ExecuteNonQuery();
                        }

                        return;
                    }

                    string dodaj_racun = $@"insert into Stavka_racuna 
                                            (id_racun, id_jelo, id_prilog, cenaJelo, cenaPrilog, kolicina) 
                                            values (?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand komanda_dodaj_racun = new OleDbCommand(dodaj_racun, konekcija))
                    {
                        komanda_dodaj_racun.Parameters.AddWithValue("?", id_racuna);
                        komanda_dodaj_racun.Parameters.AddWithValue("?", stavka.Id_jelo);
                        komanda_dodaj_racun.Parameters.AddWithValue("?", stavka.Id_prilog);
                        komanda_dodaj_racun.Parameters.AddWithValue("?", stavka.CenaJelo);
                        komanda_dodaj_racun.Parameters.AddWithValue("?", stavka.CenaPrilog);
                        komanda_dodaj_racun.Parameters.AddWithValue("?", stavka.Kolicina);
                        komanda_dodaj_racun.ExecuteNonQuery();
                    }
                }
            }
        }

        private void btn_filtriraj_Click(object sender, EventArgs e)
        {
            string jela = "select j.id_jelo, j.naziv, j.cena from Jelo j where 1=1";
            string prilozi = @"select p.id_prilog, p.naziv, p.cena
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
                jela = @"select j.id_jelo, j.naziv, j.cena 
                         from (Jelo j left join Pripadnost pr
                         on j.id_jelo = pr.id_jelo)
                         left join Prilog p
                         on pr.id_prilog = p.id_prilog
                         where 1=1
                         and p.naziv = ?";

                prilozi = "select p.id_prilog, p.naziv, p.cena from Prilog p where 1=1 and p.naziv = ?";
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

        private void btn_sacuvaj_stavku_Click(object sender, EventArgs e)
        {
            if(gridview_jela.CurrentRow == null || gridview_jela.CurrentRow.Index == -1)
            {
                MessageBox.Show("Morate selektovati jelo koje zelite da dodate u racun!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            if (gridview_prilozi.CurrentRow == null || gridview_prilozi.CurrentRow.Index == -1)
            {
                MessageBox.Show("Morate selektovati prilog koji zelite da dodate uz jelo u racun!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            if(nud_kolicina.Value <= 0)
            {
                MessageBox.Show("Morate uneti validan broj!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            DataGridViewRow red_jelo = gridview_jela.CurrentRow;
            DataGridViewRow red_prilog = gridview_prilozi.CurrentRow;

            int kolicina = Convert.ToInt32(nud_kolicina.Value);
            int.TryParse(red_jelo.Cells[0].Value.ToString(), out int id_jelo);
            int.TryParse(red_prilog.Cells[0].Value.ToString(), out int id_prilog);
            double.TryParse(red_jelo.Cells[2].Value.ToString(), out double cena_jelo);
            double.TryParse(red_prilog.Cells[2].Value.ToString(), out double cena_prilog);

            Stavka_racuna stavka = new Stavka_racuna(id_jelo, id_prilog, cena_jelo, cena_prilog, kolicina);

            Stavka_racuna ista_stavka = lista_stavke_racuna
                                            .FirstOrDefault(s => 
                                                s.Id_jelo == stavka.Id_jelo && 
                                                s.Id_prilog == stavka.Id_prilog);

            if(ista_stavka != null)
            {
                ista_stavka.Kolicina += kolicina;
                MessageBox.Show("Uspesno ste uvecali kolicinu!", "Obavestenje", MessageBoxButtons.OK);
                return;
            }

            lista_stavke_racuna.Add(stavka);
            MessageBox.Show("Uspesno ste dodali stavku!", "Obavestenje", MessageBoxButtons.OK);
        }

        private void gridview_jela_SelectionChanged(object sender, EventArgs e)
        {
            if (gridview_jela.CurrentRow == null || gridview_jela.CurrentRow.Index == -1)
                return;

            DataGridViewRow red_jelo = gridview_jela.CurrentRow;

            int.TryParse(red_jelo.Cells[0].Value.ToString(), out int id_jela);
            string prilozi = $@"select p.id_prilog, p.naziv, p.cena
                               from (Prilog p left join Pripadnost pr
                               on p.id_prilog = pr.id_prilog)
                               left join Jelo j
                               on pr.id_jelo = j.id_jelo
                               where j.id_jelo = ?";

            using (OleDbConnection konekcija = new OleDbConnection(putanja))
            using (OleDbCommand komanda_prilozi = new OleDbCommand(prilozi, konekcija))
            {
                komanda_prilozi.Parameters.AddWithValue("?", id_jela);

                OleDbDataAdapter da = new OleDbDataAdapter(komanda_prilozi);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gridview_prilozi.DataSource = dt;
            }
        }

        private void btn_sacuvaj_racun_Click(object sender, EventArgs e)
        {
            if (lista_stavke_racuna == null || lista_stavke_racuna.Count == 0)
            {
                MessageBox.Show("Nije moguce napraviti prazan racun, morate dodati jelo i priloge!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            string dodaj_racun = $@"insert into Racun (ukupna_cena) values (?)";
            double cena = 0;

            lista_stavke_racuna
                .ForEach(s => 
                    cena += s.Kolicina * (s.CenaJelo + s.CenaPrilog));

            OleDbConnection konekcija = new OleDbConnection(putanja);
            konekcija.Open();

            int id_racuna = 0;

            if (this.id_racuna.HasValue)
                id_racuna = AzurirajRacun(konekcija, cena);

            else
                id_racuna = DodajRacun(konekcija, cena);

            lista_stavke_racuna
                .ForEach(s => 
                    SacuvajStavku(konekcija, id_racuna, s));

            konekcija.Close();

            lista_stavke_racuna.Clear();
            MessageBox.Show("Uspesno ste sacuvali racun!", "Obavestenje", MessageBoxButtons.OK);
        }

        private void btn_izadji_Click(object sender, EventArgs e)
        {
            if (lista_stavke_racuna.Count == 0)
            {
                this.Close();
                return;
            }

            DialogResult are_u_sure = MessageBox.Show("Niste sacuvali sve stavke racuna.\nDa li ste sigurni da zelite da izadjete?", "Upozorenje", MessageBoxButtons.YesNo);

            if (are_u_sure == DialogResult.No)
                return;

            this.Close();
        }
    }
}
