using Commons.DTO_s.PaymentCommon.GetAllEnrolledCourses;
using Commons.DTO_s.PaymentCommon.GetTransactionConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.PaymentCommon_TestScripts.GetAllEnrolledCourses_TestScripts
{
    [TestClass]
    public class TestScripts_GetAllEnrolledCourses
    {
        [TestMethod]
        public void GetAllEnrolledCourses_GetResponse()
        {
            var GetAllEnrolledCourses_GetResponse = ApiResponse_GetAllEnrolledCourses.Sets_GetAllEnrolledCourses;
            Console.WriteLine("TestScripts Result");
            Console.WriteLine("Get Response Successfully                                       :PASS");
            Assert.AreEqual(200, GetAllEnrolledCourses_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void GetAllEnrolledCourses_ResponseFailed()
        {
            var GetAllEnrolledCourses_GetResponse = ApiResponse_GetAllEnrolledCourses.Sets_GetAllEnrolledCourses;
            Console.WriteLine("TestScripts Result");
            Console.WriteLine("Get Response Successfully                                       :FAIL");
            Assert.AreEqual(200, GetAllEnrolledCourses_GetResponse.statusCode, "Unexpected status code.");
        }
    }
}
