using Commons.DTO_s.CompanyMenu;
using Commons.DTO_s.EventType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.EventType_list
{
    [TestClass]
    public class TestScripts_GetMenus
    {
        [TestMethod]
        public void ValidResponse()
        {
            var GetMenu_GetRespons = ApiResponse_EventType_list.sets_EventType_list;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, GetMenu_GetRespons.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var GetMenu_GetRespons = ApiResponse_EventType_list.sets_EventType_list;
            Console.WriteLine("Default Response                     :   PASS");
            Assert.AreEqual(200, GetMenu_GetRespons.statusCode, "Unexpected status code.");
        }
    }
}