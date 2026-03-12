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
    public partial class Speisen : Form
    {

        private Form verwaltung;


        public Speisen(Form form)
        {
            InitializeComponent();
            verwaltung = form;

            LadeSpeisekarte();
            MessageBox.Show("Speisekarte wurde geladen");


        }

        private void btnZurueck_Click(object sender, EventArgs e)
        {
            verwaltung.Show(); 
            this.Close();      
        }

        private void LadeSpeisekarte()
        {

            DataGridViewComboBoxColumn groesseSpalte = (DataGridViewComboBoxColumn)dgvSpeisekarte.Columns["colGroesse"];

            groesseSpalte.Items.Clear();
            groesseSpalte.Items.Add("28 cm");
            groesseSpalte.Items.Add("32 cm");
            groesseSpalte.Items.Add("40 cm");
            groesseSpalte.Items.Add("0,3 l");
            groesseSpalte.Items.Add("0,5 l");
            groesseSpalte.Items.Add("-");

            dgvSpeisekarte.Rows.Clear();
            dgvSpeisekarte.AllowUserToAddRows = false;
            dgvSpeisekarte.RowHeadersVisible = false;

            dgvSpeisekarte.Rows.Add(false, "Pizza", "Pizza Magherita", "28 cm", 1, "8,50 €");
            dgvSpeisekarte.Rows.Add(false, "Pizza", "Pizza Salami", "28 cm", 1, "9,50 €");
            dgvSpeisekarte.Rows.Add(false, "Pizza", "Pizza Hollandaise", "28 cm", 1, "10,50 €");
            dgvSpeisekarte.Rows.Add(false, "Pizza", "Pizza Funghi", "28 cm", 1, "9,00 €");
            dgvSpeisekarte.Rows.Add(false, "Pizza", "Pizza Hawaii", "28 cm", 1, "10,00 €");
            dgvSpeisekarte.Rows.Add(false, "Pizza", "Pizza Sucuk", "28 cm", 1, "11,00 €");

            dgvSpeisekarte.Rows.Add(false, "Pasta", "Pasta Cabonara", "-", 1, "11,50 €");
            dgvSpeisekarte.Rows.Add(false, "Pasta", "Pasta Bolognese", "-", 1, "11,00 €");

            dgvSpeisekarte.Rows.Add(false, "Calzone", "Calzone Haehnchen", "28 cm", 1, "12,00 €");
            dgvSpeisekarte.Rows.Add(false, "Calzone", "Calzone Schwein", "28 cm", 1, "12,00 €");

            dgvSpeisekarte.Rows.Add(false, "Vorspeise", "Bruschetta", "-", 1, "6,50 €");
            dgvSpeisekarte.Rows.Add(false, "Ofengericht", "Lasagne", "-", 1, "11,50 €");

            dgvSpeisekarte.Rows.Add(false, "Getränk", "Coca Cola", "0,3 l", 1, "3,00 €");
            dgvSpeisekarte.Rows.Add(false, "Getränk", "Coca Cola Zero", "0,3 l", 1, "3,00 €");
            dgvSpeisekarte.Rows.Add(false, "Getränk", "Fanta", "0,3 l", 1, "3,00 €");
            dgvSpeisekarte.Rows.Add(false, "Getränk", "Sprite", "0,3 l", 1, "3,00 €");
            dgvSpeisekarte.Rows.Add(false, "Getränk", "Lipton Ice Tea", "0,3 l", 1, "3,50 €");
            dgvSpeisekarte.Rows.Add(false, "Getränk", "Orangensaft", "0,3 l", 1, "3,50 €");
            dgvSpeisekarte.Rows.Add(false, "Getränk", "Bier", "0,3 l", 1, "4,00 €");
            dgvSpeisekarte.Rows.Add(false, "Getränk", "Champagner", "0,3 l", 1, "18,00 €");
            dgvSpeisekarte.Rows.Add(false, "Getränk", "Wasser", "0,3 l", 1, "2,50 €");
            dgvSpeisekarte.Rows.Add(false, "Getränk", "Rotwein", "0,3 l", 1, "6,00 €");
            dgvSpeisekarte.Rows.Add(false, "Getränk", "Weisswein", "0,3 l", 1, "6,00 €");
            dgvSpeisekarte.Rows.Add(false, "Getränk", "Jim Beam", "0,3 l", 1, "5,50 €");


        }


        private double HolePreis(string artikel, string groesse)
        {
            switch (artikel)
            {
                case "Pizza Magherita":
                    if (groesse == "28 cm") return 8.50;
                    if (groesse == "32 cm") return 10.50;
                    if (groesse == "40 cm") return 13.50;
                    break;

                case "Pizza Salami":
                    if (groesse == "28 cm") return 9.50;
                    if (groesse == "32 cm") return 11.50;
                    if (groesse == "40 cm") return 14.50;
                    break;

                case "Pizza Hollandaise":
                    if (groesse == "28 cm") return 10.50;
                    if (groesse == "32 cm") return 12.50;
                    if (groesse == "40 cm") return 15.50;
                    break;

                case "Pizza Funghi":
                    if (groesse == "28 cm") return 9.00;
                    if (groesse == "32 cm") return 11.00;
                    if (groesse == "40 cm") return 14.00;
                    break;

                case "Pizza Hawaii":
                    if (groesse == "28 cm") return 10.00;
                    if (groesse == "32 cm") return 12.00;
                    if (groesse == "40 cm") return 15.00;
                    break;

                case "Pizza Sucuk":
                    if (groesse == "28 cm") return 11.00;
                    if (groesse == "32 cm") return 13.00;
                    if (groesse == "40 cm") return 16.00;
                    break;

                case "Pasta Cabonara":
                    return 11.50;

                case "Pasta Bolognese":
                    return 11.00;

                case "Calzone Haehnchen":
                    if (groesse == "28 cm") return 12.00;
                    if (groesse == "32 cm") return 14.00;
                    if (groesse == "40 cm") return 17.00;
                    break;

                case "Calzone Schwein":
                    if (groesse == "28 cm") return 12.00;
                    if (groesse == "32 cm") return 14.00;
                    if (groesse == "40 cm") return 17.00;
                    break;

                case "Bruschetta":
                    return 6.50;

                case "Lasagne":
                    return 11.50;

                case "Coca Cola":
                case "Coca Cola Zero":
                case "Fanta":
                case "Sprite":
                    if (groesse == "0,3 l") return 3.00;
                    if (groesse == "0,5 l") return 4.50;
                    break;

                case "Lipton Ice Tea":
                case "Orangensaft":
                    if (groesse == "0,3 l") return 3.50;
                    if (groesse == "0,5 l") return 5.00;
                    break;

                case "Bier":
                    if (groesse == "0,3 l") return 4.00;
                    if (groesse == "0,5 l") return 5.50;
                    break;

                case "Champagner":
                    if (groesse == "0,3 l") return 18.00;
                    if (groesse == "0,5 l") return 28.00;
                    break;

                case "Wasser":
                    if (groesse == "0,3 l") return 2.50;
                    if (groesse == "0,5 l") return 3.50;
                    break;

                case "Rotwein":
                case "Weisswein":
                    if (groesse == "0,3 l") return 6.00;
                    if (groesse == "0,5 l") return 8.50;
                    break;

                case "Jim Beam":
                    if (groesse == "0,3 l") return 5.50;
                    if (groesse == "0,5 l") return 8.00;
                    break;
            }

            return 0;
        }


        private void btnBerechnen_Click(object sender, EventArgs e)
        {

            double summe = 0;

            foreach (DataGridViewRow row in dgvSpeisekarte.Rows)
            {
                if (row.Cells["colAuswahl"].Value != null &&
                    Convert.ToBoolean(row.Cells["colAuswahl"].Value) == true)
                {
                    string artikel = row.Cells["colArtikel"].Value.ToString();
                    string groesse = row.Cells["colGroesse"].Value.ToString();

                    double preis = HolePreis(artikel, groesse);

                    row.Cells["colPreis"].Value = preis.ToString("0.00") + " €";
                    summe += preis;
                }
            }

            MessageBox.Show("Gesamtpreis: " + summe.ToString("0.00") + " €");
        }
    }
}
