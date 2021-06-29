
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxImeRestorana = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonJelovnik
            // 
            this.buttonJelovnik.Location = new System.Drawing.Point(12, 82);
            this.buttonJelovnik.Name = "buttonJelovnik";
            this.buttonJelovnik.Size = new System.Drawing.Size(115, 73);
            this.buttonJelovnik.TabIndex = 0;
            this.buttonJelovnik.Text = "Jelovnik";
            this.buttonJelovnik.UseVisualStyleBackColor = true;
            this.buttonJelovnik.Click += new System.EventHandler(this.buttonJelovnik_Click);
            // 
            // buttonZaposlenici
            // 
            this.buttonZaposlenici.Location = new System.Drawing.Point(378, 82);
            this.buttonZaposlenici.Name = "buttonZaposlenici";
            this.buttonZaposlenici.Size = new System.Drawing.Size(115, 73);
            this.buttonZaposlenici.TabIndex = 1;
            this.buttonZaposlenici.Text = "Zaposlenici";
            this.buttonZaposlenici.UseVisualStyleBackColor = true;
            this.buttonZaposlenici.Click += new System.EventHandler(this.buttonZaposlenici_Click);
            // 
            // buttonRezervacije
            // 
            this.buttonRezervacije.Location = new System.Drawing.Point(183, 82);
            this.buttonRezervacije.Name = "buttonRezervacije";
            this.buttonRezervacije.Size = new System.Drawing.Size(115, 73);
            this.buttonRezervacije.TabIndex = 2;
            this.buttonRezervacije.Text = "Rezervacije";
            this.buttonRezervacije.UseVisualStyleBackColor = true;
            this.buttonRezervacije.Click += new System.EventHandler(this.buttonRezervacije_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Restoran:";
            // 
            // textBoxImeRestorana
            // 
            this.textBoxImeRestorana.Location = new System.Drawing.Point(207, 29);
            this.textBoxImeRestorana.Name = "textBoxImeRestorana";
            this.textBoxImeRestorana.ReadOnly = true;
            this.textBoxImeRestorana.Size = new System.Drawing.Size(100, 22);
            this.textBoxImeRestorana.TabIndex = 4;
            // 
            // FormPrijavljenAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 181);
            this.Controls.Add(this.textBoxImeRestorana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRezervacije);
            this.Controls.Add(this.buttonZaposlenici);
            this.Controls.Add(this.buttonJelovnik);
            this.Name = "FormPrijavljenAdmin";
            this.Text = "Naslovnica";
            this.Load += new System.EventHandler(this.FormPrijavljenAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonJelovnik;
        private System.Windows.Forms.Button buttonZaposlenici;
        private System.Windows.Forms.Button buttonRezervacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxImeRestorana;
    }
}