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
    public partial class Izmeni : Form
    {
        int? id_racun;
        int? id_jelo;
        int? id_prilog;
        string putanja = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Restoran.accdb;";
        public Izmeni(int id_racun, int id_jelo, int id_prilog)
        {
            InitializeComponent();
            this.id_racun = id_racun;
            this.id_jelo = id_jelo;
            this.id_prilog = id_prilog;
        }

        private void Izmeni_Load(object sender, EventArgs e)
        {
            using (OleDbConnection konekcija = new OleDbConnection(putanja))
            {
                string upit = $@"select p.naziv 
                                 from Prilog p left join Pripadnost pr 
                                 on p.id_prilog = pr.id_prilog 
                                 where pr.id_jelo = {id_jelo}";

                OleDbDataAdapter da = new OleDbDataAdapter(upit, konekcija);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cb_naziv_priloga.Items.Clear();

                cb_naziv_priloga.Items.AddRange(
                    dt.AsEnumerable()
                        .Select(a => a["naziv"].ToString())
                        .ToArray());
            }
        }

        private void btn_odjavi_se_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_sacuvaj_stavku_Click(object sender, EventArgs e)
        {
            using (OleDbConnection konekcija = new OleDbConnection(putanja))
            {
                konekcija.Open();

                string trenutna_stavka = $@"select id_prilog, cenaJelo, cenaPrilog, kolicina
                                            from Stavka_racuna 
                                            where id_racun = {id_racun} 
                                            and id_jelo = {id_jelo} 
                                            and id_prilog = {id_prilog}";

                int stara_kolicina = 0;
                double stara_cenaJelo = 0, stara_cenaPrilog = 0;

                using (OleDbCommand komanda = new OleDbCommand(trenutna_stavka, konekcija))
                using (OleDbDataReader dr = komanda.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        // izmene
                        int.TryParse(dr["kolicina"].ToString(), out stara_kolicina);
                        double.TryParse(dr["cenaJelo"].ToString(), out stara_cenaJelo);
                        double.TryParse(dr["cenaPrilog"].ToString(), out stara_cenaPrilog);
                    }
                }

                string novi_naziv_priloga = cb_naziv_priloga.Text;
                int novi_id_prilog = 0;

                string nadji_prilog = $@"select id_prilog, cena 
                                         from Prilog 
                                         where naziv = '{novi_naziv_priloga}'";

                double nova_cenaPrilog = 0;

                using (OleDbCommand komanda_prilog = new OleDbCommand(nadji_prilog, konekcija))
                using (OleDbDataReader dr = komanda_prilog.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        int.TryParse(dr["id_prilog"].ToString(), out novi_id_prilog);
                        double.TryParse(dr["cena"].ToString(), out nova_cenaPrilog);
                    }
                }

                int nova_kolicina = Convert.ToInt32(nud_kolicina.Value);

                bool prilog_promenjen = novi_id_prilog != id_prilog;
                bool kolicina_promenjena = nova_kolicina != stara_kolicina;

                if (!prilog_promenjen && !kolicina_promenjena)
                {
                    MessageBox.Show("Niste napravili nikakvu izmenu!", "Obavestenje", MessageBoxButtons.OK);
                    return;
                }

                if (nova_kolicina > stara_kolicina)
                {
                    MessageBox.Show($"Kolicina ne moze biti veca od trenutne ({stara_kolicina}).", "Upozorenje", MessageBoxButtons.OK);
                    return;
                }

                if (!prilog_promenjen)
                {
                    string update_kolicina = $@"update Stavka_racuna 
                                                set kolicina = {nova_kolicina}
                                                where id_racun = {id_racun} 
                                                and id_jelo   = {id_jelo} 
                                                and id_prilog = {id_prilog}";

                    OleDbCommand komanda_update = new OleDbCommand(update_kolicina, konekcija);
                    komanda_update.ExecuteNonQuery();
                }
                else
                {
                    int preostala_kolicina = stara_kolicina - nova_kolicina;

                    if (preostala_kolicina > 0)
                    {
                        string smanji_kolicinu = $@"update Stavka_racuna 
                                                    set kolicina = {preostala_kolicina}
                                                    where id_racun  = {id_racun} 
                                                    and id_jelo   = {id_jelo} 
                                                    and id_prilog = {id_prilog}";

                        OleDbCommand komanda_smanji = new OleDbCommand(smanji_kolicinu, konekcija);
                        komanda_smanji.ExecuteNonQuery();
                    }
                    else
                    {
                        string obrisi_stavku = $@"delete from Stavka_racuna 
                                                  where id_racun  = {id_racun} 
                                                  and id_jelo   = {id_jelo} 
                                                  and id_prilog = {id_prilog}";

                        OleDbCommand komanda_obrisi = new OleDbCommand(obrisi_stavku, konekcija);
                        komanda_obrisi.ExecuteNonQuery();
                    }

                    string proveri_stavku = $@"select kolicina 
                                               from Stavka_racuna 
                                               where id_racun  = {id_racun} 
                                               and id_jelo   = {id_jelo} 
                                               and id_prilog = {novi_id_prilog}";

                    OleDbCommand komanda_proveri = new OleDbCommand(proveri_stavku, konekcija);
                    using (OleDbDataReader dr = komanda_proveri.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            int postojeca_kolicina = 0;
                            int.TryParse(dr["kolicina"].ToString(), out postojeca_kolicina);
                            int azurirana_kolicina = postojeca_kolicina + nova_kolicina;

                            string update_postojece = $@"update Stavka_racuna 
                                                         set kolicina = {azurirana_kolicina}
                                                         where id_racun  = {id_racun} 
                                                         and id_jelo   = {id_jelo} 
                                                         and id_prilog = {novi_id_prilog}";

                            OleDbCommand komanda_update_postojece = new OleDbCommand(update_postojece, konekcija);
                            komanda_update_postojece.ExecuteNonQuery();
                        }
                        else
                        {
                            string insert_stavku = $@"insert into Stavka_racuna 
                                                      (id_racun, id_jelo, id_prilog, cenaJelo, cenaPrilog, kolicina)
                                                      values ({id_racun}, {id_jelo}, {novi_id_prilog}, 
                                                      {stara_cenaJelo}, {nova_cenaPrilog}, {nova_kolicina})";

                            OleDbCommand komanda_insert = new OleDbCommand(insert_stavku, konekcija);
                            komanda_insert.ExecuteNonQuery();
                        }
                    }
                }

                string ukupna_cena_racuna = $@"select sum(kolicina * (cenaJelo + cenaPrilog))
                                               from Stavka_racuna 
                                               where id_racun = {id_racun}";

                double ukupna_cena = 0;
                OleDbCommand komanda_ukupna = new OleDbCommand(ukupna_cena_racuna, konekcija);
                using (OleDbDataReader dr = komanda_ukupna.ExecuteReader())
                {
                    if (dr.Read())
                        double.TryParse(dr[0].ToString(), out ukupna_cena);
                }

                string update_racun = $@"update Racun 
                                         set ukupna_cena = {ukupna_cena}
                                         where id_racun = {id_racun}";

                OleDbCommand komanda_racun = new OleDbCommand(update_racun, konekcija);
                komanda_racun.ExecuteNonQuery();

                MessageBox.Show("Uspesno ste izmenili stavku racuna!", "Obavestenje", MessageBoxButtons.OK);
            }
        }
    }
}
