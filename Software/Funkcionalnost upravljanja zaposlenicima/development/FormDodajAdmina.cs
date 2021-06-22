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
            using (var context = new PI21_54_DBEntities ())
            {
                id = 0;
                foreach(var obj in context.Users)
                {
                    if(obj.ID > id)
                    {
                        id = obj.ID;
                    }
                }
                    
                context.Restaurants.Attach(OdabraniRestoran);
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
                    Restaurant1 =OdabraniRestoran
                };
                context.Users.Add(admin);
                context.SaveChanges();

                Close();
            }
        }
    }
}
