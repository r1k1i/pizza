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
    public partial class Auswertung : Form
    {
        private Form verwaltung;

        public Auswertung(Form form)
        {
            InitializeComponent();
            verwaltung = form;
        }

        private void btnZurueck_Click(object sender, EventArgs e)
        {
            verwaltung.Show();
            this.Close();
        }
    }
}
