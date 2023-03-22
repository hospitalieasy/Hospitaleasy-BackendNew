using HastaneFinder.Business.Abstract;
using HastaneFinder.DataAcess.Abstract;
using HastaneFinder.DataAcess.Concrete;
using HastaneFinder.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneFinder.Business.Concrete
{

    public class PatientManager : IPatientService
    {
        private readonly IPatientRepository patientRepository;

        public PatientManager()
        {
            patientRepository = new PatientRepository();    
        }
        public Patient AddPatient(Patient patient)
        {
            return patientRepository.AddPatient(patient);
        }

        public void DeletePatientById(int id)
        {
           patientRepository.DeletePatientById(id);
        }

        public List<Patient> GetAllPatients()
        {
            return patientRepository.GetAllPatients();
        }

        public Patient GetPatientById(int id)
        {
            return patientRepository.GetPatientById(id);
        }

        public Patient UpdatePatient(Patient patient)
        {
            return patientRepository.UpdatePatient(patient);
        }
    }
}
