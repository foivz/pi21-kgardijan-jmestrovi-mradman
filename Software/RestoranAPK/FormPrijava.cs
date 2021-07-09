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
    public partial class FormPrijava : Form
    {
        public User LogiraniKorisnik { get; set; }
        public List<User> ListaKorisnika { get; set; }
        public FormPrijava()
        {
            InitializeComponent();
        }

        private void ButtonPrijava_Click(object sender, EventArgs e)
        {
            ListaKorisnika = DohvatiKorisnike();

            foreach (var obj in ListaKorisnika)
            {
                if (obj.Username == textBoxKorisnickoIme.Text && obj.Password == textBoxLozinka.Text)
                {
                    LogiraniKorisnik = obj;
                }
            }
            if (LogiraniKorisnik == null)
            {
                MessageBox.Show("Neispravno uneseni podaci");
            }
            else
            {
                if (LogiraniKorisnik.Type == "zaposlenik")
                {
                    Hide();
                    using (var forma = new FormPrijavljenZaposlenik(LogiraniKorisnik))
                    {
                        forma.ShowDialog();
                    }
                    Close();
                }
                else if (LogiraniKorisnik.Type == "admin")
                {
                    Hide();
                    using (var forma = new FormPrijavljenAdmin(LogiraniKorisnik))
                    {
                        forma.ShowDialog();
                    }
                    Close();
                }
                else if (LogiraniKorisnik.Type == "superadmin")
                {
                    Hide();
                    using (var forma = new FormPrijavljenSuperadmin())
                    {
                        forma.ShowDialog();
                    }
                    Close();
                }
            }
        }

        private List<User> DohvatiKorisnike()
        {
            using (var context = new PI21_54_DBEntities())
            {
                return context.Users.ToList();
            }
        }


        private void Pomoc()
        {
            string help = Path.Combine(new Uri(Path.GetDirectoryName
           (System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            helpProvider1.HelpNamespace = help;
            Help.ShowHelp(this, help, HelpNavigator.KeywordIndex, "Prijava");
        }

      

        private void FormPrijava_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
