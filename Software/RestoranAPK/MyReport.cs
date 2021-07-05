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

        public MyReport()
        {
            InitializeComponent();
        }
        public MyReport(Order order)
        {
            InitializeComponent();
            this.order = order;
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

        }
    }
}
