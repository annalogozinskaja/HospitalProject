using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using ClientHospitalApp.Views;

namespace ClientHospitalApp.Views
{
    public partial class PatientSearchExtendForm :PatientDetail, IPatientSearchExtendForm
    {
        public List<Relative> RelativeDataSource
        {
            set { gridControl1.DataSource = value; }
            get { return (List<Relative>)gridControl1.DataSource; }
        }
        public PatientSearchExtendForm()
        {
            InitializeComponent();
        }
    }
}
