using Commons.DTO_s.Company.CompanyNameByUserName;
using Commons.DTO_s.Company.franchises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Company.franchises_TestScripts
{
    public class TestScripts_franchises
    {
        [TestMethod]
        public void ValidResponse()
        {
            var franchises_GetResponse = ApiResponse_franchises.Sets_franchises;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, franchises_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var franchises_GetResponse = ApiResponse_franchises.Sets_franchises;
            Console.WriteLine("Default Response                     :   PASS");
            Assert.AreEqual(200, franchises_GetResponse.statusCode, "Unexpected status code.");
        }
    }
}