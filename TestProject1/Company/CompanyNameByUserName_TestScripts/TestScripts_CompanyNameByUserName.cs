using Commons.DTO_s.Company.CompanyConfigs;
using Commons.DTO_s.Company.CompanyNameByUserName;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Company.CompanyNameByUserName_TestScripts
{
    [TestClass]
    public class TestScripts_CompanyNameByUserName
    {
        [TestMethod]
        public void ValidResponse()
        {
            var CompanyNameByUserName_GetResponse = ApiResponse_CompanyNameByUserName.Sets_CompanyNameByUserName;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, CompanyNameByUserName_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var CompanyNameByUserName_GetResponse = ApiResponse_CompanyNameByUserName.Sets_CompanyNameByUserName;
            Console.WriteLine("Default Response                     :   PASS");
            Assert.AreEqual(200, CompanyNameByUserName_GetResponse.statusCode, "Unexpected status code.");
        }
    }
}