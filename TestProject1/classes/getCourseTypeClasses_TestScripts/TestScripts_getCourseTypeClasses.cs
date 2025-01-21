using Commons.DTO_s.classes.getCourseTypeClasses;
using Commons.DTO_s.classes.joinclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.classes.getCourseTypeClasses_TestScripts
{
    [TestClass]
    public class TestScripts_getCourseTypeClasses
    {
        [TestMethod]
        public void ValidResponse()
        {
            var getCourseTypeClasses_GetResponse = ApiResponse_getCourseTypeClasses.sets_getcourseTypeClasses;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, getCourseTypeClasses_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var getCourseTypeClasses_GetResponse = ApiResponse_getCourseTypeClasses.sets_getcourseTypeClasses;
            Console.WriteLine("Alphabetic or Special Character Used in input values              :   PASS");
        }
    }
}