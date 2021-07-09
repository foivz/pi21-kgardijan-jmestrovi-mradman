
namespace Funkcionalnost_prijave
{
    partial class FormDodajZaposlenika
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
            this.labelIme = new System.Windows.Forms.Label();
            this.labelKorLoz = new System.Windows.Forms.Label();
            this.labelKorIme = new System.Windows.Forms.Label();
            this.textBoxImePrezime = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelDodajZap = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelIme.Location = new System.Drawing.Point(66, 256);
            this.labelIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(134, 25);
            this.labelIme.TabIndex = 0;
            this.labelIme.Text = "Ime i prezime:";
            // 
            // labelKorLoz
            // 
            this.labelKorLoz.AutoSize = true;
            this.labelKorLoz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelKorLoz.Location = new System.Drawing.Point(66, 424);
            this.labelKorLoz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKorLoz.Name = "labelKorLoz";
            this.labelKorLoz.Size = new System.Drawing.Size(82, 25);
            this.labelKorLoz.TabIndex = 1;
            this.labelKorLoz.Text = "Lozinka:";
            // 
            // labelKorIme
            // 
            this.labelKorIme.AutoSize = true;
            this.labelKorIme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelKorIme.Location = new System.Drawing.Point(66, 339);
            this.labelKorIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKorIme.Name = "labelKorIme";
            this.labelKorIme.Size = new System.Drawing.Size(143, 25);
            this.labelKorIme.TabIndex = 2;
            this.labelKorIme.Text = "Korisničko ime:";
            // 
            // textBoxImePrezime
            // 
            this.textBoxImePrezime.Location = new System.Drawing.Point(67, 287);
            this.textBoxImePrezime.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxImePrezime.Name = "textBoxImePrezime";
            this.textBoxImePrezime.Size = new System.Drawing.Size(215, 31);
            this.textBoxImePrezime.TabIndex = 3;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(67, 370);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(215, 31);
            this.textBoxUsername.TabIndex = 4;
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(67, 455);
            this.textBoxLozinka.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(215, 31);
            this.textBoxLozinka.TabIndex = 5;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(181, 514);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(101, 43);
            this.buttonDodaj.TabIndex = 6;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(67, 514);
            this.buttonOdustani.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(99, 43);
            this.buttonOdustani.TabIndex = 7;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.panelTop.Controls.Add(this.labelDodajZap);
            this.panelTop.Controls.Add(this.labelClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(369, 100);
            this.panelTop.TabIndex = 9;
            // 
            // labelDodajZap
            // 
            this.labelDodajZap.AutoSize = true;
            this.labelDodajZap.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDodajZap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDodajZap.Location = new System.Drawing.Point(27, 30);
            this.labelDodajZap.Name = "labelDodajZap";
            this.labelDodajZap.Size = new System.Drawing.Size(294, 45);
            this.labelDodajZap.TabIndex = 11;
            this.labelDodajZap.Text = "Dodaj zaposlenika";
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelClose.Location = new System.Drawing.Point(327, 9);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(30, 35);
            this.labelClose.TabIndex = 10;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = global::Funkcionalnost_prijave.Properties.Resources.user;
            this.pictureBoxUser.Location = new System.Drawing.Point(85, 146);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(173, 107);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 10;
            this.pictureBoxUser.TabStop = false;
            // 
            // FormDodajZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(369, 577);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxImePrezime);
            this.Controls.Add(this.labelKorIme);
            this.Controls.Add(this.labelKorLoz);
            this.Controls.Add(this.labelIme);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormDodajZaposlenika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj zaposlenika";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormDodajZaposlenika_HelpRequested);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelKorLoz;
        private System.Windows.Forms.Label labelKorIme;
        private System.Windows.Forms.TextBox textBoxImePrezime;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelDodajZap;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.PictureBox pictureBoxUser;
    }
}