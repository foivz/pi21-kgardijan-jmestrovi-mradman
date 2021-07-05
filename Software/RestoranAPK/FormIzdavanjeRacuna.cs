using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace Funkcionalnost_prijave
{
    public partial class FormIzdavanjeRacuna : Form
    {
        public Order OdabranaNarudzba { get; set; }
        public User Zaposlenik { get; set; }

        public int UkupnaCijena { get; set; }
        public int BrojRacuna { get; set; }
        public DateTime VrijemeDatum { get; set; }
        public QRCode Kod { get; set; }
        public Document Doc { get; set; }

        public List<string> ListaVrstiPlacanja = new List<string>{ "Gotovina", "Debitna kartica", "Kreditna kartica" };
        public FormIzdavanjeRacuna(Order narudzba, User korisnik, int cijena)
        {
            InitializeComponent();
            OdabranaNarudzba = narudzba;
            Zaposlenik = korisnik;
            UkupnaCijena = cijena;

        }

        private void FormIzdavanjeRacuna_Load(object sender, EventArgs e)
        {
          

            BrojRacuna = 0;
            BrojRacuna = DohvatiBrRacuna();
            textBoxBrRacuna.Text = BrojRacuna.ToString();

            VrijemeDatum = DateTime.Now;
            textBoxVrijeme.Text = VrijemeDatum.ToString();

            textBoxUkupno.Text = UkupnaCijena.ToString();

            comboBoxVrstaPlacanja.DataSource = ListaVrstiPlacanja;

        }

        private int DohvatiBrRacuna()
        {
            using (var context = new EntitiesBills())
            {
                int br=0;
                foreach (var item in context.Bills)
                {
                    if (item.BrRacuna > br)
                    {
                        br= item.BrRacuna;
                    }
                }
                return br + 1;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            FormPrijavljenZaposlenik form = new FormPrijavljenZaposlenik(Zaposlenik);
            this.Hide();
            form.ShowDialog();
        }

        private void buttonIzdajRacun_Click(object sender, EventArgs e)
        {
            if (BibliotekeVanjske.ValidacijaUnosa.ProvjeriEmail(textBoxEmailGosta.Text) == "")
            {
                QRCodeGenerator qrCode = new QRCodeGenerator();
                QRCodeData data = qrCode.CreateQrCode(QRTekst(), QRCodeGenerator.ECCLevel.Q);
                Kod = new QRCode(data);
                pictureQRCode.Image = Kod.GetGraphic(5);
                pictureQRCode.Image.Save("QR" + BrojRacuna + ".png", System.Drawing.Imaging.ImageFormat.Png);


                KreiranjeRacuna();
                KreirajPDF();
                PosaljiMail();
                PromijeniStatusNarudzbe();
            }
            else
            {
                MessageBox.Show(BibliotekeVanjske.ValidacijaUnosa.ProvjeriEmail(textBoxEmailGosta.Text));
            }
        }

        private void PosaljiMail()
        {
            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
            {
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("piprojektmail@gmail.com", "piprojekttest123");
                MailMessage msg = new MailMessage();
                msg.To.Add(textBoxEmailGosta.Text);
                msg.From = new MailAddress("piprojekttest123@gmail.com");
                msg.Subject = "Racun";
                msg.Body = "Poštovani, ovim putem Vam u privitku šaljemo Vaš račun. Veselimo se Vašem ponovnom dolasku!";
                msg.Attachments.Add(new Attachment("Racun" + BrojRacuna + ".pdf"));
                client.Send(msg);
            }
        }

        private void KreirajPDF()
        {
            Doc = new Document();
            string imeDatoteke = "Racun" + BrojRacuna + ".pdf";
            PdfWriter.GetInstance(Doc, new FileStream(imeDatoteke, FileMode.Create));

            BaseFont bf1 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font1 = new iTextSharp.text.Font(bf1, 20, iTextSharp.text.Font.NORMAL);
            BaseFont bf2 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font2 = new iTextSharp.text.Font(bf2, 15, iTextSharp.text.Font.NORMAL);

            Doc.Open();

            //popunjavanje osnovnih informacija
            Paragraph p = new Paragraph("Racun broj: " + BrojRacuna + "  je uspješno izdan u " + VrijemeDatum);
            Phrase p3 = new Phrase(BrojRacuna);
            p.Alignment = Element.ALIGN_CENTER;
            Doc.Add(p);
            Doc.Add(p3);
            p = new Paragraph(" ");
            Doc.Add(p);

            //Paragraph p1 = new Paragraph(new Chunk("Sample text", font1));
            //Doc.Add(p1);

            p = new Paragraph("Izdao zaposlenik: " + Zaposlenik.Name);
            p.Alignment = Element.ALIGN_RIGHT;
            Doc.Add(p);
            p = new Paragraph("Broj narudžbe: " + OdabranaNarudzba.ID);
            p.Alignment = Element.ALIGN_RIGHT;
            Doc.Add(p);
            p = new Paragraph("Vrsta placanja: " + comboBoxVrstaPlacanja.Text);
            p.Alignment = Element.ALIGN_RIGHT;
            Doc.Add(p);
            p = new Paragraph(" ");
            Doc.Add(p);
            p = new Paragraph(" ");
            Doc.Add(p);
            p = new Paragraph("Stavke racuna");
            Doc.Add(p);
            p = new Paragraph("______________________________________________________________________________");
            Doc.Add(p);

            //dodavanje narucenih jela
            using (var context = new EntitiesBills())
            {
                List list = new List(List.UNORDERED);

                foreach (var item in context.Carts)
                {
                    if (item.Narudzba == OdabranaNarudzba.ID)
                    {
                        string jelo = item.NazivJela + " " + item.Cijena + "kn " + item.Kolicina + "komad(a)";
                        list.Add(new ListItem(jelo));
                    }
                }
                Doc.Add(list);
            }
            p = new Paragraph("______________________________________________________________________________");
            Doc.Add(p);
            p = new Paragraph("Ukupno: " + UkupnaCijena + " kn");
            p.Alignment = Element.ALIGN_LEFT;
            Doc.Add(p);
            p = new Paragraph(" ");
            Doc.Add(p);
            p = new Paragraph(" ");
            Doc.Add(p);

            //dodavanje QR Koda
            p = new Paragraph("QR kod za skeniranje. ");
            p.Alignment = Element.ALIGN_CENTER;
            Doc.Add(p);
            string imagePath = "QR" + BrojRacuna + ".png";
            iTextSharp.text.Image QRKod = iTextSharp.text.Image.GetInstance(imagePath);
            QRKod.ScaleAbsolute(160f, 160f);
            QRKod.Alignment = Element.ALIGN_CENTER;
            Doc.Add(QRKod);
            Doc.Close();

        }

        private void PromijeniStatusNarudzbe()
        {
            Order odabrana = OdabranaNarudzba;
            using (var context = new EntitiesOrder())
            {
                foreach (var item in context.Orders)
                {
                    if (item.ID == odabrana.ID)
                    {
                        item.Status = "Zavrseno";
                    }
                }
                context.SaveChanges();
            }
        }

        private void KreiranjeRacuna()
        {
            using (var context = new EntitiesBills())
            {
                string zaposlenik = Zaposlenik.Name;
                int id = BrojRacuna;
                int narudzba = OdabranaNarudzba.ID;
                DateTime vrijeme = VrijemeDatum;
                string placanje = comboBoxVrstaPlacanja.Text;

                Bill noviRacun = new Bill
                {
                    BrRacuna = id,
                    Narudzba = narudzba,
                    ImeZaposlenika = zaposlenik,
                    Vrijeme = vrijeme,
                    VrstaPlacanja = placanje,
                    

                };
                context.Bills.Add(noviRacun);
                context.SaveChanges();
            }
        }

        private string QRTekst()
        {
            string imeRestorana = dohvatiImeRestorana();
            string Kod = $"HRVHUB30\nHRK\n{int.Parse(textBoxUkupno.Text)*100} \n\n \n \n {imeRestorana} \n Julija Merlica 9 \n 42000 Varaždin \n HR1023800413290547670 \n HR00 \n\n COST \n Racun {BrojRacuna}";
                          
                

            return Kod;
        }

        private string dohvatiImeRestorana()
        {
            using (var context = new EntitiesBills())
            {
                foreach (var item in context.Restaurants)
                {
                    if(item.ID== Zaposlenik.Restaurant)
                    {
                        return item.Name;
                    }
                }
                return null;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxVrstaPlacanja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
