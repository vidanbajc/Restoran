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
            // videti nekako za slanje id_racuna
            // takodje prilikom dodavanja ukupne cene nije dovoljno samo citanje iz liste
            // za ovo dugme dodaj stavku procitamo trenutnu cenu preko ovog poslatog id_racuna
            // za za izmeni stavku mora dodatna logika, odnosno slanje id_racuna, id_jela, id_priloga
            // ovde nije ni problem moze "firstordefault"(preko sql) zato sto je to sve jedan racun
            // nije strasno kao za igricee

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
    }
}
