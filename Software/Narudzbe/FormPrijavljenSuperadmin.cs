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
    public partial class FormPrijavljenSuperadmin : Form
    {
        Restaurant OdabraniRestoran { get; set; }
        User KorisnikZaBrisanje { get; set; }
        public FormPrijavljenSuperadmin()
        {
            InitializeComponent();
        }

        private void FormPrijavljenSuperadmin_Load(object sender, EventArgs e)
        {
            OsvjeziRestorane();
        }

        private List<Restaurant> DohvatiRestorane()
        {
            using (var context = new PI21_54_DBEntities())
            {
                return context.Restaurants.ToList();
            }
        }


        private List<User> DohvatiAdmine()
        {
            OdabraniRestoran = dataGridViewRestorani.CurrentRow.DataBoundItem as Restaurant;
            List<User> ListaKorisnika = new List<User>();
            using (var context = new PI21_54_DBEntities())
            {
                foreach (var obj in context.Users)
                {
                    if (obj.Restaurant == OdabraniRestoran.ID && obj.Type == "admin")
                    {
                        ListaKorisnika.Add(obj);
                    }
                    else
                    {
                        continue;
                    }
                }
                return ListaKorisnika;
            }
        }

        private void buttonPregledajAdmine_Click(object sender, EventArgs e)
        {
            OsvjeziAdmine();
        }

        private void buttonDodajRestoran_Click(object sender, EventArgs e)
        {
            int brojRestorana = dataGridViewRestorani.RowCount;
            FormDodajRestoran form = new FormDodajRestoran(brojRestorana);
            form.ShowDialog();
        }

        private void buttonDodajAdmina_Click(object sender, EventArgs e)
        {
            FormDodajAdmina form = new FormDodajAdmina(OdabraniRestoran);
            form.ShowDialog();
            OsvjeziAdmine();
        }

        private void buttonObrisiAdmina_Click(object sender, EventArgs e)
        {
            KorisnikZaBrisanje = dataGridViewAdmin.CurrentRow.DataBoundItem as User;

            using (var context = new PI21_54_DBEntities())
            {
                context.Users.Attach(KorisnikZaBrisanje);
                context.Users.Remove(KorisnikZaBrisanje);
                context.SaveChanges();
            }
            OsvjeziAdmine();
        }

        private void OsvjeziAdmine()
        {
            dataGridViewAdmin.DataSource = DohvatiAdmine();
            dataGridViewAdmin.Columns["Restaurant1"].Visible = false;
            dataGridViewAdmin.Columns["User_Type"].Visible = false;
            dataGridViewAdmin.Columns["ID"].Visible = false;
            dataGridViewAdmin.Columns["Restaurant"].Visible = false;
            dataGridViewAdmin.Columns["Type"].Visible = false;
            dataGridViewAdmin.Columns["Username"].HeaderText = "Korisničko ime";
            dataGridViewAdmin.Columns["Password"].HeaderText = "Lozinka";
            dataGridViewAdmin.Columns["Name"].HeaderText = "Ime i prezime";

        }

        private void buttonObrisiRestoran_Click(object sender, EventArgs e)
        {
            OdabraniRestoran = dataGridViewRestorani.CurrentRow.DataBoundItem as Restaurant;

            using (var context = new PI21_54_DBEntities())
            {
                context.Restaurants.Attach(OdabraniRestoran);
                context.Restaurants.Remove(OdabraniRestoran);
                context.SaveChanges();
            }

            OsvjeziRestorane();
        }

        private void OsvjeziRestorane()
        {
            dataGridViewRestorani.DataSource = DohvatiRestorane();
            dataGridViewRestorani.Columns["Users"].Visible = false;
            dataGridViewRestorani.Columns["ID"].Visible = false;
            dataGridViewRestorani.Columns["Name"].HeaderText = "Ime restorana";
            dataGridViewRestorani.Columns["Owner_Email"].HeaderText = "E-mail vlasnika";
        }
    }
}