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
    public partial class Einloggdaten : Form
    {
        public Einloggdaten()
        {
            InitializeComponent();
        }

        private void Einloggdaten_Load(object sender, EventArgs e)
        {


            txtPasswort.UseSystemPasswordChar = true;


            LbHeadline.Text = "       Willkommen in der Verwaltung der Pizzeria Vevus!";
            LbHeadunder.Text = "  Bitte geben sie ihre Nutzerdaten an!";
            LbNutzername.Text = "Nutzername:";
            LbPasswort.Text = "Passwort:";

        }

        private Dictionary<string, string> benutzer = new Dictionary<string, string>()
        {
           { "LauinPatrono", "Ego" },
           { "RijadCapone", "Csgo2" },
           { "ArtmirBaustella", "Aristoteles" },
           { "Zana", "Kurdistan" }
        };

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nutzer = txtNutzername.Text;
            string passwort = txtPasswort.Text;

            if (benutzer.ContainsKey(nutzer) && benutzer[nutzer] == passwort)
            {
                Verwaltung v = new Verwaltung();
                v.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Falscher Benutzername oder Passwort");
            }
        }







    }
    
}
