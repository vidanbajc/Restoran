using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public class Podaci
    {
        public static DataTable PopuniGrid(string tabela)
        {
            string putanja = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Restoran.accdb;";
            string upit = $"select * from {tabela}";

            using (OleDbConnection konekcija = new OleDbConnection(putanja))
            {
                OleDbDataAdapter da = new OleDbDataAdapter(upit, konekcija);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static List<string> PopuniCb(string tabela)
        {
            string putanja = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Restoran.accdb;";
            string upit = $"select naziv from {tabela}";

            List<string> lista = new List<string>();

            using (OleDbConnection konekcija = new OleDbConnection(putanja))
            using (OleDbCommand komanda = new OleDbCommand(upit, konekcija))
            {
                konekcija.Open();

                using (OleDbDataReader dr = komanda.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(dr[0].ToString());
                    }
                }
            }

            return lista;
        }
    }
}
