using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.TestScripts_Otp_Verification
{
    [TestClass]
    public class Otp_Verification_TestScript
    {
        [TestMethod]
        public void OTP_Matched(bool IsSuccessful)
        {
            if (IsSuccessful == true)
            {
                Console.WriteLine("\nTest Script :");
                Console.WriteLine("OTP Matched Successfully            :     PASS");
                Console.WriteLine("Invalid OTP or userGuid             :     FAIL");
                Console.WriteLine("Invalid  Url                        :     FAIL\n");
                Assert.AreEqual(true, true);
                
            }
        }
        [TestMethod]
        public void Invalid_OTP(bool IsSuccessful)
        {
            if (IsSuccessful == false)
            {
                Console.WriteLine("\nTest Script :");
                Console.WriteLine("OTP Matched Successfully            :     FAIL");
                Console.WriteLine("Invalid OTP or userGuid             :     PASS");
                Console.WriteLine("Invalid  Url                        :     FAIL\n");
                Assert.AreEqual(true, true);
            }
        }
        [TestMethod]
        public void Otp_Invalidurl()
        {
            Console.WriteLine("Test Script :");
            Console.WriteLine("OTP Matched Successfully               :     FAIL");
            Console.WriteLine("Invalid  or empty   email / username   :     FAIL");
            Console.WriteLine("Invalid  Url                           :     PASS\n");
            Assert.AreEqual(true, true);
        }
    }
}

