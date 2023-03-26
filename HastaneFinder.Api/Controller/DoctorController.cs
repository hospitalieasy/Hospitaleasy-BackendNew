using HastaneFinder.Business.Abstract;
using HastaneFinder.Business.Concrete;
using HastaneFinder.Entitiy;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HastaneFinder.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private IDoctorService _doctorService;

        public DoctorController()
        {
            _doctorService = new DoctorManager();
        }

        [HttpGet]
        public List<Doctor> Get()
        {
            return _doctorService.GetAllDoctors();
        }

        [HttpGet("{id}")]
        public Doctor Get(int id)
        {
            return _doctorService.GetDoctorById(id);
        }
        [HttpPost]

        public Doctor Post([FromBody] Doctor doctor)
        {
            return _doctorService.AddDoctor(doctor);
        }


        [HttpPut("{id}")]
        public Doctor Put(int id, [FromBody] Doctor doctor)
        {
            doctor.id = id;
            return _doctorService.UpdateDoctor(doctor);


        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            _doctorService.DeleteDoctorById(id);


        }
    }
}
