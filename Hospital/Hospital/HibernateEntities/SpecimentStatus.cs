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

        private IList<SpecimentsInOrder> specimentsInOrder;

        [XmlIgnore]
        public virtual IList<SpecimentsInOrder> SpecimentsInOrderList
        {
            get { return specimentsInOrder; }
            set { specimentsInOrder = value; }
        }
        public virtual void InitSpecimentsInOrderList()
        {
            specimentsInOrder = new List<SpecimentsInOrder>();
        }
    }
}
