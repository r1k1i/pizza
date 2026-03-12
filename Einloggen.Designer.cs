namespace Pizzeria_Vevus
{
    partial class Einloggdaten
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.LbHeadline = new System.Windows.Forms.Label();
            this.LbHeadunder = new System.Windows.Forms.Label();
            this.LbNutzername = new System.Windows.Forms.Label();
            this.LbPasswort = new System.Windows.Forms.Label();
            this.txtNutzername = new System.Windows.Forms.TextBox();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LbHeadline
            // 
            this.LbHeadline.AutoSize = true;
            this.LbHeadline.BackColor = System.Drawing.Color.Transparent;
            this.LbHeadline.Font = new System.Drawing.Font("Segoe Script", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeadline.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbHeadline.Location = new System.Drawing.Point(5, 15);
            this.LbHeadline.Name = "LbHeadline";
            this.LbHeadline.Size = new System.Drawing.Size(782, 38);
            this.LbHeadline.TabIndex = 0;
            this.LbHeadline.Text = "WILLKOMMEN IN DER VERWALTUNG DER PIZZERIA VESUV";
            // 
            // LbHeadunder
            // 
            this.LbHeadunder.AutoSize = true;
            this.LbHeadunder.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeadunder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbHeadunder.Location = new System.Drawing.Point(191, 53);
            this.LbHeadunder.Name = "LbHeadunder";
            this.LbHeadunder.Size = new System.Drawing.Size(428, 34);
            this.LbHeadunder.TabIndex = 1;
            this.LbHeadunder.Text = "BItte Geben sie ihre Nutzerdaten an!";
            // 
            // LbNutzername
            // 
            this.LbNutzername.AutoSize = true;
            this.LbNutzername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNutzername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbNutzername.Location = new System.Drawing.Point(194, 216);
            this.LbNutzername.Name = "LbNutzername";
            this.LbNutzername.Size = new System.Drawing.Size(109, 18);
            this.LbNutzername.TabIndex = 2;
            this.LbNutzername.Text = "Nutzername :";
            // 
            // LbPasswort
            // 
            this.LbPasswort.AutoSize = true;
            this.LbPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPasswort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbPasswort.Location = new System.Drawing.Point(214, 242);
            this.LbPasswort.Name = "LbPasswort";
            this.LbPasswort.Size = new System.Drawing.Size(89, 18);
            this.LbPasswort.TabIndex = 3;
            this.LbPasswort.Text = "Passwort :";
            // 
            // txtNutzername
            // 
            this.txtNutzername.Location = new System.Drawing.Point(311, 216);
            this.txtNutzername.Name = "txtNutzername";
            this.txtNutzername.Size = new System.Drawing.Size(160, 20);
            this.txtNutzername.TabIndex = 5;
            // 
            // txtPasswort
            // 
            this.txtPasswort.Location = new System.Drawing.Point(311, 242);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.Size = new System.Drawing.Size(160, 20);
            this.txtPasswort.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(342, 268);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(98, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Einloggen";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pizzeria_Vevus.Properties.Resources.ChatGPT_Image_6__März_2026__17_26_08;
            this.pictureBox1.Location = new System.Drawing.Point(268, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Einloggdaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPasswort);
            this.Controls.Add(this.txtNutzername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LbPasswort);
            this.Controls.Add(this.LbNutzername);
            this.Controls.Add(this.LbHeadunder);
            this.Controls.Add(this.LbHeadline);
            this.Name = "Einloggdaten";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Einloggdaten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbHeadline;
        private System.Windows.Forms.Label LbHeadunder;
        private System.Windows.Forms.Label LbNutzername;
        private System.Windows.Forms.Label LbPasswort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNutzername;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.Button btnLogin;
    }
}

