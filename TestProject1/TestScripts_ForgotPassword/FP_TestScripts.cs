using ApiTesting_Calimatic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiTesting_Calimatic.Forgot_PasswordAttempt;

namespace TestProject1.TestScripts_ForgotPassword
{
    [TestClass]
    public class FP_TestScripts
    {
        [TestMethod]
        public void ForgotPassword_Script()
        {
            var result = new Forgot_Password_Dataget();
            var Password = new ApiStudents();
            var data = result.Getfile_FP();
            foreach (var entry in data)
            {
                // Console.WriteLine(entry);
                Console.WriteLine($"Email: {entry.email}, username: {entry.username}, url: {entry.url}");
                var response = Password.ForgotPassword(entry);
                if (response["Message"] != null && response["Message"].ToString() == "The ConnectionString property has not been initialized.")
                {
                    Console.WriteLine("Test Passed: URL Not Found");
                }
                else
                {
                    Console.WriteLine("Test Failed: Unexpected message or missing field.");
                }
            }
            Assert.AreEqual(true, response.IsSuccessful);
        }
    }
}