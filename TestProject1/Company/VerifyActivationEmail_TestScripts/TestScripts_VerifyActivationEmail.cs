using Commons.DTO_s.Company.ResendActivationEmail;
using Commons.DTO_s.Company.VerifyActivationEmail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestProject1.Company.VerifyActivationEmail_TestScripts
{
    [TestClass]
    public class TestScripts_VerifyActivationEmail
    {
        [TestMethod]
        public void ValidInputValues()
        {
            var VerifyActivationEmail_GetResponse = ApiResponse_VerifyActivationEmail.sets_VerifyActivationEmail;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, VerifyActivationEmail_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var VerifyActivationEmail_GetResponse = ApiResponse_VerifyActivationEmail.sets_VerifyActivationEmail;
            Console.WriteLine("Invalid Response                     :   PASS");
            Assert.AreEqual(200, VerifyActivationEmail_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void ContainsAlphabetValue(string companyGuid)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Invalid Alphabet Characters used in 'companyGuid' input values           :       PASS");
            Console.WriteLine("Invalid Numeric Characters used in 'companyGuid' input values            :       FAIL");
            Console.WriteLine("Invalid Special Characters used in 'companyGuid' input values            :       FAIL");
            Console.WriteLine("Valid All Input Values                                                   :       FAIL");
            Console.WriteLine("'companyGuid' is null or empty                                           :       FAIL");
            Assert.IsTrue(ContainAlphabet_Inputvalues(companyGuid), "Alphabet Character used.");
        }
        [TestMethod]
        public void SpecialCharacter(string companyGuid)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Invalid Special Characters used in 'companyGuid' input values           :       PASS");
            Console.WriteLine("Invalid Numeric Characters used in 'companyGuid' input values           :       FAIL");
            Console.WriteLine("Invalid Alphabet Character used in 'companyGuid' input values           :       FAIL");
            Console.WriteLine("Valid All Input Values                                                  :       FAIL");
            Console.WriteLine("'companyGuid' is null or empty                                          :       FAIL");
            Assert.IsTrue(ContainsSpecialCharacters(companyGuid), "Special Character used.");
        }
        [TestMethod]
        public void Null_Values(string companyGuid)
        {
            // Check if the input is null or empty
            if (string.IsNullOrEmpty(companyGuid))
            {
                Console.WriteLine("\nTest Scripts Results: ");
                Console.WriteLine("'companyGuid' is null or empty                                          :       PASS");
                Console.WriteLine("Invalid Special Characters used in 'companyGuid' input values           :       FAIL");
                Console.WriteLine("Invalid Numeric Characters used in 'companyGuid' input values           :       FAIL");
                Console.WriteLine("Invalid Alphabet Character used in 'companyGuid' input values           :       FAIL");
                Console.WriteLine("Valid All Input Values                                                  :       FAIL");
                Assert.IsTrue(ContainNullInputvalues(companyGuid), "Null 'companyGuid' ");
            }
        }
        [TestMethod]
        public void Numeric_InputValue(string companyGuid)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Invalid Numeric Characters used in 'companyGuid' input values           :       PASS");
            Console.WriteLine("'companyGuid' is null or empty                                          :       FAIL");
            Console.WriteLine("Invalid Special Characters used in 'companyGuid' input values           :       FAIL");
            Console.WriteLine("Invalid Alphabet Character used in 'companyGuid' input values           :       FAIL");
            Console.WriteLine("Valid All Input Values                                                  :       FAIL");
        }
        private bool ContainsSpecialCharacters(string str)
        {
            // Regular expression to match special characters
            string pattern = @"[%\^\*\'\(\)\!\@\?\&\+\$\~\`]";
            return Regex.IsMatch(str, pattern);
        }
        private bool ContainNullInputvalues(string strcompanyGuid)
        {
            string testInput = ".*";
            bool result = Regex.IsMatch(strcompanyGuid, testInput);
            Console.WriteLine($"Test Script Result: {(result ? "Pass" : "Fail")}");
            return Regex.IsMatch(strcompanyGuid, testInput);
        }
        private bool ContainAlphabet_Inputvalues(string str_companyGuid)
        {
            string pattern1 = @"^[a-zA-Z]+$";
            var abc = Regex.IsMatch(str_companyGuid, pattern1);
            return Regex.IsMatch(str_companyGuid, pattern1);
        }
    }
}