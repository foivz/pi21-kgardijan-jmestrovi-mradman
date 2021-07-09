
namespace Funkcionalnost_prijave
{
    partial class FormPrijavljenSuperadmin
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
            this.dataGridViewRestorani = new System.Windows.Forms.DataGridView();
            this.buttonDodajRestoran = new System.Windows.Forms.Button();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.buttonDodajAdmina = new System.Windows.Forms.Button();
            this.buttonObrisiAdmina = new System.Windows.Forms.Button();
            this.buttonObrisiRestoran = new System.Windows.Forms.Button();
            this.buttonOdjava = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelNaslovnica = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestorani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRestorani
            // 
            this.dataGridViewRestorani.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRestorani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRestorani.Location = new System.Drawing.Point(33, 143);
            this.dataGridViewRestorani.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewRestorani.Name = "dataGridViewRestorani";
            this.dataGridViewRestorani.RowHeadersWidth = 51;
            this.dataGridViewRestorani.RowTemplate.Height = 24;
            this.dataGridViewRestorani.Size = new System.Drawing.Size(312, 270);
            this.dataGridViewRestorani.TabIndex = 0;
            this.dataGridViewRestorani.SelectionChanged += new System.EventHandler(this.dataGridViewRestorani_SelectionChanged);
            // 
            // buttonDodajRestoran
            // 
            this.buttonDodajRestoran.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajRestoran.Location = new System.Drawing.Point(201, 421);
            this.buttonDodajRestoran.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDodajRestoran.Name = "buttonDodajRestoran";
            this.buttonDodajRestoran.Size = new System.Drawing.Size(144, 65);
            this.buttonDodajRestoran.TabIndex = 1;
            this.buttonDodajRestoran.Text = "Dodaj restoran";
            this.buttonDodajRestoran.UseVisualStyleBackColor = true;
            this.buttonDodajRestoran.Click += new System.EventHandler(this.buttonDodajRestoran_Click);
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(558, 143);
            this.dataGridViewAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.RowHeadersWidth = 51;
            this.dataGridViewAdmin.RowTemplate.Height = 24;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(312, 270);
            this.dataGridViewAdmin.TabIndex = 3;
            // 
            // buttonDodajAdmina
            // 
            this.buttonDodajAdmina.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajAdmina.Location = new System.Drawing.Point(736, 421);
            this.buttonDodajAdmina.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDodajAdmina.Name = "buttonDodajAdmina";
            this.buttonDodajAdmina.Size = new System.Drawing.Size(134, 65);
            this.buttonDodajAdmina.TabIndex = 4;
            this.buttonDodajAdmina.Text = "Dodaj admina";
            this.buttonDodajAdmina.UseVisualStyleBackColor = true;
            this.buttonDodajAdmina.Click += new System.EventHandler(this.buttonDodajAdmina_Click);
            // 
            // buttonObrisiAdmina
            // 
            this.buttonObrisiAdmina.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisiAdmina.Location = new System.Drawing.Point(558, 421);
            this.buttonObrisiAdmina.Margin = new System.Windows.Forms.Padding(4);
            this.buttonObrisiAdmina.Name = "buttonObrisiAdmina";
            this.buttonObrisiAdmina.Size = new System.Drawing.Size(134, 65);
            this.buttonObrisiAdmina.TabIndex = 5;
            this.buttonObrisiAdmina.Text = "Obriši admina";
            this.buttonObrisiAdmina.UseVisualStyleBackColor = true;
            this.buttonObrisiAdmina.Click += new System.EventHandler(this.buttonObrisiAdmina_Click);
            // 
            // buttonObrisiRestoran
            // 
            this.buttonObrisiRestoran.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisiRestoran.Location = new System.Drawing.Point(33, 421);
            this.buttonObrisiRestoran.Margin = new System.Windows.Forms.Padding(4);
            this.buttonObrisiRestoran.Name = "buttonObrisiRestoran";
            this.buttonObrisiRestoran.Size = new System.Drawing.Size(144, 65);
            this.buttonObrisiRestoran.TabIndex = 6;
            this.buttonObrisiRestoran.Text = "Obriši  restoran";
            this.buttonObrisiRestoran.UseVisualStyleBackColor = true;
            this.buttonObrisiRestoran.Click += new System.EventHandler(this.buttonObrisiRestoran_Click);
            // 
            // buttonOdjava
            // 
            this.buttonOdjava.Location = new System.Drawing.Point(44, 36);
            this.buttonOdjava.Name = "buttonOdjava";
            this.buttonOdjava.Size = new System.Drawing.Size(75, 32);
            this.buttonOdjava.TabIndex = 7;
            this.buttonOdjava.Text = "Odjava";
            this.buttonOdjava.UseVisualStyleBackColor = true;
            this.buttonOdjava.Click += new System.EventHandler(this.buttonOdjava_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.panelTop.Controls.Add(this.labelClose);
            this.panelTop.Controls.Add(this.labelNaslovnica);
            this.panelTop.Controls.Add(this.buttonOdjava);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(933, 100);
            this.panelTop.TabIndex = 8;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelClose.Location = new System.Drawing.Point(864, 33);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(30, 35);
            this.labelClose.TabIndex = 9;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // labelNaslovnica
            // 
            this.labelNaslovnica.AutoSize = true;
            this.labelNaslovnica.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaslovnica.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNaslovnica.Location = new System.Drawing.Point(301, 17);
            this.labelNaslovnica.Name = "labelNaslovnica";
            this.labelNaslovnica.Size = new System.Drawing.Size(325, 65);
            this.labelNaslovnica.TabIndex = 8;
            this.labelNaslovnica.Text = "NASLOVNICA";
            // 
            // FormPrijavljenSuperadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(933, 530);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.buttonObrisiRestoran);
            this.Controls.Add(this.buttonObrisiAdmina);
            this.Controls.Add(this.buttonDodajAdmina);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Controls.Add(this.buttonDodajRestoran);
            this.Controls.Add(this.dataGridViewRestorani);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrijavljenSuperadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naslovnica";
            this.Load += new System.EventHandler(this.FormPrijavljenSuperadmin_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormPrijavljenSuperadmin_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestorani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRestorani;
        private System.Windows.Forms.Button buttonDodajRestoran;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.Button buttonDodajAdmina;
        private System.Windows.Forms.Button buttonObrisiAdmina;
        private System.Windows.Forms.Button buttonObrisiRestoran;
        private System.Windows.Forms.Button buttonOdjava;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelNaslovnica;
    }
}