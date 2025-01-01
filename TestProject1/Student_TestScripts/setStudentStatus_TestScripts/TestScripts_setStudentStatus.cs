using Commons.DTO_s.Dashboards.Calender;
using Commons.DTO_s.Dashboards.Partner_Enrollment;
using Commons.DTO_s.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Student_TestScripts.setStudentStatus_TestScripts
{
    [TestClass]
    public class TestScripts_setStudentStatus
    {
        [TestMethod]
        public void ValidInputValues()
        {
            var getEnrollmentDropdown_GetResponse = ApiResponse_setStudentstatus.Sets_setstudentsStatus;
            Console.WriteLine("TestScripts Result");
            Console.WriteLine("Get Response Successfully                  :PASS");
            Console.WriteLine("Alphabet Value used in studentIds          :FAIL");
            Console.WriteLine("Special Character used in studentIds       :FAIL");
            Console.WriteLine("Null activateStudent input value           :FAIL");
            Console.WriteLine("Invalid studentIds                         :FAIL");
            Assert.AreEqual(200, getEnrollmentDropdown_GetResponse.statusCode, "Unexpected status code.");
            Assert.IsNotNull(getEnrollmentDropdown_GetResponse.response, "Response array is null.");
            Assert.IsTrue(true, getEnrollmentDropdown_GetResponse.ToString(), "Response Get Failed");
        }
        [TestMethod]
        public void ContainsAlphabet_studentIds(string studentIds)
        {
            var errorHandler_setStudentstatus = ErrorHandler_setStudentstatus.Error_setstudentsStatus;
            Console.WriteLine("TestScripts Result");
            Console.WriteLine("Alphabet Value used in studentIds          :PASS");
            Console.WriteLine("Get Response Successfully                  :FAIL");
            Console.WriteLine("Special Character used in studentIds       :FAIL");
            Console.WriteLine("Null activateStudent input value           :FAIL");
            Console.WriteLine("Invalid studentIds                         :FAIL");
            Assert.AreEqual($"The input string '{studentIds}' was not in a correct format.", errorHandler_setStudentstatus.Message, "The Message field does not match the expected value.");
        }
        [TestMethod]
        public void SpecialCharacter_studentIds(string studentIds)
        {
            var errorHandler_setStudentstatus = ErrorHandler_setStudentstatus.Error_setstudentsStatus;
            Console.WriteLine("TestScripts Result");
            Console.WriteLine("Special Character used in studentIds       :PASS");
            Console.WriteLine("Get Response Successfully                  :FAIL");
            Console.WriteLine("Alphabet Value used in studentIds          :FAIL");
            Console.WriteLine("Null activateStudent input value           :FAIL");
            Console.WriteLine("Invalid studentIds                         :FAIL");
            Assert.AreEqual($"The input string '{studentIds}' was not in a correct format.", errorHandler_setStudentstatus.Message, "The Message field does not match the expected value.");
        }
        [TestMethod]
        public void NullactivateStudent_Values()
        {
            var errorHandler_setStudentstatus = ErrorHandler_setStudentstatus.Error_setstudentsStatus;
            Console.WriteLine("TestScripts Result");
            Console.WriteLine("Null 'activateStudent' input value         :PASS");
            Console.WriteLine("Special Character used in studentIds       :FAIL");
            Console.WriteLine("Get Response Successfully                  :FAIL");
            Console.WriteLine("Alphabet Value used in studentIds          :FAIL");
            Console.WriteLine("Invalid studentIds                         :FAIL");
            Assert.AreEqual("Object reference not set to an instance of an object.", errorHandler_setStudentstatus.Message, "Unexpected error message.");
        }
        [TestMethod]
        public void Invalid_studentIds(string studentIds)
        {
            var errorHandler_setStudentstatus = ErrorHandler_setStudentstatus.Error_setstudentsStatus;
            Console.WriteLine("Invalid studentIds                         :PASS");
            Console.WriteLine("Special Character used in studentIds       :FAIL");
            Console.WriteLine("Get Response Successfully                  :FAIL");
            Console.WriteLine("Alphabet Value used in studentIds          :FAIL");
            Console.WriteLine("Invalid studentIds                         :FAIL");
            Assert.AreEqual("Value was either too large or too small for an Int32.", errorHandler_setStudentstatus.Message, "The Message field does not match the expected value.");
        }   
    }
}
