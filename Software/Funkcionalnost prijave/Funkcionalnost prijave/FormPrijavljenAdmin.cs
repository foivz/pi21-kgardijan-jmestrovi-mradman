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
    public partial class FormPrijavljenAdmin : Form
    {
        public User LogiraniKorniski { get; set; }
        public Restaurant Restoran { get; set; }
        public FormPrijavljenAdmin(User korisnik)
        {
            InitializeComponent();
            LogiraniKorniski = korisnik;
        }

        private void FormPrijavljenAdmin_Load(object sender, EventArgs e)
        {
            Restoran = NadiRestoran();
            textBoxImeRestorana.Text = Restoran.Name;
            
        }

        private Restaurant  NadiRestoran()
        {
            Restaurant restoran = new Restaurant();
            using (var context = new PI21_54_DBEntities())
            {
                foreach (var obj in context.Restaurants )
                {
                    if(obj.ID ==LogiraniKorniski.Restaurant)
                    {
                        restoran = obj;
                        break;
                    }

                }
            }
            return restoran;
        }
    }
}
