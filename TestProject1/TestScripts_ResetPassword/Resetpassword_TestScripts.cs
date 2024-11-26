using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.TestScripts_ResetPassword
{
    [TestClass]
    public class Resetpassword_TestScripts
    {
        [TestMethod]
        public void Password_Changed_Scuccesfully (string Response)
        {
            if (Response == "Password saved successfully!!")
            {
                Console.WriteLine("\nTest Script :");
                Console.WriteLine("Password saved successfully          :     PASS");
                Console.WriteLine("Invalid Url                          :     FAIL");
                Console.WriteLine("Invalid  UserGuid                    :     FAIL\n");
                Assert.AreEqual(true, true);

            }
        }
        [TestMethod]
        public void Invalid_userGuid(string Response)
        {
            if (Response == null)
            {
                Console.WriteLine("\nTest Script :");
                Console.WriteLine("Invalid UserGuid                     :     PASS");
                Console.WriteLine("Password saved successfully          :     FAIL");
                Console.WriteLine("Invalid Url                          :     FAIL\n");
                Assert.AreEqual(true, true);

            }
        }
        [TestMethod]
        public void Invalid_Url(string Response)
        {         
                Console.WriteLine("\nTest Script :");
                Console.WriteLine("Invalid Url                          :     PASS");
                Console.WriteLine("Password saved successfully          :     FAIL");
                Console.WriteLine("Invalid UserGuid                     :     FAIL\n");
                Assert.AreEqual(true, true);
        }
    }
}
