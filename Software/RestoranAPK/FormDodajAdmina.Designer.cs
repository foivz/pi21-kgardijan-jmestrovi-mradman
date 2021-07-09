
namespace Funkcionalnost_prijave
{
    partial class FormDodajAdmina
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
            this.labelKorIme = new System.Windows.Forms.Label();
            this.labelImePrez = new System.Windows.Forms.Label();
            this.labelLoz = new System.Windows.Forms.Label();
            this.textBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.textBoxImePrezime = new System.Windows.Forms.TextBox();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelDodajAdmina = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.pictureBoxAdmin = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKorIme
            // 
            this.labelKorIme.AutoSize = true;
            this.labelKorIme.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKorIme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelKorIme.Location = new System.Drawing.Point(38, 185);
            this.labelKorIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKorIme.Name = "labelKorIme";
            this.labelKorIme.Size = new System.Drawing.Size(143, 25);
            this.labelKorIme.TabIndex = 0;
            this.labelKorIme.Text = "Korisničko ime:";
            // 
            // labelImePrez
            // 
            this.labelImePrez.AutoSize = true;
            this.labelImePrez.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImePrez.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelImePrez.Location = new System.Drawing.Point(39, 308);
            this.labelImePrez.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImePrez.Name = "labelImePrez";
            this.labelImePrez.Size = new System.Drawing.Size(134, 25);
            this.labelImePrez.TabIndex = 1;
            this.labelImePrez.Text = "Ime i prezime:";
            // 
            // labelLoz
            // 
            this.labelLoz.AutoSize = true;
            this.labelLoz.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLoz.Location = new System.Drawing.Point(39, 246);
            this.labelLoz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoz.Name = "labelLoz";
            this.labelLoz.Size = new System.Drawing.Size(82, 25);
            this.labelLoz.TabIndex = 2;
            this.labelLoz.Text = "Lozinka:";
            // 
            // textBoxKorisnickoIme
            // 
            this.textBoxKorisnickoIme.Location = new System.Drawing.Point(41, 207);
            this.textBoxKorisnickoIme.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKorisnickoIme.Name = "textBoxKorisnickoIme";
            this.textBoxKorisnickoIme.Size = new System.Drawing.Size(238, 24);
            this.textBoxKorisnickoIme.TabIndex = 3;
            // 
            // textBoxImePrezime
            // 
            this.textBoxImePrezime.Location = new System.Drawing.Point(41, 330);
            this.textBoxImePrezime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxImePrezime.Name = "textBoxImePrezime";
            this.textBoxImePrezime.Size = new System.Drawing.Size(238, 24);
            this.textBoxImePrezime.TabIndex = 4;
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(42, 268);
            this.textBoxLozinka.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(237, 24);
            this.textBoxLozinka.TabIndex = 5;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodaj.Location = new System.Drawing.Point(181, 376);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(98, 38);
            this.buttonDodaj.TabIndex = 6;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            this.buttonDodaj.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.buttonDodaj_HelpRequested);
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOdustani.Location = new System.Drawing.Point(41, 376);
            this.buttonOdustani.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(97, 38);
            this.buttonOdustani.TabIndex = 7;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.panelTop.Controls.Add(this.labelDodajAdmina);
            this.panelTop.Controls.Add(this.labelClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(351, 100);
            this.panelTop.TabIndex = 8;
            // 
            // labelDodajAdmina
            // 
            this.labelDodajAdmina.AutoSize = true;
            this.labelDodajAdmina.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDodajAdmina.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDodajAdmina.Location = new System.Drawing.Point(53, 28);
            this.labelDodajAdmina.Name = "labelDodajAdmina";
            this.labelDodajAdmina.Size = new System.Drawing.Size(230, 45);
            this.labelDodajAdmina.TabIndex = 11;
            this.labelDodajAdmina.Text = "Dodaj admina";
            this.labelDodajAdmina.Click += new System.EventHandler(this.labelDodajAdmina_Click);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelClose.Location = new System.Drawing.Point(309, 9);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(30, 35);
            this.labelClose.TabIndex = 10;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // pictureBoxAdmin
            // 
            this.pictureBoxAdmin.Image = global::Funkcionalnost_prijave.Properties.Resources.user;
            this.pictureBoxAdmin.Location = new System.Drawing.Point(61, 115);
            this.pictureBoxAdmin.Name = "pictureBoxAdmin";
            this.pictureBoxAdmin.Size = new System.Drawing.Size(218, 70);
            this.pictureBoxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdmin.TabIndex = 9;
            this.pictureBoxAdmin.TabStop = false;
            // 
            // FormDodajAdmina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(351, 450);
            this.Controls.Add(this.pictureBoxAdmin);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.textBoxImePrezime);
            this.Controls.Add(this.textBoxKorisnickoIme);
            this.Controls.Add(this.labelLoz);
            this.Controls.Add(this.labelImePrez);
            this.Controls.Add(this.labelKorIme);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDodajAdmina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj admina";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKorIme;
        private System.Windows.Forms.Label labelImePrez;
        private System.Windows.Forms.Label labelLoz;
        private System.Windows.Forms.TextBox textBoxKorisnickoIme;
        private System.Windows.Forms.TextBox textBoxImePrezime;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelDodajAdmina;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.PictureBox pictureBoxAdmin;
    }
}