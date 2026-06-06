using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public class Podaci
    {
        public static void PopuniGrid(DataGridView gridview, string tabela)
        {
            string putanja = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Restoran.accdb;";

            using (OleDbConnection konekcija = new OleDbConnection(putanja))
            {
                konekcija.Open();
                string upit = $"SELECT * FROM {tabela}";
                OleDbDataAdapter da = new OleDbDataAdapter(upit, konekcija);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gridview.DataSource = dt;
            }
        }
    }
}
