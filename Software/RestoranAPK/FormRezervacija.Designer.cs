
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
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRezervacije
            // 
            this.dataGridViewRezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezervacije.Location = new System.Drawing.Point(14, 64);
            this.dataGridViewRezervacije.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewRezervacije.Name = "dataGridViewRezervacije";
            this.dataGridViewRezervacije.RowHeadersWidth = 51;
            this.dataGridViewRezervacije.RowTemplate.Height = 24;
            this.dataGridViewRezervacije.Size = new System.Drawing.Size(997, 311);
            this.dataGridViewRezervacije.TabIndex = 0;
            // 
            // buttonPovratak
            // 
            this.buttonPovratak.Location = new System.Drawing.Point(14, 14);
            this.buttonPovratak.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPovratak.Name = "buttonPovratak";
            this.buttonPovratak.Size = new System.Drawing.Size(85, 26);
            this.buttonPovratak.TabIndex = 1;
            this.buttonPovratak.Text = "<";
            this.buttonPovratak.UseVisualStyleBackColor = true;
            this.buttonPovratak.Click += new System.EventHandler(this.buttonPovratak_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(913, 410);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(99, 50);
            this.buttonDodaj.TabIndex = 2;
            this.buttonDodaj.Text = "Dodaj rezervaciju";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObriši
            // 
            this.buttonObriši.Location = new System.Drawing.Point(765, 410);
            this.buttonObriši.Margin = new System.Windows.Forms.Padding(4);
            this.buttonObriši.Name = "buttonObriši";
            this.buttonObriši.Size = new System.Drawing.Size(97, 50);
            this.buttonObriši.TabIndex = 3;
            this.buttonObriši.Text = "Obriši";
            this.buttonObriši.UseVisualStyleBackColor = true;
            this.buttonObriši.Click += new System.EventHandler(this.buttonObriši_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Mateo\\Desktop\\Aplikacija\\Aplikacija\\RestaurantHelp.chm";
            // 
            // FormRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 506);
            this.Controls.Add(this.buttonObriši);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.buttonPovratak);
            this.Controls.Add(this.dataGridViewRezervacije);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRezervacija";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}