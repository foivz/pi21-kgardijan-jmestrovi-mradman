
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
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonObrisiNarudzbu = new System.Windows.Forms.Button();
            this.buttonPrikaziNarudzbu = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelBack = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelNarudzbe = new System.Windows.Forms.Label();
            this.pictureBoxNarudzbe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNarudzbe)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNarudzbe
            // 
            this.dataGridViewNarudzbe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNarudzbe.Location = new System.Drawing.Point(251, 146);
            this.dataGridViewNarudzbe.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewNarudzbe.Name = "dataGridViewNarudzbe";
            this.dataGridViewNarudzbe.RowHeadersWidth = 51;
            this.dataGridViewNarudzbe.RowTemplate.Height = 24;
            this.dataGridViewNarudzbe.Size = new System.Drawing.Size(619, 265);
            this.dataGridViewNarudzbe.TabIndex = 0;
            // 
            // buttonPromijeniStatus
            // 
            this.buttonPromijeniStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromijeniStatus.Location = new System.Drawing.Point(75, 434);
            this.buttonPromijeniStatus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPromijeniStatus.Name = "buttonPromijeniStatus";
            this.buttonPromijeniStatus.Size = new System.Drawing.Size(113, 60);
            this.buttonPromijeniStatus.TabIndex = 3;
            this.buttonPromijeniStatus.Text = "Promjeni status";
            this.buttonPromijeniStatus.UseVisualStyleBackColor = true;
            this.buttonPromijeniStatus.Click += new System.EventHandler(this.buttonPromijeniStatus_Click);
            // 
            // buttonDodajNarudzbu
            // 
            this.buttonDodajNarudzbu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajNarudzbu.Location = new System.Drawing.Point(630, 434);
            this.buttonDodajNarudzbu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDodajNarudzbu.Name = "buttonDodajNarudzbu";
            this.buttonDodajNarudzbu.Size = new System.Drawing.Size(113, 60);
            this.buttonDodajNarudzbu.TabIndex = 5;
            this.buttonDodajNarudzbu.Text = "Dodaj narudžbu";
            this.buttonDodajNarudzbu.UseVisualStyleBackColor = true;
            this.buttonDodajNarudzbu.Click += new System.EventHandler(this.buttonDodajNarudzbu_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelStatus.Location = new System.Drawing.Point(59, 343);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(141, 25);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Odaberi status:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(57, 377);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(143, 26);
            this.comboBoxStatus.TabIndex = 7;
            // 
            // buttonObrisiNarudzbu
            // 
            this.buttonObrisiNarudzbu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisiNarudzbu.Location = new System.Drawing.Point(491, 434);
            this.buttonObrisiNarudzbu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonObrisiNarudzbu.Name = "buttonObrisiNarudzbu";
            this.buttonObrisiNarudzbu.Size = new System.Drawing.Size(113, 60);
            this.buttonObrisiNarudzbu.TabIndex = 8;
            this.buttonObrisiNarudzbu.Text = "Obriši narudžbu";
            this.buttonObrisiNarudzbu.UseVisualStyleBackColor = true;
            this.buttonObrisiNarudzbu.Click += new System.EventHandler(this.buttonObrisiNarudzbu_Click);
            // 
            // buttonPrikaziNarudzbu
            // 
            this.buttonPrikaziNarudzbu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrikaziNarudzbu.Location = new System.Drawing.Point(764, 434);
            this.buttonPrikaziNarudzbu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrikaziNarudzbu.Name = "buttonPrikaziNarudzbu";
            this.buttonPrikaziNarudzbu.Size = new System.Drawing.Size(113, 60);
            this.buttonPrikaziNarudzbu.TabIndex = 10;
            this.buttonPrikaziNarudzbu.Text = "Prikaži narudžbu";
            this.buttonPrikaziNarudzbu.UseVisualStyleBackColor = true;
            this.buttonPrikaziNarudzbu.Click += new System.EventHandler(this.buttonPrikaziNarudzbu_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.panelTop.Controls.Add(this.labelBack);
            this.panelTop.Controls.Add(this.labelClose);
            this.panelTop.Controls.Add(this.labelNarudzbe);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(933, 100);
            this.panelTop.TabIndex = 11;
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelBack.Location = new System.Drawing.Point(16, 32);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(32, 35);
            this.labelBack.TabIndex = 11;
            this.labelBack.Text = "<";
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelClose.Location = new System.Drawing.Point(891, 9);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(30, 35);
            this.labelClose.TabIndex = 10;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // labelNarudzbe
            // 
            this.labelNarudzbe.AutoSize = true;
            this.labelNarudzbe.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNarudzbe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNarudzbe.Location = new System.Drawing.Point(312, 23);
            this.labelNarudzbe.Name = "labelNarudzbe";
            this.labelNarudzbe.Size = new System.Drawing.Size(276, 65);
            this.labelNarudzbe.TabIndex = 9;
            this.labelNarudzbe.Text = "NARUDŽBE";
            // 
            // pictureBoxNarudzbe
            // 
            this.pictureBoxNarudzbe.Image = global::Funkcionalnost_prijave.Properties.Resources.tray;
            this.pictureBoxNarudzbe.Location = new System.Drawing.Point(22, 137);
            this.pictureBoxNarudzbe.Name = "pictureBoxNarudzbe";
            this.pictureBoxNarudzbe.Size = new System.Drawing.Size(217, 160);
            this.pictureBoxNarudzbe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNarudzbe.TabIndex = 12;
            this.pictureBoxNarudzbe.TabStop = false;
            // 
            // FormNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(933, 530);
            this.Controls.Add(this.pictureBoxNarudzbe);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.buttonPrikaziNarudzbu);
            this.Controls.Add(this.buttonObrisiNarudzbu);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonDodajNarudzbu);
            this.Controls.Add(this.buttonPromijeniStatus);
            this.Controls.Add(this.dataGridViewNarudzbe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNarudzbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Narudžbe";
            this.Load += new System.EventHandler(this.FormNarudzbe_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormNarudzbe_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNarudzbe)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNarudzbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNarudzbe;
        private System.Windows.Forms.Button buttonPromijeniStatus;
        private System.Windows.Forms.Button buttonDodajNarudzbu;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonObrisiNarudzbu;
        private System.Windows.Forms.Button buttonPrikaziNarudzbu;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelNarudzbe;
        private System.Windows.Forms.PictureBox pictureBoxNarudzbe;
    }
}