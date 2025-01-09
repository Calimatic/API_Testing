using Commons.DTO_s.Notification.GetUserActivityLogs;
using Commons.DTO_s.Notification.VisitNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestProject1.Notification.GetUserActivityLogs_TestScripts
{
    [TestClass]
    public class TestScripts_GetUserActivityLogs
    {
        [TestMethod]
        public void ValidInputValues()
        {
            var GetUserActivityLogs_GetResponse = ApiResponse_GetUserActivityLogs.Sets_GetUserActivityLogs;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, GetUserActivityLogs_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var GetUserActivityLogs_GetResponse = ApiResponse_GetUserActivityLogs.Sets_GetUserActivityLogs;
            Console.WriteLine("Invalid Response            :   PASS");
            Assert.AreEqual(500, GetUserActivityLogs_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void ContainsAlphabetValue(string onlyTopFifteen)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Alphabet Character used in 'onlyTopFifteen' input values           :       PASS");
            Console.WriteLine("Special Characters used in 'onlyTopFifteen' input values           :       FAIL");
            Console.WriteLine("Valid All Input Values                                             :       FAIL");
            Console.WriteLine("'onlyTopFifteen' is null or empty                                  :       FAIL");
            Assert.IsTrue(ContainAlphabet_Inputvalues(onlyTopFifteen), "Alphabet Character used.");
        }
        [TestMethod]
        public void SpecialCharacter(string onlyTopFifteen)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Special Characters used in 'notificationId' input values           :       PASS");
            Console.WriteLine("Alphabet Character used in 'notificationId' input values           :       FAIL");
            Console.WriteLine("Valid All Input Values                                             :       FAIL");
            Console.WriteLine("'notificationId' is null or empty                                  :       FAIL");
            Assert.IsTrue(ContainsSpecialCharacters(onlyTopFifteen), "Special Character used.");
        }
        public void Null_Values(string onlyTopFifteen)
        {
            // Check if the input is null or empty
            if (string.IsNullOrEmpty(onlyTopFifteen))
            {
                Console.WriteLine("\nTest Scripts Results: ");
                Console.WriteLine("'notificationId' is null or empty                                  :       PASS");
                Console.WriteLine("Special Characters used in 'notificationId' input values           :       FAIL");
                Console.WriteLine("Alphabet Character used in 'notificationId' input values           :       FAIL");
                Console.WriteLine("Valid All Input Values                                             :       FAIL");
                Assert.IsTrue(ContainNullInputvalues(onlyTopFifteen), "Null 'Types' or 'franchisesIds'");
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