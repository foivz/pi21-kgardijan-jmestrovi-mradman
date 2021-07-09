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
       
        public User LogiraniKorisnik { get; set; }
        public FormStatistika(User korisnik)
        {
            InitializeComponent();
            LogiraniKorisnik = korisnik;
        }


      


        private void FormStatistika_Load(object sender, EventArgs e)
        {
            
            entities.Orders.Load();
            orderBindingSource.DataSource = entities.Orders.Local;
            
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
            FormMyReport report = new FormMyReport(orderBindingSource.Current as Order,LogiraniKorisnik);
            report.ShowDialog();
        }

       

        private void FormStatistika_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            Hide();
            using (FormPrijavljenAdmin form = new FormPrijavljenAdmin(LogiraniKorisnik))
            {
                form.ShowDialog();
            }
            Close();
        }
    }
}
