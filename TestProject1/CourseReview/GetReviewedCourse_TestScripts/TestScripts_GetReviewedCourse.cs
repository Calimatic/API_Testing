using Commons.DTO_s.CourseReview.GetReviewedCourse;
using Commons.DTO_s.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.CourseReview.GetReviewedCourse_TestScripts
{
    [TestClass]
    public class TestScripts_GetReviewedCourse
    {
        [TestMethod]
        public void ValidResponse()
        {
            var GetReviewedCourse_GetResponse = ApiResponse_GetReviewCourse.Sets_GetReviewCourse;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, GetReviewedCourse_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var GetReviewedCourse_GetResponse = ApiResponse_GetReviewCourse.Sets_GetReviewCourse;
            Console.WriteLine("Get Response Successfully            :   FAIL");
            Assert.AreEqual(200, GetReviewedCourse_GetResponse.statusCode, "Unexpected status code.");
        }
    }
}
