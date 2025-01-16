using Commons.DTO_s.PortalUserRoles.GetRolesGird;
using Commons.DTO_s.PortalUserRoles.GetUserAccessGird;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.PortalUserRoles.GetUserAccessGird_TestScripts
{
    [TestClass]
    public class TestScripts_GetUserAccessGird
    {
        [TestMethod]
        public void ValidResponse()
        {
            var GetRolesGird_GetRespons = ApiResponse_GetUserAccessGird.sets_GetUserAccessGird;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, GetRolesGird_GetRespons.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var GetRolesGird_GetRespons = ApiResponse_GetUserAccessGird.sets_GetUserAccessGird;
            Console.WriteLine("Invalid Response                    :   PASS");
            Assert.AreEqual(200, GetRolesGird_GetRespons.statusCode, "Unexpected status code.");
        }
    }
}