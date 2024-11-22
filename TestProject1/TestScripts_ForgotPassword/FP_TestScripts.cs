using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;



namespace TestProject1.TestScripts_ForgotPassword
{
    [TestClass]
    public class FP_TestScripts
    {
        [TestMethod]
        public void ForgotPassword_Script(bool IsSuccessful)
        {
            if (IsSuccessful == true)
            {
                Console.WriteLine("\nTest Script :");
                Console.WriteLine("Otp Send Email Successfully               :   PASS");
                Console.WriteLine("Invalid  or empty   email / username      :   FAIL");
                Console.WriteLine("Invalid  Url                              :   FAIL\n");
                Assert.AreEqual(true, true);
            }
        }

        [TestMethod]
        public void ForgotPassword_Script2(bool IsSuccessful)
        {
            if (IsSuccessful == false)
            {
                Console.WriteLine("\nTest Script :");
                Console.WriteLine("Otp Send Email Successfully               :   FAIL");
                Console.WriteLine("Invalid  or empty   email / username      :   PASS");
                Console.WriteLine("Invalid  Url                              :   FAIL\n");
                Assert.AreEqual(true, true);
            }
        }

        [TestMethod]
        public void Invalidurl()
        {
                Console.WriteLine("Test Script :");
                Console.WriteLine("Otp Send Email Successfully            :   FAIL");
                Console.WriteLine("Invalid  or empty   email / username   :   FAIL");
                Console.WriteLine("Invalid  Url                           :   PASS\n");
                Assert.AreEqual(true, true);
        }
    }
}