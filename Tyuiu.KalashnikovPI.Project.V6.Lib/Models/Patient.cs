﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KalashnikovPI.Project.V6.Lib.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Diagnosis { get; set; }
        public bool IsAmbulatory { get; set; }
        public int DisabilityPeriod { get; set; }
        public bool IsDispensary { get; set; }
        public string Note { get; set; }
    }
}
