
namespace Funkcionalnost_prijave
{
    partial class FormDodajNarudzbu
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
            this.dataGridViewJela = new System.Windows.Forms.DataGridView();
            this.dataGridViewKosarica = new System.Windows.Forms.DataGridView();
            this.labelStavke = new System.Windows.Forms.Label();
            this.comboBoxVrstaJela = new System.Windows.Forms.ComboBox();
            this.labelKolicina = new System.Windows.Forms.Label();
            this.textBoxKolicina = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.labelBrojStola = new System.Windows.Forms.Label();
            this.textBoxBrStola = new System.Windows.Forms.TextBox();
            this.buttonKreirajNarudzbu = new System.Windows.Forms.Button();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelBack = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelDodajNar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKosarica)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewJela
            // 
            this.dataGridViewJela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewJela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJela.Location = new System.Drawing.Point(18, 178);
            this.dataGridViewJela.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dataGridViewJela.Name = "dataGridViewJela";
            this.dataGridViewJela.RowHeadersWidth = 51;
            this.dataGridViewJela.RowTemplate.Height = 24;
            this.dataGridViewJela.Size = new System.Drawing.Size(347, 250);
            this.dataGridViewJela.TabIndex = 0;
            // 
            // dataGridViewKosarica
            // 
            this.dataGridViewKosarica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKosarica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKosarica.Location = new System.Drawing.Point(500, 178);
            this.dataGridViewKosarica.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dataGridViewKosarica.Name = "dataGridViewKosarica";
            this.dataGridViewKosarica.RowHeadersWidth = 51;
            this.dataGridViewKosarica.RowTemplate.Height = 24;
            this.dataGridViewKosarica.Size = new System.Drawing.Size(465, 250);
            this.dataGridViewKosarica.TabIndex = 1;
            // 
            // labelStavke
            // 
            this.labelStavke.AutoSize = true;
            this.labelStavke.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelStavke.Location = new System.Drawing.Point(13, 122);
            this.labelStavke.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStavke.Name = "labelStavke";
            this.labelStavke.Size = new System.Drawing.Size(120, 25);
            this.labelStavke.TabIndex = 2;
            this.labelStavke.Text = "Vrsta stavke:";
            // 
            // comboBoxVrstaJela
            // 
            this.comboBoxVrstaJela.FormattingEnabled = true;
            this.comboBoxVrstaJela.Location = new System.Drawing.Point(141, 122);
            this.comboBoxVrstaJela.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.comboBoxVrstaJela.Name = "comboBoxVrstaJela";
            this.comboBoxVrstaJela.Size = new System.Drawing.Size(166, 33);
            this.comboBoxVrstaJela.TabIndex = 3;
            this.comboBoxVrstaJela.SelectedIndexChanged += new System.EventHandler(this.comboBoxVrstaJela_SelectedIndexChanged);
            // 
            // labelKolicina
            // 
            this.labelKolicina.AutoSize = true;
            this.labelKolicina.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelKolicina.Location = new System.Drawing.Point(17, 467);
            this.labelKolicina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKolicina.Name = "labelKolicina";
            this.labelKolicina.Size = new System.Drawing.Size(85, 25);
            this.labelKolicina.TabIndex = 4;
            this.labelKolicina.Text = "Količina:";
            // 
            // textBoxKolicina
            // 
            this.textBoxKolicina.Location = new System.Drawing.Point(110, 464);
            this.textBoxKolicina.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxKolicina.Name = "textBoxKolicina";
            this.textBoxKolicina.Size = new System.Drawing.Size(132, 31);
            this.textBoxKolicina.TabIndex = 5;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(256, 460);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(109, 44);
            this.buttonDodaj.TabIndex = 6;
            this.buttonDodaj.Text = "Dodaj jelo";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // labelBrojStola
            // 
            this.labelBrojStola.AutoSize = true;
            this.labelBrojStola.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelBrojStola.Location = new System.Drawing.Point(716, 460);
            this.labelBrojStola.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBrojStola.Name = "labelBrojStola";
            this.labelBrojStola.Size = new System.Drawing.Size(97, 25);
            this.labelBrojStola.TabIndex = 7;
            this.labelBrojStola.Text = "Broj stola:";
            // 
            // textBoxBrStola
            // 
            this.textBoxBrStola.Location = new System.Drawing.Point(833, 460);
            this.textBoxBrStola.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxBrStola.Name = "textBoxBrStola";
            this.textBoxBrStola.Size = new System.Drawing.Size(132, 31);
            this.textBoxBrStola.TabIndex = 8;
            // 
            // buttonKreirajNarudzbu
            // 
            this.buttonKreirajNarudzbu.Location = new System.Drawing.Point(821, 527);
            this.buttonKreirajNarudzbu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonKreirajNarudzbu.Name = "buttonKreirajNarudzbu";
            this.buttonKreirajNarudzbu.Size = new System.Drawing.Size(152, 61);
            this.buttonKreirajNarudzbu.TabIndex = 9;
            this.buttonKreirajNarudzbu.Text = "Kreiraj narudžbu";
            this.buttonKreirajNarudzbu.UseVisualStyleBackColor = true;
            this.buttonKreirajNarudzbu.Click += new System.EventHandler(this.buttonKreirajNarudzbu_Click);
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(634, 527);
            this.buttonOdustani.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(152, 61);
            this.buttonOdustani.TabIndex = 10;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.panelTop.Controls.Add(this.labelBack);
            this.panelTop.Controls.Add(this.labelClose);
            this.panelTop.Controls.Add(this.labelDodajNar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(994, 100);
            this.panelTop.TabIndex = 12;
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelBack.Location = new System.Drawing.Point(16, 32);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(32, 35);
            this.labelBack.TabIndex = 11;
            this.labelBack.Text = "<";
            this.labelBack.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelClose.Location = new System.Drawing.Point(952, 9);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(30, 35);
            this.labelClose.TabIndex = 10;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelDodajNar
            // 
            this.labelDodajNar.AutoSize = true;
            this.labelDodajNar.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDodajNar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDodajNar.Location = new System.Drawing.Point(245, 15);
            this.labelDodajNar.Name = "labelDodajNar";
            this.labelDodajNar.Size = new System.Drawing.Size(467, 65);
            this.labelDodajNar.TabIndex = 9;
            this.labelDodajNar.Text = " DODAJ NARUDŽBU";
            // 
            // FormDodajNarudzbu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(994, 617);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonKreirajNarudzbu);
            this.Controls.Add(this.textBoxBrStola);
            this.Controls.Add(this.labelBrojStola);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxKolicina);
            this.Controls.Add(this.labelKolicina);
            this.Controls.Add(this.comboBoxVrstaJela);
            this.Controls.Add(this.labelStavke);
            this.Controls.Add(this.dataGridViewKosarica);
            this.Controls.Add(this.dataGridViewJela);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormDodajNarudzbu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj narudžbu";
            this.Load += new System.EventHandler(this.FormDodajNarudzbu_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormDodajNarudzbu_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKosarica)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewJela;
        private System.Windows.Forms.DataGridView dataGridViewKosarica;
        private System.Windows.Forms.Label labelStavke;
        private System.Windows.Forms.ComboBox comboBoxVrstaJela;
        private System.Windows.Forms.Label labelKolicina;
        private System.Windows.Forms.TextBox textBoxKolicina;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label labelBrojStola;
        private System.Windows.Forms.TextBox textBoxBrStola;
        private System.Windows.Forms.Button buttonKreirajNarudzbu;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelDodajNar;
    }
}