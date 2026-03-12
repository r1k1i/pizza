using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria_Vevus
{
    public partial class Bestellungen : Form
    {
        private Form verwaltung;

        public Bestellungen(Form form)
        {
            InitializeComponent();
            verwaltung = form;

            LadeSpeisen();
            LadeArtikel();

            // Tische laden
            for (int i = 1; i <= 35; i++)
            {
                cmbTisch.Items.Add("Tisch " + i);
            }

            // Mitarbeiter laden
            cmbMitarbeiter.Items.Add("Artmir Genovese");
            cmbMitarbeiter.Items.Add("Rijad Capone");
            cmbMitarbeiter.Items.Add("Lauin Nostra");
            cmbMitarbeiter.Items.Add("Zana Gambino");
            cmbMitarbeiter.Items.Add("Mario Makaveli");

            cmbTisch.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMitarbeiter.DropDownStyle = ComboBoxStyle.DropDownList;
        
        }

        private void btnZurueck_Click(object sender, EventArgs e)
        {
            verwaltung.Show();
            this.Close();
        }












        private void BerechneGesamtpreis()
        {
            double summe = 0;

            foreach (DataGridViewRow row in dgvBestellkorb.Rows)
            {
                if (row.Cells["colBestellPreis"].Value != null)
                {
                    string preisText = row.Cells["colBestellPreis"].Value.ToString()
                        .Replace("€", "")
                        .Trim()
                        .Replace(",", ".");

                    summe += Convert.ToDouble(preisText, System.Globalization.CultureInfo.InvariantCulture);
                }
            }

            txtGesamtpreis.Text = summe.ToString("0.00") + " €";
        }














        private void btnHinzufuegen_Click(object sender, EventArgs e)
        {
            if (dgvArtikel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bitte zuerst einen Artikel auswählen.");
                return;
            }

            string artikel = dgvArtikel.SelectedRows[0].Cells["colArtikelName"].Value.ToString();
            double preis = Convert.ToDouble(
                dgvArtikel.SelectedRows[0].Cells["colArtikelPreis"].Value.ToString().Replace(",", "."),
                System.Globalization.CultureInfo.InvariantCulture);

            bool gefunden = false;

            foreach (DataGridViewRow row in dgvBestellkorb.Rows)
            {
                if (row.Cells["colBestellArtikel"].Value != null &&
                    row.Cells["colBestellArtikel"].Value.ToString() == artikel)
                {
                    int menge = Convert.ToInt32(row.Cells["colBestellMenge"].Value);
                    menge++;

                    row.Cells["colBestellMenge"].Value = menge;
                    row.Cells["colBestellPreis"].Value = (menge * preis).ToString("0.00") + " €";

                    gefunden = true;
                    break;
                }
            }

            if (!gefunden)
            {
                dgvBestellkorb.Rows.Add(artikel, 1, preis.ToString("0.00") + " €");
            }

            BerechneGesamtpreis();
        }


















        private void btnEntfernen_Click(object sender, EventArgs e)
        {
            if (dgvBestellkorb.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bitte zuerst einen Artikel im Bestellkorb auswählen.");
                return;
            }

            DataGridViewRow row = dgvBestellkorb.SelectedRows[0];

            int menge = Convert.ToInt32(row.Cells["colBestellMenge"].Value);

            string preisText = row.Cells["colBestellPreis"].Value.ToString()
                .Replace("€", "")
                .Trim()
                .Replace(",", ".");

            double gesamtpreis = Convert.ToDouble(preisText, System.Globalization.CultureInfo.InvariantCulture);
            double einzelpreis = gesamtpreis / menge;

            if (menge > 1)
            {
                menge--;
                row.Cells["colBestellMenge"].Value = menge;
                row.Cells["colBestellPreis"].Value = (einzelpreis * menge).ToString("0.00") + " €";
            }
            else
            {
                dgvBestellkorb.Rows.Remove(row);
            }

            BerechneGesamtpreis();
        }














        private void btnBestellungAbschliessen_Click(object sender, EventArgs e)
        {
            if (dgvBestellkorb.Rows.Count == 0)
            {
                MessageBox.Show("Es wurde nichts bestellt.");
                return;
            }

            MessageBox.Show("Bestellung erfolgreich aufgenommen!");

            dgvBestellkorb.Rows.Clear();
            txtGesamtpreis.Text = "0,00 €";
        }
















        private void LadeSpeisen()
        {
            dgvArtikel.Rows.Clear();

            string connectionString = "server=127.0.0.1;port=3306;database=riki;uid=root;pwd=DEIN_PASSWORT;";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT id, name, preis FROM speisen";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvArtikel.Rows.Add(
                                reader["id"],
                                reader["name"],
                                reader["preis"]
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Laden der Speisen:\n" + ex.Message);
            }
        }


        private void LadeArtikel()
        {
            dgvArtikel.Rows.Clear();



            dgvArtikel.Rows.Clear();

            dgvArtikel.Rows.Add(1, "Pizza Margherita", 8.50);
            dgvArtikel.Rows.Add(2, "Pizza Salami", 9.20);
            dgvArtikel.Rows.Add(3, "Pizza Funghi", 8.90);
            dgvArtikel.Rows.Add(4, "Pizza Hawaii", 9.50);
            dgvArtikel.Rows.Add(5, "Pizza Sucuk", 9.50);
            dgvArtikel.Rows.Add(6, "Pizza Hollandaise", 10.50);

            dgvArtikel.Rows.Add(7, "Pasta Carbonara", 7.50);
            dgvArtikel.Rows.Add(8, "Pasta Bolognese", 6.50);
            dgvArtikel.Rows.Add(9, "Calzone Hähnchen", 4.50);
            dgvArtikel.Rows.Add(10, "Bruschetta", 2.50);
            dgvArtikel.Rows.Add(11, "Lasagne", 5.50);

            dgvArtikel.Rows.Add(12, "Cola", 3.50);
            dgvArtikel.Rows.Add(13, "Bier", 4.20);
            dgvArtikel.Rows.Add(14, "Kaffee", 2.80);
            dgvArtikel.Rows.Add(15, "Orangensaft", 3.20);
            dgvArtikel.Rows.Add(16, "Mineralwasser", 2.50);



            string connectionString = "server=127.0.0.1;port=3306;database=riki;uid=root;pwd=DEIN_PASSWORT;";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    // Speisen laden
                    string querySpeisen = "SELECT id, name, preis FROM speisen";

                    using (MySqlCommand cmd = new MySqlCommand(querySpeisen, con))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvArtikel.Rows.Add(
                                reader["id"],
                                reader["name"],
                                reader["preis"]
                            );
                        }
                    }

                    // Getränke laden
                    string queryGetraenke = "SELECT id, name, preis FROM getraenke";

                    using (MySqlCommand cmd = new MySqlCommand(queryGetraenke, con))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvArtikel.Rows.Add(
                                reader["id"],
                                reader["name"],
                                reader["preis"]
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Laden der Artikel:\n" + ex.Message);
            }
        }




        private void btnZurRechnung_Click(object sender, EventArgs e)
        {
            if (dgvBestellkorb.Rows.Count == 0)
            {
                MessageBox.Show("Es ist keine Bestellung vorhanden.");
                return;
            }

            if (cmbMitarbeiter.Text == "")
            {
                MessageBox.Show("Bitte einen Mitarbeiter auswählen.");
                return;
            }

            if (cmbTisch.Text == "")
            {
                MessageBox.Show("Bitte einen Tisch auswählen.");
                return;
            }

            string gesamtpreis = txtGesamtpreis.Text;
            string mitarbeiter = cmbMitarbeiter.Text;
            string tisch = cmbTisch.Text;
            string datum = dtpBestellungen.Value.ToString("dd.MM.yyyy HH:mm");

            Rechnungen rechnung = new Rechnungen(this, dgvBestellkorb.Rows, gesamtpreis, mitarbeiter, tisch, datum);
            rechnung.Show();
            this.Hide();
        }

        
    }
}
