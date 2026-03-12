namespace Pizzeria_Vevus
{
    partial class Verwaltung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSpeisen = new System.Windows.Forms.Button();
            this.btnReservierung = new System.Windows.Forms.Button();
            this.btnBestellungen = new System.Windows.Forms.Button();
            this.btnMitarbeiter = new System.Windows.Forms.Button();
            this.btnRechnungen = new System.Windows.Forms.Button();
            this.btnAuswertung = new System.Windows.Forms.Button();
            this.btnTische = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSpeisen
            // 
            this.btnSpeisen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSpeisen.Location = new System.Drawing.Point(30, 37);
            this.btnSpeisen.Name = "btnSpeisen";
            this.btnSpeisen.Size = new System.Drawing.Size(104, 39);
            this.btnSpeisen.TabIndex = 0;
            this.btnSpeisen.Text = "Speisen";
            this.btnSpeisen.UseVisualStyleBackColor = true;
            this.btnSpeisen.Click += new System.EventHandler(this.btnSpeisen_Click);
            // 
            // btnReservierung
            // 
            this.btnReservierung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnReservierung.Location = new System.Drawing.Point(30, 154);
            this.btnReservierung.Name = "btnReservierung";
            this.btnReservierung.Size = new System.Drawing.Size(104, 39);
            this.btnReservierung.TabIndex = 1;
            this.btnReservierung.Text = "Reservierung";
            this.btnReservierung.UseVisualStyleBackColor = true;
            this.btnReservierung.Click += new System.EventHandler(this.btnReservierung_Click);
            // 
            // btnBestellungen
            // 
            this.btnBestellungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnBestellungen.Location = new System.Drawing.Point(30, 97);
            this.btnBestellungen.Name = "btnBestellungen";
            this.btnBestellungen.Size = new System.Drawing.Size(104, 39);
            this.btnBestellungen.TabIndex = 2;
            this.btnBestellungen.Text = "Bestellungen";
            this.btnBestellungen.UseVisualStyleBackColor = true;
            this.btnBestellungen.Click += new System.EventHandler(this.btnBestellungen_Click);
            // 
            // btnMitarbeiter
            // 
            this.btnMitarbeiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnMitarbeiter.Location = new System.Drawing.Point(30, 212);
            this.btnMitarbeiter.Name = "btnMitarbeiter";
            this.btnMitarbeiter.Size = new System.Drawing.Size(104, 39);
            this.btnMitarbeiter.TabIndex = 3;
            this.btnMitarbeiter.Text = "Mitarbeiter";
            this.btnMitarbeiter.UseVisualStyleBackColor = true;
            this.btnMitarbeiter.Click += new System.EventHandler(this.btnMitarbeiter_Click);
            // 
            // btnRechnungen
            // 
            this.btnRechnungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnRechnungen.Location = new System.Drawing.Point(30, 267);
            this.btnRechnungen.Name = "btnRechnungen";
            this.btnRechnungen.Size = new System.Drawing.Size(104, 39);
            this.btnRechnungen.TabIndex = 4;
            this.btnRechnungen.Text = "Rechnungen";
            this.btnRechnungen.UseVisualStyleBackColor = true;
            this.btnRechnungen.Click += new System.EventHandler(this.btnRechnungen_Click);
            // 
            // btnAuswertung
            // 
            this.btnAuswertung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAuswertung.Location = new System.Drawing.Point(30, 326);
            this.btnAuswertung.Name = "btnAuswertung";
            this.btnAuswertung.Size = new System.Drawing.Size(104, 39);
            this.btnAuswertung.TabIndex = 5;
            this.btnAuswertung.Text = "Auswertung";
            this.btnAuswertung.UseVisualStyleBackColor = true;
            this.btnAuswertung.Click += new System.EventHandler(this.btnAuswertung_Click);
            // 
            // btnTische
            // 
            this.btnTische.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnTische.Location = new System.Drawing.Point(30, 386);
            this.btnTische.Name = "btnTische";
            this.btnTische.Size = new System.Drawing.Size(104, 39);
            this.btnTische.TabIndex = 6;
            this.btnTische.Text = "Tische";
            this.btnTische.UseVisualStyleBackColor = true;
            this.btnTische.Click += new System.EventHandler(this.btnTische_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(176, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(581, 39);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "                     VERWALTUNGSEBENE";
            // 
            // Verwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTische);
            this.Controls.Add(this.btnAuswertung);
            this.Controls.Add(this.btnRechnungen);
            this.Controls.Add(this.btnMitarbeiter);
            this.Controls.Add(this.btnBestellungen);
            this.Controls.Add(this.btnReservierung);
            this.Controls.Add(this.btnSpeisen);
            this.Name = "Verwaltung";
            this.Text = "Verwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpeisen;
        private System.Windows.Forms.Button btnReservierung;
        private System.Windows.Forms.Button btnBestellungen;
        private System.Windows.Forms.Button btnMitarbeiter;
        private System.Windows.Forms.Button btnRechnungen;
        private System.Windows.Forms.Button btnAuswertung;
        private System.Windows.Forms.Button btnTische;
        private System.Windows.Forms.TextBox textBox1;
    }
}