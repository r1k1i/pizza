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
    public partial class Tische : Form
    {
        private Form verwaltung;
        private Dictionary<int, string> tischStatus = new Dictionary<int, string>();

        public Tische(Form form)
        {
            InitializeComponent();
            verwaltung = form;

            for (int i = 1; i <= 35; i++)
            {
                tischStatus[i] = "frei";
            }

            // Beispielstatus
            tischStatus[2] = "reserviert";
            tischStatus[5] = "besetzt";
            tischStatus[12] = "reserviert";
            tischStatus[18] = "besetzt";
            tischStatus[27] = "reserviert";
            tischStatus[34] = "besetzt";

            ZeigeHauptbereich();
        }
    


        private void AlleTischeAusblenden()
        {
            for (int i = 1; i <= 35; i++)
            {
                Button btn = this.Controls.Find("btnTisch" + i, true).FirstOrDefault() as Button;

                if (btn != null)
                {
                    btn.Visible = false;
                }
            }
        }



        private void ZeigeHauptbereich()
        {
            AlleTischeAusblenden();

            btnTisch1.Visible = true;
            btnTisch2.Visible = true;
            btnTisch3.Visible = true;
            btnTisch11.Visible = true;
            btnTisch12.Visible = true;
            btnTisch13.Visible = true;
            btnTisch21.Visible = true;
            btnTisch22.Visible = true;
            btnTisch26.Visible = true;
            btnTisch27.Visible = true;
            btnTisch31.Visible = true;
            btnTisch32.Visible = true;

            LbBereich.Text = "Hauptbereich";
            AktualisiereTischFarben();
        }


        private void ZeigeVIP()
        {
            AlleTischeAusblenden();

            btnTisch4.Visible = true;
            btnTisch5.Visible = true;
            btnTisch6.Visible = true;
            btnTisch14.Visible = true;
            btnTisch15.Visible = true;
            btnTisch16.Visible = true;
            btnTisch23.Visible = true;
            btnTisch24.Visible = true;
            btnTisch28.Visible = true;
            btnTisch29.Visible = true;
            btnTisch33.Visible = true;
            btnTisch34.Visible = true;

            LbBereich.Text = "VIP-Bereich";
            AktualisiereTischFarben();
        }

        private void ZeigeTerasse()
        {
            AlleTischeAusblenden();

            btnTisch7.Visible = true;
            btnTisch8.Visible = true;
            btnTisch9.Visible = true;
            btnTisch10.Visible = true;
            btnTisch17.Visible = true;
            btnTisch18.Visible = true;
            btnTisch19.Visible = true;
            btnTisch20.Visible = true;
            btnTisch25.Visible = true;
            btnTisch30.Visible = true;
            btnTisch35.Visible = true;

            LbBereich.Text = "Terasse";
            AktualisiereTischFarben();


        }


        private void AktualisiereTischFarben()
        {
            for (int i = 1; i <= 35; i++)
            {
                Button btn = this.Controls.Find("btnTisch" + i, true).FirstOrDefault() as Button;

                if (btn != null)
                {
                    string status = tischStatus[i];

                    if (status == "frei")
                        btn.BackColor = Color.LightGreen;
                    else if (status == "reserviert")
                        btn.BackColor = Color.Gold;
                    else if (status == "besetzt")
                        btn.BackColor = Color.IndianRed;
                }
            }
        }




        private void btnVIPBereich_Click(object sender, EventArgs e)
        {
            ZeigeVIP();
        }


        private void btnTerasse_Click(object sender, EventArgs e)
        {
            ZeigeTerasse();
        }


        private void btnHauptbereich_Click(object sender, EventArgs e)
        {
            ZeigeHauptbereich();
        }


        private void btnZurueck_Click(object sender, EventArgs e)
        {
            verwaltung.Show();
            this.Close();
        }
    }
}
