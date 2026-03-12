namespace Pizzeria_Vevus
{
    partial class Reservierung
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
            this.LbReservierungen = new System.Windows.Forms.Label();
            this.LbName = new System.Windows.Forms.Label();
            this.LbTelefon = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.LbDatum = new System.Windows.Forms.Label();
            this.LbUhrzeit = new System.Windows.Forms.Label();
            this.LbPersonen = new System.Windows.Forms.Label();
            this.LbTischnummer = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.cmbUhrzeit = new System.Windows.Forms.ComboBox();
            this.numPersonen = new System.Windows.Forms.NumericUpDown();
            this.cmbTischnummer = new System.Windows.Forms.ComboBox();
            this.btnSpeichern = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonen)).BeginInit();
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
            // LbReservierungen
            // 
            this.LbReservierungen.AutoSize = true;
            this.LbReservierungen.Font = new System.Drawing.Font("Segoe Script", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbReservierungen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbReservierungen.Location = new System.Drawing.Point(272, 20);
            this.LbReservierungen.Name = "LbReservierungen";
            this.LbReservierungen.Size = new System.Drawing.Size(258, 38);
            this.LbReservierungen.TabIndex = 2;
            this.LbReservierungen.Text = "RESERVIERUNGEN";
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbName.Location = new System.Drawing.Point(165, 113);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(130, 20);
            this.LbName.TabIndex = 3;
            this.LbName.Text = "Name, Vorname:";
            // 
            // LbTelefon
            // 
            this.LbTelefon.AutoSize = true;
            this.LbTelefon.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTelefon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbTelefon.Location = new System.Drawing.Point(227, 146);
            this.LbTelefon.Name = "LbTelefon";
            this.LbTelefon.Size = new System.Drawing.Size(68, 20);
            this.LbTelefon.TabIndex = 4;
            this.LbTelefon.Text = "Telefon:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(314, 113);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 5;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(314, 146);
            this.txtTelefon.MaxLength = 14;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 20);
            this.txtTelefon.TabIndex = 6;
            this.txtTelefon.Text = "+49";
            this.txtTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefon_KeyPress);
            // 
            // LbDatum
            // 
            this.LbDatum.AutoSize = true;
            this.LbDatum.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDatum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbDatum.Location = new System.Drawing.Point(234, 183);
            this.LbDatum.Name = "LbDatum";
            this.LbDatum.Size = new System.Drawing.Size(61, 20);
            this.LbDatum.TabIndex = 7;
            this.LbDatum.Text = "Datum:";
            // 
            // LbUhrzeit
            // 
            this.LbUhrzeit.AutoSize = true;
            this.LbUhrzeit.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUhrzeit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbUhrzeit.Location = new System.Drawing.Point(230, 216);
            this.LbUhrzeit.Name = "LbUhrzeit";
            this.LbUhrzeit.Size = new System.Drawing.Size(65, 20);
            this.LbUhrzeit.TabIndex = 8;
            this.LbUhrzeit.Text = "Uhrzeit:";
            // 
            // LbPersonen
            // 
            this.LbPersonen.AutoSize = true;
            this.LbPersonen.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPersonen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbPersonen.Location = new System.Drawing.Point(214, 254);
            this.LbPersonen.Name = "LbPersonen";
            this.LbPersonen.Size = new System.Drawing.Size(81, 20);
            this.LbPersonen.TabIndex = 9;
            this.LbPersonen.Text = "Personen:";
            // 
            // LbTischnummer
            // 
            this.LbTischnummer.AutoSize = true;
            this.LbTischnummer.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTischnummer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbTischnummer.Location = new System.Drawing.Point(184, 291);
            this.LbTischnummer.Name = "LbTischnummer";
            this.LbTischnummer.Size = new System.Drawing.Size(111, 20);
            this.LbTischnummer.TabIndex = 10;
            this.LbTischnummer.Text = "TIschnummer:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(314, 182);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 11;
            // 
            // cmbUhrzeit
            // 
            this.cmbUhrzeit.FormattingEnabled = true;
            this.cmbUhrzeit.Location = new System.Drawing.Point(314, 215);
            this.cmbUhrzeit.Name = "cmbUhrzeit";
            this.cmbUhrzeit.Size = new System.Drawing.Size(200, 21);
            this.cmbUhrzeit.TabIndex = 12;
            // 
            // numPersonen
            // 
            this.numPersonen.Location = new System.Drawing.Point(314, 254);
            this.numPersonen.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numPersonen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPersonen.Name = "numPersonen";
            this.numPersonen.Size = new System.Drawing.Size(200, 20);
            this.numPersonen.TabIndex = 13;
            this.numPersonen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbTischnummer
            // 
            this.cmbTischnummer.FormattingEnabled = true;
            this.cmbTischnummer.Location = new System.Drawing.Point(314, 290);
            this.cmbTischnummer.Name = "cmbTischnummer";
            this.cmbTischnummer.Size = new System.Drawing.Size(200, 21);
            this.cmbTischnummer.TabIndex = 14;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSpeichern.Location = new System.Drawing.Point(314, 334);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(98, 34);
            this.btnSpeichern.TabIndex = 15;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // Reservierung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.cmbTischnummer);
            this.Controls.Add(this.numPersonen);
            this.Controls.Add(this.cmbUhrzeit);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.LbTischnummer);
            this.Controls.Add(this.LbPersonen);
            this.Controls.Add(this.LbUhrzeit);
            this.Controls.Add(this.LbDatum);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.LbTelefon);
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.LbReservierungen);
            this.Controls.Add(this.btnZurueck);
            this.Name = "Reservierung";
            this.Text = "Reservierung";
            ((System.ComponentModel.ISupportInitialize)(this.numPersonen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZurueck;
        private System.Windows.Forms.Label LbReservierungen;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.Label LbTelefon;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label LbDatum;
        private System.Windows.Forms.Label LbUhrzeit;
        private System.Windows.Forms.Label LbPersonen;
        private System.Windows.Forms.Label LbTischnummer;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.ComboBox cmbUhrzeit;
        private System.Windows.Forms.NumericUpDown numPersonen;
        private System.Windows.Forms.ComboBox cmbTischnummer;
        private System.Windows.Forms.Button btnSpeichern;
    }
}