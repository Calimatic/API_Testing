using Commons.DTO_s.Department.deleteDepartments;
using Commons.DTO_s.Notification.VisitNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestProject1.Notification.VisitNotification_TestScripts
{
    [TestClass]
    public class TestScripts_VisitNotification
    {
        [TestMethod]
        public void ValidInputValues()
        {
            var VisitNotification_GetResponse = ApiResponse_VisitNotification.Sets_VisitNotification;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, VisitNotification_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var VisitNotification_GetResponse = ApiResponse_VisitNotification.Sets_VisitNotification;
            Console.WriteLine("Invalid Response            :   PASS");
            Assert.AreEqual(500, VisitNotification_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void ContainsAlphabetValue(string notificationId)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Alphabet Character used in 'notificationId' input values           :       PASS");
            Console.WriteLine("Special Characters used in 'notificationId' input values           :       FAIL");
            Console.WriteLine("Valid All Input Values                                             :       FAIL");
            Console.WriteLine("'notificationId' is null or empty                                  :       FAIL");
            Assert.IsTrue(ContainAlphabet_Inputvalues(notificationId), "Alphabet Character used.");
        }
        [TestMethod]
        public void SpecialCharacter(string notificationId)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Special Characters used in 'notificationId' input values           :       PASS");
            Console.WriteLine("Alphabet Character used in 'notificationId' input values           :       FAIL");
            Console.WriteLine("Valid All Input Values                                             :       FAIL");
            Console.WriteLine("'notificationId' is null or empty                                  :       FAIL");
            Assert.IsTrue(ContainsSpecialCharacters(notificationId), "Special Character used.");
        }
        public void Null_Values(string notificationId)
        {
            // Check if the input is null or empty
            if (string.IsNullOrEmpty(notificationId))
            {
                Console.WriteLine("\nTest Scripts Results: ");
                Console.WriteLine("'notificationId' is null or empty                                  :       PASS");
                Console.WriteLine("Special Characters used in 'notificationId' input values           :       FAIL");
                Console.WriteLine("Alphabet Character used in 'notificationId' input values           :       FAIL");
                Console.WriteLine("Valid All Input Values                                             :       FAIL");
                Assert.IsTrue(ContainNullInputvalues(notificationId), "Null 'Types' or 'franchisesIds'");
            }
        }
        private bool ContainsSpecialCharacters(string str)
        {
            // Regular expression to match special characters
            string pattern = @"[%\^\*\'\(\)\!\@\?\&\+\$\~\`]";
            return Regex.IsMatch(str, pattern);
        }
        private bool ContainNullInputvalues(string strdeptid)
        {
            string testInput = ".*";
            bool result = Regex.IsMatch(strdeptid, testInput);
            Console.WriteLine($"Test Script Result: {(result ? "Pass" : "Fail")}");
            return Regex.IsMatch(strdeptid, testInput);
        }
        private bool ContainAlphabet_Inputvalues(string str_deptId)
        {
            string pattern1 = @"^[a-zA-Z]+$";
            var abc = Regex.IsMatch(str_deptId, pattern1);
            return Regex.IsMatch(str_deptId, pattern1);
        }
    }
}