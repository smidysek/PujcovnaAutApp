using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace PujcovnaAutApp
{
    public partial class FormPujcky : Form
    {
        public FormPujcky()
        {
            InitializeComponent();
            txtVyhledat.TextChanged += FilterChanged;
            txtVyhledatAuto.TextChanged += FilterChanged;
            NacistPujcky();
        }

        private void NacistPujcky(string hledatZakaznik = "", string hledatAuto = "")
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                var query = @"
            SELECT Pujcky.ID, 
                   Zakaznici.Jmeno || ' ' || Zakaznici.Prijmeni AS Zakaznik, 
                   Auta.Znacka || ' ' || Auta.Model AS Auto, 
                   Pujcky.DatumOd, Pujcky.DatumDo
            FROM Pujcky
            JOIN Zakaznici ON Pujcky.ZakaznikID = Zakaznici.ID
            JOIN Auta ON Pujcky.AutoID = Auta.ID
            WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(hledatZakaznik))
                {
                    query += " AND Zakaznici.Jmeno || ' ' || Zakaznici.Prijmeni LIKE @hledatZakaznik";
                }

                if (!string.IsNullOrWhiteSpace(hledatAuto))
                {
                    query += " AND Auta.Znacka || ' ' || Auta.Model LIKE @hledatAuto";
                }

                query += " ORDER BY Pujcky.DatumOd DESC;";

                var adapter = new SQLiteDataAdapter(query, conn);

                if (!string.IsNullOrWhiteSpace(hledatZakaznik))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@hledatZakaznik", $"%{hledatZakaznik}%");
                }

                if (!string.IsNullOrWhiteSpace(hledatAuto))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@hledatAuto", $"%{hledatAuto}%");
                }

                var dt = new DataTable();
                adapter.Fill(dt);
                dgvPujcky.DataSource = dt;
            }
        }


        private void btnObnovit_Click(object sender, EventArgs e)
        {
            txtVyhledat.Clear();
            txtVyhledatAuto.Clear();
            NacistPujcky();
        }

        private void btnVyhledat_Click(object sender, EventArgs e)
        {
            NacistPujcky(txtVyhledat.Text);
        }

        private void btnSmazat_Click(object sender, EventArgs e)
        {
            if (dgvPujcky.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vyberte půjčku k odstranění.");
                return;
            }

            int id = Convert.ToInt32(dgvPujcky.SelectedRows[0].Cells["ID"].Value);

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Pujcky WHERE ID = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Půjčka smazána.");
            NacistPujcky();
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            NacistPujcky(txtVyhledat.Text, txtVyhledatAuto.Text);
        }

        private void txtVyhledat_TextChanged(object sender, EventArgs e)
        {
            NacistPujcky(txtVyhledat.Text);
        }
    }
}
