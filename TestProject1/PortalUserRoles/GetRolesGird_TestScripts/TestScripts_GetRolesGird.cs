using Commons.DTO_s.PortalUserRoles.GetRolesGird;
using Commons.DTO_s.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.PortalUserRoles.GetRolesGird_TestScripts
{
    [TestClass]
    public class TestScripts_GetRolesGird
    {
        [TestMethod]
        public void ValidResponse()
        {
            var GetRolesGird_GetRespons = ApiResponse_GetRolesGird.sets_GetRolesGird;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, GetRolesGird_GetRespons.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var GetRolesGird_GetRespons = ApiResponse_GetRolesGird.sets_GetRolesGird;
            Console.WriteLine("Invalid Response                    :   PASS");
            Assert.AreEqual(200, GetRolesGird_GetRespons.statusCode, "Unexpected status code.");
        }
    }
}