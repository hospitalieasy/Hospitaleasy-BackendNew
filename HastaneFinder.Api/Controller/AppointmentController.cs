using HastaneFinder.Business.Abstract;
using HastaneFinder.Business.Concrete;
using HastaneFinder.Entitiy;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HastaneFinder.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private IAppointmentService _appService;

        public AppointmentController()
        {
            _appService = new AppointmentManager();
        }

        [HttpGet]
        public List<Appointment> Get()
        {
            return _appService.GetAllAppointment();
        }

        [HttpGet("{id}")]
        public Appointment Get(int id)
        {
            return _appService.GetAppointmentById(id);
        }
        [HttpPost]

        public Appointment Post([FromBody] Appointment app)
        {
            return _appService.AddAppointment(app);
        }


        [HttpPut("{id}")]
        public Appointment Put(int id,[FromBody] Appointment app)
        {
            app.AppId = id;
            return _appService.UpdateAppointment(app);


        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            _appService.DeleteAppointmentById(id);


        }
    }
}
