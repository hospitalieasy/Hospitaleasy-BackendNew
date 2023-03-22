using HastaneFinder.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneFinder.DataAcess.Abstract
{
    public interface IPatientRepository
    {
        List<Patient> GetAllPatients();

        Patient GetPatientById(int id);
        Patient AddPatient(Patient patient);
        Patient UpdatePatient(Patient patient);
        void DeletePatientById(int id);
    }
}
