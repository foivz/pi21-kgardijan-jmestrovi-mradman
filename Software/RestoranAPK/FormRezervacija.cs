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
    public partial class FormRezervacija : Form
    {
        public User LogiraniK { get; set; }
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
            if (LogiraniK.Type == "admin")
            {
                Hide();
                using (var forma = new FormPrijavljenAdmin(LogiraniK))
                {
                    forma.ShowDialog();
                }
                Close();
            }
            else if(LogiraniK.Type== "zaposlenik")
            {
                Hide();
                using (var forma = new FormPrijavljenZaposlenik(LogiraniK))
                {
                    forma.ShowDialog();
                }
                Close();
            }
        }

        private void buttonObriši_Click(object sender, EventArgs e)
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

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            FormDodajRezervaciju form = new FormDodajRezervaciju(LogiraniK);
            form.ShowDialog();
            
        }
    }
}
