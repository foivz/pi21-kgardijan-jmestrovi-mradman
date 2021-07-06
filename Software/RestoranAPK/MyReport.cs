using Microsoft.Reporting.WinForms;
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
    public partial class MyReport : Form
    {
        EntitiesStatistika entities = new EntitiesStatistika();
        private Order order;
        public User LogiranKorisnik { get; set; }

    
        public MyReport(Order order, User kor)
        {
            InitializeComponent();
            this.order = order;
            LogiranKorisnik = kor;
        }


        private void MyReport_Load(object sender, EventArgs e)
        {
            List<Order> orders = new List<Order>();
            orders.Add(order);

            var rds = new ReportDataSource("DataSetOrder", orders);
            var rds2 = new ReportDataSource("DataSetCart", order.Carts);
            //var rds2 = new ReportDataSource("DTBill", bill);
            //var rds3 = new ReportDataSource("DTCart", cart);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            //this.reportViewer1.LocalReport.DataSources.Add(rds2);
            //this.reportViewer1.LocalReport.DataSources.Add(rds3);


            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("CurrentTime", DateTime.Now.ToString()));
            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD

        }
=======
            string mail = DohvatiMail();
            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
            {
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("piprojektmail@gmail.com", "piprojekttest123");
                MailMessage msg = new MailMessage();
                msg.To.Add(mail);
                msg.From = new MailAddress("piprojekttest123@gmail.com");
                msg.Subject = "Racun";
                msg.Body = "Poštovani, ovim putem Vam u privitku šaljemo Vaš račun. Veselimo se Vašem ponovnom dolasku!";
                msg.Attachments.Add(new Attachment("Izvjestaj.pdf"));
                client.Send(msg);
            }
        }

        private string DohvatiMail()
        {
            using (var context = new EntitiesBills())
            {
                string br = "";
                foreach (var item in context.Restaurants)
                {
                    if (item.ID == LogiranKorisnik.Restaurant)
                    {
                        br = item.Owner_Email;
                    }
                }
                return br;
            }
        }
        //---------------------------------------------
>>>>>>> Rezervacije_SLanje_Maila
    }
}
