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
    public partial class FormDodajZaposlenika : Form
    {
        private int id { get; set; }
        public User LogiranAdmin { get; set; }
        public FormDodajZaposlenika(User korisnik)
        {
            InitializeComponent();
            LogiranAdmin = korisnik;
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            using (var context = new PI21_54_DBEntities())
            {
                id = 0;
                foreach (var obj in context.Users)
                {
                    if (obj.ID > id)
                    {
                        id = obj.ID;
                    }
                }

                string username = textBoxUsername.Text;
                string password = textBoxLozinka.Text;
                string name = textBoxImePrezime.Text;


                User zaposlenik = new User
                {
                    ID = id + 1,
                    Username = username,
                    Password = password,
                    Name = name,
                    Restaurant = LogiranAdmin.Restaurant,
                    Type = "zaposlenik",
                };
                context.Users.Add(zaposlenik);
                context.SaveChanges();

                Close();
            }
        }
    }
}
