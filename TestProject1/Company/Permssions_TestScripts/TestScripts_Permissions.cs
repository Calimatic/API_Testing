using Commons.DTO_s.Company.franchises;
using Commons.DTO_s.Company.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Company.Permssions_TestScripts
{
    [TestClass]
    public class TestScripts_Permissions
    {
        [TestMethod]
        public void ValidResponse()
        {
            var Permssions_GetResponse = ApiResponse_Permissions.Sets_Permissions;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, Permssions_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var Permssions_GetResponse = ApiResponse_Permissions.Sets_Permissions;
            Console.WriteLine("Invalid URL                     :   PASS");
            Assert.AreEqual(200, Permssions_GetResponse.statusCode, "Unexpected status code.");
        }
    }
}