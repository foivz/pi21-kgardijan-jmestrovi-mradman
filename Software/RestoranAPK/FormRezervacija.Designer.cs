
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
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonObriši = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelBack = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelRezervacije = new System.Windows.Forms.Label();
            this.pictureBoxRezervacije = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervacije)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRezervacije
            // 
            this.dataGridViewRezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezervacije.Location = new System.Drawing.Point(159, 127);
            this.dataGridViewRezervacije.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dataGridViewRezervacije.Name = "dataGridViewRezervacije";
            this.dataGridViewRezervacije.RowHeadersWidth = 51;
            this.dataGridViewRezervacije.RowTemplate.Height = 24;
            this.dataGridViewRezervacije.Size = new System.Drawing.Size(756, 314);
            this.dataGridViewRezervacije.TabIndex = 0;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(785, 465);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(130, 69);
            this.buttonDodaj.TabIndex = 2;
            this.buttonDodaj.Text = "Dodaj rezervaciju";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObriši
            // 
            this.buttonObriši.Location = new System.Drawing.Point(636, 465);
            this.buttonObriši.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonObriši.Name = "buttonObriši";
            this.buttonObriši.Size = new System.Drawing.Size(130, 69);
            this.buttonObriši.TabIndex = 3;
            this.buttonObriši.Text = "Obriši";
            this.buttonObriši.UseVisualStyleBackColor = true;
            this.buttonObriši.Click += new System.EventHandler(this.buttonObriši_Click);
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
            this.panelTop.Controls.Add(this.labelRezervacije);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(951, 100);
            this.panelTop.TabIndex = 10;
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelBack.Location = new System.Drawing.Point(31, 33);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(32, 35);
            this.labelBack.TabIndex = 12;
            this.labelBack.Text = "<";
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelClose.Location = new System.Drawing.Point(862, 33);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(30, 35);
            this.labelClose.TabIndex = 11;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // labelRezervacije
            // 
            this.labelRezervacije.AutoSize = true;
            this.labelRezervacije.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRezervacije.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRezervacije.Location = new System.Drawing.Point(341, 23);
            this.labelRezervacije.Name = "labelRezervacije";
            this.labelRezervacije.Size = new System.Drawing.Size(274, 65);
            this.labelRezervacije.TabIndex = 10;
            this.labelRezervacije.Text = "Rezervacije";
            // 
            // pictureBoxRezervacije
            // 
            this.pictureBoxRezervacije.Image = global::Funkcionalnost_prijave.Properties.Resources.reservation;
            this.pictureBoxRezervacije.Location = new System.Drawing.Point(12, 127);
            this.pictureBoxRezervacije.Name = "pictureBoxRezervacije";
            this.pictureBoxRezervacije.Size = new System.Drawing.Size(140, 126);
            this.pictureBoxRezervacije.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRezervacije.TabIndex = 11;
            this.pictureBoxRezervacije.TabStop = false;
            // 
            // FormRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.pictureBoxRezervacije);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.buttonObriši);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.dataGridViewRezervacije);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormRezervacija";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervacije";
            this.Load += new System.EventHandler(this.FormRezervacija_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormRezervacija_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervacije)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRezervacije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRezervacije;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonObriši;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelRezervacije;
        private System.Windows.Forms.PictureBox pictureBoxRezervacije;
    }
}