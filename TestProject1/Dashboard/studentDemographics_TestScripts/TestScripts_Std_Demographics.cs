using Commons.DTO_s.Dashboards.studentDemographics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Dashboard.studentDemographics_TestScripts
{
    [TestClass]
    public class TestScripts_Std_Demographics
    {

        [TestMethod]
        public void ValidInputValues(string type, string state, string companyId)
        {
            var eventDropData = ApiResponseHandler.EventDropRequest;
            Console.WriteLine("Valid All Input Values               :PASS");
            Assert.AreEqual(200, eventDropData.StatusCode, "The statusCode is not 200.");
        }
        [TestMethod]
        public void DummyResponse()
        {
            var eventDropData = ApiResponseHandler.EventDropRequest;
            Console.WriteLine("Valid All Input Values               :FAIL");
            Assert.IsTrue(eventDropData.Response == null, "Response is empty or null.");
        }
        [TestMethod]
        public void Error_Something(string type, string state, string companyId)
        {
            var eventDropData = ApiResponseHandler.EventDropRequest;
            Console.WriteLine("Something Went Wrong");
            Assert.AreEqual(200, eventDropData.StatusCode, "The statusCode is not 200.");
        }
    }
}
    