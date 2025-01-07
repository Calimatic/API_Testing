using Commons.DTO_s.CourseReview.GetReviewedCourse;
using Commons.DTO_s.CourseType.list;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.CourseReview.IsReviewAddedByUser_TestScripts
{
    [TestClass]
    public class TestScripts_IsReviewAddedByUser
    {
        [TestMethod]
        public void ValidResponse()
        {
            var list_GetResponse = ApiResponse_course_list.Sets_course_list;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, list_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var list_GetResponse = ApiResponse_course_list.Sets_course_list;
            Console.WriteLine("Get Response Successfully            :   FAIL");
            Assert.AreEqual(200, list_GetResponse.statusCode, "Unexpected status code.");
        }
    }
}
