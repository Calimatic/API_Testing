using Commons.DTO_s.CourseReview.GetReviewedCourse;
using Commons.DTO_s.Department.getDepartments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Department.getDepartment_TestScripts
{
    [TestClass]
    public class TestScripts_getDepartment
    {
        [TestMethod]
        public void ValidResponse()
        {
            var getDepartment_GetResponse = ApiResponse_Root_getDepartment.Sets_getDepartment;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, getDepartment_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var getDepartment_GetResponse = ApiResponse_Root_getDepartment.Sets_getDepartment;
            Console.WriteLine("Get Response Successfully            :   FAIL");
            Assert.AreEqual(200, getDepartment_GetResponse.statusCode, "Unexpected status code.");
        }
    }
}
