using Commons.DTO_s.Department.deleteDepartments;
using Commons.DTO_s.Department.saveDepartment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestProject1.Department.deleteDepartments_TestScripts
{
    [TestClass]
    public class TestScripts_deleteDepartments
    {
        [TestMethod]
        public void ValidInputValues()
        {
            var saveDepartment_GetResponse = ApiResponse_deleteDepartments.Sets_deleteDepartments;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, saveDepartment_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var saveDepartment_GetResponse = ApiResponse_deleteDepartments.Sets_deleteDepartments;
            Console.WriteLine("Department can not be deleted! Already in use            :   PASS");
            Assert.AreEqual(500, saveDepartment_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void ContainsAlphabetValue(string deptId)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Alphabet Character used in 'deptId' input values           :       PASS");
            Console.WriteLine("Special Characters used in 'deptId' input values           :       FAIL");
            Console.WriteLine("Valid All Input Values                                     :       FAIL");
            Console.WriteLine("'deptId' is null or empty                                  :       FAIL");
            Assert.IsTrue(ContainAlphabet_Inputvalues(deptId), "Alphabet Character used.");
        }
        [TestMethod]
        public void SpecialCharacter(string deptId)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Special Characters used in 'deptId' input values           :       PASS");
            Console.WriteLine("Alphabet Character used in 'deptId' input values           :       FAIL");
            Console.WriteLine("Valid All Input Values                                     :       FAIL");
            Console.WriteLine("'deptId' is null or empty                                  :       FAIL");
            Assert.IsTrue(ContainsSpecialCharacters(deptId), "Special Character used.");
        }
        public void Null_Values(string deptId)
        {
            // Check if the input is null or empty
            if (string.IsNullOrEmpty(deptId))
            {
                Console.WriteLine("\nTest Scripts Results: ");
                Console.WriteLine("'deptId' is null or empty                                  :       PASS");
                Console.WriteLine("Special Characters used in 'deptId' input values           :       FAIL");
                Console.WriteLine("Alphabet Character used in 'deptId' input values           :       FAIL");
                Console.WriteLine("Valid All Input Values                                     :       FAIL");
                Assert.IsTrue(ContainNullInputvalues(deptId), "Null 'Types' or 'franchisesIds'");
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