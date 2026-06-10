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
        string putanja = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Restoran.accdb;";
        public Radnik()
        {
            InitializeComponent();

            gridview_racuni.AutoGenerateColumns = false;
            gridview_stavke_racuna.AutoGenerateColumns = false;

            Podaci.PopuniGrid(gridview_racuni, "Racun");
            Podaci.PopuniGrid(gridview_stavke_racuna, "Stavka_racuna");
        }

        private void btn_novi_racun_Click(object sender, EventArgs e)
        {
            Meni meni = new Meni();
            this.Hide();
            meni.ShowDialog();
            this.Show();

            gridview_racuni.DataSource = null;
            gridview_stavke_racuna.DataSource = null;
            Podaci.PopuniGrid(gridview_racuni, "Racun");
            Podaci.PopuniGrid(gridview_stavke_racuna, "Stavka_racuna");
        }

        private void btn_odjavi_se_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dodaj_stavku_Click(object sender, EventArgs e)
        {
            if (gridview_racuni.CurrentRow == null || gridview_racuni.CurrentRow.Index == -1)
            {
                MessageBox.Show("Morate selektovati racun koje zelite da izmenite!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            int id_racuna = Convert.ToInt32(gridview_racuni.CurrentRow.Cells[0].Value);

            Meni meni = new Meni(id_racuna);
            this.Hide();
            meni.ShowDialog();
            this.Show();

            gridview_racuni.DataSource = null;
            gridview_stavke_racuna.DataSource = null;
            Podaci.PopuniGrid(gridview_racuni, "Racun");
            Podaci.PopuniGrid(gridview_stavke_racuna, "Stavka_racuna");
        }

        private void btn_izmeni_stavku_Click(object sender, EventArgs e)
        {
            if (gridview_racuni.CurrentRow == null || gridview_racuni.CurrentRow.Index == -1)
            {
                MessageBox.Show("Morate selektovati racun koje zelite da izmenite!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            if(gridview_stavke_racuna.CurrentRow == null || gridview_stavke_racuna.CurrentRow.Index == -1)
            {
                MessageBox.Show("Morate selektovati stavku racuna koju zelite da izmenite!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            int.TryParse(gridview_racuni.CurrentRow.Cells[0].Value.ToString(), out int id_racun);
            int.TryParse(gridview_stavke_racuna.CurrentRow.Cells[1].Value.ToString(), out int id_jelo);
            int.TryParse(gridview_stavke_racuna.CurrentRow.Cells[2].Value.ToString(), out int id_prilog);

            Izmeni i = new Izmeni(id_racun, id_jelo, id_prilog);
            this.Hide();
            i.ShowDialog();
            this.Show();

            gridview_racuni.DataSource = null;
            gridview_stavke_racuna.DataSource = null;
            Podaci.PopuniGrid(gridview_racuni, "Racun");
            Podaci.PopuniGrid(gridview_stavke_racuna, "Stavka_racuna");
        }

        private void gridview_racuni_SelectionChanged(object sender, EventArgs e)
        {
            if (gridview_racuni.CurrentRow == null || gridview_racuni.CurrentRow.Index == -1)
                return;

            DataGridViewRow red_racun = gridview_racuni.CurrentRow;

            int.TryParse(red_racun.Cells[0].Value.ToString(), out int id_racun);

            string stavke = $@"select *
                               from Stavka_racuna
                               where id_racun = {id_racun}";

            using (OleDbConnection konekcija = new OleDbConnection(putanja))
            using (OleDbCommand komanda_prilozi = new OleDbCommand(stavke, konekcija))
            {
                OleDbDataAdapter da = new OleDbDataAdapter(komanda_prilozi);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gridview_stavke_racuna.DataSource = dt;
            }
        }

        private void btn_obrisi_stavku_Click(object sender, EventArgs e)
        {
            if (gridview_racuni.CurrentRow == null || gridview_racuni.CurrentRow.Index == -1)
            {
                MessageBox.Show("Morate selektovati racun ciju stavku zelite da obrisete!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }
            if (gridview_stavke_racuna.CurrentRow == null || gridview_stavke_racuna.CurrentRow.Index == -1)
            {
                MessageBox.Show("Morate selektovati stavku racuna koju zelite da obrisete!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            int.TryParse(gridview_racuni.CurrentRow.Cells[0].Value.ToString(), out int id_racun);
            int.TryParse(gridview_stavke_racuna.CurrentRow.Cells[1].Value.ToString(), out int id_jelo);
            int.TryParse(gridview_stavke_racuna.CurrentRow.Cells[2].Value.ToString(), out int id_prilog);

            DialogResult are_u_sure = MessageBox.Show($"Da li ste sigurni da zelite da obrisete stavku sa racuna {id_racun}", "Upozorenje", MessageBoxButtons.YesNo);

            if (are_u_sure == DialogResult.No)
                return;

            using (OleDbConnection konekcija = new OleDbConnection(putanja))
            {
                konekcija.Open();

                string obrisi_stavku = $@"delete from Stavka_racuna 
                                          where id_racun  = {id_racun} 
                                          and id_jelo   = {id_jelo} 
                                          and id_prilog = {id_prilog}";

                OleDbCommand komanda_obrisi = new OleDbCommand(obrisi_stavku, konekcija);
                komanda_obrisi.ExecuteNonQuery();

                string ukupna_cena_racuna = $@"select sum(kolicina * (cenaJelo + cenaPrilog)) 
                                               from Stavka_racuna 
                                               where id_racun = {id_racun}";

                OleDbCommand komanda_ukupna = new OleDbCommand(ukupna_cena_racuna, konekcija);

                var rezultat = komanda_ukupna.ExecuteScalar();
                double ukupna_cena = 0;

                if (rezultat != null && rezultat != DBNull.Value)
                    double.TryParse(rezultat.ToString(), out ukupna_cena);

                string azuriraj_obrisi_racun;

                if (ukupna_cena != 0)
                {
                    azuriraj_obrisi_racun = $@"update Racun 
                                        set ukupna_cena = {ukupna_cena} 
                                        where id_racun = {id_racun}";

                }

                else
                {
                    azuriraj_obrisi_racun = $@"delete from Racun 
                                        where id_racun = {id_racun}";
                }

                OleDbCommand komanda_azuriraj = new OleDbCommand(azuriraj_obrisi_racun, konekcija);
                komanda_azuriraj.ExecuteNonQuery();

                MessageBox.Show("Uspesno ste obrisali stavku!", "Obavestenje", MessageBoxButtons.OK);

                gridview_racuni.DataSource = null;
                gridview_stavke_racuna.DataSource = null;
                Podaci.PopuniGrid(gridview_racuni, "Racun");
                Podaci.PopuniGrid(gridview_stavke_racuna, "Stavka_racuna");
            }
        }
    }
}
