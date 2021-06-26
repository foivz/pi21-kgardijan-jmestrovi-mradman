
namespace Funkcionalnost_prijave
{
    partial class FormPrikaziNarudzbu
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBrNarudzbe = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxBrStola = new System.Windows.Forms.TextBox();
            this.dataGridViewNarudzba = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUkupno = new System.Windows.Forms.TextBox();
            this.buttonIzdajRacun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNarudzba)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Br. narudžbe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Br. stola:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status:";
            // 
            // textBoxBrNarudzbe
            // 
            this.textBoxBrNarudzbe.Location = new System.Drawing.Point(114, 33);
            this.textBoxBrNarudzbe.Name = "textBoxBrNarudzbe";
            this.textBoxBrNarudzbe.ReadOnly = true;
            this.textBoxBrNarudzbe.Size = new System.Drawing.Size(100, 22);
            this.textBoxBrNarudzbe.TabIndex = 4;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(114, 76);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(100, 22);
            this.textBoxStatus.TabIndex = 5;
            // 
            // textBoxBrStola
            // 
            this.textBoxBrStola.Location = new System.Drawing.Point(114, 120);
            this.textBoxBrStola.Name = "textBoxBrStola";
            this.textBoxBrStola.ReadOnly = true;
            this.textBoxBrStola.Size = new System.Drawing.Size(100, 22);
            this.textBoxBrStola.TabIndex = 6;
            // 
            // dataGridViewNarudzba
            // 
            this.dataGridViewNarudzba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNarudzba.Location = new System.Drawing.Point(13, 172);
            this.dataGridViewNarudzba.Name = "dataGridViewNarudzba";
            this.dataGridViewNarudzba.RowHeadersWidth = 51;
            this.dataGridViewNarudzba.RowTemplate.Height = 24;
            this.dataGridViewNarudzba.Size = new System.Drawing.Size(435, 204);
            this.dataGridViewNarudzba.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ukupno:";
            // 
            // textBoxUkupno
            // 
            this.textBoxUkupno.Location = new System.Drawing.Point(80, 397);
            this.textBoxUkupno.Name = "textBoxUkupno";
            this.textBoxUkupno.ReadOnly = true;
            this.textBoxUkupno.Size = new System.Drawing.Size(100, 22);
            this.textBoxUkupno.TabIndex = 9;
            // 
            // buttonIzdajRacun
            // 
            this.buttonIzdajRacun.Location = new System.Drawing.Point(356, 387);
            this.buttonIzdajRacun.Name = "buttonIzdajRacun";
            this.buttonIzdajRacun.Size = new System.Drawing.Size(92, 43);
            this.buttonIzdajRacun.TabIndex = 10;
            this.buttonIzdajRacun.Text = "Izdaj račun";
            this.buttonIzdajRacun.UseVisualStyleBackColor = true;
            // 
            // FormPrikaziNarudzbu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.buttonIzdajRacun);
            this.Controls.Add(this.textBoxUkupno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewNarudzba);
            this.Controls.Add(this.textBoxBrStola);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxBrNarudzbe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPrikaziNarudzbu";
            this.Text = "Prikaži narudžbu";
            this.Load += new System.EventHandler(this.FormPrikaziNarudzbu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNarudzba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBrNarudzbe;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxBrStola;
        private System.Windows.Forms.DataGridView dataGridViewNarudzba;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUkupno;
        private System.Windows.Forms.Button buttonIzdajRacun;
    }
}