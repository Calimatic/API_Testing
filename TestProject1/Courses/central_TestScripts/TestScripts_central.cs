using Commons.DTO_s.Courses.central;
using Commons.DTO_s.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Courses.central_TestScripts
{
    [TestClass]
    public class TestScripts_central
    {
        [TestMethod]
        public void GetResponse_Successfully()
        {
            var central_GetResponse = ApiResponse_central.Sets_central;
            Console.WriteLine("Get All Response Successfully                :   PASS");
            Assert.AreEqual(200, central_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void GetResponse_Failed() 
        {
            var central_GetResponse = ApiResponse_central.Sets_central;
            Console.WriteLine("Get All Response Successfully                :   PASS");
            Assert.AreEqual(200, central_GetResponse.statusCode, "Unexpected status code.");
        }
    }
}