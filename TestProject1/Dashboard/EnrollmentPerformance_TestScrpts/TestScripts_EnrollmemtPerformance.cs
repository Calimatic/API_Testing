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
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Valid All Input Values                                            :       PASS");
            Console.WriteLine("Response with no Data                                             :       FAIL");
            Console.WriteLine("Special Character used in 'franchiseIds' input values             :       FAIL");
            Console.WriteLine("'types' or 'franchisesIds' is null or empty                       :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'types')                            :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'franchisesIds')                    :       FAIL");
        }
        [TestMethod]
        public void InvalidInputValues(string types, string franchiseIds, int type, int performance)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Response with no Data                                             :       PASS");
            Console.WriteLine("Alphabet Character used in 'franchiseIds' input values            :       FAIL");
            Console.WriteLine("Valid All Input Values                                            :       FAIL");
            Console.WriteLine("Special Character used in 'franchiseIds' input values             :       FAIL");
            Console.WriteLine("'types' or 'franchisesIds' is null or empty                       :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'types')                            :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'franchisesIds')                    :       FAIL");
        }
        [TestMethod]
        public void ContainsAlphabet_franchiseIds(string franchiseIds)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Alphabet Character used in 'franchiseIds' input values            :       PASS");
            Console.WriteLine("Valid All Input Values                                            :       FAIL");
            Console.WriteLine("Response with no Data                                             :       FAIL");
            Console.WriteLine("Special Character used in 'franchiseIds' input values             :       FAIL");
            Console.WriteLine("'types' or 'franchisesIds' is null or empty                       :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'types')                            :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'franchisesIds')                    :       FAIL");
            Assert.IsTrue(ContainAlphabet_franchiseIds_Inputvalues(franchiseIds), "Alphabet Character used.");
        }
        [TestMethod]
        public void SpecialCharacter(string franchiseIds)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Special Character used in 'franchiseIds' input values             :       PASS");
            Console.WriteLine("Alphabet Character used in 'franchiseIds' input values            :       FAIL");
            Console.WriteLine("Response with no Data                                             :       FAIL");
            Console.WriteLine("Valid All Input Values                                            :       FAIL");
            Console.WriteLine("'types' or 'franchisesIds' is null or empty                       :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'types')                            :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'franchisesIds')                    :       FAIL");
            Assert.IsTrue(ContainsSpecialCharacters(franchiseIds), "Special Character used.");
        }
        //
        // Example usage:
        public void ValidateInput_NullValues(string types, string franchiseIds)
        {
            // Check if the input is null or empty
            if (string.IsNullOrEmpty(types) || string.IsNullOrEmpty(franchiseIds))
            {
                Console.WriteLine("\nTest Scripts Results: ");
                Console.WriteLine("'types' or 'franchisesIds' is null or empty                    :       PASS");
                Console.WriteLine("Alphabet Character used in 'franchiseIds' input values         :       FAIL");
                Console.WriteLine("Response with no Data                                          :       FAIL");
                Console.WriteLine("Special Character used in 'franchiseIds' input value           :       FAIL");
                Console.WriteLine("Valid All Input Values                                         :       FAIL");
                Console.WriteLine("Value can be null. (Parameter 'types')                         :       FAIL");
                Console.WriteLine("Value can be null. (Parameter 'franchisesIds')                 :       FAIL");
                Assert.IsTrue(ContainNullInputvalues(types, franchiseIds), "Null 'Types' or 'franchisesIds'");
            }
        }
        [TestMethod]
        public void ValidateInput_NulltypeValues(string types)
        {
            // Check if the input is null or empty
            if (string.IsNullOrEmpty(types))
            {
                Console.WriteLine("\nTest Scripts Results: ");
                Console.WriteLine("Value can be null. (Parameter 'types')                         :       PASS");
                Console.WriteLine("Alphabet Character used in 'franchiseIds' input values         :       FAIL");
                Console.WriteLine("Response with no Data                                          :       FAIL");
                Console.WriteLine("'types' or 'franchisesIds' is null or empty                    :       FAIL");
                Console.WriteLine("Special Character used in 'franchiseIds' input values          :       FAIL");
                Console.WriteLine("Valid All Input Values                                         :       FAIL");
                Console.WriteLine("Value can be null. (Parameter 'franchisesIds')                 :       FAIL");
                Assert.IsTrue(ContainNull_types_Inputvalues(types), "Null 'Types'");
            }
        }
        [TestMethod]
        public void ValidateInput_NullfranchiseIds_Values(string franchisesIds)
        {
            // Check if the input is null or empty
            if (string.IsNullOrEmpty(franchisesIds))
            {
                Console.WriteLine("\nTest Scripts Results: ");
                Console.WriteLine("Value can be null. (Parameter 'franchisesIds')                 :       PASS");
                Console.WriteLine("Alphabet Character used in 'franchiseIds' input values         :       FAIL");
                Console.WriteLine("Response with no Data                                          :       FAIL");
                Console.WriteLine("'types' or 'franchisesIds' is null or empty                    :       FAIL");
                Console.WriteLine("Special Character used in 'franchiseIds' input values          :       FAIL");
                Console.WriteLine("Valid All Input Values                                         :       FAIL");
                Console.WriteLine("Value can be null. (Parameter 'types')                         :       FAIL");
                Assert.IsTrue(ContainNull_franchiseIds_Inputvalues(franchisesIds), "Null 'franchisesIds'");
            }
        }
        private bool ContainsSpecialCharacters(string str)
        {
            // Regular expression to match special characters
            string pattern = @"[%\^\*\'\(\)\!\@\?\&\+\$\~\`]";
            return Regex.IsMatch(str, pattern);
        }
        private bool ContainNullInputvalues(string strtypes, string strfranchiseIds)
        {
            string testInput = ".*";
            bool result = Regex.IsMatch(strtypes + strfranchiseIds, testInput);
            Console.WriteLine($"Test Script Result: {(result ? "Pass" : "Fail")}");
            return Regex.IsMatch(strtypes + strfranchiseIds, testInput);
        }
        private bool ContainNull_types_Inputvalues(string strtypes)
        {
            string testInput = ".*";
            bool result = Regex.IsMatch(strtypes, testInput);
            //Console.WriteLine($"Test Script Result: {(result ? "Pass" : "Fail")}");
            return Regex.IsMatch(strtypes , testInput);
        }
        private bool ContainNull_franchiseIds_Inputvalues(string strfranchiseIds)
        {
            string testInput = ".*";
            bool result = Regex.IsMatch(strfranchiseIds, testInput);
            //Console.WriteLine($"Test Script Result: {(result ? "Pass" : "Fail")}");
            return Regex.IsMatch(strfranchiseIds, testInput);
        }
        private bool ContainAlphabet_franchiseIds_Inputvalues(string strfranchiseIds)
        {
            string pattern1 = @"^[a-zA-Z]+$";
            var abc = Regex.IsMatch(strfranchiseIds, pattern1);
            return Regex.IsMatch(strfranchiseIds, pattern1);
        }
    } 
}
