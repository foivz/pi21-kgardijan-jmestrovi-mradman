using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("CurrentTime", DateTime.Now.ToString()));
            this.reportViewer1.RefreshReport();
            ExportToPDF();
            PosaljiMail();

        }

        private void ExportToPDF()
        {
            List<Order> orders = new List<Order>();
            orders.Add(order);

            string deviceInfo = "<DeviceInfo>" + 
                    "  <EmbedFonts>None</EmbedFonts>" +
                    "</DeviceInfo>";
            string[] streamIDs;
            Warning[] warnings;

            string mimeType = string.Empty;
            string encoding = string.Empty;
            string extension = string.Empty;

            ReportViewer viewer = new ReportViewer();
            viewer.ProcessingMode = ProcessingMode.Local;
            viewer.LocalReport.ReportPath = "Izvjestaj2.rdlc";
            viewer.LocalReport.DataSources.Clear();
            viewer.LocalReport.DataSources.Add(new ReportDataSource("DTOrder", orders));
            viewer.LocalReport.DataSources.Add(new ReportDataSource("DTCart", order.Carts));
            viewer.RefreshReport();

            var bytes = viewer.LocalReport.Render("PDF", deviceInfo, out mimeType, out encoding,
                out extension, out streamIDs, out warnings
                );


            string fileName = "Izvjestaj.pdf";
            if (fileName == "Izvjestaj.pdf")
            {
                File.Delete("Izvjestaj.pdf");
            }
            File.WriteAllBytes(fileName, bytes);
            //System.Diagnostics.Process.Start(fileName);

        }

        private void PosaljiMail() 
        { 
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
                msg.Body = "Poštovani, u privitku Vam šaljemo izvještaj narudžbe!";
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

    }
}
