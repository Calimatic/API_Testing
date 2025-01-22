using Commons.DTO_s.PaymentCommon;
using Commons.DTO_s.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.PaymentCommon_TestScripts.DuplicateUserName_TestScripts
{
    [TestClass]
    public class TestScripts_DuplicateUserName
    {
        [TestMethod]
        public void ValidInputValue(string username)
        {
            var getEnrollmentDropdown_GetResponse = ApiResponse_PaymentCommon.Sets_PaymentCommont;
            Console.WriteLine("TestScripts Result");
            Console.WriteLine("Get Response Successfully                     :PASS");
            Console.WriteLine($"Invalid '{username}' Input Value             :FAIL");
            Assert.AreEqual(200, getEnrollmentDropdown_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidInputValue(string username)
        {
            var getEnrollmentDropdown_GetResponse = ApiResponse_PaymentCommon.Sets_PaymentCommont;
            Console.WriteLine("TestScripts Result");
            Console.WriteLine($"Invalid '{username}' Input Value             :PASS");
            Console.WriteLine("Get Response Successfully                     :FAIL");
            Assert.IsFalse(getEnrollmentDropdown_GetResponse.response.response.isExist, "Expected isExist to be false initially.");
        }
        [TestMethod]
        public void SpecialCharacter_username(string username)
        {
            var getEnrollmentDropdown_GetResponse = ApiResponse_PaymentCommon.Sets_PaymentCommont;
            Console.WriteLine("TestScripts Result");
            Console.WriteLine($"Invalid '{username}' Input Value             :PASS");
            Console.WriteLine("Get Response Successfully                     :FAIL");
            Assert.IsFalse(getEnrollmentDropdown_GetResponse.response.response.isExist, "Expected isExist to be false initially.");
        }
        [TestMethod]
        public void ContainsAlphabet_franchises(string username)
        {
            var getEnrollmentDropdown_GetResponse = ApiResponse_PaymentCommon.Sets_PaymentCommont;
            Console.WriteLine("TestScripts Result");
            Console.WriteLine($"Invalid '{username}' Input Value             :PASS");
            Console.WriteLine("Get Response Successfully                     :FAIL");
            Assert.IsFalse(getEnrollmentDropdown_GetResponse.response.response.isExist, "Expected isExist to be false initially.");
        }
    }
}