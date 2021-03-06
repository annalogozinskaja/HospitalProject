﻿using ClientHospitalApp.ClientEntities;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using System.Collections.Generic;

namespace ClientHospitalApp.Views
{
    public interface ISpecimentsCheckedComboBoxEdit
    {
        List<int> Speciments { get; set; }
        List<SpecimentsInOrder> SpecimentDataSource { get; set; }
    }
}