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
    public partial class FormSmjeneRada : Form
    {
        public User LogiranAdmin { get; set; }
        public List<Shift> ListaPrve { get; set; }
        public List<Shift> ListaDruge { get; set; }
        public FormSmjeneRada(User user)
        {
            InitializeComponent();
            LogiranAdmin = user;
        }

        private void FormSmjeneRada_Load(object sender, EventArgs e)
        {
            OsvjeziPrvuSmjenu();
            OsvjeziDruguSmjenu();
            Pomoc();
        }
        private void Pomoc()
        {
            string help = Path.Combine(new Uri(Path.GetDirectoryName
           (System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            helpProvider1.HelpNamespace = help;
            Help.ShowHelp(this, help, HelpNavigator.KeywordIndex, "Smjene");
        }
        private void OsvjeziDruguSmjenu()
        {
            dataGridViewDruga.DataSource = null;
            dataGridViewDruga.DataSource = DohvatiDruguSmjenu();
            dataGridViewDruga.Columns["ID"].Visible = false;
            dataGridViewDruga.Columns["Zaposlenik"].Visible = false;
            dataGridViewDruga.Columns["Smjena"].Visible = false;
            dataGridViewDruga.Columns["Restoran"].Visible = false;
            dataGridViewDruga.Columns["User"].Visible = false;
            dataGridViewDruga.Columns["Restaurant"].Visible = false;
            dataGridViewDruga.Columns["ImeZaposlenika"].HeaderText = "Zaposlenik";
        }

        private List<Shift> DohvatiDruguSmjenu()
        {
            ListaDruge = new List<Shift>();
            using(var context = new EntitiesShift())
            {
                foreach (var item in context.Shifts)
                {
                    if(item.Restoran == LogiranAdmin.Restaurant && item.Smjena==2)
                    {
                        ListaDruge.Add(item);
                    }
                }
                return ListaDruge;
            }
        }

        private void OsvjeziPrvuSmjenu()
        {
            dataGridViewPrva.DataSource = null;
            dataGridViewPrva.DataSource = DohvatiPrvuSmjenu();
            dataGridViewPrva.Columns["ID"].Visible = false;
            dataGridViewPrva.Columns["Zaposlenik"].Visible = false;
            dataGridViewPrva.Columns["Smjena"].Visible = false;
            dataGridViewPrva.Columns["Restoran"].Visible = false;
            dataGridViewPrva.Columns["User"].Visible = false;
            dataGridViewPrva.Columns["Restaurant"].Visible = false;
            dataGridViewPrva.Columns["ImeZaposlenika"].HeaderText = "Zaposlenik";
        }

        private object DohvatiPrvuSmjenu()
        {
            ListaPrve = new List<Shift>();
            using (var context = new EntitiesShift())
            {
                foreach (var item in context.Shifts)
                {
                    if (item.Restoran == LogiranAdmin.Restaurant && item.Smjena == 1)
                    {
                        ListaPrve.Add(item);
                    }
                }
                return ListaPrve;
            }
        }

        private void buttonPovratak_Click(object sender, EventArgs e)
        {
            Hide();
            using(FormPrijavljenAdmin forma = new FormPrijavljenAdmin(LogiranAdmin))
            {
                forma.ShowDialog();
            }
            Close();
        }

        private void buttonPrva_Click(object sender, EventArgs e)
        {
            Shift odabrani = dataGridViewPrva.CurrentRow.DataBoundItem as Shift;
            using (var context = new EntitiesShift())
            {
                foreach (var item in context.Shifts)
                {
                    if (item.ID == odabrani.ID)
                    {
                        item.Smjena = 2;
                    }
                }
                context.SaveChanges();
            }
            OsvjeziDruguSmjenu();
            OsvjeziPrvuSmjenu();
        }

        private void buttonDruga_Click(object sender, EventArgs e)
        {
            Shift odabran = dataGridViewDruga.CurrentRow.DataBoundItem as Shift;
            using (var context = new EntitiesShift())
            {
                foreach (var item in context.Shifts)
                {
                    if (item.ID == odabran.ID)
                    {
                        item.Smjena = 1;
                    }
                }
                context.SaveChanges();
            }
            OsvjeziDruguSmjenu();
            OsvjeziPrvuSmjenu();
        }

        private void dataGridViewPrva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
