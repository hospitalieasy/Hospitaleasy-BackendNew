using HastaneFinder.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneFinder.Business.Abstract
{
    public interface IDoctorService
    {
        List<Doctor> GetAllDoctors();

        Doctor GetDoctorById(int id);
        Doctor AddDoctor(Doctor doctor);
        Doctor UpdateDoctor(Doctor doctor);
        void DeleteDoctorById(int id);
    }
}
