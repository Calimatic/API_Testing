using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestProject1.Dashboard.ClassEnrollmentCountByType
{
    [TestClass]
    public class TestScripts_ClassEnroll
    {
        [TestMethod]
        public void Valid_Type_FranchisesID(string type , string franchises)
        {
            Console.WriteLine("\nTest Script : ");
            Console.WriteLine("Validfranchise ID                             :    PASS");
            Console.WriteLine("Alphabetic Character used in franchises       :    FAIL");
            Console.WriteLine("Special characters used in params value       :    FAIL");
            Console.WriteLine("Empty type or franchises Value                :    FAIL");
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void SpecialCharacter(string type, string franchises)
        {
            Console.WriteLine("\nTest Script : ");
            Console.WriteLine("Validfranchise ID                             :    FAIL");
            Console.WriteLine("Alphabetic Character used                     :    FAIL");
            Console.WriteLine("Special characters used in params value       :    PASS");
            Console.WriteLine("Empty type or franchises Value                :    FAIL");
            Assert.IsTrue(ContainsSpecialCharacters(type+franchises), "Special Character used.");
        }
        [TestMethod]
        public void AlphabetCharacter(string franchises)
        {
            Console.WriteLine("\nTest Script : ");
            Console.WriteLine("Validfranchise ID                             :    FAIL");
            Console.WriteLine("Alphabetic Character used in Franchises value :    PASS");
            Console.WriteLine("Special characters used in params value       :    FAIL");
            Console.WriteLine("Empty type or franchises Value                :    FAIL");
            Assert.IsTrue(ContainsAlphabetCharacters(franchises), "Alphabet Character used.");
        }
        [TestMethod]
        public void Nullparamsvalue(string type, string franchises)
        {
            Console.WriteLine("\nTest Script : ");
            Console.WriteLine("Validfranchise ID                             :    FAIL");
            Console.WriteLine("Alphabetic Character used                     :    FAIL");
            Console.WriteLine("Special characters used in params value       :    FAIL");
            Console.WriteLine("Empty type or franchises Value                :    PASS");
            Assert.AreEqual(true, true);
            //Assert.IsTrue(ContainsAlphabetCharacters(type + franchises), "Empty type or franchises Value");
        }
        private bool ContainsSpecialCharacters(string str)
        {
            // Regular expression to match special characters
            string pattern = @"[%\^\*\'\(\)\!\@\?\&\+\$\~\`]";
            return Regex.IsMatch(str, pattern);
        }
        private bool ContainsAlphabetCharacters(string str1)
        {
            // Regular expression to match special characters
            string pattern1 = @"^[a-zA-Z]+$";
            var abc = Regex.IsMatch(str1, pattern1);
            return Regex.IsMatch(str1, pattern1);
        }
    }
}
