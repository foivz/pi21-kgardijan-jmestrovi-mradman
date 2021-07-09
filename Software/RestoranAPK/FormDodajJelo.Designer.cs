
namespace Funkcionalnost_prijave
{
    partial class FormDodajJelo
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
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelVrsta = new System.Windows.Forms.Label();
            this.labelCijena = new System.Windows.Forms.Label();
            this.labelOpis = new System.Windows.Forms.Label();
            this.comboBoxVrstaJela = new System.Windows.Forms.ComboBox();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.richTextBoxOpis = new System.Windows.Forms.RichTextBox();
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelDodajStavku = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.pictureBoxStavka = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStavka)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDodaj.Location = new System.Drawing.Point(279, 576);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(100, 56);
            this.buttonDodaj.TabIndex = 0;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOdustani.Location = new System.Drawing.Point(160, 576);
            this.buttonOdustani.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(100, 56);
            this.buttonOdustani.TabIndex = 1;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(31, 243);
            this.labelNaziv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(66, 25);
            this.labelNaziv.TabIndex = 2;
            this.labelNaziv.Text = "Naziv:";
            // 
            // labelVrsta
            // 
            this.labelVrsta.AutoSize = true;
            this.labelVrsta.Location = new System.Drawing.Point(37, 519);
            this.labelVrsta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVrsta.Name = "labelVrsta";
            this.labelVrsta.Size = new System.Drawing.Size(60, 25);
            this.labelVrsta.TabIndex = 3;
            this.labelVrsta.Text = "Vrsta:";
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.Location = new System.Drawing.Point(27, 476);
            this.labelCijena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(70, 25);
            this.labelCijena.TabIndex = 4;
            this.labelCijena.Text = "Cijena:";
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Location = new System.Drawing.Point(42, 289);
            this.labelOpis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(55, 25);
            this.labelOpis.TabIndex = 5;
            this.labelOpis.Text = "Opis:";
            // 
            // comboBoxVrstaJela
            // 
            this.comboBoxVrstaJela.FormattingEnabled = true;
            this.comboBoxVrstaJela.Location = new System.Drawing.Point(105, 519);
            this.comboBoxVrstaJela.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.comboBoxVrstaJela.Name = "comboBoxVrstaJela";
            this.comboBoxVrstaJela.Size = new System.Drawing.Size(166, 33);
            this.comboBoxVrstaJela.TabIndex = 6;
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(105, 243);
            this.textBoxNaziv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(124, 31);
            this.textBoxNaziv.TabIndex = 7;
            // 
            // richTextBoxOpis
            // 
            this.richTextBoxOpis.Location = new System.Drawing.Point(105, 286);
            this.richTextBoxOpis.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.richTextBoxOpis.Name = "richTextBoxOpis";
            this.richTextBoxOpis.Size = new System.Drawing.Size(274, 178);
            this.richTextBoxOpis.TabIndex = 8;
            this.richTextBoxOpis.Text = "";
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.Location = new System.Drawing.Point(105, 476);
            this.textBoxCijena.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.Size = new System.Drawing.Size(124, 31);
            this.textBoxCijena.TabIndex = 9;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.panelTop.Controls.Add(this.labelDodajStavku);
            this.panelTop.Controls.Add(this.labelClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(408, 100);
            this.panelTop.TabIndex = 10;
            // 
            // labelDodajStavku
            // 
            this.labelDodajStavku.AutoSize = true;
            this.labelDodajStavku.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDodajStavku.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDodajStavku.Location = new System.Drawing.Point(93, 26);
            this.labelDodajStavku.Name = "labelDodajStavku";
            this.labelDodajStavku.Size = new System.Drawing.Size(215, 45);
            this.labelDodajStavku.TabIndex = 11;
            this.labelDodajStavku.Text = "Dodaj stavku";
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelClose.Location = new System.Drawing.Point(349, 36);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(30, 35);
            this.labelClose.TabIndex = 10;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // pictureBoxStavka
            // 
            this.pictureBoxStavka.Image = global::Funkcionalnost_prijave.Properties.Resources.cooking;
            this.pictureBoxStavka.Location = new System.Drawing.Point(105, 106);
            this.pictureBoxStavka.Name = "pictureBoxStavka";
            this.pictureBoxStavka.Size = new System.Drawing.Size(203, 114);
            this.pictureBoxStavka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStavka.TabIndex = 11;
            this.pictureBoxStavka.TabStop = false;
            // 
            // FormDodajJelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(408, 648);
            this.Controls.Add(this.pictureBoxStavka);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.textBoxCijena);
            this.Controls.Add(this.richTextBoxOpis);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.comboBoxVrstaJela);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.labelCijena);
            this.Controls.Add(this.labelVrsta);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonDodaj);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormDodajJelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj stavku";
            this.Load += new System.EventHandler(this.FormDodajJelo_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormDodajJelo_HelpRequested);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStavka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Label labelVrsta;
        private System.Windows.Forms.Label labelCijena;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.ComboBox comboBoxVrstaJela;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.RichTextBox richTextBoxOpis;
        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelDodajStavku;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.PictureBox pictureBoxStavka;
    }
}