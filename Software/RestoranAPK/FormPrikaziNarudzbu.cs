using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funkcionalnost_prijave
{
    public partial class FormPrikaziNarudzbu : Form
    {
        public User LogiraniKorisnik { get; set; }
        public Order OdabranaNarudzba { get; set; }
        public List<Cart> ListaKosarice { get; set; }
        public int UkupnaCijena { get; set; }
        public FormPrikaziNarudzbu(User korisnik, Order narudzba)
        {
            InitializeComponent();
            LogiraniKorisnik = korisnik;
            OdabranaNarudzba = narudzba;
        }

        private void FormPrikaziNarudzbu_Load(object sender, EventArgs e)
        {
            textBoxBrNarudzbe.Text = OdabranaNarudzba.ID.ToString();
            textBoxStatus.Text = OdabranaNarudzba.Status;
            textBoxBrStola.Text = OdabranaNarudzba.BrStola;

            dataGridViewNarudzba.DataSource = DohvatiNarudzbu();
            dataGridViewNarudzba.Columns["ID"].Visible = false;
            dataGridViewNarudzba.Columns["Narudzba"].Visible = false;
            dataGridViewNarudzba.Columns["Kolicina"].HeaderText = "Količina";
            dataGridViewNarudzba.Columns["NazivJela"].HeaderText = "Jelo";
            dataGridViewNarudzba.Columns["Order"].Visible = false;

            textBoxUkupno.Text = UkupnaCijena.ToString();
        }
        private void Pomoc()
        {
            string help = Path.Combine(new Uri(Path.GetDirectoryName
           (System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            helpProvider1.HelpNamespace = help;
            Help.ShowHelp(this, help, HelpNavigator.KeywordIndex, "Racun");
        }
        private object DohvatiNarudzbu()
        {
            using (var context = new EntitiesOrder())
            {
                ListaKosarice = new List<Cart>();
                UkupnaCijena = 0;
                foreach (var item in context.Carts)
                {
                    if (item.Narudzba == OdabranaNarudzba.ID)
                    {
                        ListaKosarice.Add(item);
                        UkupnaCijena += item.Cijena*item.Kolicina; 
                    }
                }
                return ListaKosarice;
            }
        }

        private void buttonIzdajRacun_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new FormIzdavanjeRacuna(OdabranaNarudzba,LogiraniKorisnik,UkupnaCijena))
            {
                forma.ShowDialog();
            }
            Close();
        }

        private void buttonPovratak_Click(object sender, EventArgs e)
        {
           
            
        }

        private void FormPrikaziNarudzbu_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new FormNarudzbe(LogiraniKorisnik))
            {
                forma.ShowDialog();
            }
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
