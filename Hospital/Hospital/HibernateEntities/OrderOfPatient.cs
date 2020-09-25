using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class OrderOfPatient
    {
        public virtual int ID_Order { get; set; }
        public virtual DateTime DateOrder { get; set; }
        public virtual string Symptoms { get; set; }
        public virtual Patient Patient { get; set; }

        public virtual Doctor Doctor { get; set; }

        //private IList<Patient> patient= new List<Patient>();
        //public virtual IList<Patient> PatientInList
        //{
        //    get { return patient; }
        //    set { patient = value; }
        //}

        //private IList<Doctor> doctor = new List<Doctor>();
        //public virtual IList<Doctor> DoctorInList
        //{
        //    get { return doctor; }
        //    set { doctor = value; }
        //}

        private IList<SpecimentsInOrder> specimentsInOrder = new List<SpecimentsInOrder>();
        public virtual IList<SpecimentsInOrder> SpecimentsInOrderList
        {
            get { return specimentsInOrder; }
            set { specimentsInOrder = value; }
        }

        public virtual OrderStatus OrderStatus { get; set; }
        public virtual DoctorPatientRelations DoctorPatientRelations { get; set; }

        public override string ToString()
        {
            return "\nDate of order: " + DateOrder + "\nSymptoms: " + Symptoms + "\nStatus: "+OrderStatus.OrderName;
        }
    }
}
