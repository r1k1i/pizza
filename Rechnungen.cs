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
    public partial class Rechnungen : Form
    {
        private Form verwaltung;

        public Rechnungen(Form form)
        {
            InitializeComponent();
            verwaltung = form;
        




        }

        private Form Bestellungen;
        public Rechnungen(Form form, DataGridViewRowCollection bestellRows, string gesamtpreis, string mitarbeiter, string tisch, string datum)
        {
            InitializeComponent();
            Bestellungen = form;

            txtGesamtpreis.Text = gesamtpreis;
            txtMitarbeiter.Text = mitarbeiter;
            txtTisch.Text = tisch;
            txtDatum.Text = datum;
            txtRechnungsnummer.Text = DateTime.Now.Ticks.ToString();

            foreach (DataGridViewRow row in bestellRows)
            {
                if (!row.IsNewRow)
                {
                    dgvRechnung.Rows.Add(
                        row.Cells["colBestellArtikel"].Value,
                        row.Cells["colBestellMenge"].Value,
                        row.Cells["colBestellPreis"].Value
                    );
                }
            }
        }


        

        private void btnZurueck_Click(object sender, EventArgs e)
        {
            verwaltung.Show();
            this.Close();

        }

        private void btnRechnungAbschliessen_Click(object sender, EventArgs e)
        {
            if (dgvRechnung.Rows.Count == 0)
            {
                MessageBox.Show("Keine Rechnung vorhanden.");
                return;
            }

            MessageBox.Show("Rechnung erfolgreich abgeschlossen!");

            dgvRechnung.Rows.Clear();
            txtGesamtpreis.Text = "0,00 €";
        }


    }
}
