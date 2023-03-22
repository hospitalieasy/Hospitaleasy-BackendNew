using HastaneFinder.DataAcess.Abstract;
using HastaneFinder.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HastaneFinder.DataAcess.Concrete
{
    public class PatientRepository : IPatientRepository
    {
        public Patient AddPatient(Patient patient)
        {
            using (var hastaneDbContext = new HastaneDbContext())
            {
                hastaneDbContext.Patients.Add(patient);
                hastaneDbContext.SaveChanges();
                return patient;

            }
        }

        public void DeletePatientById(int id)
        {
            using (var hastaneDbContext = new HastaneDbContext())
            {
                var patient = GetPatientById(id);
                hastaneDbContext.Patients.Remove(patient);
                hastaneDbContext.SaveChanges();
            }
        }

        public List<Patient> GetAllPatients()
        {
            using (var HastaneDbContext = new HastaneDbContext())
            {
                return HastaneDbContext.Patients.ToList();
            }
        }

        public Patient GetPatientById(int id)
        {
            using (var hastaneDbContext = new HastaneDbContext())
            {
                return hastaneDbContext.Patients.Find(id);
            }
        }

        public Patient UpdatePatient(Patient patient)
        {
            using (var hastaneDbContext = new HastaneDbContext())
            {
                hastaneDbContext.Patients.Update(patient);
                hastaneDbContext.SaveChanges();
                return patient;
            }
        }
    }
}
