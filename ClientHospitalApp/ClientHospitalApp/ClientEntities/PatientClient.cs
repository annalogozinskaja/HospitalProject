﻿using AutoMapper;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.ClientEntities
{
    public class PatientClient
    {
        public int ID_Patient { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public DateTime DOB { get; set; }
        public int SSN { get; set; }
        public Gender Gender { get; set; }

        private List<Relative> relativeList { get; set; }
        public List<Relative> RelativeList
        {
            get { return relativeList; }
            set { relativeList = value; }
        }
        public PatientClient()
        {
            this.ID_Patient = -1;
            this.Lastname = string.Empty;
            this.Firstname = string.Empty;
            this.DOB = new DateTime();
            this.SSN = -1;
            Gender = new Gender();
            relativeList = new List<Relative>();


        }

    }
}