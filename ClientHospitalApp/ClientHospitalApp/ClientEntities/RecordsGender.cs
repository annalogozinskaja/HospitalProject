using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.ClientEntities
{
    public class RecordsGender
    {
        private List <GenderClient> genderlist;
        public List<GenderClient> GenderList
        {
            get { return genderlist; }
            set { genderlist = value; }
        }

        public RecordsGender(List<GenderClient> gender)
        {
            this.genderlist = gender;
        }
       
    }
}
