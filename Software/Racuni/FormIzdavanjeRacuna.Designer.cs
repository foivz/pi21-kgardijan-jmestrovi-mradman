
namespace Funkcionalnost_prijave
{
    partial class FormIzdavanjeRacuna
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBrRacuna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureQRCode = new System.Windows.Forms.PictureBox();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxVrijeme = new System.Windows.Forms.TextBox();
            this.buttonIzdajRacun = new System.Windows.Forms.Button();
            this.comboBoxVrstaPlacanja = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUkupno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEmailGosta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Račun broj:";
            // 
            // textBoxBrRacuna
            // 
            this.textBoxBrRacuna.Location = new System.Drawing.Point(99, 28);
            this.textBoxBrRacuna.Name = "textBoxBrRacuna";
            this.textBoxBrRacuna.ReadOnly = true;
            this.textBoxBrRacuna.Size = new System.Drawing.Size(100, 22);
            this.textBoxBrRacuna.TabIndex = 1;
            this.textBoxBrRacuna.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vrsta plaćanja:";
            // 
            // pictureQRCode
            // 
            this.pictureQRCode.Location = new System.Drawing.Point(55, 289);
            this.pictureQRCode.Name = "pictureQRCode";
            this.pictureQRCode.Size = new System.Drawing.Size(433, 407);
            this.pictureQRCode.TabIndex = 4;
            this.pictureQRCode.TabStop = false;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(413, 720);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 28);
            this.ButtonClose.TabIndex = 5;
            this.ButtonClose.Text = "Zatvori";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vrijeme izdavanja:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 7;
            // 
            // textBoxVrijeme
            // 
            this.textBoxVrijeme.Location = new System.Drawing.Point(400, 28);
            this.textBoxVrijeme.Name = "textBoxVrijeme";
            this.textBoxVrijeme.ReadOnly = true;
            this.textBoxVrijeme.Size = new System.Drawing.Size(105, 22);
            this.textBoxVrijeme.TabIndex = 8;
            // 
            // buttonIzdajRacun
            // 
            this.buttonIzdajRacun.Location = new System.Drawing.Point(164, 243);
            this.buttonIzdajRacun.Name = "buttonIzdajRacun";
            this.buttonIzdajRacun.Size = new System.Drawing.Size(103, 28);
            this.buttonIzdajRacun.TabIndex = 9;
            this.buttonIzdajRacun.Text = "Izdaj račun";
            this.buttonIzdajRacun.UseVisualStyleBackColor = true;
            this.buttonIzdajRacun.Click += new System.EventHandler(this.buttonIzdajRacun_Click);
            // 
            // comboBoxVrstaPlacanja
            // 
            this.comboBoxVrstaPlacanja.FormattingEnabled = true;
            this.comboBoxVrstaPlacanja.Location = new System.Drawing.Point(135, 193);
            this.comboBoxVrstaPlacanja.Name = "comboBoxVrstaPlacanja";
            this.comboBoxVrstaPlacanja.Size = new System.Drawing.Size(121, 24);
            this.comboBoxVrstaPlacanja.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ukupno za platiti:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxUkupno
            // 
            this.textBoxUkupno.Location = new System.Drawing.Point(146, 91);
            this.textBoxUkupno.Name = "textBoxUkupno";
            this.textBoxUkupno.ReadOnly = true;
            this.textBoxUkupno.Size = new System.Drawing.Size(105, 22);
            this.textBoxUkupno.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email gosta:";
            // 
            // textBoxEmailGosta
            // 
            this.textBoxEmailGosta.Location = new System.Drawing.Point(135, 151);
            this.textBoxEmailGosta.Name = "textBoxEmailGosta";
            this.textBoxEmailGosta.Size = new System.Drawing.Size(186, 22);
            this.textBoxEmailGosta.TabIndex = 14;
            // 
            // FormIzdavanjeRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 760);
            this.Controls.Add(this.textBoxEmailGosta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxUkupno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxVrstaPlacanja);
            this.Controls.Add(this.buttonIzdajRacun);
            this.Controls.Add(this.textBoxVrijeme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.pictureQRCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBrRacuna);
            this.Controls.Add(this.label1);
            this.Name = "FormIzdavanjeRacuna";
            this.Text = "Izdavanje računa";
            this.Load += new System.EventHandler(this.FormIzdavanjeRacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBrRacuna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureQRCode;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxVrijeme;
        private System.Windows.Forms.Button buttonIzdajRacun;
        private System.Windows.Forms.ComboBox comboBoxVrstaPlacanja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUkupno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEmailGosta;
    }
}