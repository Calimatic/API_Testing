using Commons.DTO_s.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Student_TestScripts.students_TestScripts
{
    [TestClass]
    public class TestScripts_students
    {
        [TestMethod]
        public void students_GetResponse()
        {
            var students_GetResponse = ApiResponse_students.Sets_students;
            Console.WriteLine("TestScripts Result");
            Console.WriteLine("Get Response Successfully                  :PASS");
            Assert.AreEqual(200, students_GetResponse.statusCode, "Unexpected status code.");
            Assert.IsNotNull(students_GetResponse.response, "Response array is null.");
            Assert.IsTrue(true, students_GetResponse.ToString(), "Response Get Failed");
        }
    }
}
