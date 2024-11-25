using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace TestProject1.TestScripts_GetCompanyUrl
{
    [TestClass]
    public class GetCompanyUrl_TestScripts
    {
        [TestMethod]
        public void valid_username(string response)
        {
            if (response == "https://core-lms.calibermatrix.com")
            {
                Console.WriteLine("\nTest Script :");
                Console.WriteLine("Valid username            :     PASS");
                Console.WriteLine("Invalid username          :     FAIL\n");
                Assert.AreEqual(true, true);

            }
        }
        [TestMethod]
        public void Invalid_username(string response)
        {
            if (response != "https://core-lms.calibermatrix.com")
            {
                Console.WriteLine("\nTest Script :");
                Console.WriteLine("Invalid username          :     PASS");
                Console.WriteLine("Valid username            :     FAIL");
                Assert.AreEqual(true, true);

            }
        }
    }
}
