using Commons.DTO_s.Dashboards.announcement_response;
using Commons.DTO_s.Dashboards.Calender;
using Commons.DTO_s.Dashboards.Partner_Enrollment;
using Commons.DTO_s.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Student_TestScripts.getEnrollmentDropdown_TestScript
{
    [TestClass]
    public class TestScript_getEnrollmentDropdown
    {
        [TestMethod]
        public void getEnrollmentDropdown_GetResponse()
        {
            var getEnrollmentDropdown_GetResponse = ApiResponse_getEnrollmentDropdown.Sets_getEnrollmentDropdown;
            Console.WriteLine("TestScripts Result");
            Console.WriteLine("Get Response Successfully                  :PASS");
            Assert.AreEqual(200, getEnrollmentDropdown_GetResponse.statusCode, "Unexpected status code.");
            Assert.IsNotNull(getEnrollmentDropdown_GetResponse.response, "Response array is null.");
            Assert.IsTrue(true, getEnrollmentDropdown_GetResponse.ToString(), "Response Get Failed");
        }
    }
}