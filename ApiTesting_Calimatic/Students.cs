using ApiTesting_Calimatic.AppLoginFolder;
using ApiTtesting_Calimatic;
using CsvHelper;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Commons.DTO_s.Auth;
using ApiTesting_Calimatic.Forgot_PasswordAttempt;

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
                return true;
            }
            return false;
        }

        //------------->Auth
        //AppLogin Endpoint Check
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
            if (DataLogin.IsSuccessful == true)
            {
                Console.WriteLine($"Response: Valid Login Credential");
            }
            else
            {
                Console.WriteLine($"Response: Invalid Login Attempt");
            }
            return DataLogin;
        }

        //Forgot Password
        public ForgotPassword_Class ForgotPassword(csv_FP_Data request)
        {
            Login();
            var data = new Forgot_Password_Dataget();
            var dataFP = data.Getfile_FP();
            ForgotPassword_Class finalResult = null; // Store the result, initially null

            // If no records in dataFP, you may want to handle that case.
            if (dataFP == null || !dataFP.Any())
            {
                Console.WriteLine("No records found.");
                return finalResult; // Return null or handle as appropriate
            }
            foreach (var record in dataFP)
            {
                string queryString = $"Email={record.email}&username={record.username}&url={record.url}";
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/Auth/ForgotPassword?{queryString}", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_ForgotData = restClient.Get(restRequest);
                var Forgot_request = JsonConvert.DeserializeObject<Commons.DTO_s.Auth.ForgotPassword_Class>(response_ForgotData.Content);
                if (Forgot_request.IsSuccessful == true)
                {
                    Console.WriteLine($"Response: Forgot password Successfully\n");
                }
                else
                {
                    Console.WriteLine($"Response: Username or email is invalid!\n");
                }
                finalResult = Forgot_request;
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