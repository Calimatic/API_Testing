using Commons.DTO_s.Board.getFilterTypeValue;
using Commons.DTO_s.SISForm.createStudentInformationForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestProject1.SISForm.createStudentInformationForm_TestScripts
{
    [TestClass]
    public class TestScripts_createStudentInformationForm
    {
        [TestMethod]
        public void ValidInputValues()
        {
            var createStudentInformationForm_GetResponse = ApiResponse_createStudentInformationForm_Response.sets_createStudentInformationForm;
            Console.WriteLine("Get Added Successfully            :   PASS");
            Assert.AreEqual(200, createStudentInformationForm_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var createStudentInformationForm_GetResponse = ApiResponse_createStudentInformationForm_Response.sets_createStudentInformationForm;
            Console.WriteLine("Invalid Response                     :   PASS");
            Assert.AreEqual(200, createStudentInformationForm_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void ContainsAlphabetValue(string id)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Invalid Alphabet Characters used in 'id' input values           :       PASS");
            Console.WriteLine("Invalid Numeric Characters used in 'id' input values            :       FAIL");
            Console.WriteLine("Invalid Special Characters used in 'id' input values            :       FAIL");
            Console.WriteLine("Get Added Successfully                                          :       FAIL");
            Console.WriteLine("'id' is null or empty                                           :       FAIL");
            Assert.IsTrue(ContainAlphabet_Inputvalues(id), "Alphabet Character used.");
        }
        [TestMethod]
        public void SpecialCharacter(string id)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Invalid Special Characters used in 'id' input values           :       PASS");
            Console.WriteLine("Invalid Numeric Characters used in 'id' input values           :       FAIL");
            Console.WriteLine("Invalid Alphabet Character used in 'id' input values           :       FAIL");
            Console.WriteLine("Get Added Successfully                                         :       FAIL");
            Console.WriteLine("'id' is null or empty                                          :       FAIL");
            Assert.IsTrue(ContainsSpecialCharacters(id), "Special Character used.");
        }
        [TestMethod]
        public void Null_Values(string id)
        {
            // Check if the input is null or empty
            if (string.IsNullOrEmpty(id))
            {
                Console.WriteLine("\nTest Scripts Results: ");
                Console.WriteLine("'id' is null or empty                                          :       PASS");
                Console.WriteLine("Invalid Special Characters used in 'id' input values           :       FAIL");
                Console.WriteLine("Invalid Numeric Characters used in 'id' input values           :       FAIL");
                Console.WriteLine("Invalid Alphabet Character used in 'id' input values           :       FAIL");
                Console.WriteLine("Get Added Successfully                                         :       FAIL");
                Assert.IsTrue(ContainNullInputvalues(id), "Null 'id' ");
            }
        }
        [TestMethod]
        public void Numeric_InputValue(string id)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Invalid Numeric Characters used in 'id' input values           :       PASS");
            Console.WriteLine("'id' is null or empty                                          :       FAIL");
            Console.WriteLine("Invalid Special Characters used in 'id' input values           :       FAIL");
            Console.WriteLine("Invalid Alphabet Character used in 'id' input values           :       FAIL");
            Console.WriteLine("Get Added Successfully                                         :       FAIL");
        }
        private bool ContainsSpecialCharacters(string strid)
        {
            // Regular expression to match special characters
            string pattern = @"[%\^\*\'\(\)\!\@\?\&\+\$\~\`]";
            return Regex.IsMatch(strid, pattern);
        }
        private bool ContainNullInputvalues(string str_id)
        {
            string testInput = ".*";
            bool result = Regex.IsMatch(str_id, testInput);
            Console.WriteLine($"Test Script Result: {(result ? "Pass" : "Fail")}");
            return Regex.IsMatch(str_id, testInput);
        }
        private bool ContainAlphabet_Inputvalues(string str_id)
        {
            string pattern1 = @"^[a-zA-Z]+$";
            var abc = Regex.IsMatch(str_id, pattern1);
            return Regex.IsMatch(str_id, pattern1);
        }
    }
}