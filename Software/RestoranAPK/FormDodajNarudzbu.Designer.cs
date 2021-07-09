
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxVrstaJela = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKolicina = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBrStola = new System.Windows.Forms.TextBox();
            this.buttonKreirajNarudzbu = new System.Windows.Forms.Button();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKosarica)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dataGridViewKosarica.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vrsta stavke:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(17, 467);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Količina:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(716, 460);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Broj stola:";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 100);
            this.panel1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(16, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 35);
            this.label4.TabIndex = 11;
            this.label4.Text = "<";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(935, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(245, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(467, 65);
            this.label6.TabIndex = 9;
            this.label6.Text = " DODAJ NARUDŽBU";
            // 
            // FormDodajNarudzbu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(994, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonKreirajNarudzbu);
            this.Controls.Add(this.textBoxBrStola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxKolicina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxVrstaJela);
            this.Controls.Add(this.label1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewJela;
        private System.Windows.Forms.DataGridView dataGridViewKosarica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxVrstaJela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKolicina;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBrStola;
        private System.Windows.Forms.Button buttonKreirajNarudzbu;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}