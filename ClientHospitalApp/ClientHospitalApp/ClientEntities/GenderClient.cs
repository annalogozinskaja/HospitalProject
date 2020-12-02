using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.ClientEntities
{
    public class GenderClient
    {
        public int ID_Gender { get; set; }
        public string GenderName { get; set; }

        public override string ToString()
        {
            return GenderName.ToString();
        }      
    }
    
}
