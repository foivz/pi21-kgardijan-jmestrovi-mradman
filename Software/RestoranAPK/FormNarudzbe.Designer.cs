
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonObrisiNarudzbu = new System.Windows.Forms.Button();
            this.buttonPrikaziNarudzbu = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNarudzbe)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.dataGridViewNarudzbe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNarudzbe_CellContentClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(59, 343);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Odaberi status:";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 100);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(858, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(312, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 65);
            this.label3.TabIndex = 9;
            this.label3.Text = "NARUDŽBE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(16, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 35);
            this.label4.TabIndex = 11;
            this.label4.Text = "<";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Funkcionalnost_prijave.Properties.Resources.tray;
            this.pictureBox1.Location = new System.Drawing.Point(22, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(933, 530);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonPrikaziNarudzbu);
            this.Controls.Add(this.buttonObrisiNarudzbu);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNarudzbe;
        private System.Windows.Forms.Button buttonPromijeniStatus;
        private System.Windows.Forms.Button buttonDodajNarudzbu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonObrisiNarudzbu;
        private System.Windows.Forms.Button buttonPrikaziNarudzbu;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}