﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DAOLayer
{
    public class Speciment
    {
        public virtual int ID_Speciment { get; set; }
        public virtual string SpecimentName { get; set; }
    }
}
