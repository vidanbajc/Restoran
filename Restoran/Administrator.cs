using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public partial class Administrator : Form
    {
        string putanja = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Restoran.accdb;";
        public Administrator()
        {
            InitializeComponent();
            gridview_jela.DataSource = Podaci.PopuniGrid("Jelo");
            gridview_prilozi.DataSource = Podaci.PopuniGrid("Prilog");
        }

        private void btn_novo_jelo_prilog_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_naziv_jelo_prilog.Text) ||
                !double.TryParse(nud_cena_jelo_prilog.Value.ToString(), out double cena))
            {
                MessageBox.Show("Morate popuniti sva neophodna polja!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            if(cena <= 0)
            {
                MessageBox.Show("Morate uneti validne podatke!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            string naziv = tb_naziv_jelo_prilog.Text;

            string tabela = "Prilog";
            string tip = "prilog";

            if(rb_jelo.Checked)
            {
                tabela = "Jelo";
                tip = "jelo";
            }

            OleDbConnection konekcija = new OleDbConnection(putanja);
            konekcija.Open();

            string provera = $@"select naziv from {tabela} where naziv = ?";

            using (OleDbCommand komanda_provera = new OleDbCommand(provera, konekcija))
            {
                komanda_provera.Parameters.AddWithValue("?", naziv);

                if(komanda_provera.ExecuteScalar() != null)
                {
                    MessageBox.Show($"Uneli ste vec postojeci {tip}!", "Obavestenje", MessageBoxButtons.OK);
                    return;
                }
            }

            string upisi = $@"insert into {tabela} (naziv, cena) values (?, ?)";

            using (OleDbCommand komanda_upisi = new OleDbCommand(upisi, konekcija))
            {
                komanda_upisi.Parameters.AddWithValue("?", naziv);
                komanda_upisi.Parameters.AddWithValue("?", cena);
                komanda_upisi.ExecuteNonQuery();
            }

            MessageBox.Show($"Uspesno ste uneli novi {tip}!", "Obavestenje", MessageBoxButtons.OK);

            gridview_jela.DataSource = null;
            gridview_prilozi.DataSource = null;
            gridview_jela.DataSource = Podaci.PopuniGrid("Jelo");
            gridview_prilozi.DataSource = Podaci.PopuniGrid("Prilog");

            konekcija.Close();
        }

        private void btn_izmeni_jelo_prilog_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_naziv_jelo_prilog.Text) ||
                !double.TryParse(nud_cena_jelo_prilog.Value.ToString(), out double cena))
            {
                MessageBox.Show("Morate popuniti sva neophodna polja!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            if (cena <= 0)
            {
                MessageBox.Show("Morate uneti validne podatke!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            if (rb_jelo.Checked && (gridview_jela.CurrentRow == null || gridview_jela.CurrentRow.Index == -1))
            {
                MessageBox.Show("Morate selektovati jelo koje zelite da izmenite!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            if (rb_prilog.Checked && (gridview_prilozi.CurrentRow == null || gridview_prilozi.CurrentRow.Index == -1))
            {
                MessageBox.Show("Morate selektovati prilog koje zelite da izmenite!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            string naziv = tb_naziv_jelo_prilog.Text;

            string tabela = "Prilog";
            string tip = "prilog";
            int.TryParse(gridview_prilozi.CurrentRow.Cells[0].Value.ToString(), out int id);

            if (rb_jelo.Checked)
            {
                tabela = "Jelo";
                tip = "jelo";
                int.TryParse(gridview_jela.CurrentRow.Cells[0].Value.ToString(), out id);
            }
            
            OleDbConnection konekcija = new OleDbConnection(putanja);
            konekcija.Open();

            string provera = $@"select naziv from {tabela} where naziv = ? and id_{tip} <> ?";

            using (OleDbCommand komanda_provera = new OleDbCommand(provera, konekcija))
            {
                komanda_provera.Parameters.AddWithValue("?", naziv);
                komanda_provera.Parameters.AddWithValue("?", id);

                if (komanda_provera.ExecuteScalar() != null)
                {
                    MessageBox.Show($"Uneli ste vec postojeci {tip}!", "Obavestenje", MessageBoxButtons.OK);
                    return;
                }
            }

            DialogResult are_u_sure = MessageBox.Show($"Da li ste sigurni da zelite da promenite podatke za {tip}", "Pitanje", MessageBoxButtons.YesNo);

            if (are_u_sure == DialogResult.No)
            {
                konekcija.Close();
                return;
            }

            string izmeni = $@"update {tabela} set naziv = ?, cena = ? where id_{tip} = ?";

            using (OleDbCommand komanda_izmeni = new OleDbCommand(izmeni, konekcija))
            {
                komanda_izmeni.Parameters.AddWithValue("?", naziv);
                komanda_izmeni.Parameters.AddWithValue("?", cena);
                komanda_izmeni.Parameters.AddWithValue("?", id);
                komanda_izmeni.ExecuteNonQuery();
            }

            MessageBox.Show($"Uspesno ste izmenili {tip}!", "Obavestenje", MessageBoxButtons.OK);

            gridview_jela.DataSource = null;
            gridview_prilozi.DataSource = null;
            gridview_jela.DataSource = Podaci.PopuniGrid("Jelo");
            gridview_prilozi.DataSource = Podaci.PopuniGrid("Prilog");

            konekcija.Close();
        }

        private void btn_odjavi_se_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_obrisi_jelo_prilog_Click(object sender, EventArgs e)
        {
            if (rb_jelo.Checked && (gridview_jela.CurrentRow == null || gridview_jela.CurrentRow.Index == -1))
            {
                MessageBox.Show("Morate selektovati jelo koje zelite da izmenite!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            if (rb_prilog.Checked && (gridview_prilozi.CurrentRow == null || gridview_prilozi.CurrentRow.Index == -1))
            {
                MessageBox.Show("Morate selektovati prilog koje zelite da izmenite!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            string naziv = tb_naziv_jelo_prilog.Text;

            string tabela = "Prilog";
            string tip = "prilog";
            int.TryParse(gridview_prilozi.CurrentRow.Cells[0].Value.ToString(), out int id);

            if (rb_jelo.Checked)
            {
                tabela = "Jelo";
                tip = "jelo";
                int.TryParse(gridview_jela.CurrentRow.Cells[0].Value.ToString(), out id);
            }

            DialogResult are_u_sure = MessageBox.Show($"Da li ste sigurni da zelite da obrisete {tip}", "Pitanje", MessageBoxButtons.YesNo);

            if (are_u_sure == DialogResult.No)
                return;

            OleDbConnection konekcija = new OleDbConnection(putanja);
            konekcija.Open();

            string pripadnost = $@"delete from Pripadnost where id_{tip} = ?";

            using (OleDbCommand komanda_pripadnost = new OleDbCommand(pripadnost, konekcija))
            {
                komanda_pripadnost.Parameters.AddWithValue("?", id);
                komanda_pripadnost.ExecuteNonQuery();
            }

            string obrisi_iz_tabele = $@"delete from {tabela} where id_{tip} = ?";

            using (OleDbCommand komanda_izmeni = new OleDbCommand(obrisi_iz_tabele, konekcija))
            {
                komanda_izmeni.Parameters.AddWithValue("?", id);
                komanda_izmeni.ExecuteNonQuery();
            }

            MessageBox.Show($"Uspesno ste obrisali {tip}!", "Obavestenje", MessageBoxButtons.OK);

            gridview_jela.DataSource = null;
            gridview_prilozi.DataSource = null;
            gridview_jela.DataSource = Podaci.PopuniGrid("Jelo");
            gridview_prilozi.DataSource = Podaci.PopuniGrid("Prilog");

            konekcija.Close();
        }

        private void btn_povezi_jelo_prilog_Click(object sender, EventArgs e)
        {
            if (gridview_jela.CurrentRow == null || gridview_jela.CurrentRow.Index == -1 ||
                gridview_prilozi.CurrentRow == null || gridview_prilozi.CurrentRow.Index == -1)
            {
                MessageBox.Show("Morate selektovati jelo i prilog koje zelite da povezete", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            int.TryParse(gridview_jela.CurrentRow.Cells[0].Value.ToString(), out int id_jelo);
            int.TryParse(gridview_prilozi.CurrentRow.Cells[0].Value.ToString(), out int id_prilog);

            OleDbConnection konekcija = new OleDbConnection(putanja);
            konekcija.Open();

            string pripadnost = $@"select * from Pripadnost where id_jelo = ? and id_prilog = ?";

            using (OleDbCommand komanda_pripadnost = new OleDbCommand(pripadnost, konekcija))
            {
                komanda_pripadnost.Parameters.AddWithValue("?", id_jelo);
                komanda_pripadnost.Parameters.AddWithValue("?", id_prilog);
                
                if(komanda_pripadnost.ExecuteScalar() != null)
                {
                    MessageBox.Show($"Uneli ste vec postojecu kombinaciju jela i priloga!", "Obavestenje", MessageBoxButtons.OK);
                    return;
                }
            }

            string unesi_pripadnost = $@"insert into Pripadnost (id_jelo, id_prilog) values (?, ?)";

            using (OleDbCommand komanda_unesi_pripadnost = new OleDbCommand(unesi_pripadnost, konekcija))
            {
                komanda_unesi_pripadnost.Parameters.AddWithValue("?", id_jelo);
                komanda_unesi_pripadnost.Parameters.AddWithValue("?", id_prilog);
                komanda_unesi_pripadnost.ExecuteNonQuery();
            }

            MessageBox.Show($"Uspesno ste spojili jelo i prilog!", "Obavestenje", MessageBoxButtons.OK);

            gridview_jela.DataSource = null;
            gridview_prilozi.DataSource = null;
            gridview_jela.DataSource = Podaci.PopuniGrid("Jelo");
            gridview_prilozi.DataSource = Podaci.PopuniGrid("Prilog");

            konekcija.Close();
        }

        private void btn_izvestaj_Click(object sender, EventArgs e)
        {
            string ukupan_broj_racuna = $@"select count(*) from Racun";
            string ukupna_cena_racuna = $@"select sum(ukupna_cena) from Racun";

            string najprodavanija_jela = $@"select top 3 j.naziv 
                                            from Jelo j left join Stavka_racuna sr 
                                            on j.id_jelo = sr.id_jelo 
                                            group by j.naziv 
                                            order by count(sr.id_jelo) desc";

            string najprodavaniji_prilozi = $@"select top 3 p.naziv 
                                               from Prilog p left join Stavka_racuna sr 
                                               on p.id_prilog = sr.id_prilog 
                                               group by p.naziv 
                                               order by count(sr.id_prilog) desc";

            OleDbConnection konekcija = new OleDbConnection(putanja);
            konekcija.Open();

            int broj_racuna = 0;
            double cena_racuna = 0;
            List<string> jela = new List<string>();
            List<string> prilozi = new List<string>();

            using (OleDbCommand komanda_ukupan_broj_racuna = new OleDbCommand(ukupan_broj_racuna, konekcija))
            {
                broj_racuna = Convert.ToInt32(komanda_ukupan_broj_racuna.ExecuteScalar());
            }

            using (OleDbCommand komanda_ukupna_cena_racuna = new OleDbCommand(ukupna_cena_racuna, konekcija))
            {
                cena_racuna = Convert.ToDouble(komanda_ukupna_cena_racuna.ExecuteScalar());
            }

            using (OleDbCommand komanda_najprodavanija_jela = new OleDbCommand(najprodavanija_jela, konekcija))
            using (OleDbDataReader dr = komanda_najprodavanija_jela.ExecuteReader())
            {
                while (dr.Read())
                {
                    jela.Add(dr.GetString(0));
                }
            }

            using (OleDbCommand komanda_najprodavaniji_prilozi = new OleDbCommand(najprodavaniji_prilozi, konekcija))
            using (OleDbDataReader dr = komanda_najprodavaniji_prilozi.ExecuteReader())
            {
                while (dr.Read())
                {
                    prilozi.Add(dr.GetString(0));
                }
            }

            MessageBox.Show($"Ukupan broj racuna: {broj_racuna}\nUkupna zarada: {cena_racuna}\nNajprodavanija jela: {string.Join(", ", jela)}\nNajprodavaniji prilozi: {string.Join(", ", prilozi)}", "Izvestaj", MessageBoxButtons.OK);
            konekcija.Close();
        }
    }
}
