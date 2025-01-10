using Commons.DTO_s.Company.CompanyConfigs;
using Commons.DTO_s.Notification.GetUserActivityLogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestProject1.Company.CompanyConfigs_TestScripts
{
    [TestClass]
    public class TestScripts_CompanyConfigs
    {
        [TestMethod]
        public void ValidResponse()
        {
            var CompanyConfigs_GetResponse = ApiResponse_CompanyConfigs.Sets_CompanyConfigs;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, CompanyConfigs_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var CompanyConfigs_GetResponse = ApiResponse_CompanyConfigs.Sets_CompanyConfigs;
            Console.WriteLine("Default Response                     :   PASS");
            Assert.AreEqual(200, CompanyConfigs_GetResponse.statusCode, "Unexpected status code.");
        }
    }
}