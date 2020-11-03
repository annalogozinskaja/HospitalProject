﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DAOLayer
{
    public class TestsInOrder
    {
        public virtual int ID_TestOrder { get; set; }
        public virtual int ID_Test { get; set; }
        public virtual DateTime DateStart { get; set; }
        public virtual DateTime DateEnd { get; set; }
        public virtual int ID_TestStatus { get; set; }
        public virtual string Result { get; set; }
        public virtual List<int> specimentsInOrderList { get; set; }
        public virtual int Status { get; set; }

        public override string ToString()
        {
            return "\nName of test: " +ID_Test + "\nDate start: " + DateStart+
                "\nDate end: " + DateEnd + "\nResult: " + Result + "\nStatus: "+ID_TestStatus;
        }
    }
}
