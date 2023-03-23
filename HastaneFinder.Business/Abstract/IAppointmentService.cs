using HastaneFinder.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneFinder.Business.Abstract
{
    public interface IAppointmentService
    {
        List<Appointment> GetAllAppointment();

        Appointment GetAppointmentById(int id);
        Appointment AddAppointment(Appointment app);
        Appointment UpdateAppointment(Appointment app);

        void DeleteAppointmentById(int id);
    }
}
