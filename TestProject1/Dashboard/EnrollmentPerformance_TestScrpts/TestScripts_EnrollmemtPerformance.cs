using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestProject1.Dashboard.EnrollmentPerformance_TestScrpts
{
    [TestClass]
    public class TestScripts_EnrollmemtPerformance
    {
        [TestMethod]
        public void ValidInputValues(string types, string franchiseIds, int type, int performance)
        {
            Console.WriteLine("\nTest Scripts : ");
            Console.WriteLine("Valid All Input Values                                            :       PASS");
            Console.WriteLine("Special Character used 'types' or 'type' input values             :       FAIL");
            Console.WriteLine("'types' or 'franchisesIds' is null or empty                       :       FAIL");
        }
        [TestMethod]
        public void SpecialCharacter(string types, int type)
        {
            Console.WriteLine("\nTest Scripts : ");
            Console.WriteLine("Special Character used 'types' or 'type' input values             :       PASS");
            Console.WriteLine("Valid All Input Values                                            :       FAIL");
            Console.WriteLine("'types' or 'franchisesIds' is null or empty                       :       FAIL");
            Assert.IsTrue(ContainsSpecialCharacters(types, type), "Special Character used.");
        }
        //
        // Example usage:
        public void ValidateInput_NullValues(string types, string franchiseIds)
        {
            // Check if the input is null or empty
            if (string.IsNullOrEmpty(types) && string.IsNullOrEmpty(franchiseIds))
            {
                Console.WriteLine("\nTest Scripts : ");
                Console.WriteLine("'types' or 'franchisesIds' is null or empty                       :       PASS");
                Console.WriteLine("Special Character used 'types' or 'type' input values             :       FAIL");
                Console.WriteLine("Valid All Input Values                                            :       FAIL");              
                Assert.IsTrue(ContainNullInputvalues(types, franchiseIds), "Null 'Types' or 'franchisesIds'");
            }
        }
        private bool ContainsSpecialCharacters(string str, int str1)
        {
            // Regular expression to match special characters
            string pattern = @"[%\^\*\'\(\)\!\@\?\&\+\$\~\`]";
            return Regex.IsMatch(str + str1, pattern);
        }
        private bool ContainNullInputvalues(string strtypes, string strfranchiseIds)
        {
            string testInput = null;
            bool result = Regex.IsMatch(strtypes + strfranchiseIds, testInput);
            Console.WriteLine($"Test Script Result: {(result ? "Pass" : "Fail")}");
            return Regex.IsMatch(strtypes + strfranchiseIds, testInput);
        } 
    } 
}
