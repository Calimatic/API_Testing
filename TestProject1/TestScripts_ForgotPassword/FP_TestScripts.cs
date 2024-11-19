using ApiTesting_Calimatic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiTesting_Calimatic.Forgot_PasswordAttempt;
using Newtonsoft.Json;
using Commons.DTO_s.Auth;

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
                Console.WriteLine($"Email: {entry.email}, username: {entry.username}, url: {entry.url}");
                string jsonResponse = @"{
                                        'Response': 'Username or email is invalid!',
                                        'IsSuccessful': false,
                                        'StatusCode': 401
                                    }";

                // Deserialize the JSON string into an ApiResponse object
                ForgotPassword_Class apiResponse = JsonConvert.DeserializeObject<ForgotPassword_Class>(jsonResponse);

                // Check if the response was not successful
                if (!apiResponse.IsSuccessful)
                {
                    // Handle the error based on status code and response message
                    if (apiResponse.StatusCode == 401)
                    {
                        Console.WriteLine("Authentication Error: " + apiResponse.Response);
                    }
                    else
                    {
                        Console.WriteLine("Error: " + apiResponse.Response);
                    }
                }
                else
                {
                    Console.WriteLine("Request was successful.");
                }
          //      Assert.AreEqual(true, response.IsSuccessful);
            }           
        }
    }
}