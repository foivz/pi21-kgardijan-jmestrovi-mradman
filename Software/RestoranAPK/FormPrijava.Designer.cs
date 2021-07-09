
namespace Funkcionalnost_prijave
{
    partial class FormPrijava
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
            this.labelPrijava = new System.Windows.Forms.Label();
            this.labelKorIme = new System.Windows.Forms.Label();
            this.labelLoz = new System.Windows.Forms.Label();
            this.textBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.ButtonPrijava = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.pictureBoxPrijava = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrijava)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrijava
            // 
            this.labelPrijava.AutoSize = true;
            this.labelPrijava.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrijava.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPrijava.Location = new System.Drawing.Point(369, 18);
            this.labelPrijava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrijava.Name = "labelPrijava";
            this.labelPrijava.Size = new System.Drawing.Size(207, 65);
            this.labelPrijava.TabIndex = 0;
            this.labelPrijava.Text = "PRIJAVA";
            // 
            // labelKorIme
            // 
            this.labelKorIme.AutoSize = true;
            this.labelKorIme.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKorIme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelKorIme.Location = new System.Drawing.Point(228, 298);
            this.labelKorIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKorIme.Name = "labelKorIme";
            this.labelKorIme.Size = new System.Drawing.Size(143, 25);
            this.labelKorIme.TabIndex = 1;
            this.labelKorIme.Text = "Korisničko ime:";
            // 
            // labelLoz
            // 
            this.labelLoz.AutoSize = true;
            this.labelLoz.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLoz.Location = new System.Drawing.Point(289, 344);
            this.labelLoz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoz.Name = "labelLoz";
            this.labelLoz.Size = new System.Drawing.Size(82, 25);
            this.labelLoz.TabIndex = 2;
            this.labelLoz.Text = "Lozinka:";
            // 
            // textBoxKorisnickoIme
            // 
            this.textBoxKorisnickoIme.Location = new System.Drawing.Point(376, 298);
            this.textBoxKorisnickoIme.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKorisnickoIme.Name = "textBoxKorisnickoIme";
            this.textBoxKorisnickoIme.Size = new System.Drawing.Size(186, 24);
            this.textBoxKorisnickoIme.TabIndex = 3;
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(376, 346);
            this.textBoxLozinka.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(186, 24);
            this.textBoxLozinka.TabIndex = 4;
            this.textBoxLozinka.UseSystemPasswordChar = true;
            // 
            // ButtonPrijava
            // 
            this.ButtonPrijava.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPrijava.Location = new System.Drawing.Point(460, 375);
            this.ButtonPrijava.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonPrijava.Name = "ButtonPrijava";
            this.ButtonPrijava.Size = new System.Drawing.Size(102, 40);
            this.ButtonPrijava.TabIndex = 5;
            this.ButtonPrijava.Text = "Prijava";
            this.ButtonPrijava.UseVisualStyleBackColor = true;
            this.ButtonPrijava.Click += new System.EventHandler(this.ButtonPrijava_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.panelTop.Controls.Add(this.labelClose);
            this.panelTop.Controls.Add(this.labelPrijava);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(951, 112);
            this.panelTop.TabIndex = 6;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI", 15.2F);
            this.labelClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelClose.Location = new System.Drawing.Point(884, 31);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(30, 36);
            this.labelClose.TabIndex = 7;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // pictureBoxPrijava
            // 
            this.pictureBoxPrijava.Image = global::Funkcionalnost_prijave.Properties.Resources.forkR1;
            this.pictureBoxPrijava.Location = new System.Drawing.Point(389, 135);
            this.pictureBoxPrijava.Name = "pictureBoxPrijava";
            this.pictureBoxPrijava.Size = new System.Drawing.Size(162, 147);
            this.pictureBoxPrijava.TabIndex = 1;
            this.pictureBoxPrijava.TabStop = false;
            // 
            // FormPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.pictureBoxPrijava);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.ButtonPrijava);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.textBoxKorisnickoIme);
            this.Controls.Add(this.labelLoz);
            this.Controls.Add(this.labelKorIme);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormPrijava_HelpRequested);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrijava)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrijava;
        private System.Windows.Forms.Label labelKorIme;
        private System.Windows.Forms.Label labelLoz;
        private System.Windows.Forms.TextBox textBoxKorisnickoIme;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.Button ButtonPrijava;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBoxPrijava;
        private System.Windows.Forms.Label labelClose;
    }
}

