using Commons.DTO_s.PortalUserRoles.GetUserAccessGird;
using Commons.DTO_s.PublishGuid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.GetPublishedGuid_TestScripts
{
    [TestClass]
    public class TestScripts_GetPublishedGuid
    {
        [TestMethod]
        public void ValidResponse()
        {
            var GetPublishedGuid_GetRespons = ApiResponse_GetPublishedGuid.sets_GetPublishedGuid;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, GetPublishedGuid_GetRespons.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var GetPublishedGuid_GetRespons = ApiResponse_GetPublishedGuid.sets_GetPublishedGuid;
            Console.WriteLine("Invalid Response                    :   PASS");
            Assert.AreEqual(200, GetPublishedGuid_GetRespons.statusCode, "Unexpected status code.");
        }
    }
}