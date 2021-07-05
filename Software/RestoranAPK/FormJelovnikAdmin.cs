using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text.html;
using System.Collections;
using System.Net;
using System.Configuration;
using System.Web;
using System.Data.OleDb;

namespace Funkcionalnost_prijave
{
    public partial class FormJelovnikAdmin : Form
    {
        public User LogiranKorisnik { get; set; }
        public List<Meal> ListaJela { get; set; }
        public List<string> ListaVrstaJela { get; set; }
        public DateTime VrijemeDatum { get; set; }
        public string ImeRestorana { get; set; }
        public string Osoba { get; set; }
        public FormJelovnikAdmin(User korisnik)
        {
            InitializeComponent();
            LogiranKorisnik = korisnik;
        }

        private void FormJelovnikAdmin_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the '_PI21_54_DBDataSet.Meal' table. You can move, or remove it, as needed.
            this.mealTableAdapter.Fill(this._PI21_54_DBDataSet.Meal);

            VrijemeDatum = DateTime.Now;
            ImeRestorana = "";
            Osoba = "";
            Osoba = DohvatiOsobu();
            ImeRestorana = DohvatiImeRestorana();

            OsvjeziJela();
            OsvjeziJela2();

            DataGridViewMeal.Visible = false;
            comboBoxVrstaJela.DataSource = DohvatiVrsteJela();
        }

        private void OsvjeziJela()
        {

            dataGridViewJela.DataSource = null;
            dataGridViewJela.DataSource = DohvatiJela();
            dataGridViewJela.Columns["IDJela"].Visible = false;
            dataGridViewJela.Columns["Restoran"].Visible = false;
            dataGridViewJela.Columns["Vrsta"].Visible = false;
            dataGridViewJela.Columns["ProductType"].Visible = false;
            dataGridViewJela.Columns["Restaurant"].Visible = false;
        }

        private void OsvjeziJela2()
        {
            DataGridViewMeal.DataSource = null;
            DataGridViewMeal.DataSource = DohvatiSve();
        }


        private string DohvatiImeRestorana()
        {
            using (var context = new EntitiesBills())
            {
                string br = "";
                foreach (var item in context.Restaurants)
                {
                    if (item.ID == LogiranKorisnik.Restaurant)
                    {
                        br = item.Name;
                    }
                }
                return br;
            }
        }
        private string DohvatiOsobu()
        {
            using (var context = new EntitiesStatistika())
            {
                string br = "";
                foreach (var item in context.Restaurants)
                {
                    if (item.ID == LogiranKorisnik.Restaurant)
                    {
                        foreach (var item2 in context.Users)
                        {
                            if (item2.Name == LogiranKorisnik.Name)
                            {
                                br = item2.Name;
                            }
                        }
                    }
                }
                return br;
            }
        }


        private object DohvatiSve()
        {
            using (var context = new EntitiesOrder())
            {
                ListaJela = new List<Meal>();
                foreach (var item in context.Meals)
                {
                    if (item.Restoran == LogiranKorisnik.Restaurant && item.Vrsta == "Predjelo")
                    {
                        ListaJela.Add(item);
                    }
                    else if (item.Restoran == LogiranKorisnik.Restaurant && item.Vrsta == "Prilog")
                    {
                        ListaJela.Add(item);
                    }
                    else if (item.Restoran == LogiranKorisnik.Restaurant && item.Vrsta == "GlavnoJelo")
                    {
                        ListaJela.Add(item);
                    }
                    else if (item.Restoran == LogiranKorisnik.Restaurant && item.Vrsta == "Pice")
                    {
                        ListaJela.Add(item);
                    }
                    else if (item.Restoran == LogiranKorisnik.Restaurant && item.Vrsta == "Desert")
                    {
                        ListaJela.Add(item);
                    }
                }
                return ListaJela;
            }
        }

        private object DohvatiJela()
        {
            using (var context = new EntitiesOrder())
            {
                ListaJela = new List<Meal>();
                foreach (var item in context.Meals)
                {
                    if (item.Vrsta == comboBoxVrstaJela.Text && item.Restoran==LogiranKorisnik.Restaurant)
                    {
                        ListaJela.Add(item);
                    }
                }
                return ListaJela;
            }
        }

        private object DohvatiVrsteJela()
        {
            using (var context = new EntitiesOrder())
            {
                ListaVrstaJela = new List<string>();
                foreach (var item in context.ProductTypes)
                {
                    ListaVrstaJela.Add(item.VrstaJela);
                }
                return ListaVrstaJela;
            }
        }

        private void buttonPovratak_Click(object sender, EventArgs e)
        {
            FormPrijavljenAdmin form = new FormPrijavljenAdmin(LogiranKorisnik);
            form.ShowDialog();
            this.Close();
            OsvjeziJela();
            OsvjeziJela2();

        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            Meal odabrano=dataGridViewJela.CurrentRow.DataBoundItem as Meal;

            using (var context = new EntitiesBills())
            {
                foreach (var item in context.Meals)
                {
                    if(item.IDJela == odabrano.IDJela)
                    {
                        context.Meals.Remove(item);
                    }
                }
                context.SaveChanges();
            }
            OsvjeziJela();
            OsvjeziJela2();

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            FormDodajJelo form = new FormDodajJelo(LogiranKorisnik);
            form.ShowDialog();
            OsvjeziJela();
            OsvjeziJela2();

        }

        private void comboBoxVrstaJela_SelectedIndexChanged(object sender, EventArgs e)
        {
            OsvjeziJela();
            OsvjeziJela2();

        }

        private void btnEksport_Click(object sender, EventArgs e)
        {
            if (DataGridViewMeal.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Nije moguće zapisati podatke na disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable((DataGridViewMeal.Columns.Count));
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in DataGridViewMeal.Columns)
                            {
                                //if(column.HeaderText != "Restoran")
                                //{
                                //    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                //    pdfTable.AddCell(cell);
                                //}
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }


                            foreach (DataGridViewRow row in DataGridViewMeal.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {

                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }


                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 40, 40, 40, 40);
                                PdfWriter.GetInstance(pdfDoc, stream);

                                pdfDoc.Open();
                                Paragraph p = new Paragraph("Jelovnik restorana  " + ImeRestorana + "  je uspješno izdan u " + VrijemeDatum);
                                p.Alignment = Element.ALIGN_CENTER;
                                pdfDoc.Add(p);
                                p = new Paragraph(" ");
                                pdfDoc.Add(p);
                                p = new Paragraph(" ");
                                pdfDoc.Add(p);
                                pdfDoc.Add(pdfTable);
                                p = new Paragraph(" ");
                                pdfDoc.Add(p);
                                p = new Paragraph("Izdao:  " + Osoba);
                                p.Alignment = Element.ALIGN_RIGHT;
                                pdfDoc.Add(p);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Eksport u PDF uspješan. ", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nema podataka za eksport! ", "Info");
            }
        }
    }
}
