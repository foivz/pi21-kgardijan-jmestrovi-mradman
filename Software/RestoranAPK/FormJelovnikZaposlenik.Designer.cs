
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
            this.buttonPovratak = new System.Windows.Forms.Button();
            this.dataGridViewJela = new System.Windows.Forms.DataGridView();
            this.comboBoxVrstaJela = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJela)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPovratak
            // 
            this.buttonPovratak.Location = new System.Drawing.Point(13, 26);
            this.buttonPovratak.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPovratak.Name = "buttonPovratak";
            this.buttonPovratak.Size = new System.Drawing.Size(85, 26);
            this.buttonPovratak.TabIndex = 0;
            this.buttonPovratak.Text = "<";
            this.buttonPovratak.UseVisualStyleBackColor = true;
            this.buttonPovratak.Click += new System.EventHandler(this.buttonPovratak_Click);
            // 
            // dataGridViewJela
            // 
            this.dataGridViewJela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewJela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJela.Location = new System.Drawing.Point(32, 136);
            this.dataGridViewJela.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewJela.Name = "dataGridViewJela";
            this.dataGridViewJela.RowHeadersWidth = 51;
            this.dataGridViewJela.RowTemplate.Height = 24;
            this.dataGridViewJela.Size = new System.Drawing.Size(548, 314);
            this.dataGridViewJela.TabIndex = 1;
            // 
            // comboBoxVrstaJela
            // 
            this.comboBoxVrstaJela.FormattingEnabled = true;
            this.comboBoxVrstaJela.Location = new System.Drawing.Point(85, 89);
            this.comboBoxVrstaJela.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVrstaJela.Name = "comboBoxVrstaJela";
            this.comboBoxVrstaJela.Size = new System.Drawing.Size(135, 26);
            this.comboBoxVrstaJela.TabIndex = 2;
            this.comboBoxVrstaJela.SelectedIndexChanged += new System.EventHandler(this.comboBoxVrstaJela_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vrsta:";
            // 
            // FormJelovnikZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxVrstaJela);
            this.Controls.Add(this.dataGridViewJela);
            this.Controls.Add(this.buttonPovratak);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormJelovnikZaposlenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jelovnik";
            this.Load += new System.EventHandler(this.FormJelovnikZaposlenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPovratak;
        private System.Windows.Forms.DataGridView dataGridViewJela;
        private System.Windows.Forms.ComboBox comboBoxVrstaJela;
        private System.Windows.Forms.Label label1;
    }
}