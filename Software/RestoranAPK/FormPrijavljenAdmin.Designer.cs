
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelKorisnik = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // buttonJelovnik
            // 
            this.buttonJelovnik.Location = new System.Drawing.Point(466, 92);
            this.buttonJelovnik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonJelovnik.Name = "buttonJelovnik";
            this.buttonJelovnik.Size = new System.Drawing.Size(129, 82);
            this.buttonJelovnik.TabIndex = 0;
            this.buttonJelovnik.Text = "Jelovnik";
            this.buttonJelovnik.UseVisualStyleBackColor = true;
            this.buttonJelovnik.Click += new System.EventHandler(this.buttonJelovnik_Click);
            // 
            // buttonZaposlenici
            // 
            this.buttonZaposlenici.Location = new System.Drawing.Point(47, 92);
            this.buttonZaposlenici.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonZaposlenici.Name = "buttonZaposlenici";
            this.buttonZaposlenici.Size = new System.Drawing.Size(129, 82);
            this.buttonZaposlenici.TabIndex = 1;
            this.buttonZaposlenici.Text = "Zaposlenici";
            this.buttonZaposlenici.UseVisualStyleBackColor = true;
            this.buttonZaposlenici.Click += new System.EventHandler(this.buttonZaposlenici_Click);
            // 
            // buttonRezervacije
            // 
            this.buttonRezervacije.Location = new System.Drawing.Point(660, 92);
            this.buttonRezervacije.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRezervacije.Name = "buttonRezervacije";
            this.buttonRezervacije.Size = new System.Drawing.Size(129, 82);
            this.buttonRezervacije.TabIndex = 2;
            this.buttonRezervacije.Text = "Rezervacije";
            this.buttonRezervacije.UseVisualStyleBackColor = true;
            this.buttonRezervacije.Click += new System.EventHandler(this.buttonRezervacije_Click);
            // 
            // labelRestoran
            // 
            this.labelRestoran.AutoSize = true;
            this.labelRestoran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestoran.Location = new System.Drawing.Point(425, 29);
            this.labelRestoran.Name = "labelRestoran";
            this.labelRestoran.Size = new System.Drawing.Size(96, 25);
            this.labelRestoran.TabIndex = 3;
            this.labelRestoran.Text = "Restoran:";
            // 
            // buttonSmjene
            // 
            this.buttonSmjene.Location = new System.Drawing.Point(254, 92);
            this.buttonSmjene.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSmjene.Name = "buttonSmjene";
            this.buttonSmjene.Size = new System.Drawing.Size(129, 82);
            this.buttonSmjene.TabIndex = 5;
            this.buttonSmjene.Text = "Smjene rada";
            this.buttonSmjene.UseVisualStyleBackColor = true;
            this.buttonSmjene.Click += new System.EventHandler(this.buttonSmjene_Click);
            // 
            // buttonStatistika
            // 
            this.buttonStatistika.Location = new System.Drawing.Point(873, 92);
            this.buttonStatistika.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStatistika.Name = "buttonStatistika";
            this.buttonStatistika.Size = new System.Drawing.Size(129, 82);
            this.buttonStatistika.TabIndex = 6;
            this.buttonStatistika.Text = "Statistika";
            this.buttonStatistika.UseVisualStyleBackColor = true;
            this.buttonStatistika.Click += new System.EventHandler(this.buttonStatistika_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(918, 241);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Odjava";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelKorisnik
            // 
            this.labelKorisnik.AutoSize = true;
            this.labelKorisnik.Location = new System.Drawing.Point(27, 250);
            this.labelKorisnik.Name = "labelKorisnik";
            this.labelKorisnik.Size = new System.Drawing.Size(46, 18);
            this.labelKorisnik.TabIndex = 8;
            this.labelKorisnik.Text = "label2";
            // 
            // FormPrijavljenAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 292);
            this.Controls.Add(this.labelKorisnik);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonStatistika);
            this.Controls.Add(this.buttonSmjene);
            this.Controls.Add(this.labelRestoran);
            this.Controls.Add(this.buttonRezervacije);
            this.Controls.Add(this.buttonZaposlenici);
            this.Controls.Add(this.buttonJelovnik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPrijavljenAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naslovnica";
            this.Load += new System.EventHandler(this.FormPrijavljenAdmin_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelKorisnik;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}