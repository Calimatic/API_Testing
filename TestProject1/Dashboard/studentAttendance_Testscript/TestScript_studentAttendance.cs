using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestProject1.Dashboard.studentAttendance_Testscript
{
    public class TestScript_studentAttendance
    {

        [TestMethod]
        public void ValidInputValues(string type, string franchises)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Valid All Input Values                                            :       PASS");
            Console.WriteLine("Special Character used in 'type' input values                     :       FAIL");
            Console.WriteLine("Alphabet Character used in 'type' input values                    :       FAIL");
            Console.WriteLine("Alphabet Character used in 'franchises' input values              :       FAIL");
            Console.WriteLine("Special Character used in 'franchises' input values               :       FAIL");
            Console.WriteLine("'type' and 'franchises' is null or empty                          :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'type')                             :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'franchises')                       :       FAIL");
        }
        //[TestMethod]
        //public void InvalidInputValues(string type, string franchises)
        //{
        //    Console.WriteLine("\nTest Scripts Results: ");
        //    Console.WriteLine("Alphabet Character used in 'type' input values                    :       FAIL");
        //    Console.WriteLine("Valid All Input Values                                            :       FAIL");
        //    Console.WriteLine("Special Character used in 'franchises' input values               :       FAIL");
        //    Console.WriteLine("'types' or 'franchises' is null or empty                          :       FAIL");
        //    Console.WriteLine("Value can be null. (Parameter 'type')                             :       FAIL");
        //    Console.WriteLine("Value can be null. (Parameter 'franchises')                       :       FAIL");
        //}
        [TestMethod]
        public void SpecialCharacter(string type)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Special Character used in 'type' input values                     :       PASS");
            Console.WriteLine("Valid All Input Values                                            :       FAIL");
            Console.WriteLine("Alphabet Character used in 'type' input values                    :       FAIL");
            Console.WriteLine("Alphabet Character used in 'franchises' input values              :       FAIL");
            Console.WriteLine("Special Character used in 'franchises' input values               :       FAIL");
            Console.WriteLine("'type' and 'franchises' is null or empty                          :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'type')                             :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'franchises')                       :       FAIL");
            Assert.IsTrue(ContainsSpecialCharacters(type), "Special Character used.");
        }
        [TestMethod]
        public void SpecialCharacter_franchises(string franchises)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Special Character used in 'franchises' input values               :       PASS");
            Console.WriteLine("Valid All Input Values                                            :       FAIL");
            Console.WriteLine("Special Character used in 'type' input values                     :       FAIL");
            Console.WriteLine("Alphabet Character used in 'type' input values                    :       FAIL");
            Console.WriteLine("Alphabet Character used in 'franchises' input values              :       FAIL");
            Console.WriteLine("'type' and 'franchises' is null or empty                          :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'type')                             :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'franchises')                       :       FAIL");
        }
        [TestMethod]
        public void ValidateInput_NulltypeValues(string type)
        {
            // Check if the input is null or empty
            if (string.IsNullOrEmpty(type))
            {
                Console.WriteLine("\nTest Scripts Results: ");
                Console.WriteLine("Value can be null. (Parameter 'type')                         :       PASS");
                Console.WriteLine("Valid All Input Values                                        :       FAIL");
                Console.WriteLine("Special Character used in 'type' input values                 :       FAIL");
                Console.WriteLine("Alphabet Character used in 'type' input values                :       FAIL");
                Console.WriteLine("Alphabet Character used in 'franchises' input values          :       FAIL");
                Console.WriteLine("Special Character used in 'franchises' input values           :       FAIL");
                Console.WriteLine("'type' and 'franchises' is null or empty                      :       FAIL");
                Console.WriteLine("Value can be null. (Parameter 'franchises')                   :       FAIL");
                Assert.IsTrue(ContainNull_types_Inputvalues(type), "Null 'Type'");
            }
        }
        [TestMethod]
        public void ValidateInput_Nullfranchises_Values(string franchises)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Value can be null. (Parameter 'franchises')                       :       PASS");
            Console.WriteLine("'type' and 'franchises' is null or empty                          :       FAIL");
            Console.WriteLine("Valid All Input Values                                            :       FAIL");
            Console.WriteLine("Special Character used in 'type' input values                     :       FAIL");
            Console.WriteLine("Alphabet Character used in 'type' input values                    :       FAIL");
            Console.WriteLine("Alphabet Character used in 'franchises' input values              :       FAIL");
            Console.WriteLine("Special Character used in 'franchises' input values               :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'type')                             :       FAIL");
            Assert.IsTrue(ContainNull_franchises_Inputvalues(franchises), "Null 'franchises'");
        }
        [TestMethod]
        public void ContainsAlphabet_type(string type)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Alphabet Character used in 'type' input values                    :       PASS");
            Console.WriteLine("'type' and 'franchises' is null or empty                          :       FAIL");
            Console.WriteLine("Valid All Input Values                                            :       FAIL");
            Console.WriteLine("Special Character used in 'type' input values                     :       FAIL");
            Console.WriteLine("Alphabet Character used in 'type' input values                    :       FAIL");
            Console.WriteLine("Special Character used in 'franchises' input values               :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'type')                             :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'franchises')                       :       FAIL");
            Assert.IsTrue(ContainAlphabet_type_Inputvalues(type), "Alphabet Character used.");
        }
        [TestMethod]
        public void ContainsAlphabet_franchises(string franchises)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Alphabet Character used in 'franchises' input values              :       PASS");
            Console.WriteLine("'type' and 'franchises' is null or empty                          :       FAIL");
            Console.WriteLine("Valid All Input Values                                            :       FAIL");
            Console.WriteLine("Special Character used in 'type' input values                     :       FAIL");
            Console.WriteLine("Alphabet Character used in 'type' input values                    :       FAIL");
            Console.WriteLine("Special Character used in 'franchises' input values               :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'type')                             :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'franchises')                       :       FAIL");
            Assert.IsTrue(ContainAlphabet_franchises_Inputvalues(franchises), "Alphabet Character used.");
        }
        [TestMethod]
        public void ValidateInput_NullValues(string type, string franchises)
        {
            // Check if the input is null or empty
            if (string.IsNullOrEmpty(type) && string.IsNullOrEmpty(franchises))
            {
                Console.WriteLine("\nTest Scripts Results: ");
                Console.WriteLine("'types' or 'franchises' is null or empty                          :       PASS");
                Console.WriteLine("Alphabet Character used in 'franchises' input values              :       FAIL");
                Console.WriteLine("Valid All Input Values                                            :       FAIL");
                Console.WriteLine("Special Character used in 'type' input values                     :       FAIL");
                Console.WriteLine("Alphabet Character used in 'type' input values                    :       FAIL");
                Console.WriteLine("Special Character used in 'franchises' input values               :       FAIL");
                Console.WriteLine("Value can be null. (Parameter 'type')                             :       FAIL");
                Console.WriteLine("Value can be null. (Parameter 'franchises')                       :       FAIL");
                Assert.IsTrue(ContainNullInputvalues(type, franchises), "Null 'Type' and 'franchises'");
            }
        }
        private bool ContainNullInputvalues(string strtype, string strfranchises)
        {
            string testInput = ".*";
            bool result = Regex.IsMatch(strtype + strfranchises, testInput);
            //     Console.WriteLine($"Test Script Result: {(result ? "Pass" : "Fail")}");
            return Regex.IsMatch(strtype + strfranchises, testInput);
        }
        private bool ContainAlphabet_type_Inputvalues(string strtype)
        {
            string pattern1 = @"^[a-zA-Z]+$";
            var abc = Regex.IsMatch(strtype, pattern1);
            return Regex.IsMatch(strtype, pattern1);
        }
        private bool ContainAlphabet_franchises_Inputvalues(string strfranchises)
        {
            string pattern1 = @"^[a-zA-Z]+$";
            var abc = Regex.IsMatch(strfranchises, pattern1);
            return Regex.IsMatch(strfranchises, pattern1);
        }
        private bool ContainNull_franchises_Inputvalues(string strfranchises)
        {
            string testInput = ".*";
            bool result = Regex.IsMatch(strfranchises, testInput);
            //Console.WriteLine($"Test Script Result: {(result ? "Pass" : "Fail")}");
            return Regex.IsMatch(strfranchises, testInput);
        }
        private bool ContainsSpecialCharacters(string str)
        {
            // Regular expression to match special characters
            string pattern = @"[%\^\*\'\(\)\!\@\?\&\+\$\~\`]";
            return Regex.IsMatch(str, pattern);
        }
        private bool ContainNull_types_Inputvalues(string strtype)
        {
            string testInput = ".*";
            bool result = Regex.IsMatch(strtype, testInput);
            //Console.WriteLine($"Test Script Result: {(result ? "Pass" : "Fail")}");
            return Regex.IsMatch(strtype, testInput);
        }
    }
}
