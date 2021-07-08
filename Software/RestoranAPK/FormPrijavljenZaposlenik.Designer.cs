
namespace Funkcionalnost_prijave
{
    partial class FormPrijavljenZaposlenik
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelRestoran = new System.Windows.Forms.Label();
            this.buttonNarudzbe = new System.Windows.Forms.Button();
            this.buttonRezervacije = new System.Windows.Forms.Button();
            this.buttonJelovnik = new System.Windows.Forms.Button();
            this.buttonOdjava = new System.Windows.Forms.Button();
            this.labelKorisnik = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 0;
            // 
            // labelRestoran
            // 
            this.labelRestoran.AutoSize = true;
            this.labelRestoran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestoran.Location = new System.Drawing.Point(243, 45);
            this.labelRestoran.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRestoran.Name = "labelRestoran";
            this.labelRestoran.Size = new System.Drawing.Size(101, 25);
            this.labelRestoran.TabIndex = 1;
            this.labelRestoran.Text = "Restoran: ";
            this.labelRestoran.Click += new System.EventHandler(this.labelRestoran_Click);
            // 
            // buttonNarudzbe
            // 
            this.buttonNarudzbe.Location = new System.Drawing.Point(450, 148);
            this.buttonNarudzbe.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNarudzbe.Name = "buttonNarudzbe";
            this.buttonNarudzbe.Size = new System.Drawing.Size(127, 81);
            this.buttonNarudzbe.TabIndex = 3;
            this.buttonNarudzbe.Text = "Narudžbe";
            this.buttonNarudzbe.UseVisualStyleBackColor = true;
            this.buttonNarudzbe.Click += new System.EventHandler(this.buttonNarudzbe_Click);
            // 
            // buttonRezervacije
            // 
            this.buttonRezervacije.Location = new System.Drawing.Point(247, 148);
            this.buttonRezervacije.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRezervacije.Name = "buttonRezervacije";
            this.buttonRezervacije.Size = new System.Drawing.Size(127, 81);
            this.buttonRezervacije.TabIndex = 5;
            this.buttonRezervacije.Text = "Rezervacije";
            this.buttonRezervacije.UseVisualStyleBackColor = true;
            this.buttonRezervacije.Click += new System.EventHandler(this.buttonRezervacije_Click);
            // 
            // buttonJelovnik
            // 
            this.buttonJelovnik.Location = new System.Drawing.Point(38, 148);
            this.buttonJelovnik.Margin = new System.Windows.Forms.Padding(4);
            this.buttonJelovnik.Name = "buttonJelovnik";
            this.buttonJelovnik.Size = new System.Drawing.Size(127, 81);
            this.buttonJelovnik.TabIndex = 6;
            this.buttonJelovnik.Text = "Jelovnik";
            this.buttonJelovnik.UseVisualStyleBackColor = true;
            this.buttonJelovnik.Click += new System.EventHandler(this.buttonJelovnik_Click);
            // 
            // buttonOdjava
            // 
            this.buttonOdjava.Location = new System.Drawing.Point(493, 274);
            this.buttonOdjava.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOdjava.Name = "buttonOdjava";
            this.buttonOdjava.Size = new System.Drawing.Size(85, 31);
            this.buttonOdjava.TabIndex = 7;
            this.buttonOdjava.Text = "Odjava";
            this.buttonOdjava.UseVisualStyleBackColor = true;
            this.buttonOdjava.Click += new System.EventHandler(this.buttonOdjava_Click);
            // 
            // labelKorisnik
            // 
            this.labelKorisnik.AutoSize = true;
            this.labelKorisnik.Location = new System.Drawing.Point(14, 283);
            this.labelKorisnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKorisnik.Name = "labelKorisnik";
            this.labelKorisnik.Size = new System.Drawing.Size(46, 18);
            this.labelKorisnik.TabIndex = 8;
            this.labelKorisnik.Text = "label2";
            // 
            // FormPrijavljenZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 317);
            this.Controls.Add(this.labelKorisnik);
            this.Controls.Add(this.buttonOdjava);
            this.Controls.Add(this.buttonJelovnik);
            this.Controls.Add(this.buttonRezervacije);
            this.Controls.Add(this.buttonNarudzbe);
            this.Controls.Add(this.labelRestoran);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrijavljenZaposlenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naslovnica";
            this.Load += new System.EventHandler(this.FormPrijavljenZaposlenik_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormPrijavljenZaposlenik_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRestoran;
        private System.Windows.Forms.Button buttonNarudzbe;
        private System.Windows.Forms.Button buttonRezervacije;
        private System.Windows.Forms.Button buttonJelovnik;
        private System.Windows.Forms.Button buttonOdjava;
        private System.Windows.Forms.Label labelKorisnik;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}