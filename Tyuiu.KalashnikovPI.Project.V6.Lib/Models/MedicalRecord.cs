using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KalashnikovPI.Project.V6.Lib.Models
{
    public class MedicalRecord
    {
        public int PatientId { get; set; }
        public string DoctorFullName { get; set; }
        public string DoctorPosition { get; set; }
        public string DoctorSpecialization { get; set; }
        public string Diagnosis { get; set; }
        public bool NeedsOutpatientCare { get; set; }
        public int DisabilityPeriod { get; set; }
        public bool IsDispensaryObserved { get; set; }
        public string Notes { get; set; }
    }
}
