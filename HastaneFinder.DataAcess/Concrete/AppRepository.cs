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
    public class AppRepository : IAppointmentRepository
    {
        public Appointment AddAppointment(Appointment app)
        {
            using (var hastaneDbContext = new HastaneDbContext())
            {
                hastaneDbContext.Appointments.Add(app);
                hastaneDbContext.SaveChanges();
                return app;

            }
        }

       public void DeleteAppointmentById(int id)
        {
            using (var hastaneDbContext = new HastaneDbContext())
            {
                var app = GetAppointmentById(id);
                hastaneDbContext.Appointments.Remove(app);
                hastaneDbContext.SaveChanges();
            }
        }

        public List<Appointment> GetAllAppointment()
        {
            using (var HastaneDbContext = new HastaneDbContext())
            {
                return HastaneDbContext.Appointments.ToList();
            }
        }

        public Appointment GetAppointmentById(int id)
        {
            using (var hastaneDbContext = new HastaneDbContext())
            {
                return hastaneDbContext.Appointments.Find(id);
            }
        }

        public Appointment UpdateAppointment(Appointment app)
        {
            using (var hastaneDbContext = new HastaneDbContext())
            {
                hastaneDbContext.Appointments.Update(app);
                hastaneDbContext.SaveChanges();
                return app;
            }
        }
    }
}
