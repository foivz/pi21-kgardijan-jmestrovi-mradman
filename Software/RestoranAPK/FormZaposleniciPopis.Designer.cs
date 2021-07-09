
namespace Funkcionalnost_prijave
{
    partial class FormZaposleniciPopis
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
            this.dataGridViewPopisZaposlenika = new System.Windows.Forms.DataGridView();
            this.buttonDodajZaposlenika = new System.Windows.Forms.Button();
            this.buttonObrišiZaposlenika = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.buttonUredi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPovratak = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPopisZaposlenika)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPopisZaposlenika
            // 
            this.dataGridViewPopisZaposlenika.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPopisZaposlenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPopisZaposlenika.Location = new System.Drawing.Point(154, 148);
            this.dataGridViewPopisZaposlenika.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPopisZaposlenika.Name = "dataGridViewPopisZaposlenika";
            this.dataGridViewPopisZaposlenika.RowHeadersWidth = 51;
            this.dataGridViewPopisZaposlenika.RowTemplate.Height = 24;
            this.dataGridViewPopisZaposlenika.Size = new System.Drawing.Size(734, 253);
            this.dataGridViewPopisZaposlenika.TabIndex = 0;
            this.dataGridViewPopisZaposlenika.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPopisZaposlenika_CellContentClick);
            this.dataGridViewPopisZaposlenika.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPopisZaposlenika_CellContentDoubleClick);
            // 
            // buttonDodajZaposlenika
            // 
            this.buttonDodajZaposlenika.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajZaposlenika.Location = new System.Drawing.Point(745, 441);
            this.buttonDodajZaposlenika.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDodajZaposlenika.Name = "buttonDodajZaposlenika";
            this.buttonDodajZaposlenika.Size = new System.Drawing.Size(143, 58);
            this.buttonDodajZaposlenika.TabIndex = 1;
            this.buttonDodajZaposlenika.Text = "Dodaj ";
            this.buttonDodajZaposlenika.UseVisualStyleBackColor = true;
            this.buttonDodajZaposlenika.Click += new System.EventHandler(this.buttonDodajZaposlenika_Click);
            // 
            // buttonObrišiZaposlenika
            // 
            this.buttonObrišiZaposlenika.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrišiZaposlenika.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonObrišiZaposlenika.Location = new System.Drawing.Point(364, 441);
            this.buttonObrišiZaposlenika.Margin = new System.Windows.Forms.Padding(4);
            this.buttonObrišiZaposlenika.Name = "buttonObrišiZaposlenika";
            this.buttonObrišiZaposlenika.Size = new System.Drawing.Size(143, 58);
            this.buttonObrišiZaposlenika.TabIndex = 2;
            this.buttonObrišiZaposlenika.Text = "Obriši";
            this.buttonObrišiZaposlenika.UseVisualStyleBackColor = true;
            this.buttonObrišiZaposlenika.Click += new System.EventHandler(this.buttonObrišiZaposlenika_Click);
            // 
            // buttonUredi
            // 
            this.buttonUredi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUredi.Location = new System.Drawing.Point(558, 441);
            this.buttonUredi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUredi.Name = "buttonUredi";
            this.buttonUredi.Size = new System.Drawing.Size(143, 58);
            this.buttonUredi.TabIndex = 5;
            this.buttonUredi.Text = "Uredi";
            this.buttonUredi.UseVisualStyleBackColor = true;
            this.buttonUredi.Click += new System.EventHandler(this.buttonUredi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.labelPovratak);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 100);
            this.panel1.TabIndex = 10;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(238, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 65);
            this.label1.TabIndex = 9;
            this.label1.Text = "POPIS ZAPOSLENIKA";
            // 
            // labelPovratak
            // 
            this.labelPovratak.AutoSize = true;
            this.labelPovratak.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPovratak.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPovratak.Location = new System.Drawing.Point(43, 32);
            this.labelPovratak.Name = "labelPovratak";
            this.labelPovratak.Size = new System.Drawing.Size(39, 41);
            this.labelPovratak.TabIndex = 11;
            this.labelPovratak.Text = "<";
            this.labelPovratak.Click += new System.EventHandler(this.labelPovratak_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Funkcionalnost_prijave.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FormZaposleniciPopis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(933, 530);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonUredi);
            this.Controls.Add(this.buttonObrišiZaposlenika);
            this.Controls.Add(this.buttonDodajZaposlenika);
            this.Controls.Add(this.dataGridViewPopisZaposlenika);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormZaposleniciPopis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis zaposlenika";
            this.Load += new System.EventHandler(this.FormZaposleniciPopis_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormZaposleniciPopis_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPopisZaposlenika)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPopisZaposlenika;
        private System.Windows.Forms.Button buttonDodajZaposlenika;
        private System.Windows.Forms.Button buttonObrišiZaposlenika;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button buttonUredi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPovratak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}