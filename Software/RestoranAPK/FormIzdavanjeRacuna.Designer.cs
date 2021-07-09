
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
            this.labelRacun = new System.Windows.Forms.Label();
            this.textBoxBrRacuna = new System.Windows.Forms.TextBox();
            this.labelVrstePlacanja = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.labelVrijeme = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxVrijeme = new System.Windows.Forms.TextBox();
            this.buttonIzdajRacun = new System.Windows.Forms.Button();
            this.comboBoxVrstaPlacanja = new System.Windows.Forms.ComboBox();
            this.labelUkupno = new System.Windows.Forms.Label();
            this.textBoxUkupno = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmailGosta = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelIzdavanje = new System.Windows.Forms.Label();
            this.pictureBoxRacun = new System.Windows.Forms.PictureBox();
            this.pictureQRCode = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRacun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRacun
            // 
            this.labelRacun.AutoSize = true;
            this.labelRacun.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRacun.Location = new System.Drawing.Point(666, 194);
            this.labelRacun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRacun.Name = "labelRacun";
            this.labelRacun.Size = new System.Drawing.Size(109, 25);
            this.labelRacun.TabIndex = 0;
            this.labelRacun.Text = "Račun broj:";
            // 
            // textBoxBrRacuna
            // 
            this.textBoxBrRacuna.Location = new System.Drawing.Point(783, 194);
            this.textBoxBrRacuna.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxBrRacuna.Name = "textBoxBrRacuna";
            this.textBoxBrRacuna.ReadOnly = true;
            this.textBoxBrRacuna.Size = new System.Drawing.Size(171, 31);
            this.textBoxBrRacuna.TabIndex = 1;
            // 
            // labelVrstePlacanja
            // 
            this.labelVrstePlacanja.AutoSize = true;
            this.labelVrstePlacanja.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelVrstePlacanja.Location = new System.Drawing.Point(29, 333);
            this.labelVrstePlacanja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVrstePlacanja.Name = "labelVrstePlacanja";
            this.labelVrstePlacanja.Size = new System.Drawing.Size(136, 25);
            this.labelVrstePlacanja.TabIndex = 2;
            this.labelVrstePlacanja.Text = "Vrsta plaćanja:";
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
            // labelVrijeme
            // 
            this.labelVrijeme.AutoSize = true;
            this.labelVrijeme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelVrijeme.Location = new System.Drawing.Point(607, 142);
            this.labelVrijeme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVrijeme.Name = "labelVrijeme";
            this.labelVrijeme.Size = new System.Drawing.Size(168, 25);
            this.labelVrijeme.TabIndex = 6;
            this.labelVrijeme.Text = "Vrijeme izdavanja:";
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
            // 
            // labelUkupno
            // 
            this.labelUkupno.AutoSize = true;
            this.labelUkupno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUkupno.Location = new System.Drawing.Point(612, 258);
            this.labelUkupno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUkupno.Name = "labelUkupno";
            this.labelUkupno.Size = new System.Drawing.Size(163, 25);
            this.labelUkupno.TabIndex = 11;
            this.labelUkupno.Text = "Ukupno za platiti:";
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
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEmail.Location = new System.Drawing.Point(49, 289);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(116, 25);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "Email gosta:";
            // 
            // textBoxEmailGosta
            // 
            this.textBoxEmailGosta.Location = new System.Drawing.Point(173, 286);
            this.textBoxEmailGosta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxEmailGosta.Name = "textBoxEmailGosta";
            this.textBoxEmailGosta.Size = new System.Drawing.Size(232, 31);
            this.textBoxEmailGosta.TabIndex = 14;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.panelTop.Controls.Add(this.labelClose);
            this.panelTop.Controls.Add(this.labelIzdavanje);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(977, 100);
            this.panelTop.TabIndex = 15;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelClose.Location = new System.Drawing.Point(908, 32);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(30, 35);
            this.labelClose.TabIndex = 10;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // labelIzdavanje
            // 
            this.labelIzdavanje.AutoSize = true;
            this.labelIzdavanje.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIzdavanje.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelIzdavanje.Location = new System.Drawing.Point(238, 21);
            this.labelIzdavanje.Name = "labelIzdavanje";
            this.labelIzdavanje.Size = new System.Drawing.Size(480, 65);
            this.labelIzdavanje.TabIndex = 9;
            this.labelIzdavanje.Text = "IZDAVANJE RAČUNA";
            // 
            // pictureBoxRacun
            // 
            this.pictureBoxRacun.Image = global::Funkcionalnost_prijave.Properties.Resources.invoice;
            this.pictureBoxRacun.Location = new System.Drawing.Point(26, 119);
            this.pictureBoxRacun.Name = "pictureBoxRacun";
            this.pictureBoxRacun.Size = new System.Drawing.Size(144, 124);
            this.pictureBoxRacun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRacun.TabIndex = 16;
            this.pictureBoxRacun.TabStop = false;
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
            this.Controls.Add(this.pictureBoxRacun);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.textBoxEmailGosta);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxUkupno);
            this.Controls.Add(this.labelUkupno);
            this.Controls.Add(this.comboBoxVrstaPlacanja);
            this.Controls.Add(this.buttonIzdajRacun);
            this.Controls.Add(this.textBoxVrijeme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelVrijeme);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.pictureQRCode);
            this.Controls.Add(this.labelVrstePlacanja);
            this.Controls.Add(this.textBoxBrRacuna);
            this.Controls.Add(this.labelRacun);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormIzdavanjeRacuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izdavanje računa";
            this.Load += new System.EventHandler(this.FormIzdavanjeRacuna_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormIzdavanjeRacuna_HelpRequested);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRacun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRacun;
        private System.Windows.Forms.TextBox textBoxBrRacuna;
        private System.Windows.Forms.Label labelVrstePlacanja;
        private System.Windows.Forms.PictureBox pictureQRCode;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label labelVrijeme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxVrijeme;
        private System.Windows.Forms.Button buttonIzdajRacun;
        private System.Windows.Forms.ComboBox comboBoxVrstaPlacanja;
        private System.Windows.Forms.Label labelUkupno;
        private System.Windows.Forms.TextBox textBoxUkupno;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmailGosta;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelIzdavanje;
        private System.Windows.Forms.PictureBox pictureBoxRacun;
    }
}