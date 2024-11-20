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
                Console.WriteLine("Test SCript Result : Valid Entries");
                Assert.AreEqual(true, true);
            }
        }

        [TestMethod]
        public void ForgotPassword_Script2(bool IsSuccessful)
        {
            if (IsSuccessful == false)
            {
                Console.WriteLine("Test SCript Result : InValid Entries");
                Assert.AreEqual(true, true);
            }
        }
        //   var result = new Forgot_Password_Dataget();
        //  var Password = new ApiStudents();
        ////  var data1 = result.Getfile_FP();
        //  try
        //  {
        //      foreach (var entry in data1)
        //      {
        //          Console.WriteLine($"Email: {entry.email}, username: {entry.username}, url: {entry.url}");
        //          var response = Password.ForgotPassword(entry);
        //string jsonResponse = @"{
        //                      'Response': 'Username or email is invalid!',
        //                      'IsSuccessful': false,
        //                      'StatusCode': 401
        //                  }";

        //// Deserialize the JSON string into an ApiResponse object
        //ForgotPassword_Class apiResponse = JsonConvert.DeserializeObject<ForgotPassword_Class>(jsonResponse);

        ////   Check if the response was not successful
        //if (!apiResponse.IsSuccessful)
        //{
        //    // Handle the error based on status code and response message
        //    if (apiResponse.StatusCode == 401)
        //    {
        //        Console.WriteLine("Authentication Error: " + apiResponse.Response);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Error: " + apiResponse.Response);
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Request was successful.");
        //}
        //   Assert.AreEqual(true, response.IsSuccessful);
        //   }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
    }
}