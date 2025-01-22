using Commons.DTO_s.Course_Category.getCourseCategoriesByTypeId;
using Commons.DTO_s.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.CourseCategory_TestScripts.getCourseCategoriesByTypeId_TestScripts
{
    [TestClass]
    public class TestScripts_getCourseCategoriesByTypeId
    {
        [TestMethod]
        public void Default_Response()
        {
            var getCourseCategoriesByTypeId_GetResponse = ApiResponse_getCourseCategoriesByTypeId.Sets_getCourseCategoriesByTypeId;
            Console.WriteLine("\nGet All Default Value                :   PASS");
            Assert.IsNotNull(getCourseCategoriesByTypeId_GetResponse.response, "Response array is null.");

        }
        [TestMethod]
        public void ValidReponse()
        {
            var getCourseCategoriesByTypeId_GetResponse = ApiResponse_getCourseCategoriesByTypeId.Sets_getCourseCategoriesByTypeId;
            Console.WriteLine("\nValid Response                      :   PASS");
            Assert.AreEqual(200, getCourseCategoriesByTypeId_GetResponse.statusCode, "Unexpected status code.");
        }
    }
}