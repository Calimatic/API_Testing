using Commons.DTO_s.Company.CompanyNameByUserName;
using Commons.DTO_s.Company.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Company.Menus_TestScripts
{
    [TestClass]
    public class TestScripts_Menus
    {
        [TestMethod]
        public void ValidResponse()
        {
            var CompanyNameByUserName_GetResponse = ApiResponse_Menus.Sets_Menus;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, CompanyNameByUserName_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var CompanyNameByUserName_GetResponse = ApiResponse_Menus.Sets_Menus;
            Console.WriteLine("Default Response                     :   PASS");
            Assert.AreEqual(200, CompanyNameByUserName_GetResponse.statusCode, "Unexpected status code.");
        }
    }
}