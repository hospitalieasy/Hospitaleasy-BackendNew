using HastaneFinder.DataAcess.Abstract;
using HastaneFinder.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneFinder.DataAcess.Concrete
{
    public class TestResultRepository : ITestResultRepository
    {
        public TestResults AddTestResult(TestResults test)
        {
            using (var hastaneDbContext = new HastaneDbContext())
            {
                hastaneDbContext.TestResults.Add(test);
                hastaneDbContext.SaveChanges();
                return test;

            }
        }

        public void DeleteTestResultById(int id)
        {
            using (var hastaneDbContext = new HastaneDbContext())
            {
                var test = GetTestResultById(id);
                hastaneDbContext.TestResults.Remove(test);
                hastaneDbContext.SaveChanges();
            }
        }

        public List<TestResults> GetAllTestResults()
        {
            using (var HastaneDbContext = new HastaneDbContext())
            {
                return HastaneDbContext.TestResults.ToList();
            }
        }

        public TestResults GetTestResultById(int id)
        {
            using (var hastaneDbContext = new HastaneDbContext())
            {
                return hastaneDbContext.TestResults.Find(id);
            }
        }
    }
}
