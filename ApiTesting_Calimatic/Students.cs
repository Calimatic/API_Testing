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
using TestProject1.TestScripts_ResetPassword;
using TestProject1.Dashboard.Widgets_Folder;
using Commons.DTO_s.Widget;
using Commons.DTO_s.Dashboards.Partner_Enrollment;
using ApiTesting_Calimatic.Dashboard_RF.PartnerEnrollment_RF;
using TestProject1.Dashboard.Partner_Enrollment;
using System.Net;
using System.Text.RegularExpressions;
using ApiTesting_Calimatic.Dashboard_RF.ClassEnrollmentCountByType_RF;
using TestProject1.Dashboard.ClassEnrollmentCountByType;
using ApiTesting_Calimatic.Dashboard_RF.EnrollmentPerformance_RF;
using TestProject1.Dashboard.EnrollmentPerformance_TestScrpts;
using ApiTesting_Calimatic.Dashboard_RF.EventEnrollmentCountByType_RF;
using TestProject1.Dashboard.EventEnrollmentCountByType_testScripts;
using ApiTesting_Calimatic.Dashboard_RF.studentAttendance_RF;
using TestProject1.Dashboard.studentAttendance_Testscript;
using Commons.DTO_s.Dashboards.studentAttendance_Response;
using TestProject1.Dashboard.GetActiveCourseCountByType_TestScripts;
using Commons.DTO_s.Dashboards.GetActive_CourseCount;
using Commons.DTO_s.Dashboards.listofleadscount_Response;
using TestProject1.Dashboard.listofleadcount_TestScripts;
using TestProject1.Dashboard.topfranchisesbyrevenue_TestScripts;
using Commons.DTO_s.Dashboards.topfranchisesbyrevenue_Response;
using Commons.DTO_s.Dashboards.getStudentPointsCounter_resposne;
using TestProject1.Dashboard.getStudentPointsCounter_TestScripts;
using ApiTesting_Calimatic.Dashboard_RF.restoreWidgetsToDefault_RF;
using TestProject1.Dashboard.restoreWidgetsToDefault_TestScripts;
using ApiTesting_Calimatic.Dashboard_RF.leadsGeneration_RF;
using TestProject1.Dashboard.leadsGeneration_TestScript;
using ApiTesting_Calimatic.Dashboard_RF.ClassDropOffCountByType_RF;
using TestProject1.Dashboard.ClassDropOffCountByType_TestScripts;
using ApiTesting_Calimatic.Dashboard_RF.EventDropOffCountByType_RF;
using ApiTesting_Calimatic.AppLoginClass;

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
                var responseData = JsonConvert.DeserializeObject<ApiTesting_Calimatic.AppLoginFolder.ApiResponse<string>>(responsedata.Content);
                bearerToken = responseData.Response;
                //  Console.WriteLine("Bearer Token generated Successfully");
                return true;

            }
            return false;
        }

        //------------->Auth<-------------
              // 1-  AppLogin Endpoint Check      ----/api/Auth/AppLogin----
        public AppLogin_response TestLogin(csvData requestdata)
              {
                  Login();
                  var restClient = new RestClient("https://angular-api.calibermatrix.com");
                  var restRequest = new RestRequest("/api/Auth/AppLogin", Method.Post);
                  restRequest.AddHeader("Accept", "application/json");
                  restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                  restRequest.RequestFormat = DataFormat.Json;
                  restRequest.AddJsonBody(requestdata);
                  var responsedata = restClient.Execute(restRequest);
                  var DataLogin = JsonConvert.DeserializeObject<ApiTesting_Calimatic.AppLoginClass.AppLogin_response>(responsedata.Content);
                  var LoginScriptcall = new login_Testscripts();
                  if (DataLogin.isSuccessful == true)
                  {
                      Console.WriteLine("API Response: " + responsedata.Content);           
                      LoginScriptcall.ValidLoginCredential(DataLogin.isSuccessful);
                  }
                  else
                  {
                      Console.WriteLine("API Response: " + responsedata.Content);
                      LoginScriptcall.inValidLoginCredential(DataLogin.isSuccessful);
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

        //4- get Company URL            --- /api/Auth/getCompanyUrl ---
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

        //5- Reset Password            --- /api/Auth/ResetPassword ---
         public ForgotPassword_Class ResetPassword()
              {
                  Login();
                  Console.WriteLine("\n----------------- /api/Auth/ResetPassword -----------------\n");
                  var Restetpass = new ResetPassword_Dataget();
                  var reset = Restetpass.Resetpassword_FP();
                  ForgotPassword_Class finalResult = null;

                  // If no records in ResetPassword, you may want to handle that case.
                  if (reset == null || !reset.Any())
                  {
                      Console.WriteLine("No records found.");
                      // Return null or handle as appropriate
                      return finalResult;
                  }
                  foreach (var record in reset)
                  {
                      try
                      {
                          Console.WriteLine("Input Values : ");
                          Console.WriteLine($"password: {record.password} , \nconfirmPassword:  {record.confirmPassword}, \nuserGuid: {record.userGuid}, \ncompanyUrl: {record.companyUrl}");
                          var bodyContent = new
                          {
                              password = record.password,
                              confirmPassword = record.confirmPassword,
                              userGuid = record.userGuid,
                              companyUrl = record.companyUrl
                          };
                          var restClient = new RestClient("https://angular-api.calibermatrix.com");
                          var restRequest = new RestRequest($"/api/Auth/ResetPassword", Method.Post);
                          restRequest.AddHeader("Accept", "application/json");
                          restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                          restRequest.RequestFormat = DataFormat.Json;
                          restRequest.AddJsonBody(bodyContent);
                          var response_Comapanyurl = restClient.Execute(restRequest);
                          var resetPass_request = JsonConvert.DeserializeObject<Commons.DTO_s.Auth.ForgotPassword_Class>(response_Comapanyurl.Content);
                          var resetPass_Scriptcall = new Resetpassword_TestScripts();
                          if (resetPass_request.Response == "Password saved successfully!!")
                          {
                              Console.WriteLine("API Response: " + response_Comapanyurl.Content);
                              resetPass_Scriptcall.Password_Changed_Scuccesfully(resetPass_request.Response);
                          }
                          else if (resetPass_request.Response == "Unable to update password!")
                          {
                              Console.WriteLine("API Response: " + response_Comapanyurl.Content);
                              resetPass_Scriptcall.Invalid_Url(resetPass_request.Response);
                          }
                          else
                          {
                              Console.WriteLine("API Response: " + response_Comapanyurl.Content);
                              resetPass_Scriptcall.Invalid_userGuid(resetPass_request.Response);
                          }
                          finalResult = resetPass_request;
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

        //------------->Dashboard<-------------
            // 1- Widgets Endpoint Check
        public bool Widgets()
            {
                try 
                { 
                        Login();
                        Console.WriteLine("----------------- /api/Dashboard/widgets -----------------\n");
                        var restClient = new RestClient("https://angular-api.calibermatrix.com");
                        var restRequest = new RestRequest($"/api/Dashboard/widgets", Method.Get);
                        restRequest.AddHeader("Accept", "application/json");
                        restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                        restRequest.RequestFormat = DataFormat.Json;
                        var response_widgets = restClient.Get(restRequest);
                        var widget_Scriptcall = new TestScripts_widgets();
                        if (response_widgets.Content.StartsWith("{"))
                        {
                            // Deserialize as a List if the response is an array
                            var widget_request = JsonConvert.DeserializeObject<ApiResponse<List<WidgetResponse>>>(response_widgets.Content);
                            Console.WriteLine("API Response: " + response_widgets.Content);
                            widget_Scriptcall.Get_Data_Widgets();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_widgets.Content);
                            widget_Scriptcall.Fail_Get_Data_widgets();
                        }
                    return true;
                    // return Otp_Forgot_request;
                }
                catch (Exception ex)
                {
                   Console.WriteLine("\nAPI Response : " + ex.Message);
                }
               // return widget_request;
                return false;
            }

        // 2- Partner Enrollment Endpoint Check
        public PartnerEnrollment_Response PartnerEnrollment()
            {
                Login();
                Console.WriteLine("----------------- /api/Dashboard/PartnerEnrollment -----------------\n");
                var partnerenroll_RF = new PartnerEnroll_RF();
                var getfile_partnerenroll = partnerenroll_RF.Getfile_PartnerEnroll();
                PartnerEnrollment_Response finalResult = null;

                // If no records in Partner Enrollment, you may want to handle that case.
                if (getfile_partnerenroll == null || !getfile_partnerenroll.Any())
                {
                    Console.WriteLine("No records found.");
                    // Return null or handle as appropriate
                    return finalResult;
                }
                foreach (var record in getfile_partnerenroll)
                {
                    try
                    {
                        Console.WriteLine("\nInput Value : ");
                        Console.WriteLine($"franchises: {record.franchises}");
                        string queryString_partner = $"franchises={record.franchises}";
                        var restClient = new RestClient("https://angular-api.calibermatrix.com");
                        var restRequest = new RestRequest($"/api/Dashboard/PartnerEnrollments?{queryString_partner}", Method.Get);
                        restRequest.AddHeader("Accept", "application/json");
                        restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                        restRequest.RequestFormat = DataFormat.Json;
                        var response_PartnerEnroll = restClient.Execute(restRequest);
                        var Partnerenroll_Scriptcall = new TestScripts_PartnerEnrollment();
                        if (response_PartnerEnroll.StatusCode == HttpStatusCode.OK)
                        {
                            var PartnerEnrollment_request = JsonConvert.DeserializeObject<ApiResponse<List<PartnerEnrollment_Response>>>(response_PartnerEnroll.Content);
                            if (PartnerEnrollment_request.IsSuccessful == true)
                            {
                                Console.WriteLine("API Response: " + response_PartnerEnroll.Content);
                                Partnerenroll_Scriptcall.ValidFranchise_ID(record.franchises);
                            }
                            if (PartnerEnrollment_request.Response != null && PartnerEnrollment_request.Response.Any())
                            {
                                finalResult = PartnerEnrollment_request.Response.First();
                            }
                        }
                        else
                        {
                            var PartnerEnrollment_Errorrequest = JsonConvert.DeserializeObject<ErrorHandle_PartnerEnroll>(response_PartnerEnroll.Content);
                            string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                            if (Regex.IsMatch(record.franchises,pattern))
                            {
                                Console.WriteLine("API Response: " + PartnerEnrollment_Errorrequest.Message);
                                Partnerenroll_Scriptcall.SpecialCharacter(record.franchises);
                            }
                            else
                            {
                                Console.WriteLine("API Response: " + PartnerEnrollment_Errorrequest.Message);
                                Partnerenroll_Scriptcall.AlphabetCharacter(record.franchises);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                    }
                }
                    return finalResult;
            }

        // 3- ClassEnrollmentCountByType Endpoint Check
        public PartnerEnrollment_Response ClassEnrollmentCountByType()
            {
                Login();
                Console.WriteLine("----------------- /api/Dashboard/ClassEnrollmentCountByType -----------------\n");
                var ClassEnrollCountByType_RF = new ClassEnrollCountByType();
                var getfile_ClassEnrollCountByType = ClassEnrollCountByType_RF.Getfile_ClassEnrollCountByType();
                PartnerEnrollment_Response finalResult = null;

                // If no records in ClassEnrollmentCountByType, you may want to handle that case.
                if (getfile_ClassEnrollCountByType == null || !getfile_ClassEnrollCountByType.Any())
                {
                    Console.WriteLine("No records found.");
                    // Return null or handle as appropriate
                    return finalResult;
                }
                foreach (var record in getfile_ClassEnrollCountByType)
                {
                    try
                    {
                        Console.WriteLine("\nInput Value : ");
                        Console.WriteLine($"type: {record.type}, franchises: {record.franchises}");
                        string queryString_ClassEnroll = $"type={record.type}&franchises={record.franchises}";
                        var restClient = new RestClient("https://angular-api.calibermatrix.com");
                        var restRequest = new RestRequest($"/api/Dashboard/ClassEnrollmentCountByType?{queryString_ClassEnroll}", Method.Get);
                        restRequest.AddHeader("Accept", "application/json");
                        restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                        restRequest.RequestFormat = DataFormat.Json;
                        var response_ClassEnroll = restClient.Execute(restRequest);
                        var Classenroll_Scriptcall = new TestScripts_ClassEnroll();
                        if (response_ClassEnroll.StatusCode == HttpStatusCode.OK)
                        {
                            var ClassEnrollment_request = JsonConvert.DeserializeObject<ApiResponse<List<PartnerEnrollment_Response>>>(response_ClassEnroll.Content);
                            if (ClassEnrollment_request.IsSuccessful == true)
                            {
                                Console.WriteLine("API Response: " + response_ClassEnroll.Content);
                                Classenroll_Scriptcall.Valid_Type_FranchisesID(record.type,record.franchises);
                            }
                            if (ClassEnrollment_request.Response != null && ClassEnrollment_request.Response.Any())
                            {
                                finalResult = ClassEnrollment_request.Response.First();
                            }
                        }
                        else
                        {
                            var ClassEnrollment_Errorrequest = JsonConvert.DeserializeObject<ErrorHandle_PartnerEnroll>(response_ClassEnroll.Content);
                            string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                            string Alphabetpattern = @"^[a-zA-Z]+$";
                            var abc = Regex.IsMatch(record.franchises, Alphabetpattern);
                            if (Regex.IsMatch($"{record.type}{record.franchises}", pattern))
                            {
                                Console.WriteLine("API Response: " + ClassEnrollment_Errorrequest.Message);
                                Classenroll_Scriptcall.SpecialCharacter(record.franchises ,record.type);
                            }

                            else if (Regex.IsMatch(record.franchises, Alphabetpattern))
                            {
                                Console.WriteLine("API Response: " + ClassEnrollment_Errorrequest.Message);
                                Classenroll_Scriptcall.AlphabetCharacter(record.franchises);
                            }

                            else
                            {
                                Console.WriteLine("API Response: " + ClassEnrollment_Errorrequest.Message);
                                Classenroll_Scriptcall.Nullparamsvalue(record.franchises, record.type);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                    }
                }
                return finalResult;
            }
       
        // 4- Enrollment Performance Endpoint Check
        public PartnerEnrollment_Response EnrollmentPerformance()
        {
            Login();
            Console.WriteLine("----------------- /api/Dashboard/EnrollmentPerformance -----------------");
            var enrollperformance_RF = new EnrollPerformance_RF();
            var getfile_enrollpermformance = enrollperformance_RF.Getfile_EnrollmentPerformance();
            PartnerEnrollment_Response finalResult = null;

            // If no records in Enrollment Performance, you may want to handle that case.
            if (getfile_enrollpermformance == null || !getfile_enrollpermformance.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_enrollpermformance)
            {
                try
                {
                    Console.WriteLine("\nInput Values : ");
                    Console.WriteLine($"types: {record.types}, franchiseIds: {record.franchiseIds}, type: {record.type}, performance: {record.performance}");
                    string queryString_Enrollperformance = $"types={record.types}&franchiseIds={record.franchiseIds}&type={record.type}&performance={record.performance}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"/api/Dashboard/EnrollmentPerformance?{queryString_Enrollperformance}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_EnrollPermfromance = restClient.Execute(restRequest);
                    var EnrollPerformance_Scriptcall = new TestScripts_EnrollmemtPerformance();
                    if (response_EnrollPermfromance.StatusCode == HttpStatusCode.OK)
                    {
                        var ClassEnrollment_request = JsonConvert.DeserializeObject<ApiResponse<List<PartnerEnrollment_Response>>>(response_EnrollPermfromance.Content);
                        if (ClassEnrollment_request.IsSuccessful == true && ClassEnrollment_request.Response.Count>0)
                        {
                            Console.WriteLine("API Response: " + response_EnrollPermfromance.Content);
                            EnrollPerformance_Scriptcall.ValidInputValues(record.types, record.franchiseIds, record.type, record.performance);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_EnrollPermfromance.Content);
                            EnrollPerformance_Scriptcall.InvalidInputValues(record.types, record.franchiseIds, record.type, record.performance);
                        }
                        if (ClassEnrollment_request.Response != null && ClassEnrollment_request.Response.Any())
                        {
                            finalResult = ClassEnrollment_request.Response.First();
                        } 
                    }
                    else
                    {
                        var ClassEnrollment_Errorrequest = JsonConvert.DeserializeObject<ErrorHandle_PartnerEnroll>(response_EnrollPermfromance.Content);
                        string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                        string Alphabetpattern = @"^[a-zA-Z]+$";
                        string combinedInputValues_Special = $"{record.types},{record.franchiseIds}";
                        string combinedInputValues_Null = $"{record.types},{record.franchiseIds}";
                        string Null_testInput = @"^,$";
                        string testInputs = @"^\s*$";
                        var abc = Regex.IsMatch(record.types, Alphabetpattern);
                        //
                        if (Regex.IsMatch(record.franchiseIds, pattern))
                        {
                            Console.WriteLine("API Response: " + response_EnrollPermfromance.Content);
                            EnrollPerformance_Scriptcall.SpecialCharacter(record.franchiseIds);
                        }
                        else if (Regex.IsMatch(combinedInputValues_Null, Null_testInput))
                        {
                            Console.WriteLine("API Response: " + ClassEnrollment_Errorrequest.Message);
                            EnrollPerformance_Scriptcall.ValidateInput_NullValues(record.types, record.franchiseIds);
                        }
                        else if(Regex.IsMatch(record.types ?? "", testInputs))
                        {
                            Console.WriteLine("API Response: " + ClassEnrollment_Errorrequest.Message);
                            EnrollPerformance_Scriptcall.ValidateInput_NulltypeValues(record.types);
                        }
                        else if(Regex.IsMatch(record.franchiseIds ?? "" , testInputs))
                        {
                            Console.WriteLine("API Response: " + ClassEnrollment_Errorrequest.Message);
                            EnrollPerformance_Scriptcall.ValidateInput_NullfranchiseIds_Values(record.franchiseIds);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + ClassEnrollment_Errorrequest.Message);
                            EnrollPerformance_Scriptcall.ContainsAlphabet_franchiseIds(record.franchiseIds);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nAPI response with Exception Error Message : " + ex.Message);
                }
            }
            return finalResult;
        }
   
        // 5- EventEnrollmentCountByType Endpoint Check
        public PartnerEnrollment_Response EventEnrollmentCountByType()
        {
            Login();
            Console.WriteLine("----------------- /api/Dashboard/EventEnrollmentCountByType -----------------");
            var enrollCountBytype_RF = new EventEnrollCountByType();
            var enrollCountBytype = enrollCountBytype_RF.Getfile_EnrollCountByType();
            PartnerEnrollment_Response finalResult = null;

            // If no records in EventEnrollmentCountByType, you may want to handle that case.
            if (enrollCountBytype == null || !enrollCountBytype.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in enrollCountBytype)
            {
                try
                {
                    Console.WriteLine("\nInput Values : ");
                    Console.WriteLine($"type: {record.type}, franchises: {record.franchises}");
                    string queryString_EnrollCountBytype = $"type={record.type}&franchises={record.franchises}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"/api/Dashboard/EventEnrollmentCountByType?{queryString_EnrollCountBytype}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_EnrollPermfromance = restClient.Execute(restRequest);
                    var EventEnrollCountBytype_Scriptcall = new TestScripts_EventEnrollCountByType();
                    if (response_EnrollPermfromance.StatusCode == HttpStatusCode.OK)
                    {
                        var ClassEnrollment_request = JsonConvert.DeserializeObject<ApiResponse<List<PartnerEnrollment_Response>>>(response_EnrollPermfromance.Content);
                        if (ClassEnrollment_request.IsSuccessful == true && ClassEnrollment_request.Response.Count > 0)
                        {
                            Console.WriteLine("API Response: " + response_EnrollPermfromance.Content);
                            EventEnrollCountBytype_Scriptcall.ValidInputValues(record.type, record.franchises);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_EnrollPermfromance.Content);
                            EventEnrollCountBytype_Scriptcall.InvalidInputValues(record.type, record.franchises);
                        }
                        if (ClassEnrollment_request.Response != null && ClassEnrollment_request.Response.Any())
                        {
                            finalResult = ClassEnrollment_request.Response.First();
                        }
                    }
                    else
                    {
                        var ClassEnrollment_Errorrequest = JsonConvert.DeserializeObject<ErrorHandle_PartnerEnroll>(response_EnrollPermfromance.Content);
                        string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                        string Alphabetpattern = @"^[a-zA-Z]+$";
                        string combinedInputValues_Special = $"{record.type},{record.franchises}";
                        string combinedInputValues_Null = $"{record.type},{record.franchises}";
                        string Null_testInput = @"^,$";
                        string testInputs = @"^\s*$";
                        var abc = Regex.IsMatch(record.type, Alphabetpattern);
                        //
                        if (Regex.IsMatch(record.franchises, pattern))
                        {
                            Console.WriteLine("API Response: " + response_EnrollPermfromance.Content);
                            EventEnrollCountBytype_Scriptcall.SpecialCharacter(record.franchises);
                        }
                        else if (Regex.IsMatch(combinedInputValues_Null, Null_testInput))
                        {
                            Console.WriteLine("API Response: " + ClassEnrollment_Errorrequest.Message);
                            EventEnrollCountBytype_Scriptcall.ValidateInput_NullValues(record.type, record.franchises);
                        }
                        else if (Regex.IsMatch(record.type ?? "", testInputs))
                        {
                            Console.WriteLine("API Response: " + ClassEnrollment_Errorrequest.Message);
                            EventEnrollCountBytype_Scriptcall.ValidateInput_NulltypeValues(record.type);
                        }
                        else if (Regex.IsMatch(record.franchises ?? "", testInputs))
                        {
                            Console.WriteLine("API Response: " + ClassEnrollment_Errorrequest.Message);
                            EventEnrollCountBytype_Scriptcall.ValidateInput_Nullfranchises_Values(record.franchises);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + ClassEnrollment_Errorrequest.Message);
                            EventEnrollCountBytype_Scriptcall.ContainsAlphabet_franchises(record.franchises);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nAPI response with Exception Error Message : " + ex.Message);
                }
            }
            return finalResult;
        }
        
        // 6- studentAttendance Endpoint Check
        public PartnerEnrollment_Response studentAttendance()
        {
            Login();
            Console.WriteLine("----------------- /api/Dashboard/studentAttendance -----------------");
            var studentAttendance_RF = new studentAttend_RF();
            var stdAttendance = studentAttendance_RF.Getfile_studentAttendance();
            PartnerEnrollment_Response finalResult = null;

            // If no records in studentAttendance, you may want to handle that case.
            if (stdAttendance == null || !stdAttendance.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in stdAttendance)
            {
                try
                {
                    Console.WriteLine("\nInput Values : ");
                    Console.WriteLine($"type: {record.type}, franchises: {record.franchises}");
                    string queryString_studentAttendance = $"type={record.type} &franchises= {record.franchises}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"/api/Dashboard/studentAttendance?{queryString_studentAttendance}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_studentAttendance = restClient.Execute(restRequest);
                    var studentAttendance_Scriptcall = new TestScript_studentAttendance();
                    if (response_studentAttendance.StatusCode == HttpStatusCode.OK)
                    {
                        var studentAttendance_request = JsonConvert.DeserializeObject<ApiResponse<List<PartnerEnrollment_Response>>>(response_studentAttendance.Content);
                        if (studentAttendance_request.IsSuccessful == true && studentAttendance_request.Response.Count > 0)
                        {
                            Console.WriteLine("API Response: " + response_studentAttendance.Content);
                            studentAttendance_Scriptcall.ValidInputValues(record.type, record.franchises);
                        }
                        //else
                        //{
                        //    Console.WriteLine("API Response: " + response_studentAttendance.Content);
                        //    studentAttendance_Scriptcall.InvalidInputValues(record.type, record.franchises);
                        //}
                        if (studentAttendance_request.Response != null && studentAttendance_request.Response.Any())
                        {
                            finalResult = studentAttendance_request.Response.First();
                        }
                    }
                    else
                    {
                        var studentattendance_Errorrequest = JsonConvert.DeserializeObject<ErrorHandle_PartnerEnroll>(response_studentAttendance.Content);
                        string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                        string Alphabetpattern = @"^[a-zA-Z]+$";
                        string Alphabetpattern_types = @"'([a-zA-Z]+)'";
                        string combinedInputValues_Special = $"{record.type},{record.franchises}";
                        string combinedInputValues_Null = $"{record.type},{record.franchises}";
                        string Null_testInput = @"^,$";
                        string testInputs = @"^\s*$";
                        var abc = Regex.IsMatch(record.type, Alphabetpattern);
                        //
                        if (Regex.IsMatch(record.type, pattern))
                        {
                            Console.WriteLine("API Response: " + response_studentAttendance.Content);
                            studentAttendance_Scriptcall.SpecialCharacter(record.type);
                        }
                        else if (Regex.IsMatch(record.franchises, pattern))
                        {
                            Console.WriteLine("API Response: " + response_studentAttendance.Content);
                            studentAttendance_Scriptcall.SpecialCharacter_franchises(record.franchises);
                        }
                        else if (Regex.IsMatch(combinedInputValues_Null, Null_testInput))
                        {
                            Console.WriteLine("API Response: " + studentattendance_Errorrequest.Message);
                            studentAttendance_Scriptcall.ValidateInput_NullValues(record.type, record.franchises);
                        }
                        else if (Regex.IsMatch(record.type ?? "", testInputs))
                        {
                            Console.WriteLine("API Response: " + studentattendance_Errorrequest.Message);
                            studentAttendance_Scriptcall.ValidateInput_NulltypeValues(record.type);
                        }
                        else if (Regex.IsMatch(record.franchises ?? "", testInputs))
                        {
                            Console.WriteLine("API Response: " + studentattendance_Errorrequest.Message);
                            studentAttendance_Scriptcall.ValidateInput_Nullfranchises_Values(record.franchises);
                        }
                        else if (Regex.IsMatch(record.type ?? "", Alphabetpattern))
                        {
                            Console.WriteLine("API Response: " + studentattendance_Errorrequest.Message);
                            studentAttendance_Scriptcall.ContainsAlphabet_type(record.type);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + studentattendance_Errorrequest.Message);
                            studentAttendance_Scriptcall.ContainsAlphabet_franchises(record.franchises);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nAPI response with Exception Error Message : " + ex.Message);
                }
            }
            return finalResult;
        }
       
        // 7- GetActiveCourseCountByType Endpoint Check
        public bool GetActiveCourseCountByType()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/Dashboard/GetActiveCourseCountByType -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/Dashboard/GetActiveCourseCountByType", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_GetActiveCourseCountByType = restClient.Get(restRequest);
                var GetActiveCourseCountByType_Scriptcall = new TestScrips_ActiveCourseCountByType();
                if (response_GetActiveCourseCountByType.StatusCode == HttpStatusCode.OK)
                {
                    // Deserialize as a List if the response is an array
                    var ActiveCourse_request = JsonConvert.DeserializeObject<ApiResponse<List<Respone_Get_ActiveCourseCount>>>(response_GetActiveCourseCountByType.Content);
                    if (ActiveCourse_request.IsSuccessful == true && ActiveCourse_request.Response.Count > 0)
                    {
                        Console.WriteLine("API Response: " + response_GetActiveCourseCountByType.Content);
                        GetActiveCourseCountByType_Scriptcall.Successfully_Response();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_GetActiveCourseCountByType.Content);
                    GetActiveCourseCountByType_Scriptcall.Failed_Response();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }         

        // 8- listofleadscount Endpoint Check
        public bool listofleadscount()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/Dashboard/listofleadscount -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/Dashboard/listofleadscount", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_listofleadscount = restClient.Get(restRequest);
                var listofleadscount_Scriptcall = new TestScripts_leadOfLeadCount();
                if (response_listofleadscount.StatusCode == HttpStatusCode.OK)
                {
                    // Deserialize as a List if the response is an array
                    var listofleadcount_request = JsonConvert.DeserializeObject<ApiResponse<List<Response_listofleadscount>>>(response_listofleadscount.Content);
                    if (listofleadcount_request.IsSuccessful == true && listofleadcount_request.Response.Count > 0)
                    {
                        Console.WriteLine("API Response: " + response_listofleadscount.Content);
                        listofleadscount_Scriptcall.Successfully_Response();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_listofleadscount.Content);
                    listofleadscount_Scriptcall.Failed_Response();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }

        // 9- topfranchisesbyrevenue Endpoint Check
        public bool topfranchisesbyrevenue()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/Dashboard/listofleadscount -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/Dashboard/topfranchisesbyrevenue", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_topfranchisesbyrevenue = restClient.Get(restRequest);
                var topfranchisesbyrevenue_Scriptcall = new TestScripts_topfranchisesbyrevenue();
                if (response_topfranchisesbyrevenue.StatusCode == HttpStatusCode.OK)
                {
                    // Deserialize as a List if the response is an array
                    var listofleadcount_request = JsonConvert.DeserializeObject<ApiResponse<List<Response_topfranchisesbyrevenue>>>(response_topfranchisesbyrevenue.Content);
                    if (listofleadcount_request.IsSuccessful == true && listofleadcount_request.Response.Count > 0)
                    {
                        Console.WriteLine("API Response: " + response_topfranchisesbyrevenue.Content);
                        topfranchisesbyrevenue_Scriptcall.Successfully_Response();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_topfranchisesbyrevenue.Content);
                    topfranchisesbyrevenue_Scriptcall.Failed_Response();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }

        // 10- getStudentPointsCounter Endpoints Check
        public bool getStudentPointsCounter()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/Dashboard/getStudentPointsCounter -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/Dashboard/getStudentPointsCounter", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_getStudentPointsCounter = restClient.Get(restRequest);
                var getStudentPointsCounter_Scriptcall = new TestScripts_getStudentPointsCounter();
                if (response_getStudentPointsCounter.StatusCode == HttpStatusCode.OK)
                {
                    var getStudentPointsCounter_request = JsonConvert.DeserializeObject<EndpointResponse_getStudentPointsCunter>(response_getStudentPointsCounter.Content);
                    if (getStudentPointsCounter_request.IsSuccessful == true)
                    {
                        Console.WriteLine("API Response: " + response_getStudentPointsCounter.Content);
                        getStudentPointsCounter_Scriptcall.Successfully_Response();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_getStudentPointsCounter.Content);
                    getStudentPointsCounter_Scriptcall.Failed_Response();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }

        // 11- restoreWidgetsToDefault Endpoint Check
        public ForgotPassword_Class restoreWidgetsToDefault()
        {
            Login();
            Console.WriteLine("----------------- /api/Auth/restoreWidgetsToDefault -----------------\n");
            var Restetpass = new restoreWidgetsTo_Default();
            var reset = Restetpass.restoreWidgetsToDefault_FP();
            ForgotPassword_Class finalResult = null;

            // If no records in restoreWidgetsToDefault, you may want to handle that case.
            if (reset == null || !reset.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in reset)
            {
                try
                {
                    Console.WriteLine("Input Values : ");
                    Console.WriteLine($"role: {record.role}");
                    var bodyContent = new
                    {
                        role = record.role,
                    };
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"/api/Dashboard/restoreWidgetsToDefault", Method.Post);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    restRequest.AddJsonBody(bodyContent);
                    var response_restoreWidgetsToDefault = restClient.Execute(restRequest);
                    var studentAttendance_Scriptcall = new TestScripts_restoreWidgetsToDefault();
                    if (response_restoreWidgetsToDefault.StatusCode == HttpStatusCode.OK)
                    {
                        var restoreWidgetsToDefault_request = JsonConvert.DeserializeObject<Commons.DTO_s.Auth.ForgotPassword_Class>(response_restoreWidgetsToDefault.Content);
                        if (restoreWidgetsToDefault_request.IsSuccessful == true)
                        {
                            Console.WriteLine("API Response: " + response_restoreWidgetsToDefault.Content);
                            studentAttendance_Scriptcall.ValidInputValues(record.role);
                        }
                        if (restoreWidgetsToDefault_request.Response != null && restoreWidgetsToDefault_request.Response.Any())
                        {
                            finalResult = restoreWidgetsToDefault_request;
                        }
                    }
                    else
                    {
                        var restoreWidgetsToDefault_Errorrequest = JsonConvert.DeserializeObject<ErrorHandle_PartnerEnroll>(response_restoreWidgetsToDefault.Content);
                        string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                        string Alphabetpattern = @"^[a-zA-Z]+$";
                        string testInputs = @"^\s*$";
                        if (Regex.IsMatch(record.role, pattern))
                        {
                            Console.WriteLine("API Response: " + response_restoreWidgetsToDefault.Content);
                            studentAttendance_Scriptcall.SpecialCharacter(record.role);
                        }
                        else if (Regex.IsMatch(record.role ?? "", testInputs))
                        {
                            Console.WriteLine("API Response: " + restoreWidgetsToDefault_Errorrequest.Message);
                            studentAttendance_Scriptcall.ValidateInput_NullValues(record.role);
                        }
                        else if (Regex.IsMatch(record.role ?? "", Alphabetpattern))
                        {
                            Console.WriteLine("API Response: " + restoreWidgetsToDefault_Errorrequest.Message);
                            studentAttendance_Scriptcall.ContainsAlphabet_role(record.role);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + restoreWidgetsToDefault_Errorrequest.Message);
                            studentAttendance_Scriptcall.BeginExecuteNonQuery(record.role);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nAPI response with Exception Error Message : " + ex.Message);
                }
            }
            return finalResult;
        }   

        // 12- LeadsGeneration Endpoint Check
        public PartnerEnrollment_Response leadsGeneration()
        {
            Login();
            Console.WriteLine("----------------- /api/Dashboard/leadsGeneration -----------------\n");
            var ClassEnrollCountByType_RF = new leadsGeneration_DataRead();
            var getfile_ClassEnrollCountByType = ClassEnrollCountByType_RF.Getfile_leadsGeneration();
            PartnerEnrollment_Response finalResult = null;

            // If no records in LeadsGeneration, you may want to handle that case.
            if (getfile_ClassEnrollCountByType == null || !getfile_ClassEnrollCountByType.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_ClassEnrollCountByType)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    Console.WriteLine($"type: {record.type}, companyId: {record.companyId}");
                    string queryString_ClassEnroll = $"type={record.type}&companyId={record.companyId}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"/api/Dashboard/leadsGeneration?{queryString_ClassEnroll}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_leadsGeneration = restClient.Execute(restRequest);
                    var leadsGeneration_Scriptcall = new TestScripts_leadsGeneration();
                    if (response_leadsGeneration.StatusCode == HttpStatusCode.OK)
                    {
                        var leadsGeneration_request = JsonConvert.DeserializeObject<ApiResponse<List<PartnerEnrollment_Response>>>(response_leadsGeneration.Content);
                        if (leadsGeneration_request.Response != null && 
                            leadsGeneration_request.Response.All(item => string.IsNullOrEmpty(item.key) && item.value == "0") && 
                            leadsGeneration_request.Response.Count > 0)
                        {
                            Console.WriteLine("Condition met: An item with key='' and value='0' found.");
                            leadsGeneration_Scriptcall.ValidateCompanyId(record.companyId);
                        }
                        else if (leadsGeneration_request.IsSuccessful == true && leadsGeneration_request.Response.Count > 0)
                        {
                            Console.WriteLine("API Response: \n\n" + response_leadsGeneration.Content);
                            leadsGeneration_Scriptcall.ValidInputValues(record.type, record.companyId);
                        }
                        else if (leadsGeneration_request.StatusCode == 200 && leadsGeneration_request.IsSuccessful == true 
                                  && leadsGeneration_request.Response != null && !leadsGeneration_request.Response.Any())
                        {
                            Console.WriteLine("Condition met: API response is successful, statusCode is 200, But response is empty.");
                            leadsGeneration_Scriptcall.ValidTypeValue(record.type, record.companyId);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_leadsGeneration.Content);
                        }
                        if (leadsGeneration_request.Response != null && leadsGeneration_request.Response.Any())
                        {
                            finalResult = leadsGeneration_request.Response.First();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                }
            }
            return finalResult;
        }

        // 13- ClassDropOffCountByType Endpoint Check
        public PartnerEnrollment_Response ClassDropOffCountByType()
        {
            Login();
            Console.WriteLine("----------------- /api/Dashboard/ClassDropOffCountByType -----------------\n");
            var ClassDropOffCountByType_RF = new ClassDropOffCountByType_DataRead();
            var getfile_ClassDropOffCountByType = ClassDropOffCountByType_RF.Getfile_ClassDropOffCountByType();
            PartnerEnrollment_Response finalResult = null;

            // If no records in ClassDropOffCountByType, you may want to handle that case.
            if (getfile_ClassDropOffCountByType == null || !getfile_ClassDropOffCountByType.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_ClassDropOffCountByType)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    Console.WriteLine($"type: {record.type}, franchises: {record.franchises}");
                    string queryString_ClassDrop = $"type={record.type}&franchises={record.franchises}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"/api/Dashboard/ClassDropOffCountByType?{queryString_ClassDrop}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_ClassDrop = restClient.Execute(restRequest);
                    var ClassDrop_Scriptcall = new TestScripts_ClassDropOffCountByType();
                    if (response_ClassDrop.StatusCode == HttpStatusCode.OK)
                    {
                        var ClassDrop_request = JsonConvert.DeserializeObject<ApiResponse<List<PartnerEnrollment_Response>>>(response_ClassDrop.Content);
                        if (ClassDrop_request.IsSuccessful == true && ClassDrop_request.Response.Count > 0)
                        {
                            Console.WriteLine("API Response: \n\n" + response_ClassDrop.Content);
                            ClassDrop_Scriptcall.ValidInputValues(record.type, record.franchises);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_ClassDrop.Content);
                        }
                        if (ClassDrop_request.Response != null && ClassDrop_request.Response.Any())
                        {
                            finalResult = ClassDrop_request.Response.First();
                        }
                    }
                    else
                    {
                        var ClassDrop_Errorrequest = JsonConvert.DeserializeObject<ErrorHandle_PartnerEnroll>(response_ClassDrop.Content);
                        string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                        string Alphabetpattern = @"^[a-zA-Z]+$";
                        string combinedInputValues_Special = $"{record.type},{record.franchises}";
                        string combinedInputValues_Null = $"{record.type},{record.franchises}";
                        string Null_testInput = @"^,$";
                        string testInputs = @"^\s*$";
                        var abc = Regex.IsMatch(record.type, Alphabetpattern);
                
                        if (Regex.IsMatch(record.franchises, pattern))
                        {
                            Console.WriteLine("API Response: " + response_ClassDrop.Content);
                            ClassDrop_Scriptcall.SpecialCharacter_franchises(record.franchises);
                        }
                        else if (Regex.IsMatch(combinedInputValues_Null, Null_testInput))
                        {
                             Console.WriteLine("API Response: " + ClassDrop_Errorrequest.Message);
                            ClassDrop_Scriptcall.ValidateInput_NullValues(record.type, record.franchises);
                        }
                        else if (Regex.IsMatch(record.type ?? "", testInputs))
                        {
                            Console.WriteLine("API Response: " + ClassDrop_Errorrequest.Message);
                            ClassDrop_Scriptcall.ValidateInput_NulltypeValues(record.type);
                        }
                        else if (Regex.IsMatch(record.franchises ?? "", testInputs))
                        {
                            Console.WriteLine("API Response: " + ClassDrop_Errorrequest.Message);
                            ClassDrop_Scriptcall.ValidateInput_Nullfranchises_Values(record.franchises);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + ClassDrop_Errorrequest.Message);
                            ClassDrop_Scriptcall.ContainsAlphabet_franchises(record.franchises);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                }
            }
            return finalResult;
        }
        
        // 14- EventDropOffCountByType Endpoint Check
        public PartnerEnrollment_Response EventDropOffCountByType()
        {
            Login();
            Console.WriteLine("----------------- /api/Dashboard/EventDropOffCountByType -----------------\n");
            var EventDropOffCountByType_RF = new EventDropOffCountByType_DataRead();
            var getfile_EventDropOffCountByType = EventDropOffCountByType_RF.Getfile_EventDropOffCountByType();
            PartnerEnrollment_Response finalResult = null;

            // If no records in EventDropOffCountByType, you may want to handle that case.
            if (getfile_EventDropOffCountByType == null || !getfile_EventDropOffCountByType.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_EventDropOffCountByType)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    Console.WriteLine($"type: {record.type}, franchises: {record.franchises}");
                    string queryString_EventDrop = $"type={record.type}&franchises={record.franchises}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"/api/Dashboard/EventDropOffCountByType?{queryString_EventDrop}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_EventDrop = restClient.Execute(restRequest);
                    var EventDrop_Scriptcall = new TestScripts_ClassDropOffCountByType();
                    if (response_EventDrop.StatusCode == HttpStatusCode.OK)
                    {
                        var EventDrop_request = JsonConvert.DeserializeObject<ApiResponse<List<PartnerEnrollment_Response>>>(response_EventDrop.Content);
                        if (EventDrop_request.IsSuccessful == true && EventDrop_request.Response.Count > 0)
                        {
                            Console.WriteLine("API Response: \n\n" + response_EventDrop.Content);
                            EventDrop_Scriptcall.ValidInputValues(record.type, record.franchises);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_EventDrop.Content);
                        }
                        if (EventDrop_request.Response != null && EventDrop_request.Response.Any())
                        {
                            finalResult = EventDrop_request.Response.First();
                        }
                    }
                    else
                    {
                        var EventDrop_Errorrequest = JsonConvert.DeserializeObject<ErrorHandle_PartnerEnroll>(response_EventDrop.Content);
                        string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                        string Alphabetpattern = @"^[a-zA-Z]+$";
                        string combinedInputValues_Special = $"{record.type},{record.franchises}";
                        string combinedInputValues_Null = $"{record.type},{record.franchises}";
                        string Null_testInput = @"^,$";
                        string testInputs = @"^\s*$";
                        var abc = Regex.IsMatch(record.type, Alphabetpattern);

                        if (Regex.IsMatch(record.franchises, pattern))
                        {
                            Console.WriteLine("API Response: " + response_EventDrop.Content);
                            EventDrop_Scriptcall.SpecialCharacter_franchises(record.franchises);
                        }
                        else if (Regex.IsMatch(combinedInputValues_Null, Null_testInput))
                        {
                            Console.WriteLine("API Response: " + EventDrop_Errorrequest.Message);
                            EventDrop_Scriptcall.ValidateInput_NullValues(record.type, record.franchises);
                        }   
                        else if (Regex.IsMatch(record.type ?? "", testInputs))
                        {
                            Console.WriteLine("API Response: " + EventDrop_Errorrequest.Message);
                            EventDrop_Scriptcall.ValidateInput_NulltypeValues(record.type);
                        }
                        else if (Regex.IsMatch(record.franchises ?? "", testInputs))
                        {
                            Console.WriteLine("API Response: " + EventDrop_Errorrequest.Message);
                            EventDrop_Scriptcall.ValidateInput_Nullfranchises_Values(record.franchises);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + EventDrop_Errorrequest.Message);
                            EventDrop_Scriptcall.ContainsAlphabet_franchises(record.franchises);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                }
            }
            return finalResult;
        }

    }
}