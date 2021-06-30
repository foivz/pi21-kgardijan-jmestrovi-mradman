using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funkcionalnost_prijave
{
    public partial class FormStatistika : Form
    {
        EntitiesStatistika entities = new EntitiesStatistika(); 
       
        public User LogiraniKorniski { get; set; }
        public List<string> ListaStatusa { get; set; }
        public List<Order> ListaNarudzbi { get; set; }
        public FormStatistika(User korisnik)
        {
            InitializeComponent();
            LogiraniKorniski = korisnik;
        }


        //private void buttonPovratak2_Click(object sender, EventArgs e)
        //{
        //    FormPrijavljenAdmin form = new FormPrijavljenAdmin(LogiraniKorisnik);
        //    this.Hide();
        //    form.ShowDialog();
        //}


        private void FormStatistika_Load(object sender, EventArgs e)
        {
            comboBoxStatus.Visible = false;
            entities.Orders.Load();
            orderBindingSource.DataSource = entities.Orders.Local;
            DohvatiStatuse();
            comboBoxStatus.DataSource = ListaStatusa;

            
            
        }

        private object DohvatiNarudzbe()
        {
            using (var context = new EntitiesOrder())
            {
                ListaNarudzbi = new List<Order>();
                foreach (var item in context.Orders)
                {
                    if (item.Status != "Zavrseno")
                    {
                        ListaNarudzbi.Add(item);
                    }

                }
                return ListaNarudzbi;
            }
        }

        private void DohvatiStatuse()
        {
            ListaStatusa = new List<string>();
            using (var context = new EntitiesOrder())
            {
                foreach (var item in context.OrderStatus)
                {
                    if (item.Status != "Zavrseno")
                    {
                        ListaStatusa.Add(item.Status.ToString());
                    }
                }
            }
        }


        private void btnStat_Click(object sender, EventArgs e)
        {
            MyReport report = new MyReport(orderBindingSource.Current as Order);
            report.ShowDialog();
        }

        private void buttonPovratak2_Click(object sender, EventArgs e)
        {
            FormPrijavljenAdmin form = new FormPrijavljenAdmin(LogiraniKorniski);
            this.Hide();
            form.ShowDialog();
        }
    }
}
