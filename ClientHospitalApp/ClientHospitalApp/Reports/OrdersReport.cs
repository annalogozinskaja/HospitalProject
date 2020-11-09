using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientHospitalApp.Reports
{
    public partial class OrdersReport : Form
    {
        public OrdersReport()
        {
            InitializeComponent();
        }

        private void OrdersReport_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void OrdersReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
            //Form1 Form1 = new Form1();
            //Form1.Show();
            //Hide();
        }
    }
}
