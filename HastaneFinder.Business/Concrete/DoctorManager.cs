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
    public class DoctorManager : IDoctorService
    {
        private readonly IDoctorRepository doctorRepository;

        public DoctorManager()
        {
            doctorRepository = new DoctorRepository();
        }
        public Doctor AddDoctor(Doctor doctor)
        {
           return doctorRepository.AddDoctor(doctor);
        }

        public void DeleteDoctorById(int id)
        {
             doctorRepository.DeleteDoctorById(id);
        }

        public List<Doctor> GetAllDoctors()
        {
            return doctorRepository.GetAllDoctors();
        }

        public Doctor GetDoctorById(int id)
        {
            if (id > 0)
            {
                return doctorRepository.GetDoctorById(id);
            }
            throw new Exception("Id cannot be less than zero...");
        }

        public Doctor UpdateDoctor(Doctor doctor)
        {
            return doctorRepository.UpdateDoctor(doctor);
        }
    }
}
