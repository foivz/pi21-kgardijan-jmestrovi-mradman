
namespace Funkcionalnost_prijave
{
    partial class FormNarudzbe
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
            this.dataGridViewNarudzbe = new System.Windows.Forms.DataGridView();
            this.buttonPromijeniStatus = new System.Windows.Forms.Button();
            this.buttonDodajNarudzbu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonObrisiNarudzbu = new System.Windows.Forms.Button();
            this.buttonPovratak = new System.Windows.Forms.Button();
            this.buttonPrikaziNarudzbu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNarudzbe
            // 
            this.dataGridViewNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNarudzbe.Location = new System.Drawing.Point(102, 54);
            this.dataGridViewNarudzbe.Name = "dataGridViewNarudzbe";
            this.dataGridViewNarudzbe.RowHeadersWidth = 51;
            this.dataGridViewNarudzbe.RowTemplate.Height = 24;
            this.dataGridViewNarudzbe.Size = new System.Drawing.Size(486, 255);
            this.dataGridViewNarudzbe.TabIndex = 0;
            // 
            // buttonPromijeniStatus
            // 
            this.buttonPromijeniStatus.Location = new System.Drawing.Point(164, 339);
            this.buttonPromijeniStatus.Name = "buttonPromijeniStatus";
            this.buttonPromijeniStatus.Size = new System.Drawing.Size(101, 43);
            this.buttonPromijeniStatus.TabIndex = 3;
            this.buttonPromijeniStatus.Text = "Promjeni status";
            this.buttonPromijeniStatus.UseVisualStyleBackColor = true;
            this.buttonPromijeniStatus.Click += new System.EventHandler(this.buttonPromijeniStatus_Click);
            // 
            // buttonDodajNarudzbu
            // 
            this.buttonDodajNarudzbu.Location = new System.Drawing.Point(417, 339);
            this.buttonDodajNarudzbu.Name = "buttonDodajNarudzbu";
            this.buttonDodajNarudzbu.Size = new System.Drawing.Size(101, 43);
            this.buttonDodajNarudzbu.TabIndex = 5;
            this.buttonDodajNarudzbu.Text = "Dodaj narudžbu";
            this.buttonDodajNarudzbu.UseVisualStyleBackColor = true;
            this.buttonDodajNarudzbu.Click += new System.EventHandler(this.buttonDodajNarudzbu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Odaberi status:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(19, 358);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStatus.TabIndex = 7;
            // 
            // buttonObrisiNarudzbu
            // 
            this.buttonObrisiNarudzbu.Location = new System.Drawing.Point(297, 339);
            this.buttonObrisiNarudzbu.Name = "buttonObrisiNarudzbu";
            this.buttonObrisiNarudzbu.Size = new System.Drawing.Size(101, 43);
            this.buttonObrisiNarudzbu.TabIndex = 8;
            this.buttonObrisiNarudzbu.Text = "Obriši narudžbu";
            this.buttonObrisiNarudzbu.UseVisualStyleBackColor = true;
            this.buttonObrisiNarudzbu.Click += new System.EventHandler(this.buttonObrisiNarudzbu_Click);
            // 
            // buttonPovratak
            // 
            this.buttonPovratak.Location = new System.Drawing.Point(19, 13);
            this.buttonPovratak.Name = "buttonPovratak";
            this.buttonPovratak.Size = new System.Drawing.Size(75, 23);
            this.buttonPovratak.TabIndex = 9;
            this.buttonPovratak.Text = "<";
            this.buttonPovratak.UseVisualStyleBackColor = true;
            this.buttonPovratak.Click += new System.EventHandler(this.buttonPovratak_Click);
            // 
            // buttonPrikaziNarudzbu
            // 
            this.buttonPrikaziNarudzbu.Location = new System.Drawing.Point(538, 339);
            this.buttonPrikaziNarudzbu.Name = "buttonPrikaziNarudzbu";
            this.buttonPrikaziNarudzbu.Size = new System.Drawing.Size(101, 43);
            this.buttonPrikaziNarudzbu.TabIndex = 10;
            this.buttonPrikaziNarudzbu.Text = "Prikaži narudžbu";
            this.buttonPrikaziNarudzbu.UseVisualStyleBackColor = true;
            this.buttonPrikaziNarudzbu.Click += new System.EventHandler(this.buttonPrikaziNarudzbu_Click);
            // 
            // FormNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 410);
            this.Controls.Add(this.buttonPrikaziNarudzbu);
            this.Controls.Add(this.buttonPovratak);
            this.Controls.Add(this.buttonObrisiNarudzbu);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDodajNarudzbu);
            this.Controls.Add(this.buttonPromijeniStatus);
            this.Controls.Add(this.dataGridViewNarudzbe);
            this.Name = "FormNarudzbe";
            this.Text = "Narudžbe";
            this.Load += new System.EventHandler(this.FormNarudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNarudzbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNarudzbe;
        private System.Windows.Forms.Button buttonPromijeniStatus;
        private System.Windows.Forms.Button buttonDodajNarudzbu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonObrisiNarudzbu;
        private System.Windows.Forms.Button buttonPovratak;
        private System.Windows.Forms.Button buttonPrikaziNarudzbu;
    }
}