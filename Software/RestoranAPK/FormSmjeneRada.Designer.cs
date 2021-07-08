
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
            this.buttonPovratak = new System.Windows.Forms.Button();
            this.buttonPrva = new System.Windows.Forms.Button();
            this.buttonDruga = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDruga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prva smjena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Druga smjena:";
            // 
            // dataGridViewPrva
            // 
            this.dataGridViewPrva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPrva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrva.Location = new System.Drawing.Point(36, 143);
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
            this.dataGridViewDruga.Location = new System.Drawing.Point(482, 143);
            this.dataGridViewDruga.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDruga.Name = "dataGridViewDruga";
            this.dataGridViewDruga.RowHeadersWidth = 51;
            this.dataGridViewDruga.RowTemplate.Height = 24;
            this.dataGridViewDruga.Size = new System.Drawing.Size(238, 310);
            this.dataGridViewDruga.TabIndex = 3;
            // 
            // buttonPovratak
            // 
            this.buttonPovratak.Location = new System.Drawing.Point(36, 31);
            this.buttonPovratak.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPovratak.Name = "buttonPovratak";
            this.buttonPovratak.Size = new System.Drawing.Size(85, 26);
            this.buttonPovratak.TabIndex = 4;
            this.buttonPovratak.Text = "<";
            this.buttonPovratak.UseVisualStyleBackColor = true;
            this.buttonPovratak.Click += new System.EventHandler(this.buttonPovratak_Click);
            // 
            // buttonPrva
            // 
            this.buttonPrva.Location = new System.Drawing.Point(349, 224);
            this.buttonPrva.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrva.Name = "buttonPrva";
            this.buttonPrva.Size = new System.Drawing.Size(85, 26);
            this.buttonPrva.TabIndex = 5;
            this.buttonPrva.Text = ">>";
            this.buttonPrva.UseVisualStyleBackColor = true;
            this.buttonPrva.Click += new System.EventHandler(this.buttonPrva_Click);
            // 
            // buttonDruga
            // 
            this.buttonDruga.Location = new System.Drawing.Point(349, 289);
            this.buttonDruga.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDruga.Name = "buttonDruga";
            this.buttonDruga.Size = new System.Drawing.Size(85, 26);
            this.buttonDruga.TabIndex = 6;
            this.buttonDruga.Text = "<<";
            this.buttonDruga.UseVisualStyleBackColor = true;
            this.buttonDruga.Click += new System.EventHandler(this.buttonDruga_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "";
            // 
            // FormSmjeneRada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 496);
            this.Controls.Add(this.buttonDruga);
            this.Controls.Add(this.buttonPrva);
            this.Controls.Add(this.buttonPovratak);
            this.Controls.Add(this.dataGridViewDruga);
            this.Controls.Add(this.dataGridViewPrva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSmjeneRada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smjene rada";
            this.Load += new System.EventHandler(this.FormSmjeneRada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDruga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewPrva;
        private System.Windows.Forms.DataGridView dataGridViewDruga;
        private System.Windows.Forms.Button buttonPovratak;
        private System.Windows.Forms.Button buttonPrva;
        private System.Windows.Forms.Button buttonDruga;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}