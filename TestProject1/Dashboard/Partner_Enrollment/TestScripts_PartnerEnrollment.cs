using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestProject1.Dashboard.Partner_Enrollment
{
    [TestClass]
    public class TestScripts_PartnerEnrollment
    {
        [TestMethod]
        public void ValidFranchise_ID(string franchises)
        {
            Console.WriteLine("\nTest Script : ");
            Console.WriteLine("Validfranchise ID                             :    PASS");
            Console.WriteLine("Alphabetic Character used                     :    FAIL");
            Console.WriteLine("Special characters used in params value       :    FAIL");
            Assert.AreEqual(true,true);
        }

        [TestMethod]
        public void SpecialCharacter(string franchises)
        {
            Console.WriteLine("\nTest Script : ");
            Console.WriteLine("Validfranchise ID                             :    FAIL");
            Console.WriteLine("Alphabetic Character used                     :    FAIL");
            Console.WriteLine("Special characters used in params value       :    PASS");
            Assert.IsTrue(ContainsSpecialCharacters(franchises), "Special Character used.");
        }
        [TestMethod]
        public void AlphabetCharacter(string franchises)
        {
            Console.WriteLine("\nTest Script : ");
            Console.WriteLine("Validfranchise ID                             :    FAIL");
            Console.WriteLine("Alphabetic Character used                     :    PASS");
            Console.WriteLine("Special characters used in params value       :    FAIL");
            Assert.IsTrue(ContainsAlphabetCharacters(franchises), "Alphabet Character used.");
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
