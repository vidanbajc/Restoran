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
        public static void PopuniGrid(DataGridView gridview, string tabela)
        {
            string putanja = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Restoran.accdb;";

            using (OleDbConnection konekcija = new OleDbConnection(putanja))
            {
                konekcija.Open();
                string upit = $"select * from {tabela}";
                OleDbDataAdapter da = new OleDbDataAdapter(upit, konekcija);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gridview.DataSource = dt;
            }
        }

        public static void PopuniCb(ComboBox cb, string tabela, string atribut)
        {
            string putanja = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Restoran.accdb;";

            using (OleDbConnection konekcija = new OleDbConnection(putanja))
            {
                string upit = $"select {atribut} from {tabela}";

                OleDbDataAdapter da = new OleDbDataAdapter(upit, konekcija);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cb.Items.Clear();

                cb.Items.AddRange(
                    dt.AsEnumerable()
                        .Select(a => a[atribut].ToString())
                        .ToArray());
            }
        }
    }
}
