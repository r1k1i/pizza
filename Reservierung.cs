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
    public partial class Reservierung : Form
    {
        private Form verwaltung;

        public Reservierung(Form form)
        {
            InitializeComponent();
            verwaltung = form;

            LadeUhrzeiten();
            LadeFreieTische();
            txtTelefon.Text = "+49";
        }

        private void LadeFreieTische()
        {
            cmbTischnummer.Items.Clear();

            for (int i = 1; i <= 35; i++)
            {
                cmbTischnummer.Items.Add("Tisch " + i);
            }
        }


        private void btnZurueck_Click(object sender, EventArgs e)
        {
            verwaltung.Show();
            this.Close();
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // Backspace erlauben
            if (char.IsControl(e.KeyChar))
            {
                // verhindern dass +49 gelöscht wird
                if (txtTelefon.SelectionStart <= 3 && e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = true;
                }
                return;
            }

            // nur Zahlen erlauben
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }

           

        }

        private bool IstFeiertag(DateTime datum)
        {
            int jahr = datum.Year;

            // Feste bundeseinheitliche Feiertage
            if ((datum.Day == 1 && datum.Month == 1) ||     // Neujahr
                (datum.Day == 1 && datum.Month == 5) ||     // Tag der Arbeit
                (datum.Day == 3 && datum.Month == 10) ||    // Tag der Deutschen Einheit
                (datum.Day == 25 && datum.Month == 12) ||   // 1. Weihnachtstag
                (datum.Day == 26 && datum.Month == 12))     // 2. Weihnachtstag
            {
                return true;
            }

            // Bewegliche Feiertage anhand von Ostern
            DateTime ostersonntag = BerechneOstersonntag(jahr);

            if (datum == ostersonntag.AddDays(-2)) return true; // Karfreitag
            if (datum == ostersonntag.AddDays(1)) return true;  // Ostermontag
            if (datum == ostersonntag.AddDays(39)) return true; // Christi Himmelfahrt
            if (datum == ostersonntag.AddDays(50)) return true; // Pfingstmontag

            return false;
        }

        private DateTime BerechneOstersonntag(int jahr)
        {
            int a = jahr % 19;
            int b = jahr / 100;
            int c = jahr % 100;
            int d = b / 4;
            int e = b % 4;
            int f = (b + 8) / 25;
            int g = (b - f + 1) / 3;
            int h = (19 * a + b - d - g + 15) % 30;
            int i = c / 4;
            int k = c % 4;
            int l = (32 + 2 * e + 2 * i - h - k) % 7;
            int m = (a + 11 * h + 22 * l) / 451;
            int monat = (h + l - 7 * m + 114) / 31;
            int tag = ((h + l - 7 * m + 114) % 31) + 1;

            return new DateTime(jahr, monat, tag);
        }

        private void dtpDatum_ValueChanged(object sender, EventArgs e)
        {
            DateTime datum = dtpDatum.Value.Date;

            if (datum.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("An Sonntagen haben wir geschlossen.");
                dtpDatum.Value = DateTime.Today;
                return;
            }

            if (IstFeiertag(datum))
            {
                MessageBox.Show("An Feiertagen haben wir geschlossen.");
                dtpDatum.Value = DateTime.Today;
            }
        }


        private void LadeUhrzeiten()
            {
            cmbUhrzeit.Items.Clear();

            for (int stunde = 11; stunde <= 23; stunde++)
            {
                cmbUhrzeit.Items.Add(stunde.ToString("00") + ":00");

                if (stunde != 23)
                {
                    cmbUhrzeit.Items.Add(stunde.ToString("00") + ":30");
                }
            }

            cmbUhrzeit.DropDownStyle = ComboBoxStyle.DropDownList;
            }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string telefon = txtTelefon.Text.Trim();
            DateTime datum = dtpDatum.Value.Date;
            string uhrzeit = cmbUhrzeit.Text;

            if (datum.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("An Sonntagen haben wir geschlossen.");
                return;
            }

            if (IstFeiertag(datum))
            {
                MessageBox.Show("An Feiertagen haben wir geschlossen.");
                return;
            }

            if (string.IsNullOrWhiteSpace(uhrzeit))
            {
                MessageBox.Show("Bitte eine Uhrzeit auswählen.");
                return;
            }

            MessageBox.Show("Reservierung gespeichert.");





            if ((int)numPersonen.Value <= 10 && string.IsNullOrWhiteSpace(cmbTischnummer.Text))
            {
                MessageBox.Show("Bitte wählen Sie eine Tischnummer aus.");
                return;
            }

            if ((int)numPersonen.Value > 10)
            {
                MessageBox.Show("Für mehr als 10 Personen müssen mehrere Tische reserviert werden.");
                return;
            }


        }

        private void numPersonen_ValueChanged(object sender, EventArgs e)
        {
            int personen = (int)numPersonen.Value;

            if (personen > 10)
            {
                int benoetigteTische = (int)Math.Ceiling(personen / 10.0);

                MessageBox.Show(
                "Für " + personen + " Personen werden " + benoetigteTische + " Tische benötigt.\n" +
                "Ein einzelner Tisch reicht nicht aus."
                );

                if (personen > 10)
                {
                    MessageBox.Show("Für mehr als 10 Personen reicht ein Tisch nicht aus. Bitte mehrere Tische reservieren.");
                    cmbTischnummer.Enabled = false;
                    cmbTischnummer.SelectedIndex = -1;
                }
                else
                {
                    cmbTischnummer.Enabled = true;
                }

            }
        }

        private void txtTelefon_Enter(object sender, EventArgs e)
        {
            if (txtTelefon.Text == "+49")
            {
                txtTelefon.SelectionStart = txtTelefon.Text.Length;
            }

        }
    }

}
