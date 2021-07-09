
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestorani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.panel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonOdjava);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 100);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(864, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(301, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 65);
            this.label1.TabIndex = 8;
            this.label1.Text = "NASLOVNICA";
            // 
            // FormPrijavljenSuperadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(933, 530);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}