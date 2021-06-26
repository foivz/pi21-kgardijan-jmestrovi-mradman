
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKosarica)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewJela
            // 
            this.dataGridViewJela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJela.Location = new System.Drawing.Point(13, 89);
            this.dataGridViewJela.Name = "dataGridViewJela";
            this.dataGridViewJela.RowHeadersWidth = 51;
            this.dataGridViewJela.RowTemplate.Height = 24;
            this.dataGridViewJela.Size = new System.Drawing.Size(306, 251);
            this.dataGridViewJela.TabIndex = 0;
            // 
            // dataGridViewKosarica
            // 
            this.dataGridViewKosarica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKosarica.Location = new System.Drawing.Point(426, 89);
            this.dataGridViewKosarica.Name = "dataGridViewKosarica";
            this.dataGridViewKosarica.RowHeadersWidth = 51;
            this.dataGridViewKosarica.RowTemplate.Height = 24;
            this.dataGridViewKosarica.Size = new System.Drawing.Size(306, 251);
            this.dataGridViewKosarica.TabIndex = 1;
            this.dataGridViewKosarica.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vrsta:";
            // 
            // comboBoxVrstaJela
            // 
            this.comboBoxVrstaJela.FormattingEnabled = true;
            this.comboBoxVrstaJela.Location = new System.Drawing.Point(13, 42);
            this.comboBoxVrstaJela.Name = "comboBoxVrstaJela";
            this.comboBoxVrstaJela.Size = new System.Drawing.Size(134, 24);
            this.comboBoxVrstaJela.TabIndex = 3;
            this.comboBoxVrstaJela.SelectedIndexChanged += new System.EventHandler(this.comboBoxVrstaJela_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Količina:";
            // 
            // textBoxKolicina
            // 
            this.textBoxKolicina.Location = new System.Drawing.Point(79, 368);
            this.textBoxKolicina.Name = "textBoxKolicina";
            this.textBoxKolicina.Size = new System.Drawing.Size(106, 22);
            this.textBoxKolicina.TabIndex = 5;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(232, 365);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(87, 29);
            this.buttonDodaj.TabIndex = 6;
            this.buttonDodaj.Text = "Dodaj jelo";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Broj stola:";
            // 
            // textBoxBrStola
            // 
            this.textBoxBrStola.Location = new System.Drawing.Point(500, 365);
            this.textBoxBrStola.Name = "textBoxBrStola";
            this.textBoxBrStola.Size = new System.Drawing.Size(106, 22);
            this.textBoxBrStola.TabIndex = 8;
            // 
            // buttonKreirajNarudzbu
            // 
            this.buttonKreirajNarudzbu.Location = new System.Drawing.Point(610, 435);
            this.buttonKreirajNarudzbu.Name = "buttonKreirajNarudzbu";
            this.buttonKreirajNarudzbu.Size = new System.Drawing.Size(122, 39);
            this.buttonKreirajNarudzbu.TabIndex = 9;
            this.buttonKreirajNarudzbu.Text = "KreirajNarudzbu";
            this.buttonKreirajNarudzbu.UseVisualStyleBackColor = true;
            this.buttonKreirajNarudzbu.Click += new System.EventHandler(this.buttonKreirajNarudzbu_Click);
            // 
            // FormDodajNarudzbu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 500);
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
            this.Name = "FormDodajNarudzbu";
            this.Text = "Dodaj narudžbu";
            this.Load += new System.EventHandler(this.FormDodajNarudzbu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKosarica)).EndInit();
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
    }
}