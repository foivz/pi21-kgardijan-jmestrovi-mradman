
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
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureQRCode = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Račun broj:";
            // 
            // textBoxBrRacuna
            // 
            this.textBoxBrRacuna.Location = new System.Drawing.Point(783, 194);
            this.textBoxBrRacuna.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxBrRacuna.Name = "textBoxBrRacuna";
            this.textBoxBrRacuna.ReadOnly = true;
            this.textBoxBrRacuna.Size = new System.Drawing.Size(171, 31);
            this.textBoxBrRacuna.TabIndex = 1;
            this.textBoxBrRacuna.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 333);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vrsta plaćanja:";
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(860, 702);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(94, 43);
            this.ButtonClose.TabIndex = 5;
            this.ButtonClose.Text = "Zatvori";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vrijeme izdavanja:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 364);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 7;
            // 
            // textBoxVrijeme
            // 
            this.textBoxVrijeme.Location = new System.Drawing.Point(783, 139);
            this.textBoxVrijeme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxVrijeme.Name = "textBoxVrijeme";
            this.textBoxVrijeme.ReadOnly = true;
            this.textBoxVrijeme.Size = new System.Drawing.Size(171, 31);
            this.textBoxVrijeme.TabIndex = 8;
            // 
            // buttonIzdajRacun
            // 
            this.buttonIzdajRacun.Location = new System.Drawing.Point(276, 397);
            this.buttonIzdajRacun.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonIzdajRacun.Name = "buttonIzdajRacun";
            this.buttonIzdajRacun.Size = new System.Drawing.Size(129, 43);
            this.buttonIzdajRacun.TabIndex = 9;
            this.buttonIzdajRacun.Text = "Izdaj račun";
            this.buttonIzdajRacun.UseVisualStyleBackColor = true;
            this.buttonIzdajRacun.Click += new System.EventHandler(this.buttonIzdajRacun_Click);
            // 
            // comboBoxVrstaPlacanja
            // 
            this.comboBoxVrstaPlacanja.FormattingEnabled = true;
            this.comboBoxVrstaPlacanja.Location = new System.Drawing.Point(173, 333);
            this.comboBoxVrstaPlacanja.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.comboBoxVrstaPlacanja.Name = "comboBoxVrstaPlacanja";
            this.comboBoxVrstaPlacanja.Size = new System.Drawing.Size(232, 33);
            this.comboBoxVrstaPlacanja.TabIndex = 10;
            this.comboBoxVrstaPlacanja.SelectedIndexChanged += new System.EventHandler(this.comboBoxVrstaPlacanja_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(612, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ukupno za platiti:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxUkupno
            // 
            this.textBoxUkupno.Location = new System.Drawing.Point(783, 258);
            this.textBoxUkupno.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxUkupno.Name = "textBoxUkupno";
            this.textBoxUkupno.ReadOnly = true;
            this.textBoxUkupno.Size = new System.Drawing.Size(171, 31);
            this.textBoxUkupno.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 289);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email gosta:";
            // 
            // textBoxEmailGosta
            // 
            this.textBoxEmailGosta.Location = new System.Drawing.Point(173, 286);
            this.textBoxEmailGosta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxEmailGosta.Name = "textBoxEmailGosta";
            this.textBoxEmailGosta.Size = new System.Drawing.Size(232, 31);
            this.textBoxEmailGosta.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 100);
            this.panel1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(908, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 35);
            this.label8.TabIndex = 10;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(239, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(480, 65);
            this.label9.TabIndex = 9;
            this.label9.Text = "IZDAVANJE RAČUNA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Funkcionalnost_prijave.Properties.Resources.invoice;
            this.pictureBox1.Location = new System.Drawing.Point(26, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureQRCode
            // 
            this.pictureQRCode.Location = new System.Drawing.Point(460, 336);
            this.pictureQRCode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pictureQRCode.Name = "pictureQRCode";
            this.pictureQRCode.Size = new System.Drawing.Size(404, 317);
            this.pictureQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureQRCode.TabIndex = 4;
            this.pictureQRCode.TabStop = false;
            // 
            // FormIzdavanjeRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(977, 757);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
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
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormIzdavanjeRacuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izdavanje računa";
            this.Load += new System.EventHandler(this.FormIzdavanjeRacuna_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormIzdavanjeRacuna_HelpRequested);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}