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
    public class AppointmentManager : IAppointmentService
    {
        private readonly IAppointmentRepository repo;

        public AppointmentManager()
        {
            repo = new AppRepository();
        }

        public Appointment AddAppointment(Appointment app)
        {
           return repo.AddAppointment(app);
        }

        public void DeleteAppointmentById(int id)
        {
            repo.DeleteAppointmentById(id);
        }

        public List<Appointment> GetAllAppointment()
        {
            return repo.GetAllAppointment();
        }

        public Appointment GetAppointmentById(int id)
        {
            return repo.GetAppointmentById(id);
        }

        public Appointment UpdateAppointment(Appointment app)
        {
           return repo.UpdateAppointment(app);
        }
    }
}
