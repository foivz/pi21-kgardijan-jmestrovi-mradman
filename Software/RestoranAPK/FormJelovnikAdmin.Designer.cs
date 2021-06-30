
namespace Funkcionalnost_prijave
{
    partial class FormJelovnikAdmin
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
            this.buttonPovratak = new System.Windows.Forms.Button();
            this.dataGridViewJela = new System.Windows.Forms.DataGridView();
            this.comboBoxVrstaJela = new System.Windows.Forms.ComboBox();
            this.Vrsta = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJela)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPovratak
            // 
            this.buttonPovratak.Location = new System.Drawing.Point(41, 40);
            this.buttonPovratak.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPovratak.Name = "buttonPovratak";
            this.buttonPovratak.Size = new System.Drawing.Size(85, 26);
            this.buttonPovratak.TabIndex = 0;
            this.buttonPovratak.Text = "<";
            this.buttonPovratak.UseVisualStyleBackColor = true;
            this.buttonPovratak.Click += new System.EventHandler(this.buttonPovratak_Click);
            // 
            // dataGridViewJela
            // 
            this.dataGridViewJela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewJela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJela.Location = new System.Drawing.Point(59, 169);
            this.dataGridViewJela.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewJela.Name = "dataGridViewJela";
            this.dataGridViewJela.RowHeadersWidth = 51;
            this.dataGridViewJela.RowTemplate.Height = 24;
            this.dataGridViewJela.Size = new System.Drawing.Size(536, 319);
            this.dataGridViewJela.TabIndex = 1;
            // 
            // comboBoxVrstaJela
            // 
            this.comboBoxVrstaJela.FormattingEnabled = true;
            this.comboBoxVrstaJela.Location = new System.Drawing.Point(115, 121);
            this.comboBoxVrstaJela.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVrstaJela.Name = "comboBoxVrstaJela";
            this.comboBoxVrstaJela.Size = new System.Drawing.Size(135, 26);
            this.comboBoxVrstaJela.TabIndex = 2;
            this.comboBoxVrstaJela.SelectedIndexChanged += new System.EventHandler(this.comboBoxVrstaJela_SelectedIndexChanged);
            // 
            // Vrsta
            // 
            this.Vrsta.AutoSize = true;
            this.Vrsta.Location = new System.Drawing.Point(56, 121);
            this.Vrsta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Vrsta.Name = "Vrsta";
            this.Vrsta.Size = new System.Drawing.Size(46, 18);
            this.Vrsta.TabIndex = 3;
            this.Vrsta.Text = "Vrsta:";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(385, 514);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(85, 40);
            this.buttonDodaj.TabIndex = 4;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(512, 514);
            this.buttonObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(85, 40);
            this.buttonObrisi.TabIndex = 5;
            this.buttonObrisi.Text = "Obriši";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // FormJelovnikAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 598);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.Vrsta);
            this.Controls.Add(this.comboBoxVrstaJela);
            this.Controls.Add(this.dataGridViewJela);
            this.Controls.Add(this.buttonPovratak);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormJelovnikAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jelovnik";
            this.Load += new System.EventHandler(this.FormJelovnikAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPovratak;
        private System.Windows.Forms.DataGridView dataGridViewJela;
        private System.Windows.Forms.ComboBox comboBoxVrstaJela;
        private System.Windows.Forms.Label Vrsta;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonObrisi;
    }
}