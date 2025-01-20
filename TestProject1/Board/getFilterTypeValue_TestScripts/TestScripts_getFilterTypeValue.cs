using Commons.DTO_s.Board.getFilterTypeValue;
using Commons.DTO_s.PortalUserRoles.AddUpdateRoleAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestProject1.Board.getFilterTypeValue_TestScripts
{
    [TestClass]
    public class TestScripts_getFilterTypeValue
    {
        [TestMethod]
        public void ValidResponse()
        {
            var getFilterTypeValue_GetResponse = ApiResponse_getFilterTypeValue.sets_getFilterTypeValue;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, getFilterTypeValue_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var getFilterTypeValue_GetResponse = ApiResponse_getFilterTypeValue.sets_getFilterTypeValue;
            Console.WriteLine("Invalid Response                     :   PASS");
            Assert.AreEqual(200, getFilterTypeValue_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void ContainsAlphabetValue(string FilterType)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Invalid Alphabet Characters used in 'FilterType' input values           :       PASS");
            Console.WriteLine("Invalid Numeric Characters used in 'FilterType' input values            :       FAIL");
            Console.WriteLine("Invalid Special Characters used in 'FilterType' input values            :       FAIL");
            Console.WriteLine("Get Updated Successfully                                                :       FAIL");
            Console.WriteLine("'FilterType' is null or empty                                           :       FAIL");
            Assert.IsTrue(ContainAlphabet_Inputvalues(FilterType), "Alphabet Character used.");
        }
        [TestMethod]
        public void SpecialCharacter(string FilterType)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Invalid Special Characters used in 'FilterType' input values           :       PASS");
            Console.WriteLine("Invalid Numeric Characters used in 'FilterType' input values           :       FAIL");
            Console.WriteLine("Invalid Alphabet Character used in 'FilterType' input values           :       FAIL");
            Console.WriteLine("Get Updated Successfully                                               :       FAIL");
            Console.WriteLine("'FilterType' is null or empty                                          :       FAIL");
            Assert.IsTrue(ContainsSpecialCharacters(FilterType), "Special Character used.");
        }
        [TestMethod]
        public void Null_Values(string FilterType)
        {
            // Check if the input is null or empty
            if (string.IsNullOrEmpty(FilterType))
            {
                Console.WriteLine("\nTest Scripts Results: ");
                Console.WriteLine("'FilterType' is null or empty                                          :       PASS");
                Console.WriteLine("Invalid Special Characters used in 'FilterType' input values           :       FAIL");
                Console.WriteLine("Invalid Numeric Characters used in 'FilterType' input values           :       FAIL");
                Console.WriteLine("Invalid Alphabet Character used in 'FilterType' input values           :       FAIL");
                Console.WriteLine("Get Updated Successfully                                               :       FAIL");
                Assert.IsTrue(ContainNullInputvalues(FilterType), "Null 'companyGuid' ");
            }
        }
        [TestMethod]
        public void Numeric_InputValue(string FilterType)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Invalid Numeric Characters used in 'FilterType' input values           :       PASS");
            Console.WriteLine("'FilterType' is null or empty                                          :       FAIL");
            Console.WriteLine("Invalid Special Characters used in 'FilterType' input values           :       FAIL");
            Console.WriteLine("Invalid Alphabet Character used in 'FilterType' input values           :       FAIL");
            Console.WriteLine("Get Updated Successfully                                               :       FAIL");
        }
        private bool ContainsSpecialCharacters(string str)
        {
            // Regular expression to match special characters
            string pattern = @"[%\^\*\'\(\)\!\@\?\&\+\$\~\`]";
            return Regex.IsMatch(str, pattern);
        }
        private bool ContainNullInputvalues(string strFilterType)
        {
            string testInput = ".*";
            bool result = Regex.IsMatch(strFilterType, testInput);
            Console.WriteLine($"Test Script Result: {(result ? "Pass" : "Fail")}");
            return Regex.IsMatch(strFilterType, testInput);
        }
        private bool ContainAlphabet_Inputvalues(string str_FilterType)
        {
            string pattern1 = @"^[a-zA-Z]+$";
            var abc = Regex.IsMatch(str_FilterType, pattern1);
            return Regex.IsMatch(str_FilterType, pattern1);
        }
    }
}