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
    public partial class FormDodajRestoran : Form
    {
        int BrojRestorana { get; set; }
        public int id { get; set; }
        public FormDodajRestoran(int broj)
        {
            InitializeComponent();
            BrojRestorana = broj;
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodajRestoran();
            FormPrijavljenSuperadmin form = new FormPrijavljenSuperadmin();
            form.ShowDialog();
        }
        private void DodajRestoran()
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

                Restaurant restaurant = new Restaurant
                {

                    ID = id + 1,
                    Name = textBoxImeRestorana.Text,
                    Owner_Email = textBoxEmailVlasnika.Text
                };
                context.Restaurants.Add(restaurant);
                context.SaveChanges();
            }
        }

        private void FormDodajRestoran_Load(object sender, EventArgs e)
        {

        }
    }
}