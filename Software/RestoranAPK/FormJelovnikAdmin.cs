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
    public partial class FormJelovnikAdmin : Form
    {
        public User LogiranKorisnik { get; set; }
        public List<Meal> ListaJela { get; set; }
        public List<string> ListaVrstaJela { get; set; }
        public FormJelovnikAdmin(User korisnik)
        {
            InitializeComponent();
            LogiranKorisnik = korisnik;
        }

        private void FormJelovnikAdmin_Load(object sender, EventArgs e)
        {
            OsvjeziJela();
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
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            FormDodajJelo form = new FormDodajJelo(LogiranKorisnik);
            form.ShowDialog();
            OsvjeziJela();
        }

        private void comboBoxVrstaJela_SelectedIndexChanged(object sender, EventArgs e)
        {
            OsvjeziJela();
        }
    }
}
