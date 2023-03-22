using HastaneFinder.Business.Abstract;
using HastaneFinder.Business.Concrete;
using HastaneFinder.Entitiy;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HastaneFinder.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private IPatientService _patientService;

        public PatientController()
        {
            _patientService = new PatientManager();
        }

        [HttpGet]
        public List<Patient> Get()
        {
            return _patientService.GetAllPatients();
        }

        [HttpGet("{id}")]
        public Patient Get(int id)
        {
            return _patientService.GetPatientById(id);
        }
        [HttpPost]

        public Patient Post([FromBody] Patient patient)
        {
            return _patientService.AddPatient(patient);
        }


        [HttpPut]
        public Patient Put([FromBody] Patient patient)
        {

            return _patientService.UpdatePatient(patient);


        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            _patientService.DeletePatientById(id);


        }
    }
}
