namespace Pizzeria_Vevus
{
    partial class Rechnungen
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
            this.btnZurueck = new System.Windows.Forms.Button();
            this.dgvRechnung = new System.Windows.Forms.DataGridView();
            this.colBerechnungArtikel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRechnungMenge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRechnungPreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGesamtpreis = new System.Windows.Forms.TextBox();
            this.LbGesamtpreis = new System.Windows.Forms.Label();
            this.txtTisch = new System.Windows.Forms.TextBox();
            this.LbTisch = new System.Windows.Forms.Label();
            this.txtMitarbeiter = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.LbMitarbeiter = new System.Windows.Forms.Label();
            this.LbDatum = new System.Windows.Forms.Label();
            this.LbRechnungsnummer = new System.Windows.Forms.Label();
            this.txtRechnungsnummer = new System.Windows.Forms.TextBox();
            this.btnRechnungAbschliessen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRechnung)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZurueck
            // 
            this.btnZurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnZurueck.Location = new System.Drawing.Point(12, 403);
            this.btnZurueck.Name = "btnZurueck";
            this.btnZurueck.Size = new System.Drawing.Size(100, 35);
            this.btnZurueck.TabIndex = 1;
            this.btnZurueck.Text = "Zurück";
            this.btnZurueck.UseVisualStyleBackColor = true;
            this.btnZurueck.Click += new System.EventHandler(this.btnZurueck_Click);
            // 
            // dgvRechnung
            // 
            this.dgvRechnung.AllowUserToAddRows = false;
            this.dgvRechnung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRechnung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBerechnungArtikel,
            this.colRechnungMenge,
            this.colRechnungPreis});
            this.dgvRechnung.Location = new System.Drawing.Point(15, 50);
            this.dgvRechnung.Name = "dgvRechnung";
            this.dgvRechnung.ReadOnly = true;
            this.dgvRechnung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRechnung.Size = new System.Drawing.Size(370, 199);
            this.dgvRechnung.TabIndex = 3;
            // 
            // colBerechnungArtikel
            // 
            this.colBerechnungArtikel.HeaderText = "Artikel";
            this.colBerechnungArtikel.Name = "colBerechnungArtikel";
            this.colBerechnungArtikel.ReadOnly = true;
            // 
            // colRechnungMenge
            // 
            this.colRechnungMenge.HeaderText = "Menge";
            this.colRechnungMenge.Name = "colRechnungMenge";
            this.colRechnungMenge.ReadOnly = true;
            // 
            // colRechnungPreis
            // 
            this.colRechnungPreis.HeaderText = "Preis";
            this.colRechnungPreis.Name = "colRechnungPreis";
            this.colRechnungPreis.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "RECHNUNGEN";
            // 
            // txtGesamtpreis
            // 
            this.txtGesamtpreis.Location = new System.Drawing.Point(491, 50);
            this.txtGesamtpreis.Name = "txtGesamtpreis";
            this.txtGesamtpreis.ReadOnly = true;
            this.txtGesamtpreis.Size = new System.Drawing.Size(100, 20);
            this.txtGesamtpreis.TabIndex = 5;
            // 
            // LbGesamtpreis
            // 
            this.LbGesamtpreis.AutoSize = true;
            this.LbGesamtpreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.LbGesamtpreis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbGesamtpreis.Location = new System.Drawing.Point(388, 50);
            this.LbGesamtpreis.Name = "LbGesamtpreis";
            this.LbGesamtpreis.Size = new System.Drawing.Size(97, 18);
            this.LbGesamtpreis.TabIndex = 6;
            this.LbGesamtpreis.Text = "Gesamtpreis:";
            // 
            // txtTisch
            // 
            this.txtTisch.Location = new System.Drawing.Point(160, 322);
            this.txtTisch.Name = "txtTisch";
            this.txtTisch.ReadOnly = true;
            this.txtTisch.Size = new System.Drawing.Size(100, 20);
            this.txtTisch.TabIndex = 7;
            // 
            // LbTisch
            // 
            this.LbTisch.AutoSize = true;
            this.LbTisch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.LbTisch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbTisch.Location = new System.Drawing.Point(106, 324);
            this.LbTisch.Name = "LbTisch";
            this.LbTisch.Size = new System.Drawing.Size(48, 18);
            this.LbTisch.TabIndex = 8;
            this.LbTisch.Text = "Tisch:";
            // 
            // txtMitarbeiter
            // 
            this.txtMitarbeiter.Location = new System.Drawing.Point(160, 276);
            this.txtMitarbeiter.Name = "txtMitarbeiter";
            this.txtMitarbeiter.ReadOnly = true;
            this.txtMitarbeiter.Size = new System.Drawing.Size(100, 20);
            this.txtMitarbeiter.TabIndex = 9;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(160, 299);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(100, 20);
            this.txtDatum.TabIndex = 10;
            // 
            // LbMitarbeiter
            // 
            this.LbMitarbeiter.AutoSize = true;
            this.LbMitarbeiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.LbMitarbeiter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbMitarbeiter.Location = new System.Drawing.Point(73, 275);
            this.LbMitarbeiter.Name = "LbMitarbeiter";
            this.LbMitarbeiter.Size = new System.Drawing.Size(81, 18);
            this.LbMitarbeiter.TabIndex = 11;
            this.LbMitarbeiter.Text = "Mitarbeiter:";
            // 
            // LbDatum
            // 
            this.LbDatum.AutoSize = true;
            this.LbDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.LbDatum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbDatum.Location = new System.Drawing.Point(98, 298);
            this.LbDatum.Name = "LbDatum";
            this.LbDatum.Size = new System.Drawing.Size(56, 18);
            this.LbDatum.TabIndex = 12;
            this.LbDatum.Text = "Datum:";
            // 
            // LbRechnungsnummer
            // 
            this.LbRechnungsnummer.AutoSize = true;
            this.LbRechnungsnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.LbRechnungsnummer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbRechnungsnummer.Location = new System.Drawing.Point(12, 252);
            this.LbRechnungsnummer.Name = "LbRechnungsnummer";
            this.LbRechnungsnummer.Size = new System.Drawing.Size(142, 18);
            this.LbRechnungsnummer.TabIndex = 14;
            this.LbRechnungsnummer.Text = "Rechnungsnummer:";
            // 
            // txtRechnungsnummer
            // 
            this.txtRechnungsnummer.Location = new System.Drawing.Point(160, 252);
            this.txtRechnungsnummer.Name = "txtRechnungsnummer";
            this.txtRechnungsnummer.ReadOnly = true;
            this.txtRechnungsnummer.Size = new System.Drawing.Size(100, 20);
            this.txtRechnungsnummer.TabIndex = 13;
            // 
            // btnRechnungAbschliessen
            // 
            this.btnRechnungAbschliessen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnRechnungAbschliessen.Location = new System.Drawing.Point(160, 348);
            this.btnRechnungAbschliessen.Name = "btnRechnungAbschliessen";
            this.btnRechnungAbschliessen.Size = new System.Drawing.Size(191, 35);
            this.btnRechnungAbschliessen.TabIndex = 15;
            this.btnRechnungAbschliessen.Text = "Rechnung Abschließen";
            this.btnRechnungAbschliessen.UseVisualStyleBackColor = true;
            this.btnRechnungAbschliessen.Click += new System.EventHandler(this.btnRechnungAbschliessen_Click);
            // 
            // Rechnungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRechnungAbschliessen);
            this.Controls.Add(this.LbRechnungsnummer);
            this.Controls.Add(this.txtRechnungsnummer);
            this.Controls.Add(this.LbDatum);
            this.Controls.Add(this.LbMitarbeiter);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtMitarbeiter);
            this.Controls.Add(this.LbTisch);
            this.Controls.Add(this.txtTisch);
            this.Controls.Add(this.LbGesamtpreis);
            this.Controls.Add(this.txtGesamtpreis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRechnung);
            this.Controls.Add(this.btnZurueck);
            this.Name = "Rechnungen";
            this.Text = "Rechnungen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRechnung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZurueck;
        private System.Windows.Forms.DataGridView dgvRechnung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBerechnungArtikel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRechnungMenge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRechnungPreis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGesamtpreis;
        private System.Windows.Forms.Label LbGesamtpreis;
        private System.Windows.Forms.TextBox txtTisch;
        private System.Windows.Forms.Label LbTisch;
        private System.Windows.Forms.TextBox txtMitarbeiter;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label LbMitarbeiter;
        private System.Windows.Forms.Label LbDatum;
        private System.Windows.Forms.Label LbRechnungsnummer;
        private System.Windows.Forms.TextBox txtRechnungsnummer;
        private System.Windows.Forms.Button btnRechnungAbschliessen;
    }
}