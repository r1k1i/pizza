namespace Pizzeria_Vevus
{
    partial class Speisen
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
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSpeisekarte = new System.Windows.Forms.DataGridView();
            this.colAuswahl = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colKategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArtikel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroesse = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMenge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeisekarte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZurueck
            // 
            this.btnZurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnZurueck.Location = new System.Drawing.Point(12, 403);
            this.btnZurueck.Name = "btnZurueck";
            this.btnZurueck.Size = new System.Drawing.Size(100, 35);
            this.btnZurueck.TabIndex = 0;
            this.btnZurueck.Text = "Zurück";
            this.btnZurueck.UseVisualStyleBackColor = true;
            this.btnZurueck.Click += new System.EventHandler(this.btnZurueck_Click);
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(312, 392);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(160, 46);
            this.btnBerechnen.TabIndex = 13;
            this.btnBerechnen.Text = "Berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(304, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Speisekarte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(357, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Speisen";
            // 
            // dgvSpeisekarte
            // 
            this.dgvSpeisekarte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpeisekarte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAuswahl,
            this.colKategorie,
            this.colArtikel,
            this.colGroesse,
            this.colMenge,
            this.colPreis});
            this.dgvSpeisekarte.Location = new System.Drawing.Point(84, 122);
            this.dgvSpeisekarte.Name = "dgvSpeisekarte";
            this.dgvSpeisekarte.Size = new System.Drawing.Size(640, 250);
            this.dgvSpeisekarte.TabIndex = 14;
            // 
            // colAuswahl
            // 
            this.colAuswahl.HeaderText = "Auswahl";
            this.colAuswahl.Name = "colAuswahl";
            // 
            // colKategorie
            // 
            this.colKategorie.HeaderText = "Kategorie";
            this.colKategorie.Name = "colKategorie";
            this.colKategorie.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colKategorie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colArtikel
            // 
            this.colArtikel.HeaderText = "Artikel";
            this.colArtikel.Name = "colArtikel";
            this.colArtikel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colArtikel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colGroesse
            // 
            this.colGroesse.HeaderText = "Größe";
            this.colGroesse.Name = "colGroesse";
            this.colGroesse.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colMenge
            // 
            this.colMenge.HeaderText = "Menge";
            this.colMenge.Name = "colMenge";
            this.colMenge.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMenge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPreis
            // 
            this.colPreis.HeaderText = "Preis";
            this.colPreis.Name = "colPreis";
            this.colPreis.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPreis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Speisen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSpeisekarte);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZurueck);
            this.Name = "Speisen";
            this.Text = "Speisen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeisekarte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZurueck;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSpeisekarte;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAuswahl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArtikel;
        private System.Windows.Forms.DataGridViewComboBoxColumn colGroesse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreis;
    }
}