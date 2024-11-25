using ApiTesting_Calimatic.AppLoginFolder;
using Newtonsoft.Json;
using RestSharp;
using Commons.DTO_s.Auth;
using ApiTesting_Calimatic.Forgot_PasswordAttempt;
using TestProject1.TestScripts_ForgotPassword;
using TestProject1;
using TestProject1.TestScripts_Otp_Verification;
using ApiTesting_Calimatic.GetCompany;
using TestProject1.TestScripts_GetCompanyUrl;

namespace ApiTesting_Calimatic
{
    public class ApiStudents
    {
        public string bearerToken;

        // Login Method
        public bool Login()
        {
            var restClient = new RestClient("https://angular-api.calibermatrix.com");
            var restRequest = new RestRequest("/api/Auth/AppLogin", Method.Post);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;

            // Add the username and password to the request body
            var loginBody = new
            {
                userName = "admin",
                password = "admin1"
            };
            restRequest.AddJsonBody(loginBody);

            var responsedata = restClient.Execute(restRequest);
            if (responsedata.IsSuccessful)
            {
                var responseData = JsonConvert.DeserializeObject<ApiTesting_Calimatic.AppLoginFolder.AppLogin>(responsedata.Content);
                bearerToken = responseData.Response;
              //  Console.WriteLine("Bearer Token generated Successfully");
                return true;
                
            }
            return false;
            
        }

        //------------->Auth<-------------
        // 1-  AppLogin Endpoint Check      ----/api/Auth/AppLogin----
        public AppLogin TestLogin(csvData requestdata)
        {

            Login();
            var restClient = new RestClient("https://angular-api.calibermatrix.com");
            var restRequest = new RestRequest("/api/Auth/AppLogin", Method.Post);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddJsonBody(requestdata);
            var responsedata = restClient.Execute(restRequest);
            var DataLogin = JsonConvert.DeserializeObject<ApiTesting_Calimatic.AppLoginFolder.AppLogin>(responsedata.Content);
            var LoginScriptcall = new login_Testscripts();
            if (DataLogin.IsSuccessful == true)
            {
                Console.WriteLine("API Response: " + responsedata.Content);           
                LoginScriptcall.ValidLoginCredential(DataLogin.IsSuccessful);
            }
            else
            {
                Console.WriteLine("API Response: " + responsedata.Content);
                LoginScriptcall.inValidLoginCredential(DataLogin.IsSuccessful);
            }
           
            return DataLogin;
        }

        //2-   Forgot Password          --- /api/Auth//api/Auth/ForgotPassword ---
        public ForgotPassword_Class ForgotPassword()
        {
            Login();
            Console.WriteLine("----------------- /api/Auth/ForgotPassword -----------------\n");
            var data = new Forgot_Password_Dataget();
            var dataFP = data.Getfile_FP();
            ForgotPassword_Class finalResult = null; // Store the result, initially null

            // If no records in dataFP, you may want to handle that case.
            if (dataFP == null || !dataFP.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in dataFP)
            {
                try
                {
                    Console.WriteLine("Input Value : ");
                    Console.WriteLine($"Email: {record.email}, \nusername: {record.username}, \nurl: {record.url}");
                    string queryString = $"Email={record.email}&username={record.username}&url={record.url}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"/api/Auth/ForgotPassword?{queryString}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_ForgotData = restClient.Get(restRequest);
                    var Forgot_request = JsonConvert.DeserializeObject<Commons.DTO_s.Auth.ForgotPassword_Class>(response_ForgotData.Content);
                    var ForgotScriptcall = new FP_TestScripts();
                    if (Forgot_request.IsSuccessful == true)
                    {
                        Console.WriteLine("API Response: " + response_ForgotData.Content);
                        ForgotScriptcall.ForgotPassword_Script(Forgot_request.IsSuccessful);
                        var Otp = new ApiStudents();
                    //    Otp.OtpForgotPassword();

                    }
                    else
                    {
                        Console.WriteLine("API Response: " + response_ForgotData.Content);
                        ForgotScriptcall.ForgotPassword_Script2(Forgot_request.IsSuccessful);
                    }
                    finalResult = Forgot_request;
                }
                catch (Exception ex) {
                    Console.WriteLine("\nAPI Response : " + ex.Message);
                    var ForgotScriptcall = new FP_TestScripts();
                    ForgotScriptcall.Invalidurl();
                }
            }
             return finalResult;
        }

        //3- Forgot Password OTP Verification           --- /api/Auth/ForgotPasswordOtpVerification ---
        public ForgotPassword_Class OtpForgotPassword()
        {
            Login();
            Console.WriteLine("----------------- /api/Auth/ForgotPasswordOtpVerification -----------------\n");
            var data = new FPass_OTP_Verification_RF();
            var Otp_Code_FP = data.Get_Otpfile_FP();
            ForgotPassword_Class finalResult = null;

            // If no records in Otp_Code_FP, you may want to handle that case.
            if (Otp_Code_FP == null || !Otp_Code_FP.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in Otp_Code_FP)
            {
                try
                {
                    Console.WriteLine("Input Value : ");
                    Console.WriteLine($"Otp: {record.otp} , \nuserGuid:  {record.userGuid}, \nurl: {record.url}");
                    string queryString_Otp = $"Otp={record.otp} &userGuid= {record.userGuid} &url={record.url}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"/api/Auth/ForgotPasswordOtpVerification?{queryString_Otp}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_Otp_ForgotData = restClient.Get(restRequest);
                    var Otp_Forgot_request = JsonConvert.DeserializeObject<Commons.DTO_s.Auth.ForgotPassword_Class>(response_Otp_ForgotData.Content);
                    var OTP_Scriptcall = new Otp_Verification_TestScript();
                    if (Otp_Forgot_request.IsSuccessful == true)
                    {
                        Console.WriteLine("API Response: " + response_Otp_ForgotData.Content);
                        OTP_Scriptcall.OTP_Matched(Otp_Forgot_request.IsSuccessful);
                    }
                    else
                    {
                        Console.WriteLine("API Response: " + response_Otp_ForgotData.Content);
                        OTP_Scriptcall.Invalid_OTP(Otp_Forgot_request.IsSuccessful);
                    }
                    finalResult = Otp_Forgot_request;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nAPI Response : " + ex.Message);
                    var OTP_Scriptcall = new Otp_Verification_TestScript();
                    OTP_Scriptcall.Otp_Invalidurl();
                }
            }
            return finalResult;
        }

        //4- get Company URL            --- /api/Auth/getCompanyUrl
        public ForgotPassword_Class GetCompanyUrl()
        {
            Login();
            Console.WriteLine("----------------- /api/Auth/getCompanyUrl -----------------\n");
            var datacompanyurl = new getCompanyUrl_RF();
            var companyurl = datacompanyurl.Get_companyurl_FP();
            ForgotPassword_Class finalResult = null;

            // If no records in companyurl, you may want to handle that case.
            if (companyurl == null || !companyurl.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in companyurl)
            {
                try
                {
                    Console.WriteLine("Input Value : ");
                    Console.WriteLine($"userName: {record.userName}");
                    string queryString_company = $"userName={record.userName}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"/api/Auth/getCompanyUrl?{queryString_company}", Method.Post);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_Comapanyurl = restClient.Execute(restRequest);
                    var CompanyUrl_request = JsonConvert.DeserializeObject<Commons.DTO_s.Auth.ForgotPassword_Class>(response_Comapanyurl.Content);
                    var CompanyUrl_Scriptcall = new GetCompanyUrl_TestScripts();
                    if (CompanyUrl_request.Response == "https://core-lms.calibermatrix.com")
                    {
                        Console.WriteLine("API Response: " + response_Comapanyurl.Content);
                        CompanyUrl_Scriptcall.valid_username(CompanyUrl_request.Response);
                    }
                    else
                    {
                        Console.WriteLine("API Response: " + response_Comapanyurl.Content);
                        CompanyUrl_Scriptcall.Invalid_username(CompanyUrl_request.Response);
                    }
                    finalResult = CompanyUrl_request;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nAPI Response : " + ex.Message);
                }
            }
            return finalResult;
        }

        //GET Students Record
        //public StudentResponse GetStudents()
        //{
        //    //GET Method
        //    //      string bearerToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJJZCI6IjEiLCJGaXJzdE5hbWUiOiJTYXVmaWsgICIsIkxhc3ROYW1lIjoiQWRtaW4iLCJFbWFpbCI6InNhdWZpa3Rlc3RlcnNAbWFpbGluYXRvci5jb20iLCJVc2VyTmFtZSI6ImFkbWluIiwiUm9sZSI6IjEiLCJHdWlkIjoiMWI3ODQxMDUtMzZmOC00MjY5LTljODYtNzc0MzBmNjRkMDkwIiwiSXNGcmFuY2hpc2UiOiJGYWxzZSIsIkNvbXBhbnlHdWlkIjoiNmY5ZjE1YzMtNThiYS00NTNjLTgwNTctZDVhZjU1MGNlZDM5IiwiUGFyZW50Q29tcGFueUd1aWQiOiI2ZjlmMTVjMy01OGJhLTQ1M2MtODA1Ny1kNWFmNTUwY2VkMzkiLCJDb21wYW55TmFtZSI6IkNvcmUgTE1TIiwiQ29tcGFueUlkIjoiMSIsIlBhcmVudENvbXBhbnlJZCI6IjAiLCJEb21haW5VcmwiOiJodHRwczovL2NvcmUtbG1zLmNhbGliZXJtYXRyaXguY29tIiwiRmFtaWx5SWQiOiIwIiwiSXNJbXBlcnNvbmF0aW5nIjoiRmFsc2UiLCJJbXBlcnNvbmF0ZUFkbWluVXNlcm5hbWUiOiIiLCJQYXltZW50R2F0ZXdheSI6IjEiLCJEZWZhdWx0VGltZVpvbmUiOiJQYWtpc3RhbiBTdGFuZGFyZCBUaW1lIiwiUG9ydGFsVXJsIjoiaHR0cHM6Ly9jZWR1dC1kZXYtY3VzLXBvcnRhbC1hcHAtMDEuYXp1cmV3ZWJzaXRlcy5uZXQiLCJGcmFuY2hpc2VTZWN1cmVVcmwiOiJodHRwczovL3NlY3VyZS1jb3JlLWxtcy5jYWxpYmVybWF0cml4LmNvbSIsIlNlY3VyZUNvbXBhbnlJZCI6IjE1MzYiLCJleHAiOjE3MzQwMDcwOTAsImlzcyI6IkNhbGltYXRpYy5jb20iLCJhdWQiOiJsb2NhbGhvc3QifQ.gJ748rYCuQz0QWBdHa605YpfOngmZv98e-GkXX80GPY";
        //    Login();
        //    var restClient = new RestClient("https://angular-api.calibermatrix.com");
        //    var restRequest = new RestRequest("/api/Student/students", Method.Get);
        //    restRequest.AddHeader("Accept", "application/json");
        //    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
        //    restRequest.RequestFormat = DataFormat.Json;

        //    var response = restClient.Get(restRequest);
        //    var content = response.Content;

        //    var student = JsonConvert.DeserializeObject<StudentResponse>(content);
        //    return student;
        //}
        //   public duplusername checkduplicateusername()
        //   {
        //       //Post Method
        ////string bearerToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJJZCI6IjEiLCJGaXJzdE5hbWUiOiJTYXVmaWsgICIsIkxhc3ROYW1lIjoiQWRtaW4iLCJFbWFpbCI6InNhdWZpa3Rlc3RlcnNAbWFpbGluYXRvci5jb20iLCJVc2VyTmFtZSI6ImFkbWluIiwiUm9sZSI6IjEiLCJHdWlkIjoiMWI3ODQxMDUtMzZmOC00MjY5LTljODYtNzc0MzBmNjRkMDkwIiwiSXNGcmFuY2hpc2UiOiJGYWxzZSIsIkNvbXBhbnlHdWlkIjoiNmY5ZjE1YzMtNThiYS00NTNjLTgwNTctZDVhZjU1MGNlZDM5IiwiUGFyZW50Q29tcGFueUd1aWQiOiI2ZjlmMTVjMy01OGJhLTQ1M2MtODA1Ny1kNWFmNTUwY2VkMzkiLCJDb21wYW55TmFtZSI6IkNvcmUgTE1TIiwiQ29tcGFueUlkIjoiMSIsIlBhcmVudENvbXBhbnlJZCI6IjAiLCJEb21haW5VcmwiOiJodHRwczovL2NvcmUtbG1zLmNhbGliZXJtYXRyaXguY29tIiwiRmFtaWx5SWQiOiIwIiwiSXNJbXBlcnNvbmF0aW5nIjoiRmFsc2UiLCJJbXBlcnNvbmF0ZUFkbWluVXNlcm5hbWUiOiIiLCJQYXltZW50R2F0ZXdheSI6IjEiLCJEZWZhdWx0VGltZVpvbmUiOiJQYWtpc3RhbiBTdGFuZGFyZCBUaW1lIiwiUG9ydGFsVXJsIjoiaHR0cHM6Ly9jZWR1dC1kZXYtY3VzLXBvcnRhbC1hcHAtMDEuYXp1cmV3ZWJzaXRlcy5uZXQiLCJGcmFuY2hpc2VTZWN1cmVVcmwiOiJodHRwczovL3NlY3VyZS1jb3JlLWxtcy5jYWxpYmVybWF0cml4LmNvbSIsIlNlY3VyZUNvbXBhbnlJZCI6IjE1MzYiLCJleHAiOjE3MzQwMDcwOTAsImlzcyI6IkNhbGltYXRpYy5jb20iLCJhdWQiOiJsb2NhbGhvc3QifQ.gJ748rYCuQz0QWBdHa605YpfOngmZv98e-GkXX80GPY";

        //       var restClient = new RestClient("https://angular-api.calibermatrix.com");
        //       var restRequest = new RestRequest("/api/PaymentCommon/DuplicateUserName?username=admin", Method.Post);

        //       // Add username to the request body
        //       restRequest.AddHeader("Accept", "application/json");
        //       restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");

        //       // Send the username in the request body as JSON
        //       restRequest.RequestFormat = DataFormat.Json;

        //       var response = restClient.Execute(restRequest);
        //       var content = response.Content;

        //       var username = JsonConvert.DeserializeObject<duplusername>(content);
        //       return username;
        //   }

    }
}