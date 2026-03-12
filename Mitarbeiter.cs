using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pizzeria_Vevus
{
    public partial class Mitarbeiter : Form
    {
        private Form verwaltung;

        public Mitarbeiter(Form form)
        {
            InitializeComponent();
            verwaltung = form;

            cmbRolle.Items.Add("Admin");
            cmbRolle.Items.Add("Manager");
            cmbRolle.Items.Add("Mitarbeiter");
            cmbRolle.Items.Add("Praktikant");

            cmbBereich.Items.Add("Terasse");
            cmbBereich.Items.Add("VIP");
            cmbBereich.Items.Add("Haupt Bereich");
            cmbBereich.Items.Add("Familien Bereich");
            cmbBereich.Items.Add("Küche");

            LadeMitarbeiter();
        }

        private void btnZurueck_Click(object sender, EventArgs e)
        {
            verwaltung.Show();
            this.Close();
        }

        private void txtVorname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }

        }

        private void txtNachname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void btnNeu_Click(object sender, EventArgs e)
        {
           
            txtVorname.Clear();
            txtname.Clear();
            txtPasswort.Clear();
            cmbRolle.SelectedIndex = -1;
            cmbBereich.SelectedIndex = -1;
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            string vorname = txtVorname.Text.Trim();
            string nachname = txtname.Text.Trim();
            string name = vorname + " " + nachname;
            string rolle = cmbRolle.Text;
            string bereich = cmbBereich.Text;
            string passwort = txtPasswort.Text.Trim();

            if (vorname == "" || nachname == "" || rolle == "" || bereich == "" || passwort == "")
            {
                MessageBox.Show("Bitte alle Felder ausfüllen.");
                return;
            }
            string connectionString = "server=localhost;database=riki;uid=root;Rikiriki13=;";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = "INSERT INTO mitarbeiter (name, passwort, rolle, bereich) VALUES (@name, @passwort, @rolle, @bereich)";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@passwort", passwort);
                    cmd.Parameters.AddWithValue("@rolle", rolle.ToLower());
                    cmd.Parameters.AddWithValue("@bereich", bereich);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Mitarbeiter gespeichert.");

            txtVorname.Clear();
            txtname.Clear();
            txtPasswort.Clear();
            cmbRolle.SelectedIndex = -1;
            cmbBereich.SelectedIndex = -1;
        }


        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            if (dgvMitarbeiter.SelectedRows.Count > 0)
            {
                dgvMitarbeiter.Rows.RemoveAt(dgvMitarbeiter.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Bitte zuerst einen Mitarbeiter auswählen.");
            }
        }




        private void LadeMitarbeiter()
        {
            dgvMitarbeiter.Rows.Clear();

            string connectionString = "server=127.0.0.1;port=3306;database=riki;uid=root;pwd=DEIN_ECHTES_PASSWORT;";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT id, name, rolle, bereich FROM mitarbeiter";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvMitarbeiter.Rows.Add(
                                reader["id"],
                                reader["name"],
                                reader["rolle"],
                                reader["bereich"]
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankverbindung:\n" + ex.Message);
            }
        }
    }

}
