
namespace Funkcionalnost_prijave
{
    partial class FormRezervacija
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
            this.dataGridViewRezervacije = new System.Windows.Forms.DataGridView();
            this.buttonPovratak = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonObriši = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRezervacije
            // 
            this.dataGridViewRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezervacije.Location = new System.Drawing.Point(13, 57);
            this.dataGridViewRezervacije.Name = "dataGridViewRezervacije";
            this.dataGridViewRezervacije.RowHeadersWidth = 51;
            this.dataGridViewRezervacije.RowTemplate.Height = 24;
            this.dataGridViewRezervacije.Size = new System.Drawing.Size(775, 277);
            this.dataGridViewRezervacije.TabIndex = 0;
            // 
            // buttonPovratak
            // 
            this.buttonPovratak.Location = new System.Drawing.Point(13, 13);
            this.buttonPovratak.Name = "buttonPovratak";
            this.buttonPovratak.Size = new System.Drawing.Size(75, 23);
            this.buttonPovratak.TabIndex = 1;
            this.buttonPovratak.Text = "<";
            this.buttonPovratak.UseVisualStyleBackColor = true;
            this.buttonPovratak.Click += new System.EventHandler(this.buttonPovratak_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(700, 365);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(88, 45);
            this.buttonDodaj.TabIndex = 2;
            this.buttonDodaj.Text = "Dodaj rezervaciju";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObriši
            // 
            this.buttonObriši.Location = new System.Drawing.Point(592, 365);
            this.buttonObriši.Name = "buttonObriši";
            this.buttonObriši.Size = new System.Drawing.Size(86, 45);
            this.buttonObriši.TabIndex = 3;
            this.buttonObriši.Text = "Obriši";
            this.buttonObriši.UseVisualStyleBackColor = true;
            this.buttonObriši.Click += new System.EventHandler(this.buttonObriši_Click);
            // 
            // FormRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonObriši);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.buttonPovratak);
            this.Controls.Add(this.dataGridViewRezervacije);
            this.Name = "FormRezervacija";
            this.Text = "Rezervacije";
            this.Load += new System.EventHandler(this.FormRezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervacije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRezervacije;
        private System.Windows.Forms.Button buttonPovratak;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonObriši;
    }
}