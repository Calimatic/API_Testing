using Commons.DTO_s.Notification.ClearAllNotification_Response;
using Commons.DTO_s.Notification.GetUserNotifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Notification.ClearAllNotification_TestScript
{
    [TestClass]
    public class TestScript_ClearAllNotification
    {
        [TestMethod]
        public void ValidResponse()
        {
            var ClearAllNotification_GetResponse = ApiResponse_ClearAllNotification.Sets_ClearAllNotification;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, ClearAllNotification_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var ClearAllNotification_GetResponse = ApiResponse_ClearAllNotification.Sets_ClearAllNotification;
            Console.WriteLine("Invalid Response              :   PASS");
            Assert.AreEqual(500, ClearAllNotification_GetResponse.statusCode, "Unexpected status code.");
        }
    }
}