using Commons.DTO_s.PaymentCommon.GetAllEnrolledCourses;
using Commons.DTO_s.PaymentCommon.GetPortalEnrolledCourses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.PaymentCommon_TestScripts.GetPortalEnrolledCourses_TestScripts
{
    [TestClass]
    public class TestScripts_GetPortalEnrolledCourses
    {
        [TestMethod]
        public void GetPortalEnrolledCourses_GetResponse()
        {
            var GetPortalEnrolledCourses_GetResponse = ApiResponse_GetPortalEnrolledCourses.Sets_GetPortalEnrolledCourses;
            Console.WriteLine("TestScripts Result");
            Console.WriteLine("Get Response Successfully                                       :PASS");
            Assert.AreEqual(200, GetPortalEnrolledCourses_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void GetPortalEnrolledCourses_ResponseFailed()
        {
            var GetPortalEnrolledCourses_GetResponse = ApiResponse_GetPortalEnrolledCourses.Sets_GetPortalEnrolledCourses;
            Console.WriteLine("TestScripts Result");
            Console.WriteLine("Get Response Successfully                                       :FAIL");
            Assert.AreEqual(200, GetPortalEnrolledCourses_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void AlphabetCharacter_GetPortalEnrolledCourses()
        {
            var GetPortalEnrolledCourses_GetResponse = ApiResponse_GetPortalEnrolledCourses.Sets_GetPortalEnrolledCourses;
            Console.WriteLine("TestScripts Result");
            Console.WriteLine("Get Response Successfully                                       :FAIL");
            Assert.AreEqual(200, GetPortalEnrolledCourses_GetResponse.statusCode, "Unexpected status code.");
        }
    }
}
