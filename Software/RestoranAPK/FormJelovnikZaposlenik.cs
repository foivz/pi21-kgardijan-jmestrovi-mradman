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
    public partial class FormJelovnikZaposlenik : Form
    {
        public List <Meal> ListaJela { get; set; }
        public List <string> ListaVrstaJela { get; set; }
        public User LogiraniKorisnik { get; set; }
        public FormJelovnikZaposlenik(User korisnik)
        {
            InitializeComponent();
            LogiraniKorisnik = korisnik;
        }

        private void FormJelovnikZaposlenik_Load(object sender, EventArgs e)
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
                    if (item.Vrsta == comboBoxVrstaJela.Text && item.Restoran==LogiraniKorisnik.Restaurant)
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

        private void comboBoxVrstaJela_SelectedIndexChanged(object sender, EventArgs e)
        {
            OsvjeziJela();
        }

        private void buttonPovratak_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new FormPrijavljenZaposlenik(LogiraniKorisnik))
            {
                forma.ShowDialog();
            }
            Close();
        }
    }
}
