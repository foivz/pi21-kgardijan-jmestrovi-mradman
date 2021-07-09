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
    public partial class FormUrediZaposlenika : Form
    {
        public User OdabraniKorisnik { get; set; }
        public FormUrediZaposlenika(User korisnik)
        {
            InitializeComponent();
            OdabraniKorisnik = korisnik;
        }

        private void FormUrediZaposlenika_Load(object sender, EventArgs e)
        {
            textBoxImePrezime.Text = OdabraniKorisnik.Name;
            textBoxKorisnickoIme.Text = OdabraniKorisnik.Username;
            textBoxLozinka.Text = OdabraniKorisnik.Password;
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUredi_Click(object sender, EventArgs e)
        {

            using ( var context = new PI21_54_DBEntities())
            {
                
                context.Users.Attach(OdabraniKorisnik);

                OdabraniKorisnik.Name = textBoxImePrezime.Text;
                OdabraniKorisnik.Username = textBoxKorisnickoIme.Text;
                OdabraniKorisnik.Password = textBoxLozinka.Text;


                context.SaveChanges();
            }

            Close();
        }

        private void FormUrediZaposlenika_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc();
        }
        private void Pomoc()
        {
            string help = Path.Combine(new Uri(Path.GetDirectoryName
           (System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            helpProvider1.HelpNamespace = help;
            Help.ShowHelp(this, help, HelpNavigator.KeywordIndex, "Zaposlenici");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
