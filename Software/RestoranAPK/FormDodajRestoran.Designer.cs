
namespace Funkcionalnost_prijave
{
    partial class FormDodajRestoran
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
            this.textBoxImeRestorana = new System.Windows.Forms.TextBox();
            this.textBoxEmailVlasnika = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime restorana:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail vlasnika:";
            // 
            // textBoxImeRestorana
            // 
            this.textBoxImeRestorana.Location = new System.Drawing.Point(28, 85);
            this.textBoxImeRestorana.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxImeRestorana.Name = "textBoxImeRestorana";
            this.textBoxImeRestorana.Size = new System.Drawing.Size(246, 24);
            this.textBoxImeRestorana.TabIndex = 2;
            // 
            // textBoxEmailVlasnika
            // 
            this.textBoxEmailVlasnika.Location = new System.Drawing.Point(28, 193);
            this.textBoxEmailVlasnika.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmailVlasnika.Name = "textBoxEmailVlasnika";
            this.textBoxEmailVlasnika.Size = new System.Drawing.Size(246, 24);
            this.textBoxEmailVlasnika.TabIndex = 3;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(179, 238);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(94, 37);
            this.buttonDodaj.TabIndex = 4;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(67, 238);
            this.buttonOdustani.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(94, 37);
            this.buttonOdustani.TabIndex = 5;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // FormDodajRestoran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 323);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxEmailVlasnika);
            this.Controls.Add(this.textBoxImeRestorana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDodajRestoran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj restoran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxImeRestorana;
        private System.Windows.Forms.TextBox textBoxEmailVlasnika;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonOdustani;
    }
}