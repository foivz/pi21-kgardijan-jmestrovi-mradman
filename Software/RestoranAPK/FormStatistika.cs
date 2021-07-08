using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
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
            
            entities.Orders.Load();
            orderBindingSource.DataSource = entities.Orders.Local;
            Pomoc();
            
        }
        private void Pomoc()
        {
            string help = Path.Combine(new Uri(Path.GetDirectoryName
           (System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            helpProvider1.HelpNamespace = help;
            Help.ShowHelp(this, help, HelpNavigator.KeywordIndex, "Statistika");
        }


        private void btnStat_Click(object sender, EventArgs e)
        {
            MyReport report = new MyReport(orderBindingSource.Current as Order,LogiraniKorniski);
            report.ShowDialog();
        }

        private void buttonPovratak2_Click(object sender, EventArgs e)
        {
            Hide();
            using( FormPrijavljenAdmin form = new FormPrijavljenAdmin(LogiraniKorniski))
            {
                form.ShowDialog();
            }
            Close();
        }
    }
}
