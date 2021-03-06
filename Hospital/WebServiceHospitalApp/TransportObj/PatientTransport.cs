﻿using DAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceHospitalApp.TransportObj
{
    public class PatientTransport
    {
        public int ID_Patient { get; set; }
        public  string Lastname { get; set; }
        public  string Firstname { get; set; }
        public  DateTime DOB { get; set; }
        public int SSN { get; set; }

        private List<Patient> relative { get; set; }
        public List<Patient> RelativeInList
        {
            get { return relative; }
            set { relative = value; }
        }

        public Gender Gender { get; set; }
        private List<OrderOfPatient> orderOfPatient;
        public List<OrderOfPatient> OrderOfPatientInList
        {
            get { return orderOfPatient; }
            set { orderOfPatient = value; }
        }

        public PatientTransport()
        {
            this.ID_Patient = -1;
            this.Lastname = string.Empty;
            this.Firstname = string.Empty;
            this.DOB = new DateTime();
            this.SSN = -1;
            //this.RelativeInList = new List<int>();
        }

        //public PatientTransport(Patient patient)
        //{
        //    this.ID_Patient = patient.ID_Patient;
        //    this.Lastname = patient.Lastname;
        //    this.Firstname = patient.Firstname;
        //    this.DOB = patient.DOB;
        //    this.SSN = patient.SSN;
        //    //this.RelativeAutoMapper = patient.RelativeInList.ToList();
        //}

        //public Patient toPatient()
        //{
        //    Patient patient = new Patient();
        //    patient.ID_Patient = this.ID_Patient;
        //    patient.Lastname = this.Lastname;
        //    patient.Firstname = this.Firstname;
        //    patient.DOB = this.DOB;
        //    patient.SSN = this.SSN;

        //    return patient;
        //}

        public override string ToString()
        {
            return "\nPatient: " + ID_Patient.ToString() + "." + Lastname + " " + Firstname + ", " + DOB + ", " + SSN.ToString() + ". ";
        }
    }
}