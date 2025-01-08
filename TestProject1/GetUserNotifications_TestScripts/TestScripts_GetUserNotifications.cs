using Commons.DTO_s.Department.deleteDepartments;
using Commons.DTO_s.Notification.GetUserNotifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.GetUserNotifications_TestScripts
{
    [TestClass]
    public class TestScripts_GetUserNotifications
    {
        [TestMethod]
        public void ValidResponse()
        {
            var GetUserNotifications_GetResponse = ApiResponse_GetUserNotification.Sets_GetUserNotification;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, GetUserNotifications_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var GetUserNotifications_GetResponse = ApiResponse_GetUserNotification.Sets_GetUserNotification;
            Console.WriteLine("Invalid Response              :   PASS");
            Assert.AreEqual(500, GetUserNotifications_GetResponse.statusCode, "Unexpected status code.");
        }
    }
}
