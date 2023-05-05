using HastaneFinder.Business.Abstract;
using HastaneFinder.Business.Concrete;
using HastaneFinder.Entitiy;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HastaneFinder.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestResultController : ControllerBase
    {
        private ITestResultService _testService;

        public TestResultController()
        {
            _testService = new TestResultManager();
        }

        [HttpGet]
        public List<TestResults> Get()
        {
            return _testService.GetAllTestResults();
        }

        [HttpGet("{id}")]
        public TestResults Get(int id)
        {
            return _testService.GetTestResultById(id);
        }
        [HttpPost]

        public TestResults Post([FromBody] TestResults test)
        {
            return _testService.AddTestResult(test);
        }


     
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            _testService.DeleteTestResultById(id);

        }
    }
}
