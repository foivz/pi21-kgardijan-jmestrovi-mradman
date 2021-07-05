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
    public partial class FormPrijavljenZaposlenik : Form
    {
        public User LogiranKorisnik { get; set; }
        public FormPrijavljenZaposlenik(User korisnik)
        {
            InitializeComponent();
            LogiranKorisnik = korisnik;
        }

        private void FormPrijavljenZaposlenik_Load(object sender, EventArgs e)
        {
            labelRestoran.Text = "Restoran" + NadiRestoran().Name;
            labelKorisnik.Text = "Prijavljen: " + LogiranKorisnik.Name;
        }

        private Restaurant NadiRestoran()
        {
            Restaurant restoran = new Restaurant();
            using (var context = new PI21_54_DBEntities())
            {
                foreach (var obj in context.Restaurants)
                {
                    if (obj.ID == LogiranKorisnik .Restaurant )
                    {
                        restoran = obj;
                        break;
                    }

                }
            }
            return restoran;
        }

        private void buttonRezervacije_Click(object sender, EventArgs e)
        {
            FormRezervacija form = new FormRezervacija(LogiranKorisnik);
            this.Hide();
            form.ShowDialog();
        }

        private void buttonNarudzbe_Click(object sender, EventArgs e)
        {
            FormNarudzbe form = new FormNarudzbe(LogiranKorisnik);
            form.ShowDialog();
            this.Close();
        }

        private void buttonJelovnik_Click(object sender, EventArgs e)
        {
            FormJelovnikZaposlenik form = new FormJelovnikZaposlenik(LogiranKorisnik);
            form.ShowDialog();
            this.Close();
        }

        private void buttonOdjava_Click(object sender, EventArgs e)
        {
            FormPrijava form = new FormPrijava();
            form.ShowDialog();
            this.Close();
        }

        private void labelRestoran_Click(object sender, EventArgs e)
        {

        }
    }
}
