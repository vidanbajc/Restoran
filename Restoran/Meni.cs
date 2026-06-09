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
        int ?id_racuna;
        List<Stavka_racuna> lista_stavke_racuna;
        string putanja = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Restoran.accdb;";
        public Meni()
        {
            InitializeComponent();
            lista_stavke_racuna = new List<Stavka_racuna>();

            gridview_jela.AutoGenerateColumns = false;
            gridview_prilozi.AutoGenerateColumns = false;

            Podaci.PopuniGrid(gridview_jela, "Jelo");
            Podaci.PopuniGrid(gridview_prilozi, "Prilog");
            Podaci.PopuniCb(cb_naziv_jela, "Jelo", "naziv");
            Podaci.PopuniCb(cb_naziv_priloga, "Prilog", "naziv");

            cb_naziv_priloga.Enabled = true;
        }

        public Meni(int id_racuna)
        {
            InitializeComponent();
            this.id_racuna = id_racuna;
            lista_stavke_racuna = new List<Stavka_racuna>();

            gridview_jela.AutoGenerateColumns = false;
            gridview_prilozi.AutoGenerateColumns = false;

            Podaci.PopuniGrid(gridview_jela, "Jelo");
            Podaci.PopuniGrid(gridview_prilozi, "Prilog");
            Podaci.PopuniCb(cb_naziv_jela, "Jelo", "naziv");
            Podaci.PopuniCb(cb_naziv_priloga, "Prilog", "naziv");
            cb_naziv_priloga.Enabled = true;
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

            DataGridViewRow red_jelo = gridview_jela.CurrentRow;
            DataGridViewRow red_prilog = gridview_prilozi.CurrentRow;

            int.TryParse(red_jelo.Cells[0].Value.ToString(), out int id_jela);
            int.TryParse(red_prilog.Cells[0].Value.ToString(), out int id_priloga);
            double.TryParse(red_jelo.Cells[2].Value.ToString(), out double cena_jela);
            double.TryParse(red_prilog.Cells[2].Value.ToString(), out double cena_priloga);

            Stavka_racuna stavka = new Stavka_racuna(id_jela, id_priloga, cena_jela, cena_priloga, kolicina: 1);
            Stavka_racuna ista_stavka = null;

            if (lista_stavke_racuna != null)
            {
                ista_stavka = lista_stavke_racuna
                                .FirstOrDefault(s => 
                                    s.Id_jelo == stavka.Id_jelo &&
                                    s.Id_prilog == stavka.Id_prilog);
            }

            if(ista_stavka != null)
            {
                ista_stavka.Kolicina++;
                MessageBox.Show("Uspesno ste dodali stavku!", "Obavestenje", MessageBoxButtons.OK);
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
                               where j.id_jelo = {id_jela}";

            using (OleDbConnection konekcija = new OleDbConnection(putanja))
            using (OleDbCommand komanda_prilozi = new OleDbCommand(prilozi, konekcija))
            {
                OleDbDataAdapter da = new OleDbDataAdapter(komanda_prilozi);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gridview_prilozi.DataSource = dt;
            }
        }

        private void btn_sacuvaj_racun_Click(object sender, EventArgs e)
        {
            if(lista_stavke_racuna == null || lista_stavke_racuna.Count == 0)
            {
                MessageBox.Show("Nije moguce napraviti prazan racun, morate dodati jelo i priloge!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            string dodaj_racun = $@"insert into Racun (ukupna_cena) values (?)";
            string dodaj_stavku = $@"insert into Stavka_racuna
                                     (id_racun, id_jelo, id_prilog, cenaJelo, cenaPrilog, kolicina)
                                     values (?, ?, ?, ?, ?, ?)";
            double cena = 0;

            lista_stavke_racuna
                    .ForEach(s => cena += s.Kolicina * (s.CenaJelo + s.CenaPrilog));

            using (OleDbConnection konekcija = new OleDbConnection(putanja))
            using (OleDbCommand komanda_dodaj_racun = new OleDbCommand(dodaj_racun, konekcija))
            using (OleDbCommand komanda_dodaj_stavku = new OleDbCommand(dodaj_stavku, konekcija))
            {
                konekcija.Open();
                int id_racuna = 0;

                if (this.id_racuna.HasValue)
                {
                    id_racuna = this.id_racuna.Value;

                    string vrati_cenu =$@"select ukupna_cena
                                          from Racun
                                          where id_racun = {id_racuna}";

                    using (OleDbCommand komanda_vrati_cenu =new OleDbCommand(vrati_cenu, konekcija))
                    {
                        object rezultat = komanda_vrati_cenu.ExecuteScalar();

                        if (rezultat != null)
                            cena += Convert.ToDouble(rezultat);
                    }

                    string azuriraj_racun =$@"update Racun
                                              set ukupna_cena = ?
                                              where id_racun = {id_racuna}";

                    using (OleDbCommand komanda_azuriraj = new OleDbCommand(azuriraj_racun, konekcija))
                    {
                        komanda_azuriraj.Parameters.AddWithValue("?", cena);
                        komanda_azuriraj.ExecuteNonQuery();
                    }
                }

                else
                {
                    komanda_dodaj_racun.Parameters.AddWithValue("?", cena);
                    komanda_dodaj_racun.ExecuteNonQuery();

                    OleDbCommand komanda_id_racuma = new OleDbCommand("select @@identity", konekcija);

                    id_racuna = Convert.ToInt32(komanda_id_racuma.ExecuteScalar());
                }


                foreach (Stavka_racuna stavka in lista_stavke_racuna)
                {
                    komanda_dodaj_stavku.Parameters.Clear();

                    komanda_dodaj_stavku.Parameters.AddWithValue("?", id_racuna);
                    komanda_dodaj_stavku.Parameters.AddWithValue("?", stavka.Id_jelo);
                    komanda_dodaj_stavku.Parameters.AddWithValue("?", stavka.Id_prilog);
                    komanda_dodaj_stavku.Parameters.AddWithValue("?", stavka.CenaJelo);
                    komanda_dodaj_stavku.Parameters.AddWithValue("?", stavka.CenaPrilog);
                    komanda_dodaj_stavku.Parameters.AddWithValue("?", stavka.Kolicina);

                    komanda_dodaj_stavku.ExecuteNonQuery();
                }

                lista_stavke_racuna.Clear();
                lista_stavke_racuna = null;
                MessageBox.Show("Racun je uspesno sacuvan!", "Obavestenje", MessageBoxButtons.OK);
            }
        }

        private void btn_izadji_Click(object sender, EventArgs e)
        {
            if (lista_stavke_racuna == null || lista_stavke_racuna.Count == 0)
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
