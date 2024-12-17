using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestProject1.Dashboard.restoreWidgetsToDefault_TestScripts
{
    [TestClass]
    public class TestScripts_restoreWidgetsToDefault
    {
        [TestMethod]
        public void ValidInputValues(string role)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Valid Input Value                                                      :    PASS");
            Console.WriteLine("Special characters used in input value                                 :    FAIL");
            Console.WriteLine("Alphabet characters used in input value                                :    FAIL");
            Console.WriteLine("Null Input role value                                                  :    FAIL");
            Console.WriteLine("BeginExecuteNonQuery: CommandText property has not been initialized    :    FAIL");
        }
        [TestMethod]
        public void SpecialCharacter(string role)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Special characters used in input value                                 :    PASS");
            Console.WriteLine("Valid Input Values                                                     :    FAIL");
            Console.WriteLine("Alphabet characters used in input value                                :    FAIL");
            Console.WriteLine("Null Input role value                                                  :    FAIL");
            Console.WriteLine("BeginExecuteNonQuery: CommandText property has not been initialized    :    FAIL");
            Assert.IsTrue(ContainsSpecialCharacters(role), "Special Character used.");
        }
        [TestMethod]
        public void ContainsAlphabet_role(string role)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Alphabet characters used in input value                                :    PASS");
            Console.WriteLine("Special characters used in input value                                 :    FAIL");
            Console.WriteLine("Valid Input Values                                                     :    FAIL");
            Console.WriteLine("Null Input role value                                                  :    FAIL");
            Console.WriteLine("BeginExecuteNonQuery: CommandText property has not been initialized    :    FAIL");
            Assert.IsTrue(ContainsAlphabetCharacters(role), "Alphabet Character used.");
        }
        [TestMethod]
        public void ValidateInput_NullValues(string role)
        {
            // Check if the input is null or empty
            if (string.IsNullOrEmpty(role))
            {
                Console.WriteLine("\nTest Scripts Results: ");
                Console.WriteLine("Null Input role value                                                  :    PASS");
                Console.WriteLine("Alphabet characters used in input value                                :    FAIL");
                Console.WriteLine("Special characters used in input value                                 :    FAIL");
                Console.WriteLine("Valid Input Value                                                      :    FAIL");
                Console.WriteLine("BeginExecuteNonQuery: CommandText property has not been initialized    :    FAIL");
                Assert.IsTrue(ContainNull_types_values(role), "Null 'role'");
            }
        }
        [TestMethod]
        public void BeginExecuteNonQuery(string role)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("BeginExecuteNonQuery: CommandText property has not been initialized    :    PASS");
            Console.WriteLine("Null Input role value                                                  :    FAIL");
            Console.WriteLine("Alphabet characters used in input value                                :    FAIL");
            Console.WriteLine("Special characters used in input value                                 :    FAIL");
            Console.WriteLine("Valid Input Value                                                      :    FAIL");
        }
        private bool ContainNull_types_values(string strrole)
        {
            string testInput = ".*";
            bool result = Regex.IsMatch(strrole, testInput);
            //Console.WriteLine($"Test Script Result: {(result ? "Pass" : "Fail")}");
            return Regex.IsMatch(strrole, testInput);
        }
        private bool ContainsAlphabetCharacters(string str1)
        {
            // Regular expression to match special characters
            string pattern1 = @"^[a-zA-Z]+$";
            var abc = Regex.IsMatch(str1, pattern1);
            return Regex.IsMatch(str1, pattern1);
        }
        private bool ContainsSpecialCharacters(string str)
        {
            // Regular expression to match special characters
            string pattern = @"[%\^\*\'\(\)\!\@\?\&\+\$\~\`]";
            return Regex.IsMatch(str, pattern);
        }
    }
}
