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
    public partial class FormPrijavljenAdmin : Form
    {
        public User LogiraniKorniski { get; set; }
        public Restaurant Restoran { get; set; }
        public FormPrijavljenAdmin(User korisnik)
        {
            InitializeComponent();
            LogiraniKorniski = korisnik;
        }

        private void FormPrijavljenAdmin_Load(object sender, EventArgs e)
        {
            labelKorisnik.Text ="Prijavljen:" + LogiraniKorniski.Name;
            Restoran = NadiRestoran();
            labelRestoran.Text = "Restoran" + Restoran.Name;
            
        }

        private Restaurant  NadiRestoran()
        {
            Restaurant restoran = new Restaurant();
            using (var context = new PI21_54_DBEntities())
            {
                foreach (var obj in context.Restaurants )
                {
                    if(obj.ID ==LogiraniKorniski.Restaurant)
                    {
                        restoran = obj;
                        break;
                    }

                }
            }
            return restoran;
        }

        private void buttonZaposlenici_Click(object sender, EventArgs e)
        {
            FormZaposleniciPopis form = new FormZaposleniciPopis(LogiraniKorniski);
            form.ShowDialog();
            this.Close();
        }

        private void buttonRezervacije_Click(object sender, EventArgs e)
        {
            FormRezervacija form = new FormRezervacija(LogiraniKorniski);
            form.ShowDialog();
            this.Close();
        }

        private void buttonJelovnik_Click(object sender, EventArgs e)
        {
            FormJelovnikAdmin form = new FormJelovnikAdmin(LogiraniKorniski);
            form.ShowDialog();
            this.Close();
        }

        private void buttonSmjene_Click(object sender, EventArgs e)
        {
            FormSmjeneRada form = new FormSmjeneRada(LogiraniKorniski);
            form.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPrijava form = new FormPrijava();
            form.ShowDialog();
            this.Close();
        }

        private void buttonStatistika_Click(object sender, EventArgs e)
        {
            FormStatistika form = new FormStatistika(LogiraniKorniski);
            form.ShowDialog();
            this.Close();
        }
    }
}
