using Commons.DTO_s.Notification.ClearAllNotification_Response;
using Commons.DTO_s.Notification.VisitNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Notification.GetNotificationCounts_TestScripts
{
    [TestClass]
    public class TestScripts_GetNoticationCounts
    {
        [TestMethod]
        public void ValidResponse()
        {
            var GetNoticationCounts_GetResponse = ApiResponse_GetNoticationCounts.Sets_GetNoticationCounts;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, GetNoticationCounts_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var GetNoticationCounts_GetResponse = ApiResponse_GetNoticationCounts.Sets_GetNoticationCounts;
            Console.WriteLine("Invalid Response            :   PASS");
            Assert.AreEqual(500, GetNoticationCounts_GetResponse.statusCode, "Unexpected status code.");
        }
    }
}