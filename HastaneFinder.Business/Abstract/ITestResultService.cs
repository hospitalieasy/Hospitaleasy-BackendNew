using HastaneFinder.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneFinder.Business.Abstract
{
    public interface ITestResultService
    {
        List<TestResults> GetAllTestResults();

        TestResults GetTestResultById(int id);
        TestResults AddTestResult(TestResults test);
        void DeleteTestResultById(int id);
    }
}
