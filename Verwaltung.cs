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
    public partial class Verwaltung : Form
    {
        public Verwaltung()
        {
            InitializeComponent();
        }



        private void btnSpeisen_Click(object sender, EventArgs e)
        {
            Speisen s = new Speisen(this);
            s.Show();
            this.Hide();
        }

        private void btnReservierung_Click(object sender, EventArgs e)
        {

            Reservierung r = new Reservierung(this);
            r.Show();
            this.Hide();

        }

        private void btnBestellungen_Click(object sender, EventArgs e)
        {
            Bestellungen b = new Bestellungen(this);
            b.Show();
            this.Hide();
        }

        private void btnMitarbeiter_Click(object sender, EventArgs e)
        {
            Mitarbeiter m = new Mitarbeiter(this);
            m.Show();
            this.Hide();
        }

        private void btnRechnungen_Click(object sender, EventArgs e)
        {
            Rechnungen r = new Rechnungen(this);
            r.Show();
            this.Hide();
        }


        private void btnTische_Click(object sender, EventArgs e)
        {
            Tische t = new Tische(this);
            t.Show();
            this.Hide();
        }

        private void btnAuswertung_Click(object sender, EventArgs e)
        {
            Auswertung a = new Auswertung(this);
            a.Show();
            this.Hide();
        }

    }
}
