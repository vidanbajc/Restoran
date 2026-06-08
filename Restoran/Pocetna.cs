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
    public partial class Pocetna : Form
    {
        Dictionary<string, (string lozinka, string uloga)> korisnici;
        public Pocetna()
        {
            InitializeComponent();

            korisnici = new Dictionary<string, (string lozinka, string uloga)>();

            korisnici.Add("a", ("a", "admin"));
            korisnici.Add("b", ("b", "radnik"));
            korisnici.Add("c", ("c", "radnik"));

        }

        private void OcistiKontrole(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.Parent is Form && c is TextBox tb)
                    tb.Clear();

                if (c.HasChildren)
                    OcistiKontrole(c);
            }
        }

        private void btn_prijava_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_korisnicko_ime.Text) || string.IsNullOrWhiteSpace(tb_lozinka.Text))
            {
                MessageBox.Show("Morate popuniti sva neophodna polja!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            string korisnicko_ime = tb_korisnicko_ime.Text;
            string lozinka = tb_lozinka.Text;

            if(!korisnici.TryGetValue(korisnicko_ime, out var korisnik) || (korisnik.lozinka != lozinka))
            {
                MessageBox.Show("Uneli ste nepostojeceg korisnika, pokusajte ponovo!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            if(korisnik.uloga == "admin")
            {
                MessageBox.Show($"Uspesno ste se ulogovali kao {korisnik.uloga} {korisnicko_ime}!", "Dobrodosli", MessageBoxButtons.OK);

                Administrator admin = new Administrator();
                this.Hide();
                admin.ShowDialog();
            }

            else
            {
                MessageBox.Show($"Uspesno ste se ulogovali kao {korisnik.uloga} {korisnicko_ime}!", "Dobrodosli", MessageBoxButtons.OK);

                Radnik radnik = new Radnik();
                this.Hide();
                radnik.ShowDialog();
            }

            OcistiKontrole(this);
            this.Show();
        }

        private void btn_izadji_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
