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
            labelRestoran.Text = "Restoran " + NadiRestoran().Name;
            labelKorisnik.Text = "Prijavljen: " + LogiranKorisnik.Name;
        }

        private void Pomoc()
        {
            string help = Path.Combine(new Uri(Path.GetDirectoryName
           (System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            helpProvider1.HelpNamespace = help;
            Help.ShowHelp(this, help, HelpNavigator.KeywordIndex, "Naslovnica");
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
            Hide();
            using (var forma = new FormRezervacija(LogiranKorisnik))
            {
                forma.ShowDialog();
            }
            Close();
        }

        private void buttonNarudzbe_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new FormNarudzbe(LogiranKorisnik))
            {
                forma.ShowDialog();
            }
            Close();
        }

        private void buttonJelovnik_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new FormJelovnikZaposlenik(LogiranKorisnik))
            {
                forma.ShowDialog();
            }
            Close();
        }

        private void buttonOdjava_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new FormPrijava())
            {
                forma.ShowDialog();
            }
            Close();
        }

        private void labelRestoran_Click(object sender, EventArgs e)
        {

        }

        private void FormPrijavljenZaposlenik_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc();
        }
    }
}
