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
    public partial class FormDodajAdmina : Form
    {
        public Restaurant OdabraniRestoran { get; set; }
        public int id { get; set; }
        public FormDodajAdmina(Restaurant odabrani)
           
        {
            InitializeComponent();
            OdabraniRestoran = odabrani;
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if(BibliotekeVanjske.ValidacijaUnosa.ProvjeriLozinku(textBoxLozinka.Text)=="" && BibliotekeVanjske.ValidacijaUnosa.ProvjeriKorisnickoIme(textBoxKorisnickoIme.Text) == "")
            {
                using (var context = new EntitiesShift())
                {
                    id = 0;
                    foreach (var obj in context.Users)
                    {
                        if (obj.ID > id)
                        {
                            id = obj.ID;
                        }
                    }

                    string username = textBoxKorisnickoIme.Text;
                    string password = textBoxLozinka.Text;
                    string name = textBoxImePrezime.Text;


                    User admin = new User
                    {
                        ID = id + 1,
                        Username = username,
                        Password = password,
                        Name = name,
                        Restaurant = OdabraniRestoran.ID,
                        Type = "admin",
                    };
                    context.Users.Add(admin);

                    int idSmjene = 0;
                    foreach (var item in context.Shifts)
                    {
                        if (item.ID > idSmjene)
                        {
                            idSmjene = item.ID;
                        }
                    }
                    idSmjene += 1;
                    Shift novi = new Shift
                    {
                        ID = idSmjene,
                        Zaposlenik = admin.ID,
                        ImeZaposlenika = admin.Name,
                        Smjena = 1,
                        Restoran = OdabraniRestoran.ID
                    };
                    context.Shifts.Add(novi);

                    context.SaveChanges();

                    Close();
                }
            }
            else
            {
                MessageBox.Show(BibliotekeVanjske.ValidacijaUnosa.ProvjeriKorisnickoIme(textBoxKorisnickoIme.Text) + BibliotekeVanjske.ValidacijaUnosa.ProvjeriLozinku(textBoxLozinka.Text));
            }
          
        }

        private void FormDodajAdmina_Load(object sender, EventArgs e)
        {

        }

        private void buttonDodaj_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc();

        }
        private void Pomoc()
        {
            string help = Path.Combine(new Uri(Path.GetDirectoryName
           (System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            helpProvider1.HelpNamespace = help;
            Help.ShowHelp(this, help, HelpNavigator.KeywordIndex, "Naslovnica");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
