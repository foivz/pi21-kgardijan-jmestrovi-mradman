
namespace Funkcionalnost_prijave
{
    partial class FormJelovnikAdmin
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewJela = new System.Windows.Forms.DataGridView();
            this.comboBoxVrstaJela = new System.Windows.Forms.ComboBox();
            this.Vrsta = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.DataGridViewMeal = new System.Windows.Forms.DataGridView();
            this.iDJelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restoranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PI21_54_DBDataSet = new Funkcionalnost_prijave._PI21_54_DBDataSet();
            this.btnEksport = new System.Windows.Forms.Button();
            this.mealTableAdapter = new Funkcionalnost_prijave._PI21_54_DBDataSetTableAdapters.MealTableAdapter();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PI21_54_DBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewJela
            // 
            this.dataGridViewJela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewJela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJela.Location = new System.Drawing.Point(234, 169);
            this.dataGridViewJela.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewJela.Name = "dataGridViewJela";
            this.dataGridViewJela.RowHeadersWidth = 51;
            this.dataGridViewJela.RowTemplate.Height = 24;
            this.dataGridViewJela.Size = new System.Drawing.Size(641, 255);
            this.dataGridViewJela.TabIndex = 1;
            // 
            // comboBoxVrstaJela
            // 
            this.comboBoxVrstaJela.FormattingEnabled = true;
            this.comboBoxVrstaJela.Location = new System.Drawing.Point(297, 135);
            this.comboBoxVrstaJela.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVrstaJela.Name = "comboBoxVrstaJela";
            this.comboBoxVrstaJela.Size = new System.Drawing.Size(135, 26);
            this.comboBoxVrstaJela.TabIndex = 2;
            this.comboBoxVrstaJela.SelectedIndexChanged += new System.EventHandler(this.comboBoxVrstaJela_SelectedIndexChanged);
            // 
            // Vrsta
            // 
            this.Vrsta.AutoSize = true;
            this.Vrsta.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vrsta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Vrsta.Location = new System.Drawing.Point(229, 136);
            this.Vrsta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Vrsta.Name = "Vrsta";
            this.Vrsta.Size = new System.Drawing.Size(60, 25);
            this.Vrsta.TabIndex = 3;
            this.Vrsta.Text = "Vrsta:";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodaj.Location = new System.Drawing.Point(790, 445);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(85, 40);
            this.buttonDodaj.TabIndex = 4;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisi.Location = new System.Drawing.Point(653, 445);
            this.buttonObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(85, 40);
            this.buttonObrisi.TabIndex = 5;
            this.buttonObrisi.Text = "Obriši";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // DataGridViewMeal
            // 
            this.DataGridViewMeal.AllowUserToAddRows = false;
            this.DataGridViewMeal.AutoGenerateColumns = false;
            this.DataGridViewMeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMeal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDJelaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.restoranDataGridViewTextBoxColumn,
            this.vrstaDataGridViewTextBoxColumn});
            this.DataGridViewMeal.DataSource = this.mealBindingSource;
            this.DataGridViewMeal.Location = new System.Drawing.Point(684, 29);
            this.DataGridViewMeal.Name = "DataGridViewMeal";
            this.DataGridViewMeal.RowHeadersWidth = 51;
            this.DataGridViewMeal.RowTemplate.Height = 24;
            this.DataGridViewMeal.Size = new System.Drawing.Size(105, 68);
            this.DataGridViewMeal.TabIndex = 6;
            // 
            // iDJelaDataGridViewTextBoxColumn
            // 
            this.iDJelaDataGridViewTextBoxColumn.DataPropertyName = "IDJela";
            this.iDJelaDataGridViewTextBoxColumn.HeaderText = "IDJela";
            this.iDJelaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDJelaDataGridViewTextBoxColumn.Name = "iDJelaDataGridViewTextBoxColumn";
            this.iDJelaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.Width = 125;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.Width = 125;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // restoranDataGridViewTextBoxColumn
            // 
            this.restoranDataGridViewTextBoxColumn.DataPropertyName = "Restoran";
            this.restoranDataGridViewTextBoxColumn.HeaderText = "Restoran";
            this.restoranDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.restoranDataGridViewTextBoxColumn.Name = "restoranDataGridViewTextBoxColumn";
            this.restoranDataGridViewTextBoxColumn.Width = 125;
            // 
            // vrstaDataGridViewTextBoxColumn
            // 
            this.vrstaDataGridViewTextBoxColumn.DataPropertyName = "Vrsta";
            this.vrstaDataGridViewTextBoxColumn.HeaderText = "Vrsta";
            this.vrstaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vrstaDataGridViewTextBoxColumn.Name = "vrstaDataGridViewTextBoxColumn";
            this.vrstaDataGridViewTextBoxColumn.Width = 125;
            // 
            // mealBindingSource
            // 
            this.mealBindingSource.DataMember = "Meal";
            this.mealBindingSource.DataSource = this._PI21_54_DBDataSet;
            // 
            // _PI21_54_DBDataSet
            // 
            this._PI21_54_DBDataSet.DataSetName = "_PI21_54_DBDataSet";
            this._PI21_54_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEksport
            // 
            this.btnEksport.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEksport.Location = new System.Drawing.Point(440, 445);
            this.btnEksport.Name = "btnEksport";
            this.btnEksport.Size = new System.Drawing.Size(158, 40);
            this.btnEksport.TabIndex = 7;
            this.btnEksport.Text = "Eksport u PDF";
            this.btnEksport.UseVisualStyleBackColor = true;
            this.btnEksport.Click += new System.EventHandler(this.btnEksport_Click);
            // 
            // mealTableAdapter
            // 
            this.mealTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DataGridViewMeal);
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
            this.label1.Location = new System.Drawing.Point(315, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 65);
            this.label1.TabIndex = 9;
            this.label1.Text = "JELOVNIK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(46, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 35);
            this.label3.TabIndex = 11;
            this.label3.Text = "<";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Funkcionalnost_prijave.Properties.Resources.menu;
            this.pictureBox1.Location = new System.Drawing.Point(12, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FormJelovnikAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(933, 530);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEksport);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.Vrsta);
            this.Controls.Add(this.comboBoxVrstaJela);
            this.Controls.Add(this.dataGridViewJela);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormJelovnikAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jelovnik";
            this.Load += new System.EventHandler(this.FormJelovnikAdmin_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormJelovnikAdmin_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PI21_54_DBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewJela;
        private System.Windows.Forms.ComboBox comboBoxVrstaJela;
        private System.Windows.Forms.Label Vrsta;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.DataGridView DataGridViewMeal;
        private System.Windows.Forms.Button btnEksport;
        private _PI21_54_DBDataSet _PI21_54_DBDataSet;
        private System.Windows.Forms.BindingSource mealBindingSource;
        private _PI21_54_DBDataSetTableAdapters.MealTableAdapter mealTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDJelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restoranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}