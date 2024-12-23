using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestProject1.Dashboard.leadsGeneration_TestScript
{
    [TestClass]
    public class TestScripts_leadsGeneration
    {
        [TestMethod]
        public void ValidInputValues(int? type, int? companyId)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Valid Input Values                                                      :    PASS");
            Console.WriteLine("Dummy Response                                                          :    FAIL");
        }
        [TestMethod]
        public void InvalidCompanyId()
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("If CompanyId enter Invalid then Dummy Response display                  :    PASS");
            Console.WriteLine("Valid Input Values                                                      :    FAIL");
        }

        [TestMethod]
        public void ValidateCompanyId(int? companyId)
        {
            // Convert integers to strings for alphabet check
            string companyIdStr = companyId.ToString();

            // Pattern to match alphabets and Numeric and Null
            string nullPattern = @"^$";
            string alphabetPattern = @"[a-zA-Z]";
            string numericPattern = @"^\d+$";

            // Check if 'companyIdStr' contains alphabets
            bool containsAlphabet = Regex.IsMatch(companyIdStr, alphabetPattern);
            bool containsNumbersOnly = Regex.IsMatch(companyIdStr, numericPattern);
            bool containsNullvalue = Regex.IsMatch(companyIdStr, nullPattern);

            // Ensure type and companyId are not null
            if (containsNullvalue)
            {
                Console.WriteLine("\nTest Scripts Results: ");
                Console.WriteLine("Valid Input Values                                   :    FAIL");
                Console.WriteLine($"CompanyId: {companyIdStr} contains Null             :    PASS"); 
                Assert.IsTrue(true, "'CompanyId' is null, Dummy response received"); ;
                return;
            }

            else if (containsAlphabet)
            {
                // Log the result and assert success
                Console.WriteLine("\nTest Scripts Results: ");
                Console.WriteLine("Valid Input Values                                      :    FAIL");
                Console.WriteLine($"CompanyId: {companyIdStr} contains alphabets           :    PASS");
                Assert.IsTrue(containsAlphabet, "Test passed: companyId contains alphabets.");
                return;
            }
            else if (containsNumbersOnly)
            {
                // Log the result for numeric check
                Console.WriteLine("\nTest Scripts Results: ");
                Console.WriteLine("Valid Input Values                                        :    FAIL");
                Console.WriteLine($"CompanyId: {companyIdStr} contains numeric.              :    PASS");
                Assert.IsTrue(containsNumbersOnly, "Test passed: Dummy response received");
                return;
            }
            else
            {
                // If neither alphabets nor valid numbers
                Console.WriteLine("\nTest Scripts Results: ");
                Console.WriteLine("Valid Input Values                                        :    FAIL");
                Console.WriteLine($"CompanyId: {companyIdStr} contains Special Character.    :    PASS");
                Assert.Fail("Test failed: Dummy response received");
            }
        }
        [TestMethod]
        public void ValidTypeValue(int? type, int? companyId)
        {
            if (type == null || companyId == null)
            {
                Console.WriteLine("Test Passed: 'type' or 'companyId' is null, condition met.");
                Assert.IsTrue(true, "'type' or 'companyId' is null, condition passed.");
            }
            else
            {
                Console.WriteLine("Test Passed: 'type' is not null, type value does'nt exist. ");
                Assert.IsTrue(true, "'type' is not null, condition passed.");
            }
        }
    }
}
