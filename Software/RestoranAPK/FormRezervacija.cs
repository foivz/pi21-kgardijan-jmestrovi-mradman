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
    public partial class FormRezervacija : Form
    {
        public User LogiraniK { get; set; }
        public string provjera;
        public List<Reservation> ListaRezervacija { get; set; }
        public FormRezervacija(User korisnik)
        {
            InitializeComponent();
            LogiraniK = korisnik;
        }

        private void FormRezervacija_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }
        private void Pomoc()
        {
            string help = Path.Combine(new Uri(Path.GetDirectoryName
           (System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            helpProvider1.HelpNamespace = help;
            Help.ShowHelp(this, help, HelpNavigator.KeywordIndex, "Rezervacije");
        }

        private void Osvjezi()
        {
            dataGridViewRezervacije.DataSource = null;
            dataGridViewRezervacije.DataSource = DohvatiRezervacije();
            dataGridViewRezervacije.Columns["BrojRezervacije"].HeaderText = "Broj rezervacije";
            dataGridViewRezervacije.Columns["ImeGosta"].HeaderText = "Ime gosta";
            dataGridViewRezervacije.Columns["EmailGosta"].HeaderText = "E-mail";
            dataGridViewRezervacije.Columns["BrojOsoba"].HeaderText = "Broj osoba";
            dataGridViewRezervacije.Columns["BrojStola"].HeaderText = "Broj stola";
            dataGridViewRezervacije.Columns["Restoran"].Visible = false;
            dataGridViewRezervacije.Columns["Restaurant"].Visible = false;
        }

        private List<Reservation> DohvatiRezervacije()
        {
            ListaRezervacija = new List<Reservation>();
            using (var context = new EntitiesReservations())
            {
                foreach (var item in context.Reservations)
                {
                    if(item.Restoran == LogiraniK.Restaurant)
                    {
                        ListaRezervacija.Add(item);
                    }
                }
                return ListaRezervacija;
            }
        }

        private void buttonPovratak_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonObriši_Click(object sender, EventArgs e)
        {
            if (dataGridViewRezervacije.CurrentRow == null)
            {
                provjera = "";
            }
            else
            {
                provjera = dataGridViewRezervacije.CurrentRow.ToString();
            }

            if (BibliotekeVanjske.ValidacijaUnosa.ProvjeriOdabirReda(provjera) == "")
            {
                Reservation odabranaRezervacija = dataGridViewRezervacije.CurrentRow.DataBoundItem as Reservation;
                using (var context = new EntitiesReservations())
                {
                    context.Reservations.Attach(odabranaRezervacija);
                    context.Reservations.Remove(odabranaRezervacija);
                    context.SaveChanges();
                }

                Osvjezi();
            }
            else
            {
                MessageBox.Show(BibliotekeVanjske.ValidacijaUnosa.ProvjeriOdabirReda(provjera));
            }
                
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            FormDodajRezervaciju form = new FormDodajRezervaciju(LogiraniK);
            form.ShowDialog();
            Osvjezi();
            
        }

        private void FormRezervacija_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (LogiraniK.Type == "admin")
            {
                Hide();
                using (var forma = new FormPrijavljenAdmin(LogiraniK))
                {
                    forma.ShowDialog();
                }
                Close();
            }
            else if (LogiraniK.Type == "zaposlenik")
            {
                Hide();
                using (var forma = new FormPrijavljenZaposlenik(LogiraniK))
                {
                    forma.ShowDialog();
                }
                Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
