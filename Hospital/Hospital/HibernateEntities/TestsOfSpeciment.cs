using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLayer.HibernateEntities
{
    public class TestsOfSpeciment
    {
        public virtual int ID_TestSpeciment { get; set; }
        public virtual int ID_SpecimentOrder { get; set; }
        public virtual int ID_TestOrder { get; set; }
    }
}
