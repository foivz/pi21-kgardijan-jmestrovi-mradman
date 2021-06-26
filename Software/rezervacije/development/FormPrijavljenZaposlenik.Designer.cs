
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRestoran = new System.Windows.Forms.TextBox();
            this.buttonNarudzbe = new System.Windows.Forms.Button();
            this.buttonRacun = new System.Windows.Forms.Button();
            this.buttonRezervacije = new System.Windows.Forms.Button();
            this.buttonJelovnik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Restoran: ";
            // 
            // textBoxRestoran
            // 
            this.textBoxRestoran.Location = new System.Drawing.Point(246, 32);
            this.textBoxRestoran.Name = "textBoxRestoran";
            this.textBoxRestoran.ReadOnly = true;
            this.textBoxRestoran.Size = new System.Drawing.Size(149, 22);
            this.textBoxRestoran.TabIndex = 2;
            // 
            // buttonNarudzbe
            // 
            this.buttonNarudzbe.Location = new System.Drawing.Point(12, 131);
            this.buttonNarudzbe.Name = "buttonNarudzbe";
            this.buttonNarudzbe.Size = new System.Drawing.Size(113, 72);
            this.buttonNarudzbe.TabIndex = 3;
            this.buttonNarudzbe.Text = "Narudžbe";
            this.buttonNarudzbe.UseVisualStyleBackColor = true;
            // 
            // buttonRacun
            // 
            this.buttonRacun.Location = new System.Drawing.Point(155, 131);
            this.buttonRacun.Name = "buttonRacun";
            this.buttonRacun.Size = new System.Drawing.Size(113, 72);
            this.buttonRacun.TabIndex = 4;
            this.buttonRacun.Text = "Izdavanje računa";
            this.buttonRacun.UseVisualStyleBackColor = true;
            // 
            // buttonRezervacije
            // 
            this.buttonRezervacije.Location = new System.Drawing.Point(302, 131);
            this.buttonRezervacije.Name = "buttonRezervacije";
            this.buttonRezervacije.Size = new System.Drawing.Size(113, 72);
            this.buttonRezervacije.TabIndex = 5;
            this.buttonRezervacije.Text = "Rezervacije";
            this.buttonRezervacije.UseVisualStyleBackColor = true;
            this.buttonRezervacije.Click += new System.EventHandler(this.buttonRezervacije_Click);
            // 
            // buttonJelovnik
            // 
            this.buttonJelovnik.Location = new System.Drawing.Point(451, 131);
            this.buttonJelovnik.Name = "buttonJelovnik";
            this.buttonJelovnik.Size = new System.Drawing.Size(113, 72);
            this.buttonJelovnik.TabIndex = 6;
            this.buttonJelovnik.Text = "Jelovnik";
            this.buttonJelovnik.UseVisualStyleBackColor = true;
            // 
            // FormPrijavljenZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 244);
            this.Controls.Add(this.buttonJelovnik);
            this.Controls.Add(this.buttonRezervacije);
            this.Controls.Add(this.buttonRacun);
            this.Controls.Add(this.buttonNarudzbe);
            this.Controls.Add(this.textBoxRestoran);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPrijavljenZaposlenik";
            this.Text = "Naslovnica";
            this.Load += new System.EventHandler(this.FormPrijavljenZaposlenik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRestoran;
        private System.Windows.Forms.Button buttonNarudzbe;
        private System.Windows.Forms.Button buttonRacun;
        private System.Windows.Forms.Button buttonRezervacije;
        private System.Windows.Forms.Button buttonJelovnik;
    }
}