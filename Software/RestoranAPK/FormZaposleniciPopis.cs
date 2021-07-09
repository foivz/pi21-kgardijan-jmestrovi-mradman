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
    public partial class FormZaposleniciPopis : Form
    {
        public User LogiranK { get; set; }
        private string provjera;
        public FormZaposleniciPopis(User korisnik)
        {
            InitializeComponent();
            LogiranK = korisnik;
        }

        private void FormZaposleniciPopis_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }
        private void Pomoc()
        {
            string help = Path.Combine(new Uri(Path.GetDirectoryName
           (System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            helpProvider1.HelpNamespace = help;
            Help.ShowHelp(this, help, HelpNavigator.KeywordIndex, "Zaposlenici");
        }

        private void Osvjezi()
        {
            dataGridViewPopisZaposlenika.DataSource = null;
            dataGridViewPopisZaposlenika.DataSource = NadiZaposlenike();
            dataGridViewPopisZaposlenika.Columns["Restaurant1"].Visible = false;
            dataGridViewPopisZaposlenika.Columns["User_Type"].Visible = false;
            dataGridViewPopisZaposlenika.Columns["ID"].Visible = false;
            dataGridViewPopisZaposlenika.Columns["Type"].Visible = false;
            dataGridViewPopisZaposlenika.Columns["Restaurant"].Visible = false;
            dataGridViewPopisZaposlenika.Columns["Name"].HeaderText = "Ime i prezime";
            dataGridViewPopisZaposlenika.Columns["Password"].Visible = false;
            dataGridViewPopisZaposlenika.Columns["Username"].HeaderText = "Korisničko ime";
            dataGridViewPopisZaposlenika.Columns["Orders"].Visible = false;
            dataGridViewPopisZaposlenika.Columns["Shifts"].Visible = false;

        }

        private List<User> NadiZaposlenike()
        {
            List<User> popisZaposlenika = new List<User>();
            using (var context = new PI21_54_DBEntities())
            {
                foreach (var obj in context.Users)
                {
                    if(obj.Restaurant == LogiranK.Restaurant && obj.Type == "zaposlenik")
                    {
                        popisZaposlenika.Add(obj);
                    }

                }
                return popisZaposlenika;
            }
        }

        

        private void buttonDodajZaposlenika_Click(object sender, EventArgs e)
        {
            FormDodajZaposlenika form = new FormDodajZaposlenika(LogiranK);
            form.ShowDialog();
            Osvjezi();
           
        }

        private void buttonObrišiZaposlenika_Click(object sender, EventArgs e)
        {
            if (dataGridViewPopisZaposlenika.CurrentRow == null)
            {
                provjera = "";
            }
            else
            {
                provjera = dataGridViewPopisZaposlenika.CurrentRow.ToString();
            }

            if (BibliotekeVanjske.ValidacijaUnosa.ProvjeriOdabirReda(provjera)=="")
            {
                User zaposlenikZaBrisanje = dataGridViewPopisZaposlenika.CurrentRow.DataBoundItem as User;
                using (var context = new EntitiesShift())

                {
                    foreach (var item in context.Shifts)
                    {
                        if (item.Zaposlenik == zaposlenikZaBrisanje.ID)
                        {
                            context.Shifts.Remove(item);
                        }
                    }
                    context.SaveChanges();

                    foreach (var item in context.Users)
                    {
                        if (item.ID == zaposlenikZaBrisanje.ID)
                        {
                            context.Users.Remove(item);
                        }
                    }
                    context.SaveChanges();
                }

                Osvjezi();
            }
            else
            {
                MessageBox.Show(BibliotekeVanjske.ValidacijaUnosa.ProvjeriOdabirReda(provjera));
            }
           
            
        }


        private void dataGridViewPopisZaposlenika_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string provjera = dataGridViewPopisZaposlenika.CurrentRow.ToString();
            if (BibliotekeVanjske.ValidacijaUnosa.ProvjeriOdabirReda(provjera) == "")
            {
                FormUrediZaposlenika form = new FormUrediZaposlenika(dataGridViewPopisZaposlenika.CurrentRow.DataBoundItem as User);
                form.ShowDialog();
                Osvjezi();
            }
            else
            {
                MessageBox.Show(BibliotekeVanjske.ValidacijaUnosa.ProvjeriOdabirReda(provjera));
            }
       
        }

        private void buttonUredi_Click(object sender, EventArgs e)
        {
            if (dataGridViewPopisZaposlenika.CurrentRow == null)
            {
                provjera = "";
            }
            else
            {
                provjera = dataGridViewPopisZaposlenika.CurrentRow.ToString();
            }
            
            if (BibliotekeVanjske.ValidacijaUnosa.ProvjeriOdabirReda(provjera) == "")
            {
                FormUrediZaposlenika form = new FormUrediZaposlenika(dataGridViewPopisZaposlenika.CurrentRow.DataBoundItem as User);
                form.ShowDialog();
                Osvjezi();
            }
            else
            {
                MessageBox.Show(BibliotekeVanjske.ValidacijaUnosa.ProvjeriOdabirReda(provjera));
            }
        }

        private void FormZaposleniciPopis_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc();
        }

       

        private void labelPovratak_Click(object sender, EventArgs e)
        {
            Hide();
            using (var forma = new FormPrijavljenAdmin(LogiranK))
            {
                forma.ShowDialog();
            }
            Close();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
