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
    public partial class FormPrijavljenAdmin : Form
    {
        public User LogiraniKorisnik { get; set; }
        public Restaurant Restoran { get; set; }
        public FormPrijavljenAdmin(User korisnik)
        {
            InitializeComponent();
            LogiraniKorisnik = korisnik;
        }

        private void FormPrijavljenAdmin_Load(object sender, EventArgs e)
        {
            labelKorisnik.Text ="Prijavljen:" + LogiraniKorisnik.Name;
            Restoran = NadiRestoran();
            labelRestoran.Text = "Restoran" + Restoran.Name;
            
        }

        private void Pomoc()
        {
            string help = Path.Combine(new Uri(Path.GetDirectoryName
           (System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            helpProvider1.HelpNamespace = help;
            Help.ShowHelp(this, help, HelpNavigator.KeywordIndex, "Naslovnica");
        }

        private Restaurant  NadiRestoran()
        {
            Restaurant restoran = new Restaurant();
            using (var context = new PI21_54_DBEntities())
            {
                foreach (var obj in context.Restaurants )
                {
                    if(obj.ID ==LogiraniKorisnik.Restaurant)
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
            Hide();
            using (var forma = new FormZaposleniciPopis(LogiraniKorisnik))
            {
                forma.ShowDialog();
            }
            Close();
        }

        private void buttonRezervacije_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new FormRezervacija(LogiraniKorisnik))
            {
                forma.ShowDialog();
            }
            Close();
        }

        private void buttonJelovnik_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new FormJelovnikAdmin(LogiraniKorisnik))
            {
                forma.ShowDialog();
            }
            Close();
        }

        private void buttonSmjene_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new FormSmjeneRada(LogiraniKorisnik))
            {
                forma.ShowDialog();
            }
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new FormPrijava())
            {
                forma.ShowDialog();
            }
            Close();
        }

        private void buttonStatistika_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new FormStatistika(LogiraniKorisnik))
            {
                forma.ShowDialog();
            }
            Close();
        }

        private void FormPrijavljenAdmin_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc();
        }
    }
}
