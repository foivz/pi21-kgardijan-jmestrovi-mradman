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
            if (BibliotekeVanjske.ValidacijaUnosa.ProvjeriEmail(textBoxEmailGosta.Text) == "")
            {
                BrojRacuna = 0;
                BrojRacuna = DohvatiBrRacuna();
                textBoxBrRacuna.Text = BrojRacuna.ToString();

                VrijemeDatum = DateTime.Now;
                textBoxVrijeme.Text = VrijemeDatum.ToString();

                textBoxUkupno.Text = UkupnaCijena.ToString();

                comboBoxVrstaPlacanja.DataSource = ListaVrstiPlacanja;
            }
            else
            {
                MessageBox.Show(BibliotekeVanjske.ValidacijaUnosa.ProvjeriEmail(textBoxEmailGosta.Text));
            }

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
            Doc.Open();

            //popunjavanje osnovnih informacija
            Paragraph p = new Paragraph("Racun broj: "+ BrojRacuna + "  je uspješno izdan u "+ VrijemeDatum );
            Doc.Add(p);
            p = new Paragraph("Izdao zaposlenik: " + Zaposlenik.Name);
            Doc.Add(p);
            p = new Paragraph("Broj narudzbe: " + OdabranaNarudzba.ID);
            Doc.Add(p);
            p = new Paragraph("Vrsta placanja" + comboBoxVrstaPlacanja.Text);
            Doc.Add(p);
            p = new Paragraph("");
            Doc.Add(p);
            p = new Paragraph("");
            Doc.Add(p);
            p = new Paragraph("Stavke racuna:");
            Doc.Add(p);

            //dodavanje narucenih jela
            using (var context = new EntitiesBills())
            {
                List list = new List(List.UNORDERED);
       
                foreach (var item in context.Carts)
                {
                    if(item.Narudzba == OdabranaNarudzba.ID)
                    {
                        string jelo = item.NazivJela + " " + item.Cijena + "kn " + item.Kolicina +"komada" ; 
                        list.Add(new ListItem(jelo));
                    }
                }
                Doc.Add(list);
            }
            p = new Paragraph("Ukupno: " + UkupnaCijena);
            Doc.Add(p);
            p = new Paragraph("");
            Doc.Add(p);
            p = new Paragraph("");
            Doc.Add(p);

            //dodavanje QR Koda
            string imagePath = "QR" + BrojRacuna+ ".png";
            iTextSharp.text.Image QRKod = iTextSharp.text.Image.GetInstance(imagePath);
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
            
            string Kod = "Racun broj " + BrojRacuna + " je uspjesno izdan u " + textBoxVrijeme.Text +
                ". Zaposlenik: " + Zaposlenik.Name +
                ". Broj narudzbe: " + OdabranaNarudzba.ID +
                ". Ukupna cijena: " + UkupnaCijena +
                ". Vrsta placanja: " + comboBoxVrstaPlacanja.SelectedItem;
            return Kod;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxVrstaPlacanja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
