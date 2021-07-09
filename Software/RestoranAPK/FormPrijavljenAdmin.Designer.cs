
namespace Funkcionalnost_prijave
{
    partial class FormPrijavljenAdmin
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
            this.buttonJelovnik = new System.Windows.Forms.Button();
            this.buttonZaposlenici = new System.Windows.Forms.Button();
            this.buttonRezervacije = new System.Windows.Forms.Button();
            this.labelRestoran = new System.Windows.Forms.Label();
            this.buttonSmjene = new System.Windows.Forms.Button();
            this.buttonStatistika = new System.Windows.Forms.Button();
            this.buttonOdjava = new System.Windows.Forms.Button();
            this.labelKorisnik = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelNaslovnica = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonJelovnik
            // 
            this.buttonJelovnik.Location = new System.Drawing.Point(389, 274);
            this.buttonJelovnik.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.buttonJelovnik.Name = "buttonJelovnik";
            this.buttonJelovnik.Size = new System.Drawing.Size(143, 114);
            this.buttonJelovnik.TabIndex = 0;
            this.buttonJelovnik.Text = "Jelovnik";
            this.buttonJelovnik.UseVisualStyleBackColor = true;
            this.buttonJelovnik.Click += new System.EventHandler(this.buttonJelovnik_Click);
            // 
            // buttonZaposlenici
            // 
            this.buttonZaposlenici.ForeColor = System.Drawing.Color.Black;
            this.buttonZaposlenici.Location = new System.Drawing.Point(22, 274);
            this.buttonZaposlenici.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.buttonZaposlenici.Name = "buttonZaposlenici";
            this.buttonZaposlenici.Size = new System.Drawing.Size(143, 114);
            this.buttonZaposlenici.TabIndex = 1;
            this.buttonZaposlenici.Text = "Zaposlenici";
            this.buttonZaposlenici.UseVisualStyleBackColor = true;
            this.buttonZaposlenici.Click += new System.EventHandler(this.buttonZaposlenici_Click);
            // 
            // buttonRezervacije
            // 
            this.buttonRezervacije.Location = new System.Drawing.Point(570, 274);
            this.buttonRezervacije.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.buttonRezervacije.Name = "buttonRezervacije";
            this.buttonRezervacije.Size = new System.Drawing.Size(143, 114);
            this.buttonRezervacije.TabIndex = 2;
            this.buttonRezervacije.Text = "Rezervacije";
            this.buttonRezervacije.UseVisualStyleBackColor = true;
            this.buttonRezervacije.Click += new System.EventHandler(this.buttonRezervacije_Click);
            // 
            // labelRestoran
            // 
            this.labelRestoran.AutoSize = true;
            this.labelRestoran.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestoran.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRestoran.Location = new System.Drawing.Point(357, 154);
            this.labelRestoran.Name = "labelRestoran";
            this.labelRestoran.Size = new System.Drawing.Size(146, 41);
            this.labelRestoran.TabIndex = 3;
            this.labelRestoran.Text = "Restoran:";
            // 
            // buttonSmjene
            // 
            this.buttonSmjene.Location = new System.Drawing.Point(202, 274);
            this.buttonSmjene.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.buttonSmjene.Name = "buttonSmjene";
            this.buttonSmjene.Size = new System.Drawing.Size(143, 114);
            this.buttonSmjene.TabIndex = 5;
            this.buttonSmjene.Text = "Smjene rada";
            this.buttonSmjene.UseVisualStyleBackColor = true;
            this.buttonSmjene.Click += new System.EventHandler(this.buttonSmjene_Click);
            // 
            // buttonStatistika
            // 
            this.buttonStatistika.Location = new System.Drawing.Point(758, 274);
            this.buttonStatistika.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.buttonStatistika.Name = "buttonStatistika";
            this.buttonStatistika.Size = new System.Drawing.Size(143, 114);
            this.buttonStatistika.TabIndex = 6;
            this.buttonStatistika.Text = "Statistika";
            this.buttonStatistika.UseVisualStyleBackColor = true;
            this.buttonStatistika.Click += new System.EventHandler(this.buttonStatistika_Click);
            // 
            // buttonOdjava
            // 
            this.buttonOdjava.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOdjava.Location = new System.Drawing.Point(22, 32);
            this.buttonOdjava.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.buttonOdjava.Name = "buttonOdjava";
            this.buttonOdjava.Size = new System.Drawing.Size(79, 37);
            this.buttonOdjava.TabIndex = 7;
            this.buttonOdjava.Text = "Odjava";
            this.buttonOdjava.UseVisualStyleBackColor = true;
            this.buttonOdjava.Click += new System.EventHandler(this.buttonOdjava_Click);
            // 
            // labelKorisnik
            // 
            this.labelKorisnik.AutoSize = true;
            this.labelKorisnik.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelKorisnik.Location = new System.Drawing.Point(17, 487);
            this.labelKorisnik.Name = "labelKorisnik";
            this.labelKorisnik.Size = new System.Drawing.Size(64, 25);
            this.labelKorisnik.TabIndex = 8;
            this.labelKorisnik.Text = "label2";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.panelTop.Controls.Add(this.labelClose);
            this.panelTop.Controls.Add(this.labelNaslovnica);
            this.panelTop.Controls.Add(this.buttonOdjava);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(933, 100);
            this.panelTop.TabIndex = 9;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelClose.Location = new System.Drawing.Point(891, 9);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(30, 35);
            this.labelClose.TabIndex = 10;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // labelNaslovnica
            // 
            this.labelNaslovnica.AutoSize = true;
            this.labelNaslovnica.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaslovnica.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNaslovnica.Location = new System.Drawing.Point(303, 26);
            this.labelNaslovnica.Name = "labelNaslovnica";
            this.labelNaslovnica.Size = new System.Drawing.Size(325, 65);
            this.labelNaslovnica.TabIndex = 9;
            this.labelNaslovnica.Text = "NASLOVNICA";
            // 
            // FormPrijavljenAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(933, 530);
            this.Controls.Add(this.labelKorisnik);
            this.Controls.Add(this.buttonStatistika);
            this.Controls.Add(this.buttonSmjene);
            this.Controls.Add(this.labelRestoran);
            this.Controls.Add(this.buttonRezervacije);
            this.Controls.Add(this.buttonZaposlenici);
            this.Controls.Add(this.buttonJelovnik);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "FormPrijavljenAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naslovnica";
            this.Load += new System.EventHandler(this.FormPrijavljenAdmin_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormPrijavljenAdmin_HelpRequested);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonJelovnik;
        private System.Windows.Forms.Button buttonZaposlenici;
        private System.Windows.Forms.Button buttonRezervacije;
        private System.Windows.Forms.Label labelRestoran;
        private System.Windows.Forms.Button buttonSmjene;
        private System.Windows.Forms.Button buttonStatistika;
        private System.Windows.Forms.Button buttonOdjava;
        private System.Windows.Forms.Label labelKorisnik;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelNaslovnica;
        private System.Windows.Forms.Label labelClose;
    }
}