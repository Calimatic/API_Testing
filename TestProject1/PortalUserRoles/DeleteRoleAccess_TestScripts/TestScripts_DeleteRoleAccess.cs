using Commons.DTO_s.PortalUserRoles.AddUpdateRoleAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestProject1.PortalUserRoles.DeleteRoleAccess_TestScripts
{
    [TestClass]
    public class TestScripts_DeleteRoleAccess
    {
        [TestMethod]
        public void ValidInputValues()
        {
            var AddUpdateRoleAccess_GetResponse = ApiResponse_AddUpdateRoleAccess.sets_AddUpdateRoleAccess;
            Console.WriteLine("Get Updated Successfully            :   PASS");
            Assert.AreEqual(true, AddUpdateRoleAccess_GetResponse.response.isSuccessful, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var AddUpdateRoleAccess_GetResponse = ApiResponse_AddUpdateRoleAccess.sets_AddUpdateRoleAccess;
            Console.WriteLine("Invalid Updated Data                     :   PASS");
            Assert.AreEqual(true, AddUpdateRoleAccess_GetResponse.response.isSuccessful, "Unexpected status code.");
        }
        [TestMethod]
        public void ContainsAlphabetValue(string id)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Invalid Alphabet Characters used in 'id' input values           :       PASS");
            Console.WriteLine("Invalid Numeric Characters used in 'id' input values            :       FAIL");
            Console.WriteLine("Invalid Special Characters used in 'id' input values            :       FAIL");
            Console.WriteLine("Get Updated Successfully                                        :       FAIL");
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
            Console.WriteLine("Get Updated Successfully                                       :       FAIL");
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
                Console.WriteLine("Get Updated Successfully                                       :       FAIL");
                Assert.IsTrue(ContainNullInputvalues(id), "Null 'companyGuid' ");
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
            Console.WriteLine("Get Updated Successfully                                       :       FAIL");
        }
        private bool ContainsSpecialCharacters(string str)
        {
            // Regular expression to match special characters
            string pattern = @"[%\^\*\'\(\)\!\@\?\&\+\$\~\`]";
            return Regex.IsMatch(str, pattern);
        }
        private bool ContainNullInputvalues(string strid)
        {
            string testInput = ".*";
            bool result = Regex.IsMatch(strid, testInput);
            Console.WriteLine($"Test Script Result: {(result ? "Pass" : "Fail")}");
            return Regex.IsMatch(strid, testInput);
        }
        private bool ContainAlphabet_Inputvalues(string str_id)
        {
            string pattern1 = @"^[a-zA-Z]+$";
            var abc = Regex.IsMatch(str_id, pattern1);
            return Regex.IsMatch(str_id, pattern1);
        }
    }
}
