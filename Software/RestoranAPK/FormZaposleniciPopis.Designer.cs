
namespace Funkcionalnost_prijave
{
    partial class FormZaposleniciPopis
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
            this.dataGridViewPopisZaposlenika = new System.Windows.Forms.DataGridView();
            this.buttonDodajZaposlenika = new System.Windows.Forms.Button();
            this.buttonObrišiZaposlenika = new System.Windows.Forms.Button();
            this.buttonUrediZaposlenika = new System.Windows.Forms.Button();
            this.buttonPovratak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPopisZaposlenika)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPopisZaposlenika
            // 
            this.dataGridViewPopisZaposlenika.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPopisZaposlenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPopisZaposlenika.Location = new System.Drawing.Point(20, 58);
            this.dataGridViewPopisZaposlenika.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPopisZaposlenika.Name = "dataGridViewPopisZaposlenika";
            this.dataGridViewPopisZaposlenika.RowHeadersWidth = 51;
            this.dataGridViewPopisZaposlenika.RowTemplate.Height = 24;
            this.dataGridViewPopisZaposlenika.Size = new System.Drawing.Size(536, 253);
            this.dataGridViewPopisZaposlenika.TabIndex = 0;
            this.dataGridViewPopisZaposlenika.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPopisZaposlenika_CellContentClick);
            // 
            // buttonDodajZaposlenika
            // 
            this.buttonDodajZaposlenika.Location = new System.Drawing.Point(414, 335);
            this.buttonDodajZaposlenika.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDodajZaposlenika.Name = "buttonDodajZaposlenika";
            this.buttonDodajZaposlenika.Size = new System.Drawing.Size(143, 58);
            this.buttonDodajZaposlenika.TabIndex = 1;
            this.buttonDodajZaposlenika.Text = "Dodaj ";
            this.buttonDodajZaposlenika.UseVisualStyleBackColor = true;
            this.buttonDodajZaposlenika.Click += new System.EventHandler(this.buttonDodajZaposlenika_Click);
            // 
            // buttonObrišiZaposlenika
            // 
            this.buttonObrišiZaposlenika.Location = new System.Drawing.Point(25, 335);
            this.buttonObrišiZaposlenika.Margin = new System.Windows.Forms.Padding(4);
            this.buttonObrišiZaposlenika.Name = "buttonObrišiZaposlenika";
            this.buttonObrišiZaposlenika.Size = new System.Drawing.Size(143, 58);
            this.buttonObrišiZaposlenika.TabIndex = 2;
            this.buttonObrišiZaposlenika.Text = "Obriši";
            this.buttonObrišiZaposlenika.UseVisualStyleBackColor = true;
            this.buttonObrišiZaposlenika.Click += new System.EventHandler(this.buttonObrišiZaposlenika_Click);
            // 
            // buttonUrediZaposlenika
            // 
            this.buttonUrediZaposlenika.Location = new System.Drawing.Point(202, 335);
            this.buttonUrediZaposlenika.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUrediZaposlenika.Name = "buttonUrediZaposlenika";
            this.buttonUrediZaposlenika.Size = new System.Drawing.Size(143, 58);
            this.buttonUrediZaposlenika.TabIndex = 3;
            this.buttonUrediZaposlenika.Text = "Uredi";
            this.buttonUrediZaposlenika.UseVisualStyleBackColor = true;
            this.buttonUrediZaposlenika.Click += new System.EventHandler(this.buttonUrediZaposlenika_Click);
            // 
            // buttonPovratak
            // 
            this.buttonPovratak.Location = new System.Drawing.Point(25, 16);
            this.buttonPovratak.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPovratak.Name = "buttonPovratak";
            this.buttonPovratak.Size = new System.Drawing.Size(94, 31);
            this.buttonPovratak.TabIndex = 4;
            this.buttonPovratak.Text = "< Povratak";
            this.buttonPovratak.UseVisualStyleBackColor = true;
            this.buttonPovratak.Click += new System.EventHandler(this.buttonPovratak_Click);
            // 
            // FormZaposleniciPopis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 418);
            this.Controls.Add(this.buttonPovratak);
            this.Controls.Add(this.buttonUrediZaposlenika);
            this.Controls.Add(this.buttonObrišiZaposlenika);
            this.Controls.Add(this.buttonDodajZaposlenika);
            this.Controls.Add(this.dataGridViewPopisZaposlenika);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormZaposleniciPopis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis zaposlenika";
            this.Load += new System.EventHandler(this.FormZaposleniciPopis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPopisZaposlenika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPopisZaposlenika;
        private System.Windows.Forms.Button buttonDodajZaposlenika;
        private System.Windows.Forms.Button buttonObrišiZaposlenika;
        private System.Windows.Forms.Button buttonUrediZaposlenika;
        private System.Windows.Forms.Button buttonPovratak;
    }
}