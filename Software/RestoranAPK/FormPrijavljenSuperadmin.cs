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
        private void Pomoc()
        {
            string help = Path.Combine(new Uri(Path.GetDirectoryName
           (System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            helpProvider1.HelpNamespace = help;
            Help.ShowHelp(this, help, HelpNavigator.KeywordIndex, "Naslovnica");
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

        private void buttonDodajRestoran_Click(object sender, EventArgs e)
        {
            int brojRestorana = dataGridViewRestorani.RowCount;
            using (var forma = new FormDodajRestoran(brojRestorana))
            {
                forma.ShowDialog();
            }
            OsvjeziRestorane();
            
        }

        private void buttonDodajAdmina_Click(object sender, EventArgs e)
        {
            
            using (var forma = new FormDodajAdmina(OdabraniRestoran))
            {
                forma.ShowDialog();
            }
          
            OsvjeziAdmine();
        }

        private void buttonObrisiAdmina_Click(object sender, EventArgs e)
        {
            KorisnikZaBrisanje = dataGridViewAdmin.CurrentRow.DataBoundItem as User;

            using (var context = new EntitiesShift())
            {

                foreach (var item in context.Shifts)
                {
                    if (item.Zaposlenik == KorisnikZaBrisanje.ID)
                    {
                        context.Shifts.Remove(item);
                    }
                }
                context.SaveChanges();

                foreach (var item in context.Users)
                {
                    if (item.ID == KorisnikZaBrisanje.ID)
                    {
                        context.Users.Remove(item);
                    }
                }
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
            dataGridViewAdmin.Columns["Password"].Visible = false;
            dataGridViewAdmin.Columns["Name"].HeaderText = "Ime i prezime";
            dataGridViewAdmin.Columns["Shifts"].Visible = false;
            dataGridViewAdmin.Columns["Orders"].Visible = false;

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
            dataGridViewRestorani.Columns["Shifts"].Visible = false;
            dataGridViewRestorani.Columns["Meals"].Visible = false;
            dataGridViewRestorani.Columns["Reservations"].Visible = false;
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

        private void dataGridViewRestorani_SelectionChanged(object sender, EventArgs e)
        {
            OsvjeziAdmine();
        }

        private void FormPrijavljenSuperadmin_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}