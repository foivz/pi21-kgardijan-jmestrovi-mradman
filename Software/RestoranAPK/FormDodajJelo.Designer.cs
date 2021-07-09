
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxVrstaJela = new System.Windows.Forms.ComboBox();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.richTextBoxOpis = new System.Windows.Forms.RichTextBox();
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.buttonDodaj.Click += new System.EventHandler(this.button1_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 243);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 519);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vrsta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 476);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cijena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Opis:";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 100);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(74, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 45);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dodaj stavku";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(349, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 35);
            this.label6.TabIndex = 10;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Funkcionalnost_prijave.Properties.Resources.cooking;
            this.pictureBox1.Location = new System.Drawing.Point(105, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FormDodajJelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(408, 648);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxCijena);
            this.Controls.Add(this.richTextBoxOpis);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.comboBoxVrstaJela);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxVrstaJela;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.RichTextBox richTextBoxOpis;
        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}