using HastaneFinder.DataAcess.Abstract;
using HastaneFinder.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneFinder.DataAcess.Concrete
{
    public class DoctorRepository : IDoctorRepository
    {
        public Doctor AddDoctor(Doctor doctor)
        {
            using (var hastaneDbContext = new HastaneDbContext())
            {
                hastaneDbContext.Tbl_Doctor.Add(doctor);
                hastaneDbContext.SaveChanges();
                return doctor;

            }
        }

        public void DeleteDoctorById(int id)
        {
            using (var hastaneDbContext = new HastaneDbContext())
            {
                var doctor = GetDoctorById(id);
                hastaneDbContext.Tbl_Doctor.Remove(doctor);
                hastaneDbContext.SaveChanges();
            }
        }

        public List<Doctor> GetAllDoctors()
        {
            using (var HastaneDbContext = new HastaneDbContext())
            {
                return HastaneDbContext.Tbl_Doctor.ToList();
            }
        }

        public Doctor GetDoctorById(int id)
        {
            using (var hastaneDbContext = new HastaneDbContext())
            {
                return hastaneDbContext.Tbl_Doctor.Find(id);
            }
        }

        public Doctor UpdateDoctor(Doctor doctor)
        {
            using (var hastaneDbContext = new HastaneDbContext())
            {
                hastaneDbContext.Tbl_Doctor.Update(doctor);
                hastaneDbContext.SaveChanges();
                return doctor;
            }
        }
    }
}
