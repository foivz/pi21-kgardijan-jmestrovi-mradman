
namespace Funkcionalnost_prijave
{
    partial class FormDodajRestoran
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
            this.labelImer = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxImeRestorana = new System.Windows.Forms.TextBox();
            this.textBoxEmailVlasnika = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelRestoran = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.pictureBoxRestoran = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestoran)).BeginInit();
            this.SuspendLayout();
            // 
            // labelImer
            // 
            this.labelImer.AutoSize = true;
            this.labelImer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelImer.Location = new System.Drawing.Point(29, 200);
            this.labelImer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImer.Name = "labelImer";
            this.labelImer.Size = new System.Drawing.Size(136, 25);
            this.labelImer.TabIndex = 0;
            this.labelImer.Text = "Ime restorana:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEmail.Location = new System.Drawing.Point(29, 310);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(146, 25);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "E-mail vlasnika:";
            // 
            // textBoxImeRestorana
            // 
            this.textBoxImeRestorana.Location = new System.Drawing.Point(32, 243);
            this.textBoxImeRestorana.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxImeRestorana.Name = "textBoxImeRestorana";
            this.textBoxImeRestorana.Size = new System.Drawing.Size(246, 24);
            this.textBoxImeRestorana.TabIndex = 2;
            // 
            // textBoxEmailVlasnika
            // 
            this.textBoxEmailVlasnika.Location = new System.Drawing.Point(32, 339);
            this.textBoxEmailVlasnika.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmailVlasnika.Name = "textBoxEmailVlasnika";
            this.textBoxEmailVlasnika.Size = new System.Drawing.Size(246, 24);
            this.textBoxEmailVlasnika.TabIndex = 3;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodaj.Location = new System.Drawing.Point(205, 419);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(94, 45);
            this.buttonDodaj.TabIndex = 4;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOdustani.Location = new System.Drawing.Point(28, 419);
            this.buttonOdustani.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(104, 45);
            this.buttonOdustani.TabIndex = 5;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.panelTop.Controls.Add(this.labelRestoran);
            this.panelTop.Controls.Add(this.labelClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(369, 100);
            this.panelTop.TabIndex = 6;
            // 
            // labelRestoran
            // 
            this.labelRestoran.AutoSize = true;
            this.labelRestoran.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestoran.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRestoran.Location = new System.Drawing.Point(50, 28);
            this.labelRestoran.Name = "labelRestoran";
            this.labelRestoran.Size = new System.Drawing.Size(243, 45);
            this.labelRestoran.TabIndex = 11;
            this.labelRestoran.Text = "Dodaj restoran";
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
            this.labelClose.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBoxRestoran
            // 
            this.pictureBoxRestoran.Image = global::Funkcionalnost_prijave.Properties.Resources.dodaj_res;
            this.pictureBoxRestoran.Location = new System.Drawing.Point(109, 106);
            this.pictureBoxRestoran.Name = "pictureBoxRestoran";
            this.pictureBoxRestoran.Size = new System.Drawing.Size(150, 96);
            this.pictureBoxRestoran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRestoran.TabIndex = 7;
            this.pictureBoxRestoran.TabStop = false;
            // 
            // FormDodajRestoran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(369, 497);
            this.Controls.Add(this.pictureBoxRestoran);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxEmailVlasnika);
            this.Controls.Add(this.textBoxImeRestorana);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelImer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDodajRestoran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj restoran";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormDodajRestoran_HelpRequested);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestoran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImer;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxImeRestorana;
        private System.Windows.Forms.TextBox textBoxEmailVlasnika;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelRestoran;
        private System.Windows.Forms.PictureBox pictureBoxRestoran;
    }
}