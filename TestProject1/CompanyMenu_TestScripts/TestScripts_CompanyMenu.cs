using Commons.DTO_s.Company.franchises;
using Commons.DTO_s.CompanyMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.CompanyMenu_TestScripts
{
    [TestClass]
    public class TestScripts_CompanyMenu
    {
        [TestMethod]
        public void ValidResponse()
        {
            var GetMenu_GetRespons = ApiResponse_CompanyMenu.sets_CompanyMenu;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, GetMenu_GetRespons.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var GetMenu_GetRespons = ApiResponse_CompanyMenu.sets_CompanyMenu;
            Console.WriteLine("Default Response                     :   PASS");
            Assert.AreEqual(200, GetMenu_GetRespons.statusCode, "Unexpected status code.");
        }
    }
}