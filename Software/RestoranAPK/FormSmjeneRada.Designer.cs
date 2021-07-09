
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
            this.labelPrva = new System.Windows.Forms.Label();
            this.labelDruga = new System.Windows.Forms.Label();
            this.dataGridViewPrva = new System.Windows.Forms.DataGridView();
            this.dataGridViewDruga = new System.Windows.Forms.DataGridView();
            this.buttonPrva = new System.Windows.Forms.Button();
            this.buttonDruga = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelPovratak = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelSmjene = new System.Windows.Forms.Label();
            this.pictureBoxSmjene = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDruga)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmjene)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrva
            // 
            this.labelPrva.AutoSize = true;
            this.labelPrva.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrva.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPrva.Location = new System.Drawing.Point(200, 103);
            this.labelPrva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrva.Name = "labelPrva";
            this.labelPrva.Size = new System.Drawing.Size(122, 25);
            this.labelPrva.TabIndex = 0;
            this.labelPrva.Text = "Prva smjena:";
            // 
            // labelDruga
            // 
            this.labelDruga.AutoSize = true;
            this.labelDruga.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDruga.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDruga.Location = new System.Drawing.Point(596, 103);
            this.labelDruga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDruga.Name = "labelDruga";
            this.labelDruga.Size = new System.Drawing.Size(136, 25);
            this.labelDruga.TabIndex = 1;
            this.labelDruga.Text = "Druga smjena:";
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
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.panelTop.Controls.Add(this.labelPovratak);
            this.panelTop.Controls.Add(this.labelClose);
            this.panelTop.Controls.Add(this.labelSmjene);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(933, 100);
            this.panelTop.TabIndex = 10;
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
            // labelSmjene
            // 
            this.labelSmjene.AutoSize = true;
            this.labelSmjene.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSmjene.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSmjene.Location = new System.Drawing.Point(303, 26);
            this.labelSmjene.Name = "labelSmjene";
            this.labelSmjene.Size = new System.Drawing.Size(344, 65);
            this.labelSmjene.TabIndex = 9;
            this.labelSmjene.Text = "SMJENE RADA";
            // 
            // pictureBoxSmjene
            // 
            this.pictureBoxSmjene.Image = global::Funkcionalnost_prijave.Properties.Resources.shift;
            this.pictureBoxSmjene.Location = new System.Drawing.Point(12, 134);
            this.pictureBoxSmjene.Name = "pictureBoxSmjene";
            this.pictureBoxSmjene.Size = new System.Drawing.Size(156, 150);
            this.pictureBoxSmjene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSmjene.TabIndex = 11;
            this.pictureBoxSmjene.TabStop = false;
            // 
            // FormSmjeneRada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(933, 530);
            this.Controls.Add(this.pictureBoxSmjene);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.buttonDruga);
            this.Controls.Add(this.buttonPrva);
            this.Controls.Add(this.dataGridViewDruga);
            this.Controls.Add(this.dataGridViewPrva);
            this.Controls.Add(this.labelDruga);
            this.Controls.Add(this.labelPrva);
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
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmjene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrva;
        private System.Windows.Forms.Label labelDruga;
        private System.Windows.Forms.DataGridView dataGridViewPrva;
        private System.Windows.Forms.DataGridView dataGridViewDruga;
        private System.Windows.Forms.Button buttonPrva;
        private System.Windows.Forms.Button buttonDruga;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelSmjene;
        private System.Windows.Forms.Label labelPovratak;
        private System.Windows.Forms.PictureBox pictureBoxSmjene;
    }
}