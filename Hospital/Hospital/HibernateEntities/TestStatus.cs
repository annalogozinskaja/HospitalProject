using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DAOLayer
{
    public class TestStatus
    {
        public virtual int ID_TestStatus { get; set; }
        public virtual string TestStatusName { get; set; }
    }
}
