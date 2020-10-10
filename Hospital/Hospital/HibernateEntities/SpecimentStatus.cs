using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DAOLayer
{
    public class SpecimentStatus
    {
        public virtual int ID_SpecimentStatus { get; set; }
        public virtual string SpecimentStatusName { get; set; }
        public virtual List<int> specimentsInOrderList { get; set; }
    }
}
