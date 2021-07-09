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
    public partial class FormDodajNarudzbu : Form
    { 
        public Order NovaNarudzba { get; set; }
        public int NovaNarudzbaID { get; set; } 
        public User LogiranKorisnik { get; set; }
        public List<Meal> ListaJela { get; set; }
        public List<Cart> ListaKosarice { get; set; }
        public List<string> ListaVrstaJela { get; set; }
        public FormDodajNarudzbu(User korisnik)
        {
            InitializeComponent();
            LogiranKorisnik = korisnik;

        }

      

        private void comboBoxVrstaJela_SelectedIndexChanged(object sender, EventArgs e)
        {
            OsvjeziJela();
        }

        private void FormDodajNarudzbu_Load(object sender, EventArgs e)
        {
            comboBoxVrstaJela.DataSource = DohvatiVrsteJela();
            KreirajNarudzbu();
            OsvjeziJela();
            OsvjeziKosaricu();

        }

        private void OsvjeziKosaricu()
        {
            dataGridViewKosarica.DataSource = null;
            dataGridViewKosarica.DataSource = DohvatiKosaricu();
            dataGridViewKosarica.Columns["ID"].Visible = false;
            dataGridViewKosarica.Columns["Narudzba"].Visible = false;
            dataGridViewKosarica.Columns["Kolicina"].HeaderText = "Količina";
            dataGridViewKosarica.Columns["NazivJela"].HeaderText = "Jelo";
            dataGridViewKosarica.Columns["Order"].Visible = false;

        }
   

        private object DohvatiKosaricu()
        {
            using (var context = new EntitiesOrder())
            {
                ListaKosarice = new List<Cart>();
                foreach (var item in context.Carts)
                {
                    if(item.Narudzba == NovaNarudzbaID )
                    {
                        ListaKosarice.Add(item);
                    }
                }
                return ListaKosarice;
            }
        }

        private void KreirajNarudzbu()
        {
            
            using (var context = new EntitiesOrder())
            {
                NovaNarudzbaID = 0;
                foreach (var item in context.Orders)
                {
                    if (item.ID > NovaNarudzbaID)
                    {
                        NovaNarudzbaID = item.ID;
                    }
                }
                NovaNarudzbaID += 1;
                Order narudzba = new Order
                {
                    ID = NovaNarudzbaID,
                    Zaposlenik = LogiranKorisnik.ID,
                    Status = "priprema",
                    BrStola = textBoxBrStola.Text
                };
                NovaNarudzba = narudzba;
                context.Orders.Add(narudzba);
                context.SaveChanges();

            }
        }

        private void OsvjeziJela()
        {
            dataGridViewJela.DataSource = null;
            dataGridViewJela.DataSource = DohvatiJela();
            dataGridViewJela.Columns["IDJela"].Visible = false;
            dataGridViewJela.Columns["Opis"].Visible = false;
            dataGridViewJela.Columns["Restoran"].Visible = false;
            dataGridViewJela.Columns["Vrsta"].Visible = false;
            dataGridViewJela.Columns["Cijena"].Visible = false;
            dataGridViewJela.Columns["ProductType"].Visible = false;
            dataGridViewJela.Columns["Restaurant"].Visible = false;
        }

        private object DohvatiJela()
        {
            using (var context = new EntitiesOrder())
            {
                ListaJela = new List<Meal>();
                foreach (var item in context.Meals)
                {
                    if(item.Vrsta == comboBoxVrstaJela.Text && item.Restoran ==LogiranKorisnik.Restaurant)
                    {
                        ListaJela.Add(item);
                    }
                }
                return ListaJela;
            }
        }

        private object DohvatiVrsteJela()
        {
           using(var context = new EntitiesOrder())
            {
                ListaVrstaJela = new List<string>();
                foreach (var item in context.ProductTypes)
                {
                    ListaVrstaJela.Add(item.VrstaJela);
                }
                return ListaVrstaJela;
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            
            if (BibliotekeVanjske.ValidacijaUnosa.ProvjeriBrojcanuVrijednost(textBoxKolicina.Text) == "")
            {
                using (var context = new EntitiesOrder())
                {
                    int idNovi = 0;
                    foreach (var item in context.Carts)
                    {
                        if (idNovi < item.ID)
                        {
                            idNovi = item.ID;
                        }
                    }

                    Meal jelo = dataGridViewJela.CurrentRow.DataBoundItem as Meal;
                    int narudzba = NovaNarudzbaID;
                    int kolicina = int.Parse(textBoxKolicina.Text);

                    Cart kosarica = new Cart
                    {
                        ID = idNovi + 1,
                        Narudzba = narudzba,
                        NazivJela = jelo.Naziv,
                        Cijena = int.Parse(jelo.Cijena),
                        Kolicina = kolicina

                    };
                    context.Carts.Add(kosarica);
                    context.SaveChanges();
                }
                OsvjeziKosaricu();
            }
            else
            {
                MessageBox.Show(BibliotekeVanjske.ValidacijaUnosa.ProvjeriBrojcanuVrijednost(textBoxKolicina.Text));
            }
           
        }

        private void buttonKreirajNarudzbu_Click(object sender, EventArgs e)
        {
            if (BibliotekeVanjske.ValidacijaUnosa.ProvjeriOdabirStola(textBoxBrStola.Text) =="")
            {
                using (var context = new EntitiesOrder())
                {
                    foreach (var item in context.Orders)
                    {
                        if (item.ID == NovaNarudzba.ID)
                        {
                            item.BrStola = textBoxBrStola.Text;
                        }
                    }
                    context.SaveChanges();
                }
                Close();
            }
            else
            {
                MessageBox.Show(BibliotekeVanjske.ValidacijaUnosa.ProvjeriOdabirStola(textBoxBrStola.Text));
            }
           
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Order odabrana = NovaNarudzba;
            using (var context = new EntitiesOrder())
            {
                foreach (var item in context.Carts)
                {
                    if (item.Narudzba == odabrana.ID)
                    {
                        context.Carts.Remove(item);
                    }
                }
                foreach (var item in context.Orders)
                {
                    if (item.ID == odabrana.ID)
                    {
                        context.Orders.Remove(item);
                    }
                }
                context.SaveChanges();
            }
            Close();


        }

        private void FormDodajNarudzbu_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc();
        }
        private void Pomoc()
        {
            string help = Path.Combine(new Uri(Path.GetDirectoryName
           (System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            helpProvider1.HelpNamespace = help;
            Help.ShowHelp(this, help, HelpNavigator.KeywordIndex, "Narudzbe");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Order odabrana = NovaNarudzba;
            using (var context = new EntitiesOrder())
            {
                foreach (var item in context.Carts)
                {
                    if (item.Narudzba == odabrana.ID)
                    {
                        context.Carts.Remove(item);
                    }
                }
                foreach (var item in context.Orders)
                {
                    if (item.ID == odabrana.ID)
                    {
                        context.Orders.Remove(item);
                    }
                }
                context.SaveChanges();
            }
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Order odabrana = NovaNarudzba;
            using (var context = new EntitiesOrder())
            {
                foreach (var item in context.Carts)
                {
                    if (item.Narudzba == odabrana.ID)
                    {
                        context.Carts.Remove(item);
                    }
                }
                foreach (var item in context.Orders)
                {
                    if (item.ID == odabrana.ID)
                    {
                        context.Orders.Remove(item);
                    }
                }
                context.SaveChanges();
            }
            Close();
        }
    }
}
