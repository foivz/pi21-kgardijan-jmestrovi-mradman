
namespace Funkcionalnost_prijave
{
    partial class FormSmjeneRada
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewPrva = new System.Windows.Forms.DataGridView();
            this.dataGridViewDruga = new System.Windows.Forms.DataGridView();
            this.buttonPrva = new System.Windows.Forms.Button();
            this.buttonDruga = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPovratak = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDruga)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(200, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prva smjena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(596, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Druga smjena:";
            // 
            // dataGridViewPrva
            // 
            this.dataGridViewPrva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPrva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrva.Location = new System.Drawing.Point(205, 134);
            this.dataGridViewPrva.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPrva.Name = "dataGridViewPrva";
            this.dataGridViewPrva.RowHeadersWidth = 51;
            this.dataGridViewPrva.RowTemplate.Height = 24;
            this.dataGridViewPrva.Size = new System.Drawing.Size(247, 310);
            this.dataGridViewPrva.TabIndex = 2;
            this.dataGridViewPrva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrva_CellContentClick);
            // 
            // dataGridViewDruga
            // 
            this.dataGridViewDruga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDruga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDruga.Location = new System.Drawing.Point(601, 134);
            this.dataGridViewDruga.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDruga.Name = "dataGridViewDruga";
            this.dataGridViewDruga.RowHeadersWidth = 51;
            this.dataGridViewDruga.RowTemplate.Height = 24;
            this.dataGridViewDruga.Size = new System.Drawing.Size(248, 310);
            this.dataGridViewDruga.TabIndex = 3;
            // 
            // buttonPrva
            // 
            this.buttonPrva.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrva.Location = new System.Drawing.Point(205, 452);
            this.buttonPrva.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrva.Name = "buttonPrva";
            this.buttonPrva.Size = new System.Drawing.Size(161, 44);
            this.buttonPrva.TabIndex = 5;
            this.buttonPrva.Text = "Prebaci u drugu";
            this.buttonPrva.UseVisualStyleBackColor = true;
            this.buttonPrva.Click += new System.EventHandler(this.buttonPrva_Click);
            // 
            // buttonDruga
            // 
            this.buttonDruga.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDruga.Location = new System.Drawing.Point(601, 452);
            this.buttonDruga.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDruga.Name = "buttonDruga";
            this.buttonDruga.Size = new System.Drawing.Size(145, 44);
            this.buttonDruga.TabIndex = 6;
            this.buttonDruga.Text = "Prebaci u prvu";
            this.buttonDruga.UseVisualStyleBackColor = true;
            this.buttonDruga.Click += new System.EventHandler(this.buttonDruga_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.labelPovratak);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 100);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(858, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(303, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 65);
            this.label4.TabIndex = 9;
            this.label4.Text = "SMJENE RADA";
            // 
            // labelPovratak
            // 
            this.labelPovratak.AutoSize = true;
            this.labelPovratak.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPovratak.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPovratak.Location = new System.Drawing.Point(32, 32);
            this.labelPovratak.Name = "labelPovratak";
            this.labelPovratak.Size = new System.Drawing.Size(32, 35);
            this.labelPovratak.TabIndex = 11;
            this.labelPovratak.Text = "<";
            this.labelPovratak.Click += new System.EventHandler(this.labelPovratak_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Funkcionalnost_prijave.Properties.Resources.shift;
            this.pictureBox1.Location = new System.Drawing.Point(12, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FormSmjeneRada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(933, 530);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonDruga);
            this.Controls.Add(this.buttonPrva);
            this.Controls.Add(this.dataGridViewDruga);
            this.Controls.Add(this.dataGridViewPrva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSmjeneRada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smjene rada";
            this.Load += new System.EventHandler(this.FormSmjeneRada_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormSmjeneRada_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDruga)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewPrva;
        private System.Windows.Forms.DataGridView dataGridViewDruga;
        private System.Windows.Forms.Button buttonPrva;
        private System.Windows.Forms.Button buttonDruga;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPovratak;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}