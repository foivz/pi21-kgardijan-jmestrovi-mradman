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
    public partial class FormZaposleniciPopis : Form
    {
        public User LogiranK { get; set; }
        public FormZaposleniciPopis(User korisnik)
        {
            InitializeComponent();
            LogiranK = korisnik;
        }

        private void FormZaposleniciPopis_Load(object sender, EventArgs e)
        {
            Osvjezi();  
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
            dataGridViewPopisZaposlenika.Columns["Password"].HeaderText = "Lozinka";
            dataGridViewPopisZaposlenika.Columns["Username"].HeaderText = "Korisničko ime";
            
        }

        private void buttonPovratak_Click(object sender, EventArgs e)
        {
            FormPrijavljenAdmin form = new FormPrijavljenAdmin(LogiranK);
            this.Hide();
            form.ShowDialog();
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

        private void dataGridViewPopisZaposlenika_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDodajZaposlenika_Click(object sender, EventArgs e)
        {
            FormDodajZaposlenika form = new FormDodajZaposlenika(LogiranK);
            form.ShowDialog();
            Osvjezi();
           
        }

        private void buttonObrišiZaposlenika_Click(object sender, EventArgs e)
        {
            User zaposlenikZaBrisanje = dataGridViewPopisZaposlenika.CurrentRow.DataBoundItem as User;
            using (var context = new PI21_54_DBEntities())
            {
                context.Users.Attach(zaposlenikZaBrisanje);
                context.Users.Remove(zaposlenikZaBrisanje);
                context.SaveChanges();
            }

            Osvjezi();
            
        }

        private void buttonUrediZaposlenika_Click(object sender, EventArgs e)
        {
            FormUrediZaposlenika form = new FormUrediZaposlenika(dataGridViewPopisZaposlenika.CurrentRow.DataBoundItem as User);
            form.ShowDialog();
            Osvjezi();
        }
    }
}
