
namespace Funkcionalnost_prijave
{
    partial class FormJelovnikZaposlenik
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
            this.dataGridViewJela = new System.Windows.Forms.DataGridView();
            this.comboBoxVrstaJela = new System.Windows.Forms.ComboBox();
            this.labelVrsta = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelBack = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelJelovnik = new System.Windows.Forms.Label();
            this.pictureBoxJelovnik = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJela)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJelovnik)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewJela
            // 
            this.dataGridViewJela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewJela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJela.Location = new System.Drawing.Point(269, 176);
            this.dataGridViewJela.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewJela.Name = "dataGridViewJela";
            this.dataGridViewJela.RowHeadersWidth = 51;
            this.dataGridViewJela.RowTemplate.Height = 24;
            this.dataGridViewJela.Size = new System.Drawing.Size(619, 326);
            this.dataGridViewJela.TabIndex = 1;
            // 
            // comboBoxVrstaJela
            // 
            this.comboBoxVrstaJela.FormattingEnabled = true;
            this.comboBoxVrstaJela.Location = new System.Drawing.Point(340, 142);
            this.comboBoxVrstaJela.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVrstaJela.Name = "comboBoxVrstaJela";
            this.comboBoxVrstaJela.Size = new System.Drawing.Size(143, 26);
            this.comboBoxVrstaJela.TabIndex = 2;
            this.comboBoxVrstaJela.SelectedIndexChanged += new System.EventHandler(this.comboBoxVrstaJela_SelectedIndexChanged);
            // 
            // labelVrsta
            // 
            this.labelVrsta.AutoSize = true;
            this.labelVrsta.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVrsta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelVrsta.Location = new System.Drawing.Point(272, 140);
            this.labelVrsta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVrsta.Name = "labelVrsta";
            this.labelVrsta.Size = new System.Drawing.Size(60, 25);
            this.labelVrsta.TabIndex = 3;
            this.labelVrsta.Text = "Vrsta:";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.panelTop.Controls.Add(this.labelBack);
            this.panelTop.Controls.Add(this.labelClose);
            this.panelTop.Controls.Add(this.labelJelovnik);
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
            this.labelBack.Location = new System.Drawing.Point(46, 32);
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
            this.labelClose.Location = new System.Drawing.Point(858, 32);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(30, 35);
            this.labelClose.TabIndex = 10;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // labelJelovnik
            // 
            this.labelJelovnik.AutoSize = true;
            this.labelJelovnik.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJelovnik.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelJelovnik.Location = new System.Drawing.Point(329, 21);
            this.labelJelovnik.Name = "labelJelovnik";
            this.labelJelovnik.Size = new System.Drawing.Size(241, 65);
            this.labelJelovnik.TabIndex = 9;
            this.labelJelovnik.Text = "JELOVNIK";
            // 
            // pictureBoxJelovnik
            // 
            this.pictureBoxJelovnik.Image = global::Funkcionalnost_prijave.Properties.Resources.menu1;
            this.pictureBoxJelovnik.Location = new System.Drawing.Point(16, 132);
            this.pictureBoxJelovnik.Name = "pictureBoxJelovnik";
            this.pictureBoxJelovnik.Size = new System.Drawing.Size(201, 155);
            this.pictureBoxJelovnik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxJelovnik.TabIndex = 12;
            this.pictureBoxJelovnik.TabStop = false;
            // 
            // FormJelovnikZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(933, 530);
            this.Controls.Add(this.pictureBoxJelovnik);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.labelVrsta);
            this.Controls.Add(this.comboBoxVrstaJela);
            this.Controls.Add(this.dataGridViewJela);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormJelovnikZaposlenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jelovnik";
            this.Load += new System.EventHandler(this.FormJelovnikZaposlenik_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormJelovnikZaposlenik_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJela)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJelovnik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewJela;
        private System.Windows.Forms.ComboBox comboBoxVrstaJela;
        private System.Windows.Forms.Label labelVrsta;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelJelovnik;
        private System.Windows.Forms.PictureBox pictureBoxJelovnik;
    }
}