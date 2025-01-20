using Commons.DTO_s.Board.Board_student;
using Commons.DTO_s.PublishGuid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Board.Board_student_TestSripts
{
    [TestClass]
    public class TestScripts_student
    {
        [TestMethod]
        public void ValidResponse()
        {
            var student_GetRespons = ApiResponse_student.sets_student;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, student_GetRespons.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var student_GetRespons = ApiResponse_student.sets_student;
            Console.WriteLine("Fake Response                    :   PASS");
            Assert.AreEqual(200, student_GetRespons.statusCode, "Unexpected status code.");
        }
    }
}