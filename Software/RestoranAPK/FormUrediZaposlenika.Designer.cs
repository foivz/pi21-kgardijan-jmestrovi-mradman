
namespace Funkcionalnost_prijave
{
    partial class FormUrediZaposlenika
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
            this.labelIme = new System.Windows.Forms.Label();
            this.labelLoz = new System.Windows.Forms.Label();
            this.labelkorIme = new System.Windows.Forms.Label();
            this.buttonUredi = new System.Windows.Forms.Button();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.textBoxImePrezime = new System.Windows.Forms.TextBox();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.textBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelUrediZap = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelIme.Location = new System.Drawing.Point(52, 230);
            this.labelIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(134, 25);
            this.labelIme.TabIndex = 0;
            this.labelIme.Text = "Ime i prezime:";
            // 
            // labelLoz
            // 
            this.labelLoz.AutoSize = true;
            this.labelLoz.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLoz.Location = new System.Drawing.Point(52, 374);
            this.labelLoz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoz.Name = "labelLoz";
            this.labelLoz.Size = new System.Drawing.Size(82, 25);
            this.labelLoz.TabIndex = 1;
            this.labelLoz.Text = "Lozinka:";
            // 
            // labelkorIme
            // 
            this.labelkorIme.AutoSize = true;
            this.labelkorIme.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelkorIme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelkorIme.Location = new System.Drawing.Point(52, 305);
            this.labelkorIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelkorIme.Name = "labelkorIme";
            this.labelkorIme.Size = new System.Drawing.Size(143, 25);
            this.labelkorIme.TabIndex = 2;
            this.labelkorIme.Text = "Korisničko ime:";
            // 
            // buttonUredi
            // 
            this.buttonUredi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUredi.Location = new System.Drawing.Point(170, 460);
            this.buttonUredi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUredi.Name = "buttonUredi";
            this.buttonUredi.Size = new System.Drawing.Size(99, 38);
            this.buttonUredi.TabIndex = 3;
            this.buttonUredi.Text = "Uredi";
            this.buttonUredi.UseVisualStyleBackColor = true;
            this.buttonUredi.Click += new System.EventHandler(this.buttonUredi_Click);
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOdustani.Location = new System.Drawing.Point(57, 460);
            this.buttonOdustani.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(105, 38);
            this.buttonOdustani.TabIndex = 4;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // textBoxImePrezime
            // 
            this.textBoxImePrezime.Location = new System.Drawing.Point(56, 259);
            this.textBoxImePrezime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxImePrezime.Name = "textBoxImePrezime";
            this.textBoxImePrezime.Size = new System.Drawing.Size(213, 24);
            this.textBoxImePrezime.TabIndex = 5;
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(57, 403);
            this.textBoxLozinka.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(212, 24);
            this.textBoxLozinka.TabIndex = 6;
            // 
            // textBoxKorisnickoIme
            // 
            this.textBoxKorisnickoIme.Location = new System.Drawing.Point(56, 334);
            this.textBoxKorisnickoIme.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKorisnickoIme.Name = "textBoxKorisnickoIme";
            this.textBoxKorisnickoIme.Size = new System.Drawing.Size(213, 24);
            this.textBoxKorisnickoIme.TabIndex = 7;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.panelTop.Controls.Add(this.labelUrediZap);
            this.panelTop.Controls.Add(this.labelClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(351, 100);
            this.panelTop.TabIndex = 9;
            // 
            // labelUrediZap
            // 
            this.labelUrediZap.AutoSize = true;
            this.labelUrediZap.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUrediZap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUrediZap.Location = new System.Drawing.Point(12, 28);
            this.labelUrediZap.Name = "labelUrediZap";
            this.labelUrediZap.Size = new System.Drawing.Size(286, 45);
            this.labelUrediZap.TabIndex = 11;
            this.labelUrediZap.Text = "Uredi zaposlenika";
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelClose.Location = new System.Drawing.Point(312, 36);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(30, 35);
            this.labelClose.TabIndex = 10;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = global::Funkcionalnost_prijave.Properties.Resources.user;
            this.pictureBoxUser.Location = new System.Drawing.Point(73, 129);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(185, 89);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 10;
            this.pictureBoxUser.TabStop = false;
            // 
            // FormUrediZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(351, 530);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.textBoxKorisnickoIme);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.textBoxImePrezime);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonUredi);
            this.Controls.Add(this.labelkorIme);
            this.Controls.Add(this.labelLoz);
            this.Controls.Add(this.labelIme);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUrediZaposlenika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi ";
            this.Load += new System.EventHandler(this.FormUrediZaposlenika_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormUrediZaposlenika_HelpRequested);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelLoz;
        private System.Windows.Forms.Label labelkorIme;
        private System.Windows.Forms.Button buttonUredi;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.TextBox textBoxImePrezime;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.TextBox textBoxKorisnickoIme;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelUrediZap;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.PictureBox pictureBoxUser;
    }
}