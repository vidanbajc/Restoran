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
    public partial class Administrator : Form
    {
        string putanja = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Restoran.accdb;";
        public Administrator()
        {
            InitializeComponent();
            Podaci.PopuniGrid(gridview_jela, "Jelo");
            Podaci.PopuniGrid(gridview_prilozi, "Prilog");
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
            Podaci.PopuniGrid(gridview_jela, "Jelo");
            Podaci.PopuniGrid(gridview_prilozi, "Prilog");

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
            Podaci.PopuniGrid(gridview_jela, "Jelo");
            Podaci.PopuniGrid(gridview_prilozi, "Prilog");

            konekcija.Close();
        }

        private void btn_odjavi_se_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
