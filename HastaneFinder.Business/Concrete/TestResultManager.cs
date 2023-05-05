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
    public class TestResultManager : ITestResultService
    {
        private readonly ITestResultRepository repo;

        public TestResultManager()
        {
            repo = new TestResultRepository();
        }

        public TestResults AddTestResult(TestResults test)
        {
            return repo.AddTestResult(test);
        }

        public void DeleteTestResultById(int id)
        {
           repo.DeleteTestResultById(id);
        }

        public List<TestResults> GetAllTestResults()
        {
            return repo.GetAllTestResults();
        }

        public TestResults GetTestResultById(int id)
        {
            return repo.GetTestResultById(id);
        }
    }
}
