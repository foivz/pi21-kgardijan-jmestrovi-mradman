using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funkcionalnost_prijave
{
    public partial class FormNarudzbe : Form
    {
        public List<string> ListaStatusa { get; set; }
        public List<Order> ListaNarudzbi { get; set; }
        public User LogiranKorisnik { get; set; }
        public Order OdabranaNarudzba { get; set; }
        public FormNarudzbe(User korisnik)
        {
            InitializeComponent();
            LogiranKorisnik = korisnik;
        }

        private void FormNarudzbe_Load(object sender, EventArgs e)
        {
            DohvatiStatuse();
            comboBoxStatus.DataSource = ListaStatusa;

            Osvjezi();
        }

        private void Osvjezi()
        {
            dataGridViewNarudzbe.DataSource = null;
            dataGridViewNarudzbe.DataSource = DohvatiNarudzbe();
            dataGridViewNarudzbe.Columns["ID"].HeaderText = "Br. narudžbe";
            dataGridViewNarudzbe.Columns["Zaposlenik"].Visible = false;
            dataGridViewNarudzbe.Columns["User"].Visible = false;
            dataGridViewNarudzbe.Columns["Carts"].Visible = false;
            dataGridViewNarudzbe.Columns["Bills"].Visible = false;
            dataGridViewNarudzbe.Columns["OrderStatu"].Visible = false;
            dataGridViewNarudzbe.Columns["BrStola"].HeaderText = "Br. stola";
        }

        private object DohvatiNarudzbe()
        {
            using (var context = new EntitiesOrder())
            {
                ListaNarudzbi = new List<Order>();
                foreach (var item in context.Orders)
                {
                    if (item.Status != "Zavrseno")
                    {
                        ListaNarudzbi.Add(item);
                    }
                   
                }

                return ListaNarudzbi;
            }
        }

        private void DohvatiStatuse()
        {
            ListaStatusa = new List<string>();
            using (var context =  new EntitiesOrder())
            {
                foreach (var item in context.OrderStatus)
                {
                    if(item.Status != "Zavrseno")
                    {
                        ListaStatusa.Add(item.Status.ToString());
                    }
                }
            }
        }

        private void buttonObrisiNarudzbu_Click(object sender, EventArgs e)
        {
            Order odabrana = dataGridViewNarudzbe.CurrentRow.DataBoundItem as Order;
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
            Osvjezi();
        }

        private void buttonPovratak_Click(object sender, EventArgs e)
        {
            FormPrijavljenZaposlenik form = new FormPrijavljenZaposlenik(LogiranKorisnik);
            this.Hide();
            form.ShowDialog();
        }

        private void buttonPromijeniStatus_Click(object sender, EventArgs e)
        {
            Order odabrana = dataGridViewNarudzbe.CurrentRow.DataBoundItem as Order;
            using (var context = new EntitiesOrder())
            {
                foreach (var item in context.Orders)
                {
                    if(item.ID == odabrana.ID)
                    {
                        item.Status = comboBoxStatus.Text;
                    }
                }
                context.SaveChanges();
            }
            Osvjezi();
        }

        private void buttonDodajNarudzbu_Click(object sender, EventArgs e)
        {
            FormDodajNarudzbu form = new FormDodajNarudzbu(LogiranKorisnik);
            form.ShowDialog();
            Osvjezi();
        }

        private void buttonPrikaziNarudzbu_Click(object sender, EventArgs e)
        {
            OdabranaNarudzba = dataGridViewNarudzbe.CurrentRow.DataBoundItem as Order;
            FormPrikaziNarudzbu form = new FormPrikaziNarudzbu(LogiranKorisnik, OdabranaNarudzba);
            this.Hide();
            form.ShowDialog();
        }
    }
}
