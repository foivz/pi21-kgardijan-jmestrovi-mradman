
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.labelRestoran.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestoran.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRestoran.Location = new System.Drawing.Point(332, 142);
            this.labelRestoran.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRestoran.Name = "labelRestoran";
            this.labelRestoran.Size = new System.Drawing.Size(154, 41);
            this.labelRestoran.TabIndex = 1;
            this.labelRestoran.Text = "Restoran: ";
            this.labelRestoran.Click += new System.EventHandler(this.labelRestoran_Click);
            // 
            // buttonNarudzbe
            // 
            this.buttonNarudzbe.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNarudzbe.Location = new System.Drawing.Point(620, 251);
            this.buttonNarudzbe.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNarudzbe.Name = "buttonNarudzbe";
            this.buttonNarudzbe.Size = new System.Drawing.Size(127, 89);
            this.buttonNarudzbe.TabIndex = 3;
            this.buttonNarudzbe.Text = "Narudžbe";
            this.buttonNarudzbe.UseVisualStyleBackColor = true;
            this.buttonNarudzbe.Click += new System.EventHandler(this.buttonNarudzbe_Click);
            // 
            // buttonRezervacije
            // 
            this.buttonRezervacije.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRezervacije.Location = new System.Drawing.Point(374, 251);
            this.buttonRezervacije.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRezervacije.Name = "buttonRezervacije";
            this.buttonRezervacije.Size = new System.Drawing.Size(127, 89);
            this.buttonRezervacije.TabIndex = 5;
            this.buttonRezervacije.Text = "Rezervacije";
            this.buttonRezervacije.UseVisualStyleBackColor = true;
            this.buttonRezervacije.Click += new System.EventHandler(this.buttonRezervacije_Click);
            // 
            // buttonJelovnik
            // 
            this.buttonJelovnik.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJelovnik.Location = new System.Drawing.Point(153, 251);
            this.buttonJelovnik.Margin = new System.Windows.Forms.Padding(4);
            this.buttonJelovnik.Name = "buttonJelovnik";
            this.buttonJelovnik.Size = new System.Drawing.Size(127, 89);
            this.buttonJelovnik.TabIndex = 6;
            this.buttonJelovnik.Text = "Jelovnik";
            this.buttonJelovnik.UseVisualStyleBackColor = true;
            this.buttonJelovnik.Click += new System.EventHandler(this.buttonJelovnik_Click);
            // 
            // buttonOdjava
            // 
            this.buttonOdjava.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOdjava.Location = new System.Drawing.Point(23, 37);
            this.buttonOdjava.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOdjava.Name = "buttonOdjava";
            this.buttonOdjava.Size = new System.Drawing.Size(85, 35);
            this.buttonOdjava.TabIndex = 7;
            this.buttonOdjava.Text = "Odjava";
            this.buttonOdjava.UseVisualStyleBackColor = true;
            this.buttonOdjava.Click += new System.EventHandler(this.buttonOdjava_Click);
            // 
            // labelKorisnik
            // 
            this.labelKorisnik.AutoSize = true;
            this.labelKorisnik.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKorisnik.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelKorisnik.Location = new System.Drawing.Point(18, 483);
            this.labelKorisnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKorisnik.Name = "labelKorisnik";
            this.labelKorisnik.Size = new System.Drawing.Size(64, 25);
            this.labelKorisnik.TabIndex = 8;
            this.labelKorisnik.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonOdjava);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 100);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(858, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 35);
            this.label3.TabIndex = 11;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(300, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 65);
            this.label2.TabIndex = 10;
            this.label2.Text = "NASLOVNICA";
            // 
            // FormPrijavljenZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(933, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelKorisnik);
            this.Controls.Add(this.buttonJelovnik);
            this.Controls.Add(this.buttonRezervacije);
            this.Controls.Add(this.buttonNarudzbe);
            this.Controls.Add(this.labelRestoran);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrijavljenZaposlenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naslovnica";
            this.Load += new System.EventHandler(this.FormPrijavljenZaposlenik_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormPrijavljenZaposlenik_HelpRequested);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}