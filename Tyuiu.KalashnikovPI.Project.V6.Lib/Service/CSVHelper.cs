using System.Text;
using Tyuiu.KalashnikovPI.Project.V6.Lib.Models;

namespace Tyuiu.KalashnikovPI.Project.V6.Lib.Service
{
    public class CSVHelper
    {
        private string filePath;

        public CSVHelper(string path)
        {
            filePath = path;
        }

        // Методы для работы с пациентами
        public void SavePatients(List<Patient> patients)
        {
            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                sw.WriteLine("Номер,Фамилия,Имя,Отчество,ДатаРождения");
                foreach (var patient in patients)
                {
                    sw.WriteLine($"{patient.Id},{patient.LastName},{patient.FirstName},{patient.MiddleName},{patient.BirthDate:dd.MM.yyyy}");
                }
            }
        }

        public List<Patient> LoadPatients()
        {
            List<Patient> patients = new List<Patient>();
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath, Encoding.UTF8))
                {
                    sr.ReadLine(); // Пропускаем заголовок
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        patients.Add(new Patient
                        {
                            Id = int.Parse(data[0]),
                            LastName = data[1],
                            FirstName = data[2],
                            MiddleName = data[3],
                            BirthDate = DateTime.ParseExact(data[4], "dd.MM.yyyy", null)
                        });
                    }
                }
            }
            return patients;
        }

        // Методы для работы с медицинскими записями
        public void SaveMedicalRecords(List<MedicalRecord> records)
        {
            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                sw.WriteLine("ИдПациента,ВрачФИО,Должность,Специализация,Диагноз,АмбулаторноеЛечение,СрокНетрудоспособности,ДиспансерныйУчет,Примечание");
                foreach (var record in records)
                {
                    sw.WriteLine($"{record.PatientId},{record.DoctorFullName},{record.DoctorPosition},{record.DoctorSpecialization}," +
                               $"{record.Diagnosis},{record.NeedsOutpatientCare},{record.DisabilityPeriod},{record.IsDispensaryObserved},{record.Notes}");
                }
            }
        }

        public List<MedicalRecord> LoadMedicalRecords()
        {
            List<MedicalRecord> records = new List<MedicalRecord>();
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath, Encoding.UTF8))
                {
                    sr.ReadLine(); // Пропускаем заголовок
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        records.Add(new MedicalRecord
                        {
                            PatientId = int.Parse(data[0]),
                            DoctorFullName = data[1],
                            DoctorPosition = data[2],
                            DoctorSpecialization = data[3],
                            Diagnosis = data[4],
                            NeedsOutpatientCare = bool.Parse(data[5]),
                            DisabilityPeriod = int.Parse(data[6]),
                            IsDispensaryObserved = bool.Parse(data[7]),
                            Notes = data[8]
                        });
                    }
                }
            }
            return records;
        }

        // Методы статистики
        public Dictionary<string, int> GetDiagnosisStatistics(List<MedicalRecord> records)
        {
            return records.GroupBy(r => r.Diagnosis).ToDictionary(g => g.Key, g => g.Count());
        }

        public int GetTotalPatients(List<Patient> patients)
        {
            return patients.Count;
        }

        public double GetAverageDisabilityPeriod(List<MedicalRecord> records)
        {
            return records.Average(r => r.DisabilityPeriod);
        }

        public int GetMinDisabilityPeriod(List<MedicalRecord> records)
        {
            return records.Min(r => r.DisabilityPeriod);
        }

        public int GetMaxDisabilityPeriod(List<MedicalRecord> records)
        {
            return records.Max(r => r.DisabilityPeriod);
        }

    }
}