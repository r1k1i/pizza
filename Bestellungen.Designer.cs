namespace Pizzeria_Vevus
{
    partial class Bestellungen
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvArtikel = new System.Windows.Forms.DataGridView();
            this.colArtikelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArtikelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArtikelPreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBestellkorb = new System.Windows.Forms.DataGridView();
            this.colBestellArtikel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBestellMenge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBestellPreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHinzufuegen = new System.Windows.Forms.Button();
            this.btnEntfernen = new System.Windows.Forms.Button();
            this.txtGesamtpreis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBestellungAbschliessen = new System.Windows.Forms.Button();
            this.dtpBestellungen = new System.Windows.Forms.DateTimePicker();
            this.cmbTisch = new System.Windows.Forms.ComboBox();
            this.cmbMitarbeiter = new System.Windows.Forms.ComboBox();
            this.btnLeeren = new System.Windows.Forms.Button();
            this.LbMitarbeiter = new System.Windows.Forms.Label();
            this.LbTisch = new System.Windows.Forms.Label();
            this.btnZurRechnung = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestellkorb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZurueck
            // 
            this.btnZurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnZurueck.Location = new System.Drawing.Point(12, 403);
            this.btnZurueck.Name = "btnZurueck";
            this.btnZurueck.Size = new System.Drawing.Size(100, 35);
            this.btnZurueck.TabIndex = 2;
            this.btnZurueck.Text = "Zurück";
            this.btnZurueck.UseVisualStyleBackColor = true;
            this.btnZurueck.Click += new System.EventHandler(this.btnZurueck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(316, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bestellungen";
            // 
            // dgvArtikel
            // 
            this.dgvArtikel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colArtikelID,
            this.colArtikelName,
            this.colArtikelPreis});
            this.dgvArtikel.Location = new System.Drawing.Point(10, 107);
            this.dgvArtikel.Name = "dgvArtikel";
            this.dgvArtikel.Size = new System.Drawing.Size(341, 281);
            this.dgvArtikel.TabIndex = 4;
            // 
            // colArtikelID
            // 
            this.colArtikelID.HeaderText = "ID";
            this.colArtikelID.Name = "colArtikelID";
            // 
            // colArtikelName
            // 
            this.colArtikelName.HeaderText = "Name";
            this.colArtikelName.Name = "colArtikelName";
            // 
            // colArtikelPreis
            // 
            this.colArtikelPreis.HeaderText = "Preis";
            this.colArtikelPreis.Name = "colArtikelPreis";
            // 
            // dgvBestellkorb
            // 
            this.dgvBestellkorb.AllowUserToAddRows = false;
            this.dgvBestellkorb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBestellkorb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBestellArtikel,
            this.colBestellMenge,
            this.colBestellPreis});
            this.dgvBestellkorb.Location = new System.Drawing.Point(438, 107);
            this.dgvBestellkorb.MultiSelect = false;
            this.dgvBestellkorb.Name = "dgvBestellkorb";
            this.dgvBestellkorb.ReadOnly = true;
            this.dgvBestellkorb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBestellkorb.Size = new System.Drawing.Size(341, 281);
            this.dgvBestellkorb.TabIndex = 5;
            // 
            // colBestellArtikel
            // 
            this.colBestellArtikel.HeaderText = "Artikel";
            this.colBestellArtikel.Name = "colBestellArtikel";
            this.colBestellArtikel.ReadOnly = true;
            // 
            // colBestellMenge
            // 
            this.colBestellMenge.HeaderText = "Menge";
            this.colBestellMenge.Name = "colBestellMenge";
            this.colBestellMenge.ReadOnly = true;
            // 
            // colBestellPreis
            // 
            this.colBestellPreis.HeaderText = "Preis";
            this.colBestellPreis.Name = "colBestellPreis";
            this.colBestellPreis.ReadOnly = true;
            // 
            // btnHinzufuegen
            // 
            this.btnHinzufuegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnHinzufuegen.Location = new System.Drawing.Point(357, 201);
            this.btnHinzufuegen.Name = "btnHinzufuegen";
            this.btnHinzufuegen.Size = new System.Drawing.Size(75, 23);
            this.btnHinzufuegen.TabIndex = 6;
            this.btnHinzufuegen.Text = "+";
            this.btnHinzufuegen.UseVisualStyleBackColor = true;
            this.btnHinzufuegen.Click += new System.EventHandler(this.btnHinzufuegen_Click);
            // 
            // btnEntfernen
            // 
            this.btnEntfernen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnEntfernen.Location = new System.Drawing.Point(357, 241);
            this.btnEntfernen.Name = "btnEntfernen";
            this.btnEntfernen.Size = new System.Drawing.Size(75, 23);
            this.btnEntfernen.TabIndex = 7;
            this.btnEntfernen.Text = "-";
            this.btnEntfernen.UseVisualStyleBackColor = true;
            this.btnEntfernen.Click += new System.EventHandler(this.btnEntfernen_Click);
            // 
            // txtGesamtpreis
            // 
            this.txtGesamtpreis.Location = new System.Drawing.Point(667, 412);
            this.txtGesamtpreis.Name = "txtGesamtpreis";
            this.txtGesamtpreis.ReadOnly = true;
            this.txtGesamtpreis.Size = new System.Drawing.Size(100, 20);
            this.txtGesamtpreis.TabIndex = 8;
            this.txtGesamtpreis.Text = "0,00€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(551, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gesamtpreis:";
            // 
            // btnBestellungAbschliessen
            // 
            this.btnBestellungAbschliessen.Location = new System.Drawing.Point(332, 394);
            this.btnBestellungAbschliessen.Name = "btnBestellungAbschliessen";
            this.btnBestellungAbschliessen.Size = new System.Drawing.Size(134, 23);
            this.btnBestellungAbschliessen.TabIndex = 22;
            this.btnBestellungAbschliessen.Text = "Bestellung abschließen";
            this.btnBestellungAbschliessen.UseVisualStyleBackColor = true;
            this.btnBestellungAbschliessen.Click += new System.EventHandler(this.btnBestellungAbschliessen_Click);
            // 
            // dtpBestellungen
            // 
            this.dtpBestellungen.Location = new System.Drawing.Point(10, 12);
            this.dtpBestellungen.Name = "dtpBestellungen";
            this.dtpBestellungen.Size = new System.Drawing.Size(176, 20);
            this.dtpBestellungen.TabIndex = 21;
            // 
            // cmbTisch
            // 
            this.cmbTisch.FormattingEnabled = true;
            this.cmbTisch.Location = new System.Drawing.Point(667, 36);
            this.cmbTisch.Name = "cmbTisch";
            this.cmbTisch.Size = new System.Drawing.Size(121, 21);
            this.cmbTisch.TabIndex = 20;
        
            // 
            // cmbMitarbeiter
            // 
            this.cmbMitarbeiter.FormattingEnabled = true;
            this.cmbMitarbeiter.Location = new System.Drawing.Point(667, 11);
            this.cmbMitarbeiter.Name = "cmbMitarbeiter";
            this.cmbMitarbeiter.Size = new System.Drawing.Size(121, 21);
            this.cmbMitarbeiter.TabIndex = 19;
            // 
            // btnLeeren
            // 
            this.btnLeeren.Location = new System.Drawing.Point(720, 78);
            this.btnLeeren.Name = "btnLeeren";
            this.btnLeeren.Size = new System.Drawing.Size(59, 23);
            this.btnLeeren.TabIndex = 23;
            this.btnLeeren.Text = "Leeren";
            this.btnLeeren.UseVisualStyleBackColor = true;
            // 
            // LbMitarbeiter
            // 
            this.LbMitarbeiter.AutoSize = true;
            this.LbMitarbeiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LbMitarbeiter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbMitarbeiter.Location = new System.Drawing.Point(567, 13);
            this.LbMitarbeiter.Name = "LbMitarbeiter";
            this.LbMitarbeiter.Size = new System.Drawing.Size(94, 20);
            this.LbMitarbeiter.TabIndex = 24;
            this.LbMitarbeiter.Text = "Mitarbeiter:";
            // 
            // LbTisch
            // 
            this.LbTisch.AutoSize = true;
            this.LbTisch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LbTisch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbTisch.Location = new System.Drawing.Point(606, 37);
            this.LbTisch.Name = "LbTisch";
            this.LbTisch.Size = new System.Drawing.Size(55, 20);
            this.LbTisch.TabIndex = 25;
            this.LbTisch.Text = "Tisch:";
            // 
            // btnZurRechnung
            // 
            this.btnZurRechnung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnZurRechnung.Location = new System.Drawing.Point(118, 403);
            this.btnZurRechnung.Name = "btnZurRechnung";
            this.btnZurRechnung.Size = new System.Drawing.Size(110, 35);
            this.btnZurRechnung.TabIndex = 26;
            this.btnZurRechnung.Text = "Zur Rechnung";
            this.btnZurRechnung.UseVisualStyleBackColor = true;
            this.btnZurRechnung.Click += new System.EventHandler(this.btnZurRechnung_Click);
            // 
            // Bestellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZurRechnung);
            this.Controls.Add(this.LbTisch);
            this.Controls.Add(this.LbMitarbeiter);
            this.Controls.Add(this.btnLeeren);
            this.Controls.Add(this.btnBestellungAbschliessen);
            this.Controls.Add(this.dtpBestellungen);
            this.Controls.Add(this.cmbTisch);
            this.Controls.Add(this.cmbMitarbeiter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGesamtpreis);
            this.Controls.Add(this.btnEntfernen);
            this.Controls.Add(this.btnHinzufuegen);
            this.Controls.Add(this.dgvBestellkorb);
            this.Controls.Add(this.dgvArtikel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZurueck);
            this.Name = "Bestellungen";
            this.Text = "Bestellungen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestellkorb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZurueck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvArtikel;
        private System.Windows.Forms.DataGridView dgvBestellkorb;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBestellArtikel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBestellMenge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBestellPreis;
        private System.Windows.Forms.Button btnHinzufuegen;
        private System.Windows.Forms.Button btnEntfernen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArtikelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArtikelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArtikelPreis;
        private System.Windows.Forms.TextBox txtGesamtpreis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBestellungAbschliessen;
        private System.Windows.Forms.DateTimePicker dtpBestellungen;
        private System.Windows.Forms.ComboBox cmbTisch;
        private System.Windows.Forms.ComboBox cmbMitarbeiter;
        private System.Windows.Forms.Button btnLeeren;
        private System.Windows.Forms.Label LbMitarbeiter;
        private System.Windows.Forms.Label LbTisch;
        private System.Windows.Forms.Button btnZurRechnung;
    }
}