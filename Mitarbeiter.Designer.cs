namespace Pizzeria_Vevus
{
    partial class Mitarbeiter
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
            this.dgvMitarbeiter = new System.Windows.Forms.DataGridView();
            this.LbMitarbeiterverwaltung = new System.Windows.Forms.Label();
            this.LbName = new System.Windows.Forms.Label();
            this.LbRolle = new System.Windows.Forms.Label();
            this.LbBereich = new System.Windows.Forms.Label();
            this.LbPasswort = new System.Windows.Forms.Label();
            this.btnNeu = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnLoeschen = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.cmbRolle = new System.Windows.Forms.ComboBox();
            this.cmbBereich = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LbVorname = new System.Windows.Forms.Label();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRolle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBereich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMitarbeiter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZurueck
            // 
            this.btnZurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnZurueck.Location = new System.Drawing.Point(12, 403);
            this.btnZurueck.Name = "btnZurueck";
            this.btnZurueck.Size = new System.Drawing.Size(100, 35);
            this.btnZurueck.TabIndex = 3;
            this.btnZurueck.Text = "Zurück";
            this.btnZurueck.UseVisualStyleBackColor = true;
            this.btnZurueck.Click += new System.EventHandler(this.btnZurueck_Click);
            // 
            // dgvMitarbeiter
            // 
            this.dgvMitarbeiter.AllowUserToAddRows = false;
            this.dgvMitarbeiter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMitarbeiter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNachname,
            this.colRolle,
            this.colBereich});
            this.dgvMitarbeiter.Location = new System.Drawing.Point(38, 110);
            this.dgvMitarbeiter.MultiSelect = false;
            this.dgvMitarbeiter.Name = "dgvMitarbeiter";
            this.dgvMitarbeiter.ReadOnly = true;
            this.dgvMitarbeiter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMitarbeiter.Size = new System.Drawing.Size(422, 272);
            this.dgvMitarbeiter.TabIndex = 4;
            // 
            // LbMitarbeiterverwaltung
            // 
            this.LbMitarbeiterverwaltung.AutoSize = true;
            this.LbMitarbeiterverwaltung.Font = new System.Drawing.Font("Segoe Script", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMitarbeiterverwaltung.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbMitarbeiterverwaltung.Location = new System.Drawing.Point(239, 20);
            this.LbMitarbeiterverwaltung.Name = "LbMitarbeiterverwaltung";
            this.LbMitarbeiterverwaltung.Size = new System.Drawing.Size(296, 38);
            this.LbMitarbeiterverwaltung.TabIndex = 5;
            this.LbMitarbeiterverwaltung.Text = "Mitarbeiterverwaltung";
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbName.Location = new System.Drawing.Point(472, 200);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(93, 18);
            this.LbName.TabIndex = 8;
            this.LbName.Text = "Nachname:";
            // 
            // LbRolle
            // 
            this.LbRolle.AutoSize = true;
            this.LbRolle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRolle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbRolle.Location = new System.Drawing.Point(513, 239);
            this.LbRolle.Name = "LbRolle";
            this.LbRolle.Size = new System.Drawing.Size(52, 18);
            this.LbRolle.TabIndex = 9;
            this.LbRolle.Text = "Rolle:";
            // 
            // LbBereich
            // 
            this.LbBereich.AutoSize = true;
            this.LbBereich.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbBereich.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbBereich.Location = new System.Drawing.Point(495, 275);
            this.LbBereich.Name = "LbBereich";
            this.LbBereich.Size = new System.Drawing.Size(70, 18);
            this.LbBereich.TabIndex = 10;
            this.LbBereich.Text = "Bereich:";
            // 
            // LbPasswort
            // 
            this.LbPasswort.AutoSize = true;
            this.LbPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPasswort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbPasswort.Location = new System.Drawing.Point(485, 310);
            this.LbPasswort.Name = "LbPasswort";
            this.LbPasswort.Size = new System.Drawing.Size(84, 18);
            this.LbPasswort.TabIndex = 11;
            this.LbPasswort.Text = "Passwort:";
            // 
            // btnNeu
            // 
            this.btnNeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNeu.Location = new System.Drawing.Point(129, 403);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.Size = new System.Drawing.Size(100, 33);
            this.btnNeu.TabIndex = 12;
            this.btnNeu.Text = "Neu";
            this.btnNeu.UseVisualStyleBackColor = true;
            this.btnNeu.Click += new System.EventHandler(this.btnNeu_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSpeichern.Location = new System.Drawing.Point(246, 402);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(100, 33);
            this.btnSpeichern.TabIndex = 13;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnLoeschen
            // 
            this.btnLoeschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnLoeschen.Location = new System.Drawing.Point(371, 402);
            this.btnLoeschen.Name = "btnLoeschen";
            this.btnLoeschen.Size = new System.Drawing.Size(89, 33);
            this.btnLoeschen.TabIndex = 14;
            this.btnLoeschen.Text = "Löschen";
            this.btnLoeschen.UseVisualStyleBackColor = true;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(576, 200);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(147, 20);
            this.txtname.TabIndex = 16;
            // 
            // txtPasswort
            // 
            this.txtPasswort.Location = new System.Drawing.Point(576, 308);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.Size = new System.Drawing.Size(147, 20);
            this.txtPasswort.TabIndex = 18;
            this.txtPasswort.UseSystemPasswordChar = true;
            // 
            // cmbRolle
            // 
            this.cmbRolle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRolle.FormattingEnabled = true;
            this.cmbRolle.Location = new System.Drawing.Point(576, 236);
            this.cmbRolle.Name = "cmbRolle";
            this.cmbRolle.Size = new System.Drawing.Size(147, 21);
            this.cmbRolle.TabIndex = 20;
            // 
            // cmbBereich
            // 
            this.cmbBereich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBereich.FormattingEnabled = true;
            this.cmbBereich.Location = new System.Drawing.Point(576, 272);
            this.cmbBereich.Name = "cmbBereich";
            this.cmbBereich.Size = new System.Drawing.Size(147, 21);
            this.cmbBereich.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(541, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mitarbeiter Bearbeitung :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(34, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Mitarbeiterliste :";
            // 
            // LbVorname
            // 
            this.LbVorname.AutoSize = true;
            this.LbVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbVorname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbVorname.Location = new System.Drawing.Point(489, 162);
            this.LbVorname.Name = "LbVorname";
            this.LbVorname.Size = new System.Drawing.Size(80, 18);
            this.LbVorname.TabIndex = 7;
            this.LbVorname.Text = "Vorname:";
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(576, 160);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(147, 20);
            this.txtVorname.TabIndex = 17;
            this.txtVorname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVorname_KeyPress);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colNachname
            // 
            this.colNachname.HeaderText = "Name";
            this.colNachname.Name = "colNachname";
            this.colNachname.ReadOnly = true;
            // 
            // colRolle
            // 
            this.colRolle.HeaderText = "Rolle";
            this.colRolle.Name = "colRolle";
            this.colRolle.ReadOnly = true;
            // 
            // colBereich
            // 
            this.colBereich.HeaderText = "Bereich";
            this.colBereich.Name = "colBereich";
            this.colBereich.ReadOnly = true;
            // 
            // Mitarbeiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbBereich);
            this.Controls.Add(this.cmbRolle);
            this.Controls.Add(this.txtPasswort);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnLoeschen);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.btnNeu);
            this.Controls.Add(this.LbPasswort);
            this.Controls.Add(this.LbBereich);
            this.Controls.Add(this.LbRolle);
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.LbVorname);
            this.Controls.Add(this.LbMitarbeiterverwaltung);
            this.Controls.Add(this.dgvMitarbeiter);
            this.Controls.Add(this.btnZurueck);
            this.Name = "Mitarbeiter";
            this.Text = "Mitarbeiter";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMitarbeiter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZurueck;
        private System.Windows.Forms.DataGridView dgvMitarbeiter;
        private System.Windows.Forms.Label LbMitarbeiterverwaltung;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.Label LbRolle;
        private System.Windows.Forms.Label LbBereich;
        private System.Windows.Forms.Label LbPasswort;
        private System.Windows.Forms.Button btnNeu;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnLoeschen;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.ComboBox cmbRolle;
        private System.Windows.Forms.ComboBox cmbBereich;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LbVorname;
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNachname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRolle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBereich;
    }
}