﻿using ApiTesting_Calimatic.AppLoginFolder;
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
using ApiTesting_Calimatic.Dashboard_RF.currentmonthwidgetscount_RF;
using TestProject1.Dashboard.currentmonthwidgetType_TestScripts;
using Commons.DTO_s.Dashboards.currentmonthwidgetcount_Dataget;
using Newtonsoft.Json.Linq;
using Commons.DTO_s.Dashboards.Calender;
using Commons.DTO_s.Dashboards.studentDemographics;
using ApiTesting_Calimatic.Dashboard_RF.studentDemographics;
using TestProject1.Dashboard.studentDemographics_TestScripts;
using System.Security.Cryptography.X509Certificates;
using Commons.DTO_s.Dashboards.announcement_response;
using TestProject1.Dashboard.announcement_TestScripts;
using System.Reflection.Metadata.Ecma335;
using Commons.DTO_s.Student;
using TestProject1.Student_TestScripts.getEnrollmentDropdown_TestScript;
using TestProject1.Student_TestScripts.students_TestScripts;
using ApiTesting_Calimatic.Students_RF;
using TestProject1.Student_TestScripts.setStudentStatus_TestScripts;
using ApiTtesting_Calimatic;
using Commons.DTO_s.PaymentCommon;
using ApiTesting_Calimatic.PaymentCommon_RF.DuplicateUsername_RF;
using TestProject1.PaymentCommon_TestScripts.DuplicateUserName_TestScripts;
using System.Transactions;
using Commons.DTO_s.PaymentCommon.GetTransactionConfig;
using ApiTesting_Calimatic.PaymentCommon_RF.GetTransactionConfig_RF;
using TestProject1.PaymentCommon_TestScripts.GetTransactionConfig_TestScripts;
using Commons.DTO_s.PaymentCommon.GetAllEnrolledCourses;
using TestProject1.PaymentCommon_TestScripts.GetAllEnrolledCourses_TestScripts;
using ApiTesting_Calimatic.PaymentCommon_RF.GetPortalEnrolledCourses_RF;
using Commons.DTO_s.PaymentCommon.GetPortalEnrolledCourses;
using TestProject1.PaymentCommon_TestScripts.GetPortalEnrolledCourses_TestScripts;
using Commons.DTO_s.PaymentCommon.GetStudentCoursesViewDetails;
using Commons.DTO_s.Course_Category.getCourseCategoriesByTypeId;
using ApiTesting_Calimatic.CourseCategory.getCourseCategoriesByTypeId_RF;
using TestProject1.CourseCategory_TestScripts.getCourseCategoriesByTypeId_TestScripts;
using Commons.DTO_s.Courses.central;
using TestProject1.Courses.central_TestScripts;
using ApiTesting_Calimatic.Courses.getCoursesByTypeAndCategory_RF;
using Commons.DTO_s.CourseReview.GetReviewedCourse;
using ApiTesting_Calimatic.CourseReview.GetReviewedCourse_RF;
using TestProject1.CourseReview.GetReviewedCourse_TestScripts;
using ApiTesting_Calimatic.CourseReview.AddCourseReview_RF;
using Commons.DTO_s.CourseReview.AddCourseReview;
using TestProject1.CourseReview.AddCourseReview_TestScripts;
using TestProject1.CourseReview.IsReviewAddedByUser_TestScripts;
using Commons.DTO_s.CourseType.list;
using ApiTesting_Calimatic.CourseType.list;
using Commons.DTO_s.Department.getDepartments;
using TestProject1.Department.getDepartment_TestScripts;
using ApiTesting_Calimatic.Department.saveDepartment_RF;
using Commons.DTO_s.Department.saveDepartment;
using TestProject1.Department.saveDepartment_TestScripts;
using ApiTesting_Calimatic.Department.deleteDepartments_RF;
using Commons.DTO_s.Department.deleteDepartments;
using TestProject1.Department.deleteDepartments_TestScripts;
using Commons.DTO_s.Notification.GetUserNotifications;
using TestProject1.GetUserNotifications_TestScripts;
using Commons.DTO_s.Notification.ClearAllNotification_Response;
using TestProject1.Notification.ClearAllNotification_TestScript;
using ApiTesting_Calimatic.Notification_RF;
using Commons.DTO_s.Notification.VisitNotification;
using TestProject1.Notification.VisitNotification_TestScripts;
using TestProject1.Notification.GetNotificationCounts_TestScripts;
using ApiTesting_Calimatic.Notification_RF.GetUserActivityLogs_RF;
using Commons.DTO_s.Notification.GetUserActivityLogs;
using TestProject1.Notification.GetUserActivityLogs_TestScripts;
using Commons.DTO_s.Company.CompanyConfigs;
using TestProject1.Company.CompanyConfigs_TestScripts;
using ApiTesting_Calimatic.Company.CompanyConfigs_RF;
using Commons.DTO_s.Company.CompanyNameByUserName;
using ApiTesting_Calimatic.Company.CompanyNameByUserName_RF;
using Commons.DTO_s.Company.Menus;
using TestProject1.Company.Menus_TestScripts;
using ApiTesting_Calimatic.Company.franchises_RF;
using Commons.DTO_s.Company.franchises;
using TestProject1.Company.franchises_TestScripts;
using Commons.DTO_s.Company.Permissions;
using TestProject1.Company.Permssions_TestScripts;
using Commons.DTO_s.Company.saveBrandings;
using ApiTesting_Calimatic.Company.saveBrandings_RF;
using TestProject1.Company.saveBrandings_TestScripts;
using Commons.DTO_s.Company.StripeConnectUrl;
using TestProject1.Company.StripeConnectUrl_TestScripts;
using ApiTesting_Calimatic.Company.ResendActivationEmail_RF;
using Commons.DTO_s.Company.ResendActivationEmail;
using TestProject1.Company.ResendActivationEmail_TestScripts;
using ApiTesting_Calimatic.Company.VerifyActivationEmail_RF;
using Commons.DTO_s.Company.VerifyActivationEmail;
using TestProject1.Company.VerifyActivationEmail_TestScripts;
using ApiTesting_Calimatic.CompanyMenu_RF;
using Commons.DTO_s.CompanyMenu;
using TestProject1.CompanyMenu_TestScripts;
using Commons.DTO_s.EventType;
using TestProject1.EventType_list;
using ApiTesting_Calimatic.FileUpload;
using Commons.DTO_s.FileUpload;
using TestProject1.FileUpload_TestScripts;
using Commons.DTO_s.Profile;
using Commons.DTO_s.Profile.GetEmailPreferences;
using TestProject1.Profile_TestScripts.GetEmailPreferences_TestScripts;
using Commons.DTO_s.PortalUserRoles.GetRolesGird;
using TestProject1.PortalUserRoles.GetRolesGird_TestScripts;
using Commons.DTO_s.PortalUserRoles.GetUserAccessGird;
using TestProject1.PortalUserRoles.GetUserAccessGird_TestScripts;
using ApiTesting_Calimatic.PortalUserRoles.AddUpdateRoles_RF;
using Commons.DTO_s.PortalUserRoles.AddUpdateRoles;
using TestProject1.PortalUserRoles.AddUpdateRoles_TestScripts;
using ApiTesting_Calimatic.PortalUserRoles.DeleteRole_RF;
using Commons.DTO_s.PortalUserRoles.DeleteRole;
using TestProject1.PortalUserRoles.DeleteRole_TestScripts;
using ApiTesting_Calimatic.PortalUserRoles.AddUpdateRoleAccess_RF;
using Commons.DTO_s.PortalUserRoles.AddUpdateRoleAccess;
using TestProject1.PortalUserRoles.AddUpdateRoleAccess_TestScripts;
using TestProject1.PortalUserRoles.DeleteRoleAccess_TestScripts;
using Commons.DTO_s.PublishGuid;
using TestProject1.GetPublishedGuid_TestScripts;
using Commons.DTO_s.Board.Board_student;
using TestProject1.Board.Board_student_TestSripts;
using ApiTesting_Calimatic.Board.student_RF;
using Commons.DTO_s.Board.getFilterTypeValue;
using TestProject1.Board.getFilterTypeValue_TestScripts;
using ApiTesting_Calimatic.Board.getFilterTypeValue_RF;
using ApiTesting_Calimatic.classes.onlineclasses_RF;
using Commons.DTO_s.classes.onlineclasses;
using TestProject1.classes.onlineclasses_TestScripts;
using ApiTesting_Calimatic.classes.joinclass_RF;
using Commons.DTO_s.classes.joinclass;
using TestProject1.classes.joinclass_TestScripts;
using ApiTesting_Calimatic.classes.getCourseTypeClasses_RF;
using Commons.DTO_s.classes.getCourseTypeClasses;
using TestProject1.classes.getCourseTypeClasses_TestScripts;
using Commons.DTO_s.SISForm.getStudentInformationList;
using TestProject1.SISForm.getStudentInformationList_TestScripts;
using ApiTesting_Calimatic.SISForm.createStudentInformationForm_RF;
using TestProject1.SISForm.createStudentInformationForm_TestScripts;
using Commons.DTO_s.SISForm.createStudentInformationForm;
using Commons.DTO_s.AddOnsManage.getFeeList;
using TestProject1.AddOnsManage.getFeeList_TestScripts;
using ApiTesting_Calimatic.AddOnsManage.getNewFee_RF;
using Commons.DTO_s.AddOnsManage.getNewFee;
using TestProject1.AddOnsManage.getNewFee_TestScripts;

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
        /*
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
                                if (Regex.IsMatch(record.franchises, pattern))
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
                                    Classenroll_Scriptcall.Valid_Type_FranchisesID(record.type, record.franchises);
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
                                    Classenroll_Scriptcall.SpecialCharacter(record.franchises, record.type);
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
                                if (ClassEnrollment_request.IsSuccessful == true && ClassEnrollment_request.Response.Count > 0)
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
                                else if (Regex.IsMatch(record.types ?? "", testInputs))
                                {
                                    Console.WriteLine("API Response: " + ClassEnrollment_Errorrequest.Message);
                                    EnrollPerformance_Scriptcall.ValidateInput_NulltypeValues(record.types);
                                }
                                else if (Regex.IsMatch(record.franchiseIds ?? "", testInputs))
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

                // 15- currentmonthwidgetscount Endpint Check
                public Response_currentmonthwidgetscount currentmonthwidgetscount()
                {
                    Login();
                    Console.WriteLine("----------------- /api/Dashboard/currentmonthwidgetscount -----------------\n");
                    var Currentmonthwidgetscount_RF = new currentmonthwidgetscount_DataRead();
                    var getfile_currentmonthwidgetscount = Currentmonthwidgetscount_RF.Getfile_currentmont_WC();
                    Response_currentmonthwidgetscount finalResult = null;

                    // If no records in currentmonthwidgetscount, you may want to handle that case.
                    if (getfile_currentmonthwidgetscount == null || !getfile_currentmonthwidgetscount.Any())
                    {
                        Console.WriteLine("No records found.");
                        // Return null or handle as appropriate
                        return finalResult;
                    }
                    foreach (var record in getfile_currentmonthwidgetscount)
                    {
                        try
                        {
                            Console.WriteLine("\nInput Value : ");
                            Console.WriteLine($"widgetType: {record.widgetType}");
                            string queryString_currentmonth_WC = $"widgetType={record.widgetType}";
                            var restClient = new RestClient("https://angular-api.calibermatrix.com");
                            var restRequest = new RestRequest($"/api/Dashboard/currentmonthwidgetscount?{queryString_currentmonth_WC}", Method.Get);
                            restRequest.AddHeader("Accept", "application/json");
                            restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                            restRequest.RequestFormat = DataFormat.Json;
                            var response_currentmonth_WC = restClient.Execute(restRequest);
                            var WidgetType_Scriptcall = new TestScripts_currentmonthwidgetType();
                            if (response_currentmonth_WC.StatusCode == HttpStatusCode.OK)
                            {
                                Console.WriteLine("API Response: \n\n" + response_currentmonth_WC.Content);
                                WidgetType_Scriptcall.ValidateInputvalue(record.widgetType);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                        }
                    }
                    return finalResult;
                }

                // 16-  triowidgetscount Endpoint Check
                public Response_currentmonthwidgetscount triowidgetscount()
                {
                    Login();
                    Console.WriteLine("----------------- /api/Dashboard/triowidgetscount -----------------\n");
                    var triowidgetscount_RF = new currentmonthwidgetscount_DataRead();
                    var getfile_triowidgetscount = triowidgetscount_RF.Getfile_currentmont_WC();
                    Response_currentmonthwidgetscount finalResult = null;

                    // If no records in triowidgetscount, you may want to handle that case.
                    if (getfile_triowidgetscount == null || !getfile_triowidgetscount.Any())
                    {
                        Console.WriteLine("No records found.");
                        // Return null or handle as appropriate
                        return finalResult;
                    }
                    foreach (var record in getfile_triowidgetscount)
                    {
                        try
                        {
                            Console.WriteLine("\nInput Value : ");
                            Console.WriteLine($"widgetType: {record.widgetType}");
                            string queryString_triowidgetscount = $"widgetType={record.widgetType}";
                            var restClient = new RestClient("https://angular-api.calibermatrix.com");
                            var restRequest = new RestRequest($"/api/Dashboard/triowidgetscount?{queryString_triowidgetscount}", Method.Get);
                            restRequest.AddHeader("Accept", "application/json");
                            restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                            restRequest.RequestFormat = DataFormat.Json;
                            var response_triowidgetscount = restClient.Execute(restRequest);
                            var WidgetType_Scriptcall = new TestScripts_currentmonthwidgetType();
                            var ClassDrop_request = JsonConvert.DeserializeObject<ApiResponse<Response_currentmonthwidgetscount>>(response_triowidgetscount.Content);
                            if (response_triowidgetscount.StatusCode == HttpStatusCode.OK)
                            {
                                Console.WriteLine("API Response: \n\n" + response_triowidgetscount.Content);
                                WidgetType_Scriptcall.ValidateInputvalue(record.widgetType);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                        }
                    }
                    return finalResult;
                }

                // 17- DashbaordCalender Endpoint Check
                public bool Calendar()
                {
                    try
                    {
                        Login();
                        Console.WriteLine("----------------- /api/Dashboard/Calendar -----------------\n");
                        var restClient = new RestClient("https://angular-api.calibermatrix.com");
                        var restRequest = new RestRequest($"/api/Dashboard/calendar", Method.Get);
                        restRequest.AddHeader("Accept", "application/json");
                        restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                        restRequest.RequestFormat = DataFormat.Json;
                        var response_topfranchisesby = restClient.Get(restRequest);
                        var topfranchisesbyrevenue_Scriptcall = new TestScripts_topfranchisesbyrevenue();
                        var listofleadcount_request = JsonConvert.DeserializeObject<General_Response>(response_topfranchisesby.Content);
                        if (response_topfranchisesby.StatusCode == HttpStatusCode.OK)
                        {
                            if (listofleadcount_request.isSuccessful == true)
                            {
                                Console.WriteLine("API Response: " + response_topfranchisesby.Content);
                                topfranchisesbyrevenue_Scriptcall.Successfully_Response();
                            }
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_topfranchisesby.Content);
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

                // 18- studentDemographics Endpoint Check
                public studentDemographics_Response studentDemographics()
                {
                    Login();
                    Console.WriteLine("----------------- /api/Dashboard/studentDemographics -----------------\n");
                    var studentDemographics_RF_record = new studentDemographics_RF();
                    var getfile_studentDemographics = studentDemographics_RF_record.Getfile_EventDropOffCountByType();
                    studentDemographics_Response finalResult = null;

                    // If no records in studentDemographics, you may want to handle that case.
                    if (getfile_studentDemographics == null || !getfile_studentDemographics.Any())
                    {
                        Console.WriteLine("No records found.");
                        // Return null or handle as appropriate
                        return finalResult;
                    }
                    foreach (var record in getfile_studentDemographics)
                    {
                        try
                        {
                            Console.WriteLine("\nInput Value : ");
                            Console.WriteLine($"type: {record.type}, franchises: {record.state}, companyId: {record.companyId}");
                            string queryString_stdDemographics = $"type={record.type}&state={record.state}&companyId={record.companyId}";
                            var restClient = new RestClient("https://angular-api.calibermatrix.com");
                            var restRequest = new RestRequest($"/api/Dashboard/studentDemographics?{queryString_stdDemographics}", Method.Get);
                            restRequest.AddHeader("Accept", "application/json");
                            restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                            restRequest.RequestFormat = DataFormat.Json;
                            var response_std_DemoGraphics = restClient.Execute(restRequest);
                            var stdDemographics_Scriptcall = new TestScripts_Std_Demographics();
                            if (response_std_DemoGraphics.StatusCode == HttpStatusCode.OK)
                            {
                                var EventDrop_request = JsonConvert.DeserializeObject<ApiResponse<List<studentDemographics_Response>>>(response_std_DemoGraphics.Content);
                                ApiResponseHandler.SetEventDropRequest(EventDrop_request);
                                if (EventDrop_request.IsSuccessful == true && EventDrop_request.Response.Count > 0)
                                {
                                    Console.WriteLine("API Response: \n\n" + response_std_DemoGraphics.Content);
                                    stdDemographics_Scriptcall.ValidInputValues(record.type, record.state, record.companyId);
                                }
                                else if (EventDrop_request.IsSuccessful != true && EventDrop_request.Response.Count < 0)
                                {
                                    Console.WriteLine("API Response: " + response_std_DemoGraphics.Content);
                                    stdDemographics_Scriptcall.Error_Something(record.type, record.state, record.companyId);
                                }
                                else
                                {
                                    Console.WriteLine("API Response: " + response_std_DemoGraphics.Content);
                                    stdDemographics_Scriptcall.DummyResponse();
                                }
                                if (EventDrop_request.Response != null && EventDrop_request.Response.Any())
                                {
                                    finalResult = EventDrop_request.Response.First();
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

                // 19- announcement Endpoint Check
                public bool Announcement_Endpoint()
                {
                    try
                    {
                        Login();
                        Console.WriteLine("----------------- /api/Dashboard/announcement -----------------\n");
                        var restClient = new RestClient("https://angular-api.calibermatrix.com");
                        var restRequest = new RestRequest($"/api/Dashboard/announcements", Method.Get);
                        restRequest.AddHeader("Accept", "application/json");
                        restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                        restRequest.RequestFormat = DataFormat.Json;
                        var response_GetActiveCourseCountByType = restClient.Get(restRequest);
                        var GetActiveCourseCountByType_Scriptcall = new TestScripts_announcement();
                        if (response_GetActiveCourseCountByType.StatusCode == HttpStatusCode.OK)
                        {
                            // Deserialize as a List if the response is an array
                            var ActiveCourse_request = JsonConvert.DeserializeObject<Main_Response>(response_GetActiveCourseCountByType.Content);
                            ApiResponse_announcement.Set_announcement(ActiveCourse_request);
                            if (ActiveCourse_request.isSuccessful == true)
                            {
                                Console.WriteLine("API Response: " + response_GetActiveCourseCountByType.Content);
                                GetActiveCourseCountByType_Scriptcall.announcement_GetResponse();
                            }
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_GetActiveCourseCountByType.Content);
                            GetActiveCourseCountByType_Scriptcall.announcement_GetResponse();
                        }
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("\nAPI Response : " + ex.Message);
                    }
                    return false;
                }
        */

        //-------------------->/api/Student/<--------------------

        // 1- getEnrollmentDropdown Check Endpoint
        public bool getEnrollmentDropdown()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/Student/getEnrollmentDropdown -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/Student/getEnrollmentDropdown", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_getEnrollmentDropdown = restClient.Get(restRequest);
                var getEnrollmentDropdown_Scriptcall = new TestScript_getEnrollmentDropdown();
                if (response_getEnrollmentDropdown.StatusCode == HttpStatusCode.OK)
                {
                    // Deserialize as a List if the response is an array
                    var getEnrollmentDropdown_request = JsonConvert.DeserializeObject<Response_getEnrollmentDropdown>(response_getEnrollmentDropdown.Content);
                    ApiResponse_getEnrollmentDropdown.Set_getEnrollmentDropdown(getEnrollmentDropdown_request);
                    if (getEnrollmentDropdown_request.isSuccessful == true)
                    {
                        Console.WriteLine("API Response: " + response_getEnrollmentDropdown.Content);
                        getEnrollmentDropdown_Scriptcall.getEnrollmentDropdown_GetResponse();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_getEnrollmentDropdown.Content);
                    getEnrollmentDropdown_Scriptcall.getEnrollmentDropdown_GetResponse();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }

        // 2- student Endpoint
        public bool Student_students()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/Student/students -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/Student/students", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_students = restClient.Get(restRequest);
                var students_Scriptcall = new TestScripts_students();
                if (response_students.StatusCode == HttpStatusCode.OK)
                {
                    // Deserialize as a List if the response is an array
                    var ActiveCourse_request = JsonConvert.DeserializeObject<GetResponse_students>(response_students.Content);
                    ApiResponse_students.Set_students(ActiveCourse_request);
                    if (ActiveCourse_request.isSuccessful == true)
                    {
                        Console.WriteLine("API Response: " + response_students.Content);
                        students_Scriptcall.students_GetResponse();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_students.Content);
                    students_Scriptcall.students_GetResponse();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }

        // 3- setStudentStatus
        public setStudentStatus setStudentStatus()
        {
            Login();
            Console.WriteLine("----------------- /api/Student/setStudentStatus -----------------\n");
            var setstudentStatus_RF_record = new setStudentStatus_DataRead();
            var getfile_setStudentStatus = setstudentStatus_RF_record.Getfile_setStudentStatus();
            setStudentStatus finalResult = null;

            // If no records in getfile_setStudentStatus, you may want to handle that case.
            if (getfile_setStudentStatus == null || !getfile_setStudentStatus.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_setStudentStatus)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    var bodyContent = new
                    {
                        studentIds = record.studentIds,
                        activateStudent = record.activateStudent

                    };
                    Console.WriteLine($"studentIds: {record.studentIds}, activateStudent: {record.activateStudent}");
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/Student/setStudentStatus", Method.Post);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    restRequest.AddJsonBody(bodyContent);
                    var response_setStudentStatus = restClient.Execute(restRequest);
                    var setStudentStatus_Scriptcall = new TestScripts_setStudentStatus();
                    if (response_setStudentStatus.StatusCode == HttpStatusCode.OK)
                    {
                        var EventDrop_request = JsonConvert.DeserializeObject<setStudentStatus>(response_setStudentStatus.Content);
                        ApiResponse_setStudentstatus.Set_setstudentsStatus(EventDrop_request);
                        if (EventDrop_request.isSuccessful == true)
                        {
                            Console.WriteLine("API Response: \n\n" + response_setStudentStatus.Content);
                            setStudentStatus_Scriptcall.ValidInputValues();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_setStudentStatus.Content);
                            // setStudentStatus_Scriptcall.DummyResponse();
                        }
                        finalResult = EventDrop_request;
                    }
                    else
                    {
                        var setStudentStatus_Errorrequest = JsonConvert.DeserializeObject<ErrorHandle_PartnerEnroll>(response_setStudentStatus.Content);
                        ErrorHandler_setStudentstatus.Set_setstudentsStatus(setStudentStatus_Errorrequest);
                        string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                        string Alphabetpattern = @"([a-zA-Z]+)";
                        string combinedInputValues_Special = $"{record.studentIds},{record.activateStudent}";
                        var abc = Regex.IsMatch(record.studentIds, Alphabetpattern);

                        if (Regex.IsMatch(record.studentIds, pattern))
                        {
                            Console.WriteLine("API Response: " + response_setStudentStatus.Content);
                            setStudentStatus_Scriptcall.SpecialCharacter_studentIds(record.studentIds);
                        }
                        else if (record.activateStudent.GetValueOrDefault(false) == false)
                        {
                            Console.WriteLine("API Response: " + setStudentStatus_Errorrequest.Message);
                            setStudentStatus_Scriptcall.NullactivateStudent_Values();
                        }
                        else if (Regex.IsMatch(record.studentIds, Alphabetpattern))
                        {
                            Console.WriteLine("API Response: " + setStudentStatus_Errorrequest.Message);
                            setStudentStatus_Scriptcall.ContainsAlphabet_studentIds(record.studentIds);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + setStudentStatus_Errorrequest.Message);
                            setStudentStatus_Scriptcall.Invalid_studentIds(record.studentIds);
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

        //--------------------->/api/PaymentCommon/<--------------------
        // 1-  Duplicate UserName Endpoint Check 
        public Root_PaymentCommon DuplicateUserName()
        {
            Login();
            Console.WriteLine("----------------- /api/PaymentCommon/DuplicateUserName -----------------\n");
            var Duplicateusername_RF = new DuplicateUserName_DataRead();
            var getfile_Duplicateusername = Duplicateusername_RF.Getfile_Duplicateusername();
            Root_PaymentCommon finalResult = null;

            // If no records in EventDropOffCountByType, you may want to handle that case.
            if (getfile_Duplicateusername == null || !getfile_Duplicateusername.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_Duplicateusername)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    Console.WriteLine($"username: {record.username}");
                    string queryString_DuplicateUsername = $"username={record.username}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"/api/PaymentCommon/DuplicateUserName?{queryString_DuplicateUsername}", Method.Post);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_DuplicateuserName = restClient.Execute(restRequest);
                    var DuplicateUserName_Scriptcall = new TestScripts_DuplicateUserName();
                    if (response_DuplicateuserName.StatusCode == HttpStatusCode.OK)
                    {
                        var DuplicateUsername_request = JsonConvert.DeserializeObject<Root_PaymentCommon>(response_DuplicateuserName.Content);
                        ApiResponse_PaymentCommon.Set_PaymentCommon(DuplicateUsername_request);
                        if (DuplicateUsername_request.response.response.isExist == true)
                        {
                            Console.WriteLine("API Response: \n\n" + response_DuplicateuserName.Content);
                            DuplicateUserName_Scriptcall.ValidInputValue(record.username);
                        }
                        else
                        {
                            var EventDrop_Errorrequest = JsonConvert.DeserializeObject<Root_ErrorHandler_DuplicateUserName>(response_DuplicateuserName.Content);
                            string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                            string Alphabetpattern = @"^[a-zA-Z]+$";
                            string Null_testInput = @"^,$";
                            string testInputs = @"^\s*$";
                            var abc = Regex.IsMatch(record.username, Alphabetpattern);

                            if (Regex.IsMatch(record.username, pattern))
                            {
                                Console.WriteLine("API Response: " + response_DuplicateuserName.Content);
                                DuplicateUserName_Scriptcall.SpecialCharacter_username(record.username);
                            }
                            else if (Regex.IsMatch(record.username ?? "", @"^\d+$"))
                            {
                                Console.WriteLine("API Response: " + EventDrop_Errorrequest.response);
                                DuplicateUserName_Scriptcall.InValidInputValue(record.username);
                            }
                            else if (Regex.IsMatch(record.username ?? "", testInputs))
                            {
                                Console.WriteLine("API Response: " + EventDrop_Errorrequest.response);
                                // DuplicateUserName_Scriptcall.ValidateInput_Nullfranchises_Values(record.username);
                            }
                            else
                            {
                                Console.WriteLine("API Response: " + EventDrop_Errorrequest.response);
                                DuplicateUserName_Scriptcall.ContainsAlphabet_franchises(record.username);
                            }
                        }
                        if (DuplicateUsername_request.response != null)
                        {
                            finalResult = DuplicateUsername_request;
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

        // 2- GetTransactionConfig Endpoint Check
        public Root_GetTransactionConfig GetTransactionConfig()
        {
            Login();
            Console.WriteLine("----------------- /api/PaymentCommon/GetTransactionConfig -----------------\n");
            var GetTransactionConfig_RF = new GetTransactionConfig_DataRead();
            var getfile_GetTransactionConfig = GetTransactionConfig_RF.Getfile_GetTransactionConfig();
            Root_GetTransactionConfig finalResult = null;

            // If no records in GetTransactionConfig, you may want to handle that case.
            if (getfile_GetTransactionConfig == null || !getfile_GetTransactionConfig.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_GetTransactionConfig)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    Console.WriteLine($"CompanyGuid: {record.CompanyGuid}");
                    string queryString_DuplicateUsername = $"CompanyGuid={record.CompanyGuid}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"/api/PaymentCommon/GetTransactionConfig?{queryString_DuplicateUsername}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_DuplicateuserName = restClient.Execute(restRequest);
                    var DuplicateUserName_Scriptcall = new TestScripts_GetTransactionConfig();
                    // var Get_request = JsonConvert.DeserializeObject<Response_GetTransactionConfig>(response_DuplicateuserName.Content);

                    try
                    {
                        if ((int)response_DuplicateuserName.StatusCode == 200)
                        {
                            var DuplicateUsername_request = JsonConvert.DeserializeObject<Root_GetTransactionConfig>(response_DuplicateuserName.Content);
                            ApiResponse_GetTransactionConfig.Set_GetTransactionConfig(DuplicateUsername_request);

                            if (DuplicateUsername_request.response.statusCode == 200 &&
                               DuplicateUsername_request.response.isSuccessful == true)
                            {
                                Console.WriteLine("API Response: \n\n" + response_DuplicateuserName.Content);
                                DuplicateUserName_Scriptcall.ValidInputValue(record.CompanyGuid);
                            }
                            else
                            {
                                var EventDrop_Errorrequest = JsonConvert.DeserializeObject<Root_ErrorHandler_DuplicateUserName>(response_DuplicateuserName.Content);
                                string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                                string Alphabetpattern = @"^[a-zA-Z]+$";
                                string combinedInputValues_Special = $"{record.CompanyGuid}";
                                string combinedInputValues_Null = $"{record.CompanyGuid}";
                                string Null_testInput = @"^,$";
                                string testInputs = @"^\s*$";
                                var abc = Regex.IsMatch(record.CompanyGuid, Alphabetpattern);

                                if (Regex.IsMatch(record.CompanyGuid, pattern))
                                {
                                    Console.WriteLine("API Response: " + response_DuplicateuserName.Content);
                                    //     DuplicateUserName_Scriptcall.SpecialCharacter_username(record.CompanyGuid);
                                }
                                else if (Regex.IsMatch(combinedInputValues_Null, Null_testInput))
                                {
                                    Console.WriteLine("API Response: " + EventDrop_Errorrequest.response);
                                    //  DuplicateUserName_Scriptcall.ValidateInput_NullValues(record.username);
                                }
                                else if (Regex.IsMatch(record.CompanyGuid ?? "", @"^\d+$"))
                                {
                                    Console.WriteLine("API Response: " + EventDrop_Errorrequest.response);
                                    //  DuplicateUserName_Scriptcall.InValidInputValue(record.CompanyGuid);
                                }
                                else if (Regex.IsMatch(record.CompanyGuid ?? "", testInputs))
                                {
                                    Console.WriteLine("API Response: " + EventDrop_Errorrequest.response);
                                    // DuplicateUserName_Scriptcall.ValidateInput_Nullfranchises_Values(record.username);
                                }
                                else
                                {
                                    Console.WriteLine("API Response: " + EventDrop_Errorrequest.response);
                                    //    DuplicateUserName_Scriptcall.ContainsAlphabet_franchises(record.CompanyGuid);
                                }
                            }
                            if (DuplicateUsername_request.response != null)
                            {
                                finalResult = DuplicateUsername_request;
                            }
                        }

                    }
                    catch (JsonException ex)
                    {
                        Console.WriteLine("Deserialization error: " + ex.Message);
                        DuplicateUserName_Scriptcall.InValidInputValue(record.CompanyGuid);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                }
            }
            return finalResult;
        }

        // 3- GetAllEnrolledCourses Endpoint Check
        public bool GetAllEnrolledCourses()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/PaymentCommon/GetAllEnrolledCourses -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/PaymentCommon/GetAllEnrolledCourses", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_students = restClient.Get(restRequest);
                var students_Scriptcall = new TestScripts_GetAllEnrolledCourses();
                if (response_students.StatusCode == HttpStatusCode.OK)
                {
                    // Deserialize as a List if the response is an array
                    var ActiveCourse_request = JsonConvert.DeserializeObject<Root_GetAllEnrolledCourses>(response_students.Content);
                    ApiResponse_GetAllEnrolledCourses.Set_GetAllEnrolledCourses(ActiveCourse_request);
                    if (ActiveCourse_request.isSuccessful == true)
                    {
                        Console.WriteLine("API Response: " + response_students.Content);
                        students_Scriptcall.GetAllEnrolledCourses_GetResponse();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_students.Content);
                    students_Scriptcall.GetAllEnrolledCourses_ResponseFailed();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }

        // 4- GetPortalEnrolledCourses Endpoint Check
        public Root_GetPortalEnrolledCourses GetPortalEnrolledCourses()
        {
            Login();
            Console.WriteLine("----------------- /api/PaymentCommon/GetPortalEnrolledCourses -----------------\n");
            var GetPortalEnrolledCourses_RF = new GetPortalEnrolledCourses_DataRead();
            var getfile_GetPortalEnrolledCourses = GetPortalEnrolledCourses_RF.Getfile_GetPortalEnrolledCourses();
            Root_GetPortalEnrolledCourses finalResult = null;

            // If no records in GetPortalEnrolledCourses, you may want to handle that case.
            if (getfile_GetPortalEnrolledCourses == null || !getfile_GetPortalEnrolledCourses.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_GetPortalEnrolledCourses)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    Console.WriteLine($"userId: {record.userId}");
                    string queryString_GetPortalEnrolledCourses = $"userId={record.userId}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"/api/PaymentCommon/GetPortalEnrolledCourses?{queryString_GetPortalEnrolledCourses}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_GetPortalEnrolledCourses = restClient.Execute(restRequest);
                    var GetPortalEnrolledCourses_Scriptcall = new TestScripts_GetPortalEnrolledCourses();
                    try
                    {
                        if ((int)response_GetPortalEnrolledCourses.StatusCode == 200)
                        {
                            var GetPortalEnrolledCourses_request = JsonConvert.DeserializeObject<Root_GetPortalEnrolledCourses>(response_GetPortalEnrolledCourses.Content);
                            ApiResponse_GetPortalEnrolledCourses.Set_GetAllEnrolledCourses(GetPortalEnrolledCourses_request);

                            if (GetPortalEnrolledCourses_request.response.statusCode != 500 &&
                               GetPortalEnrolledCourses_request.isSuccessful == true)
                            {
                                Console.WriteLine("API Response: \n\n" + response_GetPortalEnrolledCourses.Content);
                                GetPortalEnrolledCourses_Scriptcall.GetPortalEnrolledCourses_GetResponse();
                            }
                            else
                            {
                                var EventDrop_Errorrequest = JsonConvert.DeserializeObject<Root_GetPortalEnrolledCourses>(response_GetPortalEnrolledCourses.Content);
                                string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                                string Alphabetpattern = @"^[a-zA-Z]+$";
                                string combinedInputValues_Special = $"{record.userId}";
                                string combinedInputValues_Null = $"{record.userId}";
                                string Null_testInput = @"^,$";
                                string testInputs = @"^\s*$";
                                var abc = Regex.IsMatch(record.userId, Alphabetpattern);

                                if (Regex.IsMatch(record.userId, pattern))
                                {
                                    Console.WriteLine("API Response: " + response_GetPortalEnrolledCourses.Content);
                                    //     GetPortalEnrolledCourses_Scriptcall.SpecialCharacter_username(record.CompanyGuid);
                                }
                                else if (Regex.IsMatch(record.userId ?? "", @"^\d+$"))
                                {
                                    Console.WriteLine("API Response: " + EventDrop_Errorrequest.response);
                                    GetPortalEnrolledCourses_Scriptcall.GetPortalEnrolledCourses_ResponseFailed();
                                }
                                else if (Regex.IsMatch(record.userId ?? "", testInputs))
                                {
                                    Console.WriteLine("API Response: " + EventDrop_Errorrequest.response);
                                    // GetPortalEnrolledCourses_Scriptcall.ValidateInput_Nullfranchises_Values(record.username);
                                }
                                else
                                {
                                    Console.WriteLine("API Response: " + EventDrop_Errorrequest.response);
                                    GetPortalEnrolledCourses_Scriptcall.AlphabetCharacter_GetPortalEnrolledCourses();
                                }
                            }
                            if (GetPortalEnrolledCourses_request.response != null)
                            {
                                finalResult = GetPortalEnrolledCourses_request;
                            }
                        }
                    }
                    catch (JsonException ex)
                    {
                        Console.WriteLine("Deserialization error: " + ex.Message);
                        //     GetPortalEnrolledCourses_Scriptcall.InValidInputValue(record.userId);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                }
            }
            return finalResult;
        }

        // 5- IsCourseEnrolledByUser Endpoint Check
        public Root_GetPortalEnrolledCourses IsCourseEnrolledByUser()
           {
               Login();
               Console.WriteLine("----------------- /api/PaymentCommon/IsCourseEnrolledByUser -----------------\n");
               var GetPortalEnrolledCourses_RF = new GetPortalEnrolledCourses_DataRead();
               var getfile_IsCourseEnrolledByUser = GetPortalEnrolledCourses_RF.Getfile_GetPortalEnrolledCourses();
               Root_GetPortalEnrolledCourses finalResult = null;

               // If no records in IsCourseEnrolledByUser, you may want to handle that case.
               if (getfile_IsCourseEnrolledByUser == null || !getfile_IsCourseEnrolledByUser.Any())
               {
                   Console.WriteLine("No records found.");
                   // Return null or handle as appropriate
                   return finalResult;
               }
               foreach (var record in getfile_IsCourseEnrolledByUser)
               {
                   try
                   {
                       Console.WriteLine("\nInput Value : ");
                       Console.WriteLine($"userId: {record.userId}");
                       string queryString_GetPortalEnrolledCourses = $"userId={record.userId}";
                       var restClient = new RestClient("https://angular-api.calibermatrix.com");
                       var restRequest = new RestRequest($"/api/PaymentCommon/IsCourseEnrolledByUser?{queryString_GetPortalEnrolledCourses}", Method.Get);
                       restRequest.AddHeader("Accept", "application/json");
                       restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                       restRequest.RequestFormat = DataFormat.Json;
                       var response_GetPortalEnrolledCourses = restClient.Execute(restRequest);
                       var GetPortalEnrolledCourses_Scriptcall = new TestScripts_GetPortalEnrolledCourses();
                       try
                       {
                           if ((int)response_GetPortalEnrolledCourses.StatusCode == 200)
                           {
                               var GetPortalEnrolledCourses_request = JsonConvert.DeserializeObject<Root_GetPortalEnrolledCourses>(response_GetPortalEnrolledCourses.Content);
                               ApiResponse_GetPortalEnrolledCourses.Set_GetAllEnrolledCourses(GetPortalEnrolledCourses_request);

                               if (GetPortalEnrolledCourses_request.response.statusCode != 500 &&
                                  GetPortalEnrolledCourses_request.isSuccessful == true)
                               {
                                   Console.WriteLine("API Response: \n\n" + response_GetPortalEnrolledCourses.Content);
                                   GetPortalEnrolledCourses_Scriptcall.GetPortalEnrolledCourses_GetResponse();
                               }
                               else
                               {
                                   var EventDrop_Errorrequest = JsonConvert.DeserializeObject<Root_GetPortalEnrolledCourses>(response_GetPortalEnrolledCourses.Content);
                                   string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                                   string Alphabetpattern = @"^[a-zA-Z]+$";
                                   string combinedInputValues_Special = $"{record.userId}";
                                   string combinedInputValues_Null = $"{record.userId}";
                                   string Null_testInput = @"^,$";
                                   string testInputs = @"^\s*$";
                                   var abc = Regex.IsMatch(record.userId, Alphabetpattern);

                                   if (Regex.IsMatch(record.userId, pattern))
                                   {
                                       Console.WriteLine("API Response: " + response_GetPortalEnrolledCourses.Content);
                                       //     GetPortalEnrolledCourses_Scriptcall.SpecialCharacter_username(record.CompanyGuid);
                                   }
                                   else if (Regex.IsMatch(record.userId ?? "", @"^\d+$"))
                                   {
                                       Console.WriteLine("API Response: " + EventDrop_Errorrequest.response);
                                       GetPortalEnrolledCourses_Scriptcall.GetPortalEnrolledCourses_ResponseFailed();
                                   }
                                   else if (Regex.IsMatch(record.userId ?? "", testInputs))
                                   {
                                       Console.WriteLine("API Response: " + EventDrop_Errorrequest.response);
                                       // GetPortalEnrolledCourses_Scriptcall.ValidateInput_Nullfranchises_Values(record.username);
                                   }
                                   else
                                   {
                                       Console.WriteLine("API Response: " + EventDrop_Errorrequest.response);
                                       GetPortalEnrolledCourses_Scriptcall.AlphabetCharacter_GetPortalEnrolledCourses();
                                   }
                               }
                               if (GetPortalEnrolledCourses_request.response != null)
                               {
                                   finalResult = GetPortalEnrolledCourses_request;
                               }
                           }
                       }
                       catch (JsonException ex)
                       {
                           Console.WriteLine("Deserialization error: " + ex.Message);
                           //     GetPortalEnrolledCourses_Scriptcall.InValidInputValue(record.userId);
                       }
                   }
                   catch (Exception ex)
                   {
                       Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                   }
               }
               return finalResult;
           }

        // 6- GetStudentCoursesViewDetails Endpoint Check (PENDING) (MARKETPLACE ENDPOINT PENDING)
        public Root_GetStudentCoursesViewDetails GetStudentCoursesViewDetails()
        {
            Login();
            Console.WriteLine("----------------- /api/Dashboard/GetStudentCoursesViewDetails -----------------\n");
            var setstudentStatus_RF_record = new setStudentStatus_DataRead();
            var getfile_setStudentStatus = setstudentStatus_RF_record.Getfile_setStudentStatus();
            Root_GetStudentCoursesViewDetails finalResult = null;

            // If no records in getfile_setStudentStatus, you may want to handle that case.
            if (getfile_setStudentStatus == null || !getfile_setStudentStatus.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_setStudentStatus)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    var bodyContent = new
                    {
                        studentIds = record.studentIds,
                        activateStudent = record.activateStudent

                    };
                    Console.WriteLine($"studentIds: {record.studentIds}, activateStudent: {record.activateStudent}");
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/PaymentCommon/GetStudentCoursesViewDetails", Method.Post);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    restRequest.AddJsonBody(bodyContent);
                    var response_setStudentStatus = restClient.Execute(restRequest);
                    var setStudentStatus_Scriptcall = new TestScripts_setStudentStatus();
                    if (response_setStudentStatus.StatusCode == HttpStatusCode.OK)
                    {
                        var EventDrop_request = JsonConvert.DeserializeObject<Root_GetStudentCoursesViewDetails>(response_setStudentStatus.Content);
                        // ApiResponse_setStudentstatus.Set_setstudentsStatus(EventDrop_request);
                        if (EventDrop_request.isSuccessful == true)
                        {
                            Console.WriteLine("API Response: \n\n" + response_setStudentStatus.Content);
                            setStudentStatus_Scriptcall.ValidInputValues();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_setStudentStatus.Content);
                            // setStudentStatus_Scriptcall.DummyResponse();
                        }
                        finalResult = EventDrop_request;
                    }
                    else
                    {
                        var setStudentStatus_Errorrequest = JsonConvert.DeserializeObject<ErrorHandle_PartnerEnroll>(response_setStudentStatus.Content);
                        ErrorHandler_setStudentstatus.Set_setstudentsStatus(setStudentStatus_Errorrequest);
                        string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                        string Alphabetpattern = @"([a-zA-Z]+)";
                        string combinedInputValues_Special = $"{record.studentIds},{record.activateStudent}";
                        var abc = Regex.IsMatch(record.studentIds, Alphabetpattern);

                        if (Regex.IsMatch(record.studentIds, pattern))
                        {
                            Console.WriteLine("API Response: " + response_setStudentStatus.Content);
                            setStudentStatus_Scriptcall.SpecialCharacter_studentIds(record.studentIds);
                        }
                        else if (record.activateStudent.GetValueOrDefault(false) == false)
                        {
                            Console.WriteLine("API Response: " + setStudentStatus_Errorrequest.Message);
                            setStudentStatus_Scriptcall.NullactivateStudent_Values();
                        }
                        else if (Regex.IsMatch(record.studentIds, Alphabetpattern))
                        {
                            Console.WriteLine("API Response: " + setStudentStatus_Errorrequest.Message);
                            setStudentStatus_Scriptcall.ContainsAlphabet_studentIds(record.studentIds);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + setStudentStatus_Errorrequest.Message);
                            setStudentStatus_Scriptcall.Invalid_studentIds(record.studentIds);
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

                                         //--------------------CourseCategory--------------------
        // getCourseCategoriesByTypeId Endpoint Check
        public Root_getCourseCategoriesByTypeId_Response getCourseCategoriesByTypeId()
        {
            Login();
            Console.WriteLine("----------------- /api/CourseCategory/getCourseCategoriesByTypeId -----------------\n");
            var getCourseCategoriesByTypeId_RF = new getCourseCategoriesByTypeId_DataReadFile();
            var getfile_getCourseCategoriesByTypeId = getCourseCategoriesByTypeId_RF.Getfile_getCourseCategoriesByTypeId();
            Root_getCourseCategoriesByTypeId_Response finalResult = null;

            // If no records in getCourseCategoriesByTypeId, you may want to handle that case.
            if (getfile_getCourseCategoriesByTypeId == null || !getfile_getCourseCategoriesByTypeId.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_getCourseCategoriesByTypeId)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    Console.WriteLine($"typeId: {record.typeId}");
                    string queryString_getCourseCategoriesByTypeId = $"typeId={record.typeId}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"/api/CourseCategory/getCourseCategoriesByTypeId?{queryString_getCourseCategoriesByTypeId}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_getCourseCategoriesByTypeId = restClient.Execute(restRequest);
                    var getCourseCategoriesByTypeId_Scriptcall = new TestScripts_getCourseCategoriesByTypeId();
                    if (response_getCourseCategoriesByTypeId.StatusCode == HttpStatusCode.OK)
                    {
                        var getCourseCategoriesByTypeId_request = JsonConvert.DeserializeObject<Root_getCourseCategoriesByTypeId_Response>(response_getCourseCategoriesByTypeId.Content);
                        ApiResponse_getCourseCategoriesByTypeId.Set_getCourseCategoriesByTypeId(getCourseCategoriesByTypeId_request);
                        if (getCourseCategoriesByTypeId_request.isSuccessful == true && getCourseCategoriesByTypeId_request.response.Count > 0)
                        {
                            Console.WriteLine("API Response: " + response_getCourseCategoriesByTypeId.Content);
                            getCourseCategoriesByTypeId_Scriptcall.Default_Response();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_getCourseCategoriesByTypeId.Content);
                            getCourseCategoriesByTypeId_Scriptcall.ValidReponse();
                        }
                        if (getCourseCategoriesByTypeId_request.response != null && getCourseCategoriesByTypeId_request.response.Any())
                        {
                            finalResult = getCourseCategoriesByTypeId_request;
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

                                        //--------------------Courses--------------------
        // 1- central Endpoint Check
        public bool central()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/Courses/central -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/Courses/central", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_central = restClient.Get(restRequest);
                var central_Scriptcall = new TestScripts_central();
                if (response_central.StatusCode == HttpStatusCode.OK)
                {
                    // Deserialize as a List if the response is an array
                    var central_request = JsonConvert.DeserializeObject<Root_central>(response_central.Content);
                    ApiResponse_central.Set_central(central_request);
                    if (central_request.isSuccessful == true)
                    {
                        Console.WriteLine("API Response: " + response_central.Content);
                        central_Scriptcall.GetResponse_Successfully();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_central.Content);
                    central_Scriptcall.GetResponse_Failed();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }

        // 2- getCoursesByTypeAndCategory Endpoint Check
        public Root_getCourseCategoriesByTypeId_Response getCoursesByTypeAndCategory()
        {
            Login();
            Console.WriteLine("----------------- /api/Courses/getCoursesByTypeAndCategory -----------------\n");
            var getCoursesByTypeAndCategory_RF = new getCoursesByTypeAndCategory_DataRead();
            var getfile_getCoursesByTypeAndCategory = getCoursesByTypeAndCategory_RF.Getfile_getCoursesByTypeAndCategory_DataRead();
            Root_getCourseCategoriesByTypeId_Response finalResult = null;

            // If no records in getCourseCategoriesByTypeId, you may want to handle that case.
            if (getfile_getCoursesByTypeAndCategory == null || !getfile_getCoursesByTypeAndCategory.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_getCoursesByTypeAndCategory)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    Console.WriteLine($"typeId: {record.typeId}, categoryId: {record.categoryId}");
                    string queryString_getCourseCategoriesByTypeId = $"typeId={record.typeId}&categoryId={record.categoryId}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"/api/Courses/getCoursesByTypeAndCategory?{queryString_getCourseCategoriesByTypeId}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_getCourseCategoriesByTypeId = restClient.Execute(restRequest);
                    var getCourseCategoriesByTypeId_Scriptcall = new TestScripts_getCourseCategoriesByTypeId();
                    if (response_getCourseCategoriesByTypeId.StatusCode == HttpStatusCode.OK)
                    {
                        var getCourseCategoriesByTypeId_request = JsonConvert.DeserializeObject<Root_getCourseCategoriesByTypeId_Response>(response_getCourseCategoriesByTypeId.Content);
                        ApiResponse_getCourseCategoriesByTypeId.Set_getCourseCategoriesByTypeId(getCourseCategoriesByTypeId_request);
                        if (getCourseCategoriesByTypeId_request.isSuccessful == true && getCourseCategoriesByTypeId_request.response.Count > 0)
                        {
                            Console.WriteLine("API Response: " + response_getCourseCategoriesByTypeId.Content);
                            getCourseCategoriesByTypeId_Scriptcall.Default_Response();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_getCourseCategoriesByTypeId.Content);
                            getCourseCategoriesByTypeId_Scriptcall.ValidReponse();
                        }
                        if (getCourseCategoriesByTypeId_request.response != null && getCourseCategoriesByTypeId_request.response.Any())
                        {
                            finalResult = getCourseCategoriesByTypeId_request;
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

        // -----------------------CourseReview-------------------------
        // 1- GetReviewedCourse Endpoint Check
        public Root_GetReviewCourse GetReviewedCourse()
        {
            Login();
            Console.WriteLine("----------------- /api/CourseReview/GetReviewedCourse -----------------\n");
            var GetReviewedCourse_RF = new GetReviewedCourse_DataRead();
            var getfile_GetReviewedCourse = GetReviewedCourse_RF.Getfile_GetReviewedCourse();
            Root_GetReviewCourse finalResult = null;

            // If no records in getCourseCategoriesByTypeId, you may want to handle that case.
            if (getfile_GetReviewedCourse == null || !getfile_GetReviewedCourse.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_GetReviewedCourse)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    Console.WriteLine($"courseId: {record.courseId}");
                    string queryString_getCourseCategoriesByTypeId = $"courseId={record.courseId}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"/api/CourseReview/GetReviewedCourse?{queryString_getCourseCategoriesByTypeId}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_getCourseCategoriesByTypeId = restClient.Execute(restRequest);
                    var getCourseCategoriesByTypeId_Scriptcall = new TestScripts_GetReviewedCourse();
                    if (response_getCourseCategoriesByTypeId.StatusCode == HttpStatusCode.OK)
                    {
                        var getCourseCategoriesByTypeId_request = JsonConvert.DeserializeObject<Root_GetReviewCourse>(response_getCourseCategoriesByTypeId.Content);
                        ApiResponse_GetReviewCourse.Set_GetReviewCourse(getCourseCategoriesByTypeId_request);
                        if (getCourseCategoriesByTypeId_request.isSuccessful == true)
                        {
                            Console.WriteLine("API Response: " + response_getCourseCategoriesByTypeId.Content);
                            getCourseCategoriesByTypeId_Scriptcall.ValidResponse();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_getCourseCategoriesByTypeId.Content);
                            getCourseCategoriesByTypeId_Scriptcall.InValidReponse();
                        }
                        if (getCourseCategoriesByTypeId_request.response != null)
                        {
                            finalResult = getCourseCategoriesByTypeId_request;
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

        // 2- AddCourseReview Endpoint Check
        public AddCourseReview_Response AddCourseReview()
        {
            Login();
            Console.WriteLine("----------------- /api/CourseReview/AddCourseReview -----------------\n");
            var AddCourseReview_RF_record = new AddCourseReview_DataRead();
            var getfile_AddCourseReview = AddCourseReview_RF_record.Getfile_AddCourseReview();
            AddCourseReview_Response finalResult = null;

            // If no records in getfile_AddCourseReview, you may want to handle that case.
            if (getfile_AddCourseReview == null || !getfile_AddCourseReview.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_AddCourseReview)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    var bodyContent = new
                    {
                        id = record.id,
                        courseId = record.courseId,
                        rating = record.rating,
                        review = record.review,
                        isShow = record.isShow,
                        createdDate = record.createdDate
                    };
                    Console.WriteLine($"id: {record.id},\ncourseId: {record.courseId},\nrating: {record.rating},\nreview: {record.review},\nisShow: {record.isShow},\ncreatedDate: {record.createdDate}");
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/CourseReview/AddCourseReview", Method.Post);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    restRequest.AddJsonBody(bodyContent);
                    var response_setStudentStatus = restClient.Execute(restRequest);
                    var setStudentStatus_Scriptcall = new TestScripts_AddCourseReview();
                    if (response_setStudentStatus.StatusCode == HttpStatusCode.OK)
                    {
                        var AddCourseReview_request = JsonConvert.DeserializeObject<AddCourseReview_Response>(response_setStudentStatus.Content);
                        ApiResponse_AddCourseReview.Set_AddCourseReview(AddCourseReview_request);
                        if (AddCourseReview_request.isSuccessful == true)
                        {
                            Console.WriteLine("API Response: \n\n" + response_setStudentStatus.Content);
                            setStudentStatus_Scriptcall.ValidInputValues();
                        }
                        finalResult = AddCourseReview_request;
                    }
                    else
                    {
                        var setStudentStatus_Errorrequest = JsonConvert.DeserializeObject<ErrorHandle_PartnerEnroll>(response_setStudentStatus.Content);
                        ErrorHandler_setStudentstatus.Set_setstudentsStatus(setStudentStatus_Errorrequest);
                        string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                        string Alphabetpattern = @"([a-zA-Z]+)";
                        string Null_testInput = @"^,$";
                        string testInputs = @"^\s*$";
                        string combinedInputValues_Special = $"{record.id},{record.courseId}";
                        var abc = Regex.IsMatch(record.id, Alphabetpattern);

                        if (Regex.IsMatch(record.id, pattern) ||
                            Regex.IsMatch(record.courseId, pattern) ||
                            Regex.IsMatch(record.rating, pattern))
                        {
                            Console.WriteLine("API Response: " + response_setStudentStatus.Content);
                            setStudentStatus_Scriptcall.SpecialCharacter(record.id,record.courseId,record.rating);
                        }
                        else if (Regex.IsMatch(record.id, testInputs) ||
                            Regex.IsMatch(record.courseId, testInputs) ||
                            Regex.IsMatch(record.rating, testInputs))
                        {
                            Console.WriteLine("API Response: " + setStudentStatus_Errorrequest.Message);
                            setStudentStatus_Scriptcall.Null_Values(record.id, record.courseId, record.rating);
                        }
                        else if (Regex.IsMatch(record.id, Alphabetpattern) || 
                            Regex.IsMatch(record.courseId, Alphabetpattern) || 
                            Regex.IsMatch(record.rating, Alphabetpattern))
                        {
                            Console.WriteLine("API Response: " + setStudentStatus_Errorrequest.Message);
                            setStudentStatus_Scriptcall.ContainsAlphabetValue(record.id, record.courseId, record.rating);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + setStudentStatus_Errorrequest.Message);
                        //    setStudentStatus_Scriptcall.Invalid_studentIds(record.id);
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

        // 3- IsReviewAddedByUser Endpoint Check
        public Root_IsReviewAddedByUser IsReviewAddedByUser()
        {
            Login();
            Console.WriteLine("----------------- /api/CourseReview/IsReviewAddedByUser -----------------\n");
            var IsReviewAddedByUser_RF = new GetReviewedCourse_DataRead();
            var getfile_IsReviewAddedByUser = IsReviewAddedByUser_RF.Getfile_GetReviewedCourse();
            Root_IsReviewAddedByUser finalResult = null;

            // If no records in IsReviewAddedByUser, you may want to handle that case.
            if (getfile_IsReviewAddedByUser == null || !getfile_IsReviewAddedByUser.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_IsReviewAddedByUser)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    Console.WriteLine($"courseId: {record.courseId}");
                    string queryString_IsReviewAddedByUser = $"courseId={record.courseId}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"/api/CourseReview/IsReviewAddedByUser?{queryString_IsReviewAddedByUser}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_IsReviewAddedByUser = restClient.Execute(restRequest);
                    var IsReviewAddedByUser_Scriptcall = new TestScripts_IsReviewAddedByUser();
                    if (response_IsReviewAddedByUser.StatusCode == HttpStatusCode.OK)
                    {
                        var IsReviewAddedByUser_request = JsonConvert.DeserializeObject<Root_IsReviewAddedByUser>(response_IsReviewAddedByUser.Content);
                        ApiResponse_IsReviewAddedByUser.Set_IsReviewAddedByUser(IsReviewAddedByUser_request);
                        if (IsReviewAddedByUser_request.isSuccessful == true && IsReviewAddedByUser_request.response == true)
                        {
                            Console.WriteLine("API Response: " + response_IsReviewAddedByUser.Content);
                            IsReviewAddedByUser_Scriptcall.ValidResponse();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_IsReviewAddedByUser.Content);
                            IsReviewAddedByUser_Scriptcall.InValidReponse();
                        }
                        if (IsReviewAddedByUser_request.response == true)
                        {
                            finalResult = IsReviewAddedByUser_request;
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

        //                                          -----------------CourseType--------------------
        // list Endpoint Check
        public Root_course_list list()
        {
            Login();
            Console.WriteLine("----------------- /api/CourseType/list -----------------\n");
            var list_RF = new course_list_DataRead();
            var getfile_list = list_RF.Getfile_list();
            Root_course_list finalResult = null;

            // If no records in IsReviewAddedByUser, you may want to handle that case.
            if (getfile_list == null || !getfile_list.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_list)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    Console.WriteLine($"unassign: {record.unassign}");
                    string queryString_list = $"unassign={record.unassign}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"/api/CourseType/list?{queryString_list}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_list = restClient.Execute(restRequest);
                    var list_Scriptcall = new TestScripts_IsReviewAddedByUser();
                    if (response_list.StatusCode == HttpStatusCode.OK)
                    {
                        var list_request = JsonConvert.DeserializeObject<Root_course_list>(response_list.Content);
                        ApiResponse_course_list.Set_course_list(list_request);
                        if (list_request.isSuccessful == true && list_request.response.Count > 0 )
                        {
                            Console.WriteLine("API Response: " + response_list.Content);
                            list_Scriptcall.ValidResponse();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_list.Content);
                            list_Scriptcall.InValidReponse();
                        }
                        if (list_request.response.Count < 0)
                        {
                            finalResult = list_request;
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

        //                                          ------------------Department-------------------
        // 1- getDepartments Endpoint Check
        public bool getDepartments()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/Department/getDepartments -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/Department/getDepartments", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_getDepartment = restClient.Get(restRequest);
                var getDepartment_Scriptcall = new TestScripts_getDepartment();
                if (response_getDepartment.StatusCode == HttpStatusCode.OK)
                {
                    // Deserialize as a List if the response is an array
                    var getDepartment_request = JsonConvert.DeserializeObject<Root_getDepartment_Response>(response_getDepartment.Content);
                    ApiResponse_Root_getDepartment.Set_getDepartment(getDepartment_request);
                    if (getDepartment_request.isSuccessful == true)
                    {
                        Console.WriteLine("API Response: " + response_getDepartment.Content);
                        getDepartment_Scriptcall.ValidResponse();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_getDepartment.Content);
                    getDepartment_Scriptcall.InValidReponse();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }

        // 2- saveDepartments Endpoint Check
        public Root_saveDepartment saveDepartments()
        {
            Login();
            Console.WriteLine("----------------- /api/Department/saveDepartments -----------------\n");
            var AddCourseReview_RF_record = new saveDepartment_DataRead();
            var getfile_AddCourseReview = AddCourseReview_RF_record.Getfile_saveDepartment();
            Root_saveDepartment finalResult = null;

            // If no records in getfile_AddCourseReview, you may want to handle that case.
            if (getfile_AddCourseReview == null || !getfile_AddCourseReview.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_AddCourseReview)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    var bodyContent = new
                    {
                        deptId = record.deptId,
                        deptName = record.deptName,
                        statusCode = record.statusCode
                    };
                    Console.WriteLine($"deptId: {record.deptId},\ndeptName: {record.deptName},\nstatusCode: {record.statusCode}");
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/Department/saveDepartments", Method.Post);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    restRequest.AddJsonBody(bodyContent);
                    var response_saveDepartment = restClient.Execute(restRequest);
                    var saveDepartment_Scriptcall = new TestScripts_saveDepartment();
                    if (response_saveDepartment.StatusCode == HttpStatusCode.OK)
                    {
                        var saveDepartment_request = JsonConvert.DeserializeObject<Root_saveDepartment>(response_saveDepartment.Content);
                        ApiResponse_saveDepartment.Set_saveDepartment(saveDepartment_request);
                        if (saveDepartment_request.isSuccessful == true)
                        {
                            Console.WriteLine("API Response: \n\n" + response_saveDepartment.Content);
                            saveDepartment_Scriptcall.ValidInputValues();
                        }
                        finalResult = saveDepartment_request;
                    }
                    else
                    {
                        var saveDepartment_Errorrequest = JsonConvert.DeserializeObject<ErrorHandle_PartnerEnroll>(response_saveDepartment.Content);
                        ErrorHandler_setStudentstatus.Set_setstudentsStatus(saveDepartment_Errorrequest);
                        string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                        string Alphabetpattern = @"([a-zA-Z]+)";
                        string Null_testInput = @"^,$";
                        string testInputs = @"^\s*$";
                        string combinedInputValues_Special = $"{record.deptId},{record.statusCode}";
                        var abc = Regex.IsMatch(record.deptId, Alphabetpattern);

                        if (Regex.IsMatch(record.deptId, pattern))                   
                        {
                            Console.WriteLine("API Response: " + response_saveDepartment.Content);
                            saveDepartment_Scriptcall.SpecialCharacter(record.deptId);
                        }
                        else if (Regex.IsMatch(record.deptId, testInputs))
                        {
                            Console.WriteLine("API Response: " + saveDepartment_Errorrequest.Message);
                            saveDepartment_Scriptcall.Null_Values(record.deptId);
                        }
                        else if (Regex.IsMatch(record.deptId, Alphabetpattern))
                        {
                            Console.WriteLine("API Response: " + saveDepartment_Errorrequest.Message);
                            saveDepartment_Scriptcall.ContainsAlphabetValue(record.deptId);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + saveDepartment_Errorrequest.Message);
                            //    setStudentStatus_Scriptcall.Invalid_studentIds(record.id);
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

        // 3- deleteDepartments Endpoint Check
        public deleteDepartments_Response deleteDepartments()
        {
            Login();
            Console.WriteLine("----------------- /api/Department/deleteDepartments -----------------\n");
            var AddCourseReview_RF_record = new deleteDepartments_DataRead();
            var getfile_AddCourseReview = AddCourseReview_RF_record.Getfile_deleteDepartments();
            deleteDepartments_Response finalResult = null;

            // If no records in getfile_AddCourseReview, you may want to handle that case.
            if (getfile_AddCourseReview == null || !getfile_AddCourseReview.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_AddCourseReview)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    var bodyContent = new
                    {
                        deptId = record.deptId,
                        deptName = record.deptName,
                        statusCode = record.statusCode
                    };
                    Console.WriteLine($"deptId: {record.deptId},\ndeptName: {record.deptName},\nstatusCode: {record.statusCode}");
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/Department/deleteDepartments", Method.Post);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    restRequest.AddJsonBody(bodyContent);
                    var response_saveDepartment = restClient.Execute(restRequest);
                    var saveDepartment_Scriptcall = new TestScripts_deleteDepartments();
                    if (response_saveDepartment.StatusCode == HttpStatusCode.OK)
                    {
                        var saveDepartment_request = JsonConvert.DeserializeObject<deleteDepartments_Response>(response_saveDepartment.Content);
                        ApiResponse_deleteDepartments.Set_deleteDepartments(saveDepartment_request);
                        if (saveDepartment_request.isSuccessful == true && saveDepartment_request.statusCode!=500)
                        {
                            Console.WriteLine("API Response: \n\n" + response_saveDepartment.Content);
                            saveDepartment_Scriptcall.ValidInputValues();
                        }
                        else
                        {
                            Console.WriteLine("API Response: \n\n" + response_saveDepartment.Content);
                            saveDepartment_Scriptcall.InValidReponse();
                        }
                        finalResult = saveDepartment_request;
                    }
                    else
                    {
                        var saveDepartment_Errorrequest = JsonConvert.DeserializeObject<ErrorHandle_PartnerEnroll>(response_saveDepartment.Content);
                        ErrorHandler_setStudentstatus.Set_setstudentsStatus(saveDepartment_Errorrequest);
                        string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                        string Alphabetpattern = @"([a-zA-Z]+)";
                        string Null_testInput = @"^,$";
                        string testInputs = @"^\s*$";
                        string combinedInputValues_Special = $"{record.deptId},{record.statusCode}";
                        var abc = Regex.IsMatch(record.deptId, Alphabetpattern);

                        if (Regex.IsMatch(record.deptId, pattern))
                        {
                            Console.WriteLine("API Response: " + response_saveDepartment.Content);
                            saveDepartment_Scriptcall.SpecialCharacter(record.deptId);
                        }
                        else if (Regex.IsMatch(record.deptId, testInputs))
                        {
                            Console.WriteLine("API Response: " + saveDepartment_Errorrequest.Message);
                            saveDepartment_Scriptcall.Null_Values(record.deptId);
                        }
                        else if (Regex.IsMatch(record.deptId, Alphabetpattern))
                        {
                            Console.WriteLine("API Response: " + saveDepartment_Errorrequest.Message);
                            saveDepartment_Scriptcall.ContainsAlphabetValue(record.deptId);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + saveDepartment_Errorrequest.Message);
                            //    setStudentStatus_Scriptcall.Invalid_studentIds(record.id);
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

        //                                      ---------------------- Notification ----------------------
        // 1- GetUserNotifications Endpoint Check
        public bool GetUserNotifications()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/Notification/GetUserNotifications -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/Notification/GetUserNotifications", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_GetUserNotifications = restClient.Get(restRequest);
                var GetUserNotifications_Scriptcall = new TestScripts_GetUserNotifications();
                if (response_GetUserNotifications.StatusCode == HttpStatusCode.OK)
                {
                    // Deserialize as a List if the response is an array
                    var getDepartment_request = JsonConvert.DeserializeObject<Root_GetUserNotification>(response_GetUserNotifications.Content);
                    ApiResponse_GetUserNotification.Set_GetUserNotification(getDepartment_request);
                    if (getDepartment_request.isSuccessful == true)
                    {
                        Console.WriteLine("API Response: " + response_GetUserNotifications.Content);
                        GetUserNotifications_Scriptcall.ValidResponse();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_GetUserNotifications.Content);
                    GetUserNotifications_Scriptcall.InValidReponse();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }

        // 2- ClearAllNotification Endpoint Check
        public bool ClearAllNotification()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/Notification/ClearAllNotification -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/Notification/ClearAllNotification", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_ClearAllNotification = restClient.Get(restRequest);
                var ClearAllNotification_Scriptcall = new TestScript_ClearAllNotification();
                if (response_ClearAllNotification.StatusCode == HttpStatusCode.OK)
                {
                    // Deserialize as a List if the response is an array
                    var getDepartment_request = JsonConvert.DeserializeObject<ClearAllNotification_Response>(response_ClearAllNotification.Content);
                    ApiResponse_ClearAllNotification.Set_ClearAllNotification(getDepartment_request);
                    if (getDepartment_request.isSuccessful == true)
                    {
                        Console.WriteLine("API Response: " + response_ClearAllNotification.Content);
                        ClearAllNotification_Scriptcall.ValidResponse();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_ClearAllNotification.Content);
                    ClearAllNotification_Scriptcall.InValidReponse();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }

        // 3- VisitNotification Endpoint Check
        public VisitNotification_Response VisitNotification()
        {
            Login();
            Console.WriteLine("----------------- /api/Notification/VisitNotification -----------------\n");
            var VisitNotification_RF = new VisitNotification_DataRead();
            var getfile_VisitNotification = VisitNotification_RF.Getfile_VisitNotification();
            VisitNotification_Response finalResult = null;

            // If no records in Getfile_VisitNotification, you may want to handle that case.
            if (getfile_VisitNotification == null || !getfile_VisitNotification.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_VisitNotification)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    var bodyContent = new
                    {
                        notificationId = record.notificationId

                    };
                    Console.WriteLine($"notificationId: {record.notificationId}");
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/Notification/VisitNotification", Method.Post);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    restRequest.AddJsonBody(bodyContent);
                    var response_setStudentStatus = restClient.Execute(restRequest);
                    var setStudentStatus_Scriptcall = new TestScripts_VisitNotification();
                    if (response_setStudentStatus.StatusCode == HttpStatusCode.OK)
                    {
                        var EventDrop_request = JsonConvert.DeserializeObject<VisitNotification_Response>(response_setStudentStatus.Content);
                        ApiResponse_VisitNotification.Set_VisitNotification(EventDrop_request);
                        if (EventDrop_request.isSuccessful == true)
                        {
                            Console.WriteLine("API Response: \n\n" + response_setStudentStatus.Content);
                            setStudentStatus_Scriptcall.ValidInputValues();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_setStudentStatus.Content);
                            // setStudentStatus_Scriptcall.DummyResponse();
                        }
                        finalResult = EventDrop_request;
                    }
                    else
                    {
                        var setStudentStatus_Errorrequest = JsonConvert.DeserializeObject<ErrorHandle_PartnerEnroll>(response_setStudentStatus.Content);
                        ErrorHandler_setStudentstatus.Set_setstudentsStatus(setStudentStatus_Errorrequest);
                        string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                        string Alphabetpattern = @"([a-zA-Z]+)";
                        string Null_testInput = @"^,$";
                        string testInputs = @"^\s*$";
                        var abc = Regex.IsMatch(record.notificationId, Alphabetpattern);

                        if (Regex.IsMatch(record.notificationId, pattern))
                        {
                            Console.WriteLine("API Response: " + response_setStudentStatus.Content);
                            setStudentStatus_Scriptcall.SpecialCharacter(record.notificationId);
                        }
                        else if (Regex.IsMatch(record.notificationId, testInputs))
                        {
                            Console.WriteLine("API Response: " + setStudentStatus_Errorrequest.Message);
                            setStudentStatus_Scriptcall.Null_Values(record.notificationId);
                        }
                        else if (Regex.IsMatch(record.notificationId, Alphabetpattern))
                        {
                            Console.WriteLine("API Response: " + setStudentStatus_Errorrequest.Message);
                            setStudentStatus_Scriptcall.ContainsAlphabetValue(record.notificationId);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + setStudentStatus_Errorrequest.Message);
                            setStudentStatus_Scriptcall.InValidReponse();
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

        // 4- GetNoticationCounts Endpoint Check
        public bool GetNotificationCounts()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/Notification/GetNoticationCounts -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/Notification/GetNoticationCounts", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_GetNoticationCounts = restClient.Get(restRequest);
                var GetNoticationCounts_Scriptcall = new TestScripts_GetNoticationCounts();
                if (response_GetNoticationCounts.StatusCode == HttpStatusCode.OK)
                {
                    // Deserialize as a List if the response is an array
                    var getDepartment_request = JsonConvert.DeserializeObject<GetNoticationCounts_Response>(response_GetNoticationCounts.Content);
                    ApiResponse_GetNoticationCounts.Set_GetNoticationCounts(getDepartment_request);
                    if (getDepartment_request.isSuccessful == true)
                    {
                        Console.WriteLine("API Response: " + response_GetNoticationCounts.Content);
                        GetNoticationCounts_Scriptcall.ValidResponse();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_GetNoticationCounts.Content);
                    GetNoticationCounts_Scriptcall.InValidReponse();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }

        // 5- GetUserActivityLogs Endpoint Check
        public Root_GetUserActivityLogs GetUserActivityLogs()
        {
            Login();
            Console.WriteLine("----------------- /api/Notification/GetUserActivityLogs -----------------\n");
            var GetUserActivityLogs_RF = new GetUserActivityLogs_DataRead();
            var getfile_GetUserActivityLogs = GetUserActivityLogs_RF.Getfile_GetUserActivityLogs();
            Root_GetUserActivityLogs finalResult = null;

            // If no records in Getfile_GetUserActivityLogs, you may want to handle that case.
            if (getfile_GetUserActivityLogs == null || !getfile_GetUserActivityLogs.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_GetUserActivityLogs)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    Console.WriteLine($"onlyTopFifteen: {record.onlyTopFifteen}");
                    string queryString_GetUserActivityLogs = $"onlyTopFifteen={record.onlyTopFifteen}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/Notification/GetUserActivityLogs?{queryString_GetUserActivityLogs}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_GetUserActivityLogs = restClient.Execute(restRequest);
                    var GetUserActivityLogs_Scriptcall = new TestScripts_GetUserActivityLogs();
                    if (response_GetUserActivityLogs.StatusCode == HttpStatusCode.OK)
                    {
                        var EventDrop_request = JsonConvert.DeserializeObject<Root_GetUserActivityLogs>(response_GetUserActivityLogs.Content);
                        ApiResponse_GetUserActivityLogs.Set_GetUserActivityLogs(EventDrop_request);
                        if (EventDrop_request.isSuccessful == true)
                        {
                            Console.WriteLine("API Response: \n\n" + response_GetUserActivityLogs.Content);
                            GetUserActivityLogs_Scriptcall.ValidInputValues();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_GetUserActivityLogs.Content);
                            // setStudentStatus_Scriptcall.DummyResponse();
                        }
                        finalResult = EventDrop_request;
                    }
                    else
                    {
                        var setStudentStatus_Errorrequest = JsonConvert.DeserializeObject<ErrorHandle_PartnerEnroll>(response_GetUserActivityLogs.Content);
                        ErrorHandler_setStudentstatus.Set_setstudentsStatus(setStudentStatus_Errorrequest);
                        string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                        string Alphabetpattern = @"([a-zA-Z]+)";
                        string Null_testInput = @"^,$";
                        string testInputs = @"^\s*$";
                        var abc = Regex.IsMatch(record.onlyTopFifteen, Alphabetpattern);

                        if (Regex.IsMatch(record.onlyTopFifteen, pattern))
                        {
                            Console.WriteLine("API Response: " + response_GetUserActivityLogs.Content);
                            GetUserActivityLogs_Scriptcall.SpecialCharacter(record.onlyTopFifteen);
                        }
                        else if (Regex.IsMatch(record.onlyTopFifteen, testInputs))
                        {
                            Console.WriteLine("API Response: " + setStudentStatus_Errorrequest.Message);
                            GetUserActivityLogs_Scriptcall.Null_Values(record.onlyTopFifteen);
                        }
                        else if (Regex.IsMatch(record.onlyTopFifteen, Alphabetpattern))
                        {
                            Console.WriteLine("API Response: " + setStudentStatus_Errorrequest.Message);
                            GetUserActivityLogs_Scriptcall.ContainsAlphabetValue(record.onlyTopFifteen);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + setStudentStatus_Errorrequest.Message);
                            GetUserActivityLogs_Scriptcall.InValidReponse();
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

        //                                     -------------------- Company --------------------
        // 1- CompanyConfigs Endpoint Check
        public Root_CompanyConfigs CompanyConfigs()
        {
            Login();
            Console.WriteLine("----------------- /api/Company/CompanyConfigs -----------------\n");
            var CompanyConfigs_RF = new CompanyConfig_DataRead();
            var getfile_CompanyConfigs = CompanyConfigs_RF.Getfile_CompanyConfig();
            Root_CompanyConfigs finalResult = null;

            // If no records in Getfile_CompanyConfig, you may want to handle that case.
            if (getfile_CompanyConfigs == null || !getfile_CompanyConfigs.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_CompanyConfigs)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    Console.WriteLine($"url: {record.url}");
                    string queryString_CompanyConfigs = $"url={record.url}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/Company/CompanyConfigs?{queryString_CompanyConfigs}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_GetUserActivityLogs = restClient.Execute(restRequest);
                    var GetUserActivityLogs_Scriptcall = new TestScripts_CompanyConfigs();
                    if (response_GetUserActivityLogs.StatusCode == HttpStatusCode.OK)
                    {
                        var EventDrop_request = JsonConvert.DeserializeObject<Root_CompanyConfigs>(response_GetUserActivityLogs.Content);
                        ApiResponse_CompanyConfigs.Set_CompanyConfigs(EventDrop_request);
                        if (EventDrop_request.isSuccessful == true && EventDrop_request.response == null)
                        {
                            Console.WriteLine("API Response: \n\n" + response_GetUserActivityLogs.Content);
                            GetUserActivityLogs_Scriptcall.ValidResponse();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_GetUserActivityLogs.Content);
                            GetUserActivityLogs_Scriptcall.InValidReponse();
                        }
                        finalResult = EventDrop_request;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                }
            }
            return finalResult;
        }

        // 2- CompanyNameByUserName Endpoint Check
        public CompanyNameByUserName_Response CompanyNameByUserName()
        {
            Login();
            Console.WriteLine("----------------- /api/Company/CompanyNameByUserName -----------------\n");
            var CompanyNameByUserName_RF = new CompanyNameByUserName_DataRead();
            var getfile_CompanyNameByUserName = CompanyNameByUserName_RF.Getfile_CompanyNameByUserName();
            CompanyNameByUserName_Response finalResult = null;

            // If no records in Getfile_CompanyNameByUserName, you may want to handle that case.
            if (getfile_CompanyNameByUserName == null || !getfile_CompanyNameByUserName.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_CompanyNameByUserName)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    Console.WriteLine($"userName: {record.userName},url: {record.url}");
                    string queryString_CompanyNameByUserName = $"userName: {record.userName}&url={record.url}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/Company/CompanyNameByUserName?{queryString_CompanyNameByUserName}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_GetUserActivityLogs = restClient.Execute(restRequest);
                    var GetUserActivityLogs_Scriptcall = new TestScripts_CompanyConfigs();
                    if (response_GetUserActivityLogs.StatusCode == HttpStatusCode.OK)
                    {
                        var EventDrop_request = JsonConvert.DeserializeObject<CompanyNameByUserName_Response>(response_GetUserActivityLogs.Content);
                        ApiResponse_CompanyNameByUserName.Set_CompanyNameByUserName(EventDrop_request);
                        if (EventDrop_request.isSuccessful == true)
                        {
                            Console.WriteLine("API Response: \n\n" + response_GetUserActivityLogs.Content);
                            GetUserActivityLogs_Scriptcall.ValidResponse();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_GetUserActivityLogs.Content);
                            GetUserActivityLogs_Scriptcall.InValidReponse();
                        }
                        finalResult = EventDrop_request;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                }
            }
            return finalResult;
        }

        // 3- Menus Endpoint Check
        public bool Menus()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/Company/Menus -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/Company/Menus", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_Menus = restClient.Get(restRequest);
                var GetNoticationCounts_Scriptcall = new TestScripts_Menus();
                if (response_Menus.StatusCode == HttpStatusCode.OK)
                {
                    // Deserialize as a List if the response is an array
                    var Menus_request = JsonConvert.DeserializeObject<Root_Menus_Response>(response_Menus.Content);
                    ApiResponse_Menus.Set_Menus(Menus_request);
                    if (Menus_request.isSuccessful == true && Menus_request.response.Count > 0)
                    {
                        Console.WriteLine("API Response: " + response_Menus.Content);
                        GetNoticationCounts_Scriptcall.ValidResponse();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_Menus.Content);
                    GetNoticationCounts_Scriptcall.InValidReponse();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }

        // 4- franchises Endpoint Check
        public Root_franchises franchises()
        {
            Login();
            Console.WriteLine("----------------- /api/Company/franchises -----------------\n");
            var franchises_RF = new franchises_DataRead();
            var getfile_franchises = franchises_RF.Getfile_franchises();
            Root_franchises finalResult = null;

            // If no records in Getfile_CompanyConfig, you may want to handle that case.
            if (getfile_franchises == null || !getfile_franchises.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_franchises)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    Console.WriteLine($"excludeMainBusiness: {record.excludeMainBusiness}");
                    string queryString_franchises = $"excludeMainBusiness={record.excludeMainBusiness}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/Company/franchises?{queryString_franchises}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_franchises = restClient.Execute(restRequest);
                    var GetUserActivityLogs_Scriptcall = new TestScripts_franchises();
                    if (response_franchises.StatusCode == HttpStatusCode.OK)
                    {
                        var EventDrop_request = JsonConvert.DeserializeObject<Root_franchises>(response_franchises.Content);
                        ApiResponse_franchises.Set_franchises(EventDrop_request);
                        if (EventDrop_request.isSuccessful == true)
                        {
                            Console.WriteLine("API Response: \n\n" + response_franchises.Content);
                            GetUserActivityLogs_Scriptcall.ValidResponse();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_franchises.Content);
                            GetUserActivityLogs_Scriptcall.InValidReponse();
                        }
                        finalResult = EventDrop_request;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                }
            }
            return finalResult;
        }

        // 5- Permissions Endpoint Check
        public bool Permissions()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/Company/Permissions -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/Company/Permissions", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_Permissions = restClient.Get(restRequest);
                var Permissions_Scriptcall = new TestScripts_Permissions();
                if (response_Permissions.StatusCode == HttpStatusCode.OK)
                {
                    // Deserialize as a List if the response is an array
                    var Permissions_request = JsonConvert.DeserializeObject<Root_Permssion_Response>(response_Permissions.Content);
                    ApiResponse_Permissions.Set_Permissions(Permissions_request);
                    if (Permissions_request.isSuccessful == true && Permissions_request.response.Count > 0)
                    {
                        Console.WriteLine("API Response: " + response_Permissions.Content);
                        Permissions_Scriptcall.ValidResponse();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_Permissions.Content);
                    Permissions_Scriptcall.InValidReponse();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }

        // 6- saveBrandings Endpoint Check
        public saveBrandings_Response saveBrandings()
        {
            Login();
            Console.WriteLine("----------------- /api/Company/saveBrandings -----------------\n");
            var saveBrandings_RF = new saveBranding_DataRead();
            var getfile_saveBrandings = saveBrandings_RF.Getfile_SaveBrandings();
            saveBrandings_Response finalResult = null;

            // If no records in Getfile_CompanyConfig, you may want to handle that case.
            if (getfile_saveBrandings == null || !getfile_saveBrandings.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_saveBrandings)
            {
                try
                {
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/Company/saveBrandings", Method.Post);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    //
                    restRequest.AddParameter("Title", record.Title);
                    restRequest.AddFile("Favicon", record.Favicon);
                    restRequest.AddFile("Logo", record.Logo);
                    restRequest.AddFile("LoginLogo", record.LoginLogo);
                    restRequest.AddParameter("PrimaryColor", record.PrimaryColor);
                    //
                    var response_franchises = restClient.Execute(restRequest);
                    var GetUserActivityLogs_Scriptcall = new TestScripts_saveBrandings();
                    if (response_franchises.StatusCode == HttpStatusCode.OK)
                    {
                        var saveBrandings_request = JsonConvert.DeserializeObject<saveBrandings_Response>(response_franchises.Content);
                        ApiResponse_saveBrandings.Set_saveBrandings(saveBrandings_request);
                        if (saveBrandings_request.isSuccessful == true)
                        {
                            Console.WriteLine("API Response: \n\n" + response_franchises.Content);
                            GetUserActivityLogs_Scriptcall.ValidResponse();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_franchises.Content);
                            GetUserActivityLogs_Scriptcall.InValidReponse();
                        }
                        finalResult = saveBrandings_request;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                }
            }
            return finalResult;
        }

        // 7- StripeConnectUrl Endpoint Check
        public bool StripeConnectUrl()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/Company/StripeConnectUrl -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/Company/StripeConnectUrl", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_StripeConnectUrl = restClient.Get(restRequest);
                var StripeConnectUrl_Scriptcall = new TestScripts_StripeConnectUrl();
                if (response_StripeConnectUrl.StatusCode == HttpStatusCode.OK)
                {
                    // Deserialize as a List if the response is an array
                    var StripeConnectUrl_request = JsonConvert.DeserializeObject<Root_StripeConnectUrl_Response>(response_StripeConnectUrl.Content);
                    ApiResponse_StripeConnectUrl.set_StripeConnectUrl(StripeConnectUrl_request);
                    if (StripeConnectUrl_request.isSuccessful == true && StripeConnectUrl_request.statusCode == 200)
                    {
                        Console.WriteLine("API Response: " + response_StripeConnectUrl.Content);
                        StripeConnectUrl_Scriptcall.ValidResponse();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_StripeConnectUrl.Content);
                    StripeConnectUrl_Scriptcall.InValidReponse();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }

        // 8- ResendActivationEmail Endpoint Check
        public ResendActivationEmail_Response ResendActivationEmail()
        {
            Login();
            Console.WriteLine("----------------- /api/Company/ResendActivationEmail -----------------\n");
            var ResendActivationEmail_RF = new ResendActivationEmail_DataRead();
            var getfile_ResendActivationEmail = ResendActivationEmail_RF.Getfile_ResendActivationEmail();
            ResendActivationEmail_Response finalResult = null;

            // If no records in getfile_ResendActivationEmail, you may want to handle that case.
            if (getfile_ResendActivationEmail == null || !getfile_ResendActivationEmail.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_ResendActivationEmail)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    var bodyContent = new
                    {
                        companyGuid = record.companyGuid
                    };
                    Console.WriteLine($"companyGuid: {record.companyGuid}");
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/Company/ResendActivationEmail", Method.Post);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    restRequest.AddJsonBody(bodyContent);
                    var response_ResendActivationEmail = restClient.Execute(restRequest);
                    var ResendActivationEmail_Scriptcall = new TestScripts_ResendActivationEmail();
                    if (response_ResendActivationEmail.StatusCode == HttpStatusCode.OK)
                    {
                        var ResendActivationEmail_request = JsonConvert.DeserializeObject<ResendActivationEmail_Response>(response_ResendActivationEmail.Content);
                        ApiResponse_ResendActivationEmail_Response.set_ResendActivationEmail(ResendActivationEmail_request);
                        if (ResendActivationEmail_request.isSuccessful == true)
                        {
                            Console.WriteLine("API Response: \n\n" + response_ResendActivationEmail.Content);
                            ResendActivationEmail_Scriptcall.ValidInputValues();
                        }
                        finalResult = ResendActivationEmail_request;
                    }
                    else
                    {
                        var ResendActivationEmail_Errorrequest = JsonConvert.DeserializeObject<ErrorHandle_PartnerEnroll>(response_ResendActivationEmail.Content);
                        ErrorHandler_setStudentstatus.Set_setstudentsStatus(ResendActivationEmail_Errorrequest);
                        string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                        string Alphabetpattern = @"([a-zA-Z]+)";
                        string Null_testInput = @"^,$";
                        string testInputs = @"^\s*$";
                        var abc = Regex.IsMatch(record.companyGuid, Alphabetpattern);

                        if (Regex.IsMatch(record.companyGuid, pattern))
                        {
                            Console.WriteLine("API Response: " + response_ResendActivationEmail.Content);
                            ResendActivationEmail_Scriptcall.SpecialCharacter(record.companyGuid);
                        }
                        else if (Regex.IsMatch(record.companyGuid, testInputs))
                        {
                            Console.WriteLine("API Response: " + ResendActivationEmail_Errorrequest.Message);
                            ResendActivationEmail_Scriptcall.Null_Values(record.companyGuid);
                        }
                        else if (Regex.IsMatch(record.companyGuid, Alphabetpattern))
                        {
                            Console.WriteLine("API Response: " + ResendActivationEmail_Errorrequest.Message);
                            ResendActivationEmail_Scriptcall.ContainsAlphabetValue(record.companyGuid);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + ResendActivationEmail_Errorrequest.Message);
                            ResendActivationEmail_Scriptcall.Numeric_InputValue(record.companyGuid);
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

        // 9- VerifyActivationEmail Endpoint Check
        public Root_VerifyActivationEmail VerifyActivationEmail()
        {
            Login();
            Console.WriteLine("----------------- /api/Company/VerifyActivationEmail -----------------\n");
            var VerifyActivationEmail_RF = new VerifyActivationEmail_DataRead();
            var getfile_VerifyActivationEmail = VerifyActivationEmail_RF.Getfile_VerifyActivationEmail();
            Root_VerifyActivationEmail finalResult = null;

            // If no records in getfile_ResendActivationEmail, you may want to handle that case.
            if (getfile_VerifyActivationEmail == null || !getfile_VerifyActivationEmail.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_VerifyActivationEmail)
            {
                try
                {   
                    Console.WriteLine("\nInput Value : ");
                    var bodyContent = new
                    {
                        companyGuid = record.companyGuid,
                        activationCode = record.activationCode
                    };
                    Console.WriteLine($"companyGuid: {record.companyGuid},activationCode: {record.activationCode}");
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/Company/VerifyActivationEmail", Method.Post);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    restRequest.AddJsonBody(bodyContent);
                    var response_VerifyActivationEmail = restClient.Execute(restRequest);
                    var ResendActivationEmail_Scriptcall = new TestScripts_VerifyActivationEmail();
                    if (response_VerifyActivationEmail.StatusCode == HttpStatusCode.OK)
                    {
                        var VerifyActivationEmail_request = JsonConvert.DeserializeObject<Root_VerifyActivationEmail>(response_VerifyActivationEmail.Content);
                        ApiResponse_VerifyActivationEmail.set_VerifyActivationEmail(VerifyActivationEmail_request);
                        if (VerifyActivationEmail_request.isSuccessful == true && VerifyActivationEmail_request.response.message!= "No Organization found")
                        {
                            Console.WriteLine("API Response: \n\n" + response_VerifyActivationEmail.Content);
                            ResendActivationEmail_Scriptcall.ValidInputValues();
                        }
                        finalResult = VerifyActivationEmail_request;
                    }
                    else
                    {
                        var VerifyActivationEmail_Errorrequest = JsonConvert.DeserializeObject<ErrorHandle_PartnerEnroll>(response_VerifyActivationEmail.Content);
                        ErrorHandler_setStudentstatus.Set_setstudentsStatus(VerifyActivationEmail_Errorrequest);
                        string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                        string Alphabetpattern = @"([a-zA-Z]+)";
                        string Null_testInput = @"^,$";
                        string testInputs = @"^\s*$";
                        var abc = Regex.IsMatch(record.companyGuid, Alphabetpattern);

                        if (Regex.IsMatch(record.companyGuid, pattern))
                        {
                            Console.WriteLine("API Response: " + response_VerifyActivationEmail.Content);
                            ResendActivationEmail_Scriptcall.SpecialCharacter(record.companyGuid);
                        }
                        else if (Regex.IsMatch(record.companyGuid, testInputs))
                        {
                            Console.WriteLine("API Response: " + VerifyActivationEmail_Errorrequest.Message);
                            ResendActivationEmail_Scriptcall.Null_Values(record.companyGuid);
                        }
                        else if (Regex.IsMatch(record.companyGuid, Alphabetpattern))
                        {
                            Console.WriteLine("API Response: " + VerifyActivationEmail_Errorrequest.Message);
                            ResendActivationEmail_Scriptcall.ContainsAlphabetValue(record.companyGuid);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + VerifyActivationEmail_Errorrequest.Message);
                            ResendActivationEmail_Scriptcall.Numeric_InputValue(record.companyGuid);
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

        // 10- GetMenus Endpoint Check
        public CompanyMenu_Response GetMenus()
        {
            Login();
            Console.WriteLine("----------------- /api/CompanyMenu/GetMenus -----------------\n");
            var GetMenus_RF = new GetMenus_DataRead();
            var getfile_GetMenus = GetMenus_RF.Getfile_GetMenus();
            CompanyMenu_Response finalResult = null;

            // If no records in Getfile_GetMenus, you may want to handle that case.
            if (getfile_GetMenus == null || !getfile_GetMenus.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_GetMenus)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    Console.WriteLine($"userRoleId: {record.userRoleId} , userGuid: {record.userGuid}");
                    string queryString_GetMenu = $"userRoleId={record.userRoleId}&userGuid={record.userGuid}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/CompanyMenu/GetMenus?{queryString_GetMenu}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_GetMenus = restClient.Execute(restRequest);
                    var GetMenus_Scriptcall = new TestScripts_CompanyMenu();
                    if (response_GetMenus.StatusCode == HttpStatusCode.OK)
                    {
                        var EventDrop_request = JsonConvert.DeserializeObject<CompanyMenu_Response>(response_GetMenus.Content);
                        ApiResponse_CompanyMenu.set_CompanyMenu(EventDrop_request);
                        if (EventDrop_request.isSuccessful == true)
                        {
                            Console.WriteLine("API Response: \n\n" + response_GetMenus.Content);
                            GetMenus_Scriptcall.ValidResponse();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_GetMenus.Content);
                            GetMenus_Scriptcall.InValidReponse();
                        }
                        finalResult = EventDrop_request;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                }
            }
            return finalResult;
        }

        //                                               -------------------EventType-----------------
        // 1- EventType/list
        public bool EventType_list()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/EventType/list -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/EventType/list", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_EventType_list = restClient.Get(restRequest);
                var EventType_list_Scriptcall = new TestScripts_GetMenus();
                if (response_EventType_list.StatusCode == HttpStatusCode.OK)
                {
                    // Deserialize as a List if the response is an array
                    var EventType_list_request = JsonConvert.DeserializeObject<Root_EventType_list_Response>(response_EventType_list.Content);
                    ApiResponse_EventType_list.set_EventType_list(EventType_list_request);
                    if (EventType_list_request.isSuccessful == true && EventType_list_request.statusCode == 200)
                    {
                        Console.WriteLine("API Response: " + response_EventType_list.Content);
                        EventType_list_Scriptcall.ValidResponse();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_EventType_list.Content);
                    EventType_list_Scriptcall.InValidReponse();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }

        //                                              ----------------FileUpload------------------
        // 1- FileUpload Endpoint Check
        public FileUpload_Response FileUpload()
        {
            Login();
            Console.WriteLine("----------------- /api/FileUpload -----------------\n");
            var FileUpload_RF = new FileUpload_DataRead();
            var getfile_FileUpload = FileUpload_RF.Getfile_FileUpload();
            FileUpload_Response finalResult = null;

            // If no records in Getfile_FileUpload, you may want to handle that case.
            if (getfile_FileUpload == null || !getfile_FileUpload.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_FileUpload)
            {
                try
                {
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/FileUpload", Method.Post);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    //
                    restRequest.AddFile("File", record.File);
                    restRequest.AddParameter("CompanyGuid", record.CompanyGuid);
                    //
                    var response_FileUpload = restClient.Execute(restRequest);
                    var FileUpload_Scriptcall = new TestScripts_FileUpload();
                    if (response_FileUpload.StatusCode == HttpStatusCode.OK)
                    {
                        var FileUpload_request = JsonConvert.DeserializeObject<FileUpload_Response>(response_FileUpload.Content);
                        ApiResponse_Fileupload.set_FileUpload(FileUpload_request);
                        if (FileUpload_request.isSuccessful == true)
                        {
                            Console.WriteLine("API Response: \n\n" + response_FileUpload.Content);
                            FileUpload_Scriptcall.ValidResponse();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_FileUpload.Content);
                            FileUpload_Scriptcall.InValidReponse();
                        }
                        finalResult = FileUpload_request;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                }
            }
            return finalResult;
        }

        //                                              ---------------- Profile ----------------
        // 1- GetProfileBasicInfo Endpoint Check
        public bool GetProfileBasicInfo()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/Profile/GetProfileBasicInfo -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/Profile/GetProfileBasicInfo", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_GetProfileBasicInfo = restClient.Get(restRequest);
                var GetProfileBasicInfo_Scriptcall = new TestScripts_GetMenus();
                if (response_GetProfileBasicInfo.StatusCode == HttpStatusCode.OK)
                {
                    // Deserialize as a List if the response is an array
                    var EventType_list_request = JsonConvert.DeserializeObject<Root_GetProfileBasicInfo>(response_GetProfileBasicInfo.Content);
                    ApiResponse_GetProfileBasicInfo.set_GetProfileBasicInfo(EventType_list_request);
                    if (EventType_list_request.isSuccessful == true && EventType_list_request.statusCode == 200)
                    {
                        Console.WriteLine("API Response: " + response_GetProfileBasicInfo.Content);
                        GetProfileBasicInfo_Scriptcall.ValidResponse();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_GetProfileBasicInfo.Content);
                    GetProfileBasicInfo_Scriptcall.InValidReponse();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }

        // 2- GetEmailPreferences Endpoint Check
        public bool GetEmailPreferences()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/Profile/GetEmailPreferences -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/Profile/GetEmailPreferences", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_GetEmailPreferences = restClient.Get(restRequest);
                var GetEmailPreferences_Scriptcall = new TestScripts_GetEmailPreferences();
                if (response_GetEmailPreferences.StatusCode == HttpStatusCode.OK)
                {
                    // Deserialize as a List if the response is an array
                    var EventType_list_request = JsonConvert.DeserializeObject<GetEmailPreferences_Response>(response_GetEmailPreferences.Content);
                    ApiResponse_GetEmailPreference.set_GetEmailPreferences(EventType_list_request);
                    if (EventType_list_request.isSuccessful == true && EventType_list_request.statusCode == 200)
                    {
                        Console.WriteLine("API Response: " + response_GetEmailPreferences.Content);
                        GetEmailPreferences_Scriptcall.ValidResponse();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_GetEmailPreferences.Content);
                    GetEmailPreferences_Scriptcall.InValidReponse();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }

        //                                              ------------------ PortalUserRoles -------------------
        // 1- GetRolesGird Endpoint Check
        public bool GetRolesGird()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/PortalUserRoles/GetRolesGird -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/PortalUserRoles/GetRolesGird", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_GetRolesGird = restClient.Get(restRequest);
                var GetRolesGird_Scriptcall = new TestScripts_GetRolesGird();
                if (response_GetRolesGird.StatusCode == HttpStatusCode.OK)
                {
                    // Deserialize as a List if the response is an array
                    var EventType_list_request = JsonConvert.DeserializeObject<Root_GetRolesGird>(response_GetRolesGird.Content);
                    ApiResponse_GetRolesGird.set_GetRolesGird(EventType_list_request);
                    if (EventType_list_request.isSuccessful == true && EventType_list_request.statusCode == 200)
                    {
                        Console.WriteLine("API Response: " + response_GetRolesGird.Content);
                        GetRolesGird_Scriptcall.ValidResponse();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_GetRolesGird.Content);
                    GetRolesGird_Scriptcall.InValidReponse();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }

        // 2- GetUserAccessGird Endpoint Check
        public bool GetUserAccessGird()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/PortalUserRoles/GetUserAccessGird -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/PortalUserRoles/GetUserAccessGird", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_GetRolesGird = restClient.Get(restRequest);
                var GetRolesGird_Scriptcall = new TestScripts_GetUserAccessGird();
                if (response_GetRolesGird.StatusCode == HttpStatusCode.OK)
                {
                    // Deserialize as a List if the response is an array
                    var EventType_list_request = JsonConvert.DeserializeObject<Root_GetUserAccessGird>(response_GetRolesGird.Content);
                    ApiResponse_GetUserAccessGird.set_GetUserAccessGird(EventType_list_request);
                    if (EventType_list_request.isSuccessful == true && EventType_list_request.statusCode == 200)
                    {
                        Console.WriteLine("API Response: " + response_GetRolesGird.Content);
                        GetRolesGird_Scriptcall.ValidResponse();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_GetRolesGird.Content);
                    GetRolesGird_Scriptcall.InValidReponse();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }

        // 3- AddUpdateRoles Endpoint Check
        public Root_AddUpdateRoles AddUpdateRoles()
        {
            Login();
            Console.WriteLine("----------------- /api/PortalUserRoles/AddUpdateRoles -----------------\n");
            var AddUpdateRoles_RF = new AddUpdateRoles_DataRead();
            var getfile_AddUpdateRoles = AddUpdateRoles_RF.Getfile_AddUpdateRoles();
            Root_AddUpdateRoles finalResult = null;

            // If no records in getfile_ResendActivationEmail, you may want to handle that case.
            if (getfile_AddUpdateRoles == null || !getfile_AddUpdateRoles.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_AddUpdateRoles)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    var bodyContent = new
                    {
                        id = record.id,
                        roleName = record.roleName,
                        roleActions = record.roleActions,
                        permissions = JsonConvert.DeserializeObject<List<int>>(record.permissions)
                    };
                    Console.WriteLine($"id: {record.id},roleName: {record.roleName},roleActions: {record.roleActions},permissions: {record.permissions}");
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/PortalUserRoles/AddUpdateRoles", Method.Post);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    restRequest.AddJsonBody(bodyContent);
                    var response_AddUpdateRoles = restClient.Execute(restRequest);
                    var AddUpdateRoles_Scriptcall = new AddUpdateRoles_TestScripts();
                    if (response_AddUpdateRoles.StatusCode == HttpStatusCode.OK)
                    {
                        var AddUpdateRoles_request = JsonConvert.DeserializeObject<Root_AddUpdateRoles>(response_AddUpdateRoles.Content);
                        ApiResponse_AddUpdateRoles.set_AddUpdateRoles(AddUpdateRoles_request);
                        if (AddUpdateRoles_request.isSuccessful == true && AddUpdateRoles_request.response.response == "Role saved successfully }")
                        {
                            Console.WriteLine("API Response: \n\n" + response_AddUpdateRoles.Content);
                            AddUpdateRoles_Scriptcall.ValidInputValues();
                        }
                        finalResult = AddUpdateRoles_request;
                    }
                    else
                    {
                        var AddUpdateRoles_Errorrequest = JsonConvert.DeserializeObject<ErrorHandle_PartnerEnroll>(response_AddUpdateRoles.Content);
                        ErrorHandler_setStudentstatus.Set_setstudentsStatus(AddUpdateRoles_Errorrequest);
                        string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                        string Alphabetpattern = @"([a-zA-Z]+)";
                        string Null_testInput = @"^,$";
                        string testInputs = @"^\s*$";
                        var abc = Regex.IsMatch(record.id, Alphabetpattern);

                        if (Regex.IsMatch(record.id, pattern))
                        {
                            Console.WriteLine("API Response: " + response_AddUpdateRoles.Content);
                            AddUpdateRoles_Scriptcall.SpecialCharacter(record.id);
                        }
                        else if (Regex.IsMatch(record.id, testInputs))
                        {
                            Console.WriteLine("API Response: " + AddUpdateRoles_Errorrequest.Message);
                            AddUpdateRoles_Scriptcall.Null_Values(record.id);
                        }
                        else if (Regex.IsMatch(record.id, Alphabetpattern))
                        {
                            Console.WriteLine("API Response: " + AddUpdateRoles_Errorrequest.Message);
                            AddUpdateRoles_Scriptcall.ContainsAlphabetValue(record.id);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + AddUpdateRoles_Errorrequest.Message);
                            AddUpdateRoles_Scriptcall.Numeric_InputValue(record.id);
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

        // 4- DeleteRole Endpoint Check
        public Root_DeleteRole DeleteRole()
        {
            Login();
            Console.WriteLine("----------------- /api/PortalUserRoles/DeleteRole -----------------\n");
            var DeleteRole_RF = new DeleteRole_DataRead();
            var getfile_DeleteRole = DeleteRole_RF.Getfile_DeleteRole();
            Root_DeleteRole finalResult = null;

            // If no records in getfile_ResendActivationEmail, you may want to handle that case.
            if (getfile_DeleteRole == null || !getfile_DeleteRole.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_DeleteRole)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    var bodyContent = new
                    {
                        id = record.id,
                        roleName = record.roleName,
                        roleActions = record.roleActions,
                        permissions = JsonConvert.DeserializeObject<List<int>>(record.permissions),
                        permissionsList = record.permissionsList
                    };
                    Console.WriteLine($"id: {record.id},roleName: {record.roleName},roleActions: {record.roleActions},permissions: {record.permissions},permissionsList: {record.permissionsList}");
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/PortalUserRoles/DeleteRole", Method.Post);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    restRequest.AddJsonBody(bodyContent);
                    var response_AddUpdateRoles = restClient.Execute(restRequest);
                    var AddUpdateRoles_Scriptcall = new TestScripts_DeleteRole();
                    if (response_AddUpdateRoles.StatusCode == HttpStatusCode.OK)
                    {
                        var AddUpdateRoles_request = JsonConvert.DeserializeObject<Root_DeleteRole>(response_AddUpdateRoles.Content);
                        ApiResponse_DeleteRole.set_DeleteRole(AddUpdateRoles_request);
                        if (AddUpdateRoles_request.isSuccessful == true && AddUpdateRoles_request.response.response == "Role deleted successfully")
                        {   
                            Console.WriteLine("API Response: \n\n" + response_AddUpdateRoles.Content);
                            AddUpdateRoles_Scriptcall.ValidInputValues();
                        }
                        finalResult = AddUpdateRoles_request;
                    }
                    else
                    {
                        var AddUpdateRoles_Errorrequest = JsonConvert.DeserializeObject<ErrorHandle_PartnerEnroll>(response_AddUpdateRoles.Content);
                        ErrorHandler_setStudentstatus.Set_setstudentsStatus(AddUpdateRoles_Errorrequest);
                        string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                        string Alphabetpattern = @"([a-zA-Z]+)";
                        string Null_testInput = @"^,$";
                        string testInputs = @"^\s*$";
                        var abc = Regex.IsMatch(record.id, Alphabetpattern);

                        if (Regex.IsMatch(record.id, pattern))
                        {
                            Console.WriteLine("API Response: " + response_AddUpdateRoles.Content);
                            AddUpdateRoles_Scriptcall.SpecialCharacter(record.id);
                        }
                        else if (Regex.IsMatch(record.id, testInputs))
                        {
                            Console.WriteLine("API Response: " + AddUpdateRoles_Errorrequest.Message);
                            AddUpdateRoles_Scriptcall.Null_Values(record.id);
                        }
                        else if (Regex.IsMatch(record.id, Alphabetpattern))
                        {
                            Console.WriteLine("API Response: " + AddUpdateRoles_Errorrequest.Message);
                            AddUpdateRoles_Scriptcall.ContainsAlphabetValue(record.id);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + AddUpdateRoles_Errorrequest.Message);
                            AddUpdateRoles_Scriptcall.Numeric_InputValue(record.id);
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

        // 5- AddUpdateRoleAccess Endpoint Check
        public Root_AddUpdateRoleAccess AddUpdateRoleAccess()
        {
            Login();
            Console.WriteLine("----------------- /api/PortalUserRoles/AddUpdateRoleAccess -----------------\n");
            var AddUpdateRoleAccess_RF = new AddUpdateRoleAccess_DataRead();
            var getfile_AddUpdateRoleAccess = AddUpdateRoleAccess_RF.Getfile_AddUpdateRoleAccess();
            Root_AddUpdateRoleAccess finalResult = null;

            // If no records in getfile_ResendActivationEmail, you may want to handle that case.
            if (getfile_AddUpdateRoleAccess == null || !getfile_AddUpdateRoleAccess.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_AddUpdateRoleAccess)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                   // var deserializedObject = JsonConvert.DeserializeObject<dynamic>();
                    var bodyContent = new
                    {
                        id = record.id,
                        role = record.role,
                        username = record.username,
                        franchisesDropdown = JsonConvert.DeserializeObject<List<AddUpdateRoleAccess_InputValues>>(record.franchisesDropdown)

                    };
                    Console.WriteLine($"id: {record.id},role: {record.role},username: {record.username},franchisesDropdown: {record.franchisesDropdown}");
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/PortalUserRoles/AddUpdateRoleAccess", Method.Post);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    restRequest.AddJsonBody(bodyContent);
                    var response_AddUpdateRoles = restClient.Execute(restRequest);
                    var AddUpdateRoles_Scriptcall = new TestScripts_AddUpdateRoleAccess();
                    if (response_AddUpdateRoles.StatusCode == HttpStatusCode.OK)
                    {
                        var AddUpdateRoles_request = JsonConvert.DeserializeObject<Root_AddUpdateRoleAccess>(response_AddUpdateRoles.Content);
                        ApiResponse_AddUpdateRoleAccess.set_AddUpdateRoleAccess(AddUpdateRoles_request);
                        if (AddUpdateRoles_request.isSuccessful == true && AddUpdateRoles_request.response.response == "User access saved successfully")
                        {
                            Console.WriteLine("API Response: \n\n" + response_AddUpdateRoles.Content);
                            AddUpdateRoles_Scriptcall.ValidInputValues();
                        }
                        finalResult = AddUpdateRoles_request;
                    }
                    else
                    {
                        var AddUpdateRoles_Errorrequest = JsonConvert.DeserializeObject<ErrorHandle_PartnerEnroll>(response_AddUpdateRoles.Content);
                        ErrorHandler_setStudentstatus.Set_setstudentsStatus(AddUpdateRoles_Errorrequest);
                        string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                        string Alphabetpattern = @"([a-zA-Z]+)";
                        string Null_testInput = @"^,$";
                        string testInputs = @"^\s*$";
                        var abc = Regex.IsMatch(record.id, Alphabetpattern);

                        if (Regex.IsMatch(record.id, pattern))
                        {
                            Console.WriteLine("API Response: " + response_AddUpdateRoles.Content);
                            AddUpdateRoles_Scriptcall.SpecialCharacter(record.id);
                        }
                        else if (Regex.IsMatch(record.id, testInputs))
                        {
                            Console.WriteLine("API Response: " + AddUpdateRoles_Errorrequest.Message);
                            AddUpdateRoles_Scriptcall.Null_Values(record.id);
                        }
                        else if (Regex.IsMatch(record.id, Alphabetpattern))
                        {
                            Console.WriteLine("API Response: " + AddUpdateRoles_Errorrequest.Message);
                            AddUpdateRoles_Scriptcall.ContainsAlphabetValue(record.id);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + AddUpdateRoles_Errorrequest.Message);
                            AddUpdateRoles_Scriptcall.Numeric_InputValue(record.id);
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

        // 6- DeleteRoleAccess Endpoint Check
        public Root_AddUpdateRoleAccess DeleteRoleAccess()
        {
            Login();
            Console.WriteLine("----------------- /api/PortalUserRoles/DeleteRoleAccess -----------------\n");
            var AddUpdateRoleAccess_RF = new AddUpdateRoleAccess_DataRead();
            var getfile_AddUpdateRoleAccess = AddUpdateRoleAccess_RF.Getfile_AddUpdateRoleAccess();
            Root_AddUpdateRoleAccess finalResult = null;

            // If no records in getfile_ResendActivationEmail, you may want to handle that case.
            if (getfile_AddUpdateRoleAccess == null || !getfile_AddUpdateRoleAccess.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_AddUpdateRoleAccess)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    var bodyContent = new
                    {
                        id = record.id,
                        role = record.role,
                        username = record.username,
                        franchisesDropdown = JsonConvert.DeserializeObject<List<AddUpdateRoleAccess_InputValues>>(record.franchisesDropdown)

                    };
                    Console.WriteLine($"id: {record.id},role: {record.role},username: {record.username},franchisesDropdown: {record.franchisesDropdown}");
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/PortalUserRoles/DeleteRoleAccess", Method.Post);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    restRequest.AddJsonBody(bodyContent);
                    var response_AddUpdateRoles = restClient.Execute(restRequest);
                    var AddUpdateRoles_Scriptcall = new TestScripts_DeleteRoleAccess();
                    if (response_AddUpdateRoles.StatusCode == HttpStatusCode.OK)
                    {
                        var AddUpdateRoles_request = JsonConvert.DeserializeObject<Root_AddUpdateRoleAccess>(response_AddUpdateRoles.Content);
                        ApiResponse_AddUpdateRoleAccess.set_AddUpdateRoleAccess(AddUpdateRoles_request);
                        if (AddUpdateRoles_request.isSuccessful == true && AddUpdateRoles_request.response.response == "Role access deleted successfully")
                        {
                            Console.WriteLine("API Response: \n\n" + response_AddUpdateRoles.Content);
                            AddUpdateRoles_Scriptcall.ValidInputValues();
                        }
                        finalResult = AddUpdateRoles_request;
                    }
                    else
                    {
                        var AddUpdateRoles_Errorrequest = JsonConvert.DeserializeObject<ErrorHandle_PartnerEnroll>(response_AddUpdateRoles.Content);
                        ErrorHandler_setStudentstatus.Set_setstudentsStatus(AddUpdateRoles_Errorrequest);
                        string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                        string Alphabetpattern = @"([a-zA-Z]+)";
                        string Null_testInput = @"^,$";
                        string testInputs = @"^\s*$";
                        var abc = Regex.IsMatch(record.id, Alphabetpattern);

                        if (Regex.IsMatch(record.id, pattern))
                        {
                            Console.WriteLine("API Response: " + response_AddUpdateRoles.Content);
                            AddUpdateRoles_Scriptcall.SpecialCharacter(record.id);
                        }
                        else if (Regex.IsMatch(record.id, testInputs))
                        {
                            Console.WriteLine("API Response: " + AddUpdateRoles_Errorrequest.Message);
                            AddUpdateRoles_Scriptcall.Null_Values(record.id);
                        }
                        else if (Regex.IsMatch(record.id, Alphabetpattern))
                        {
                            Console.WriteLine("API Response: " + AddUpdateRoles_Errorrequest.Message);
                            AddUpdateRoles_Scriptcall.ContainsAlphabetValue(record.id);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + AddUpdateRoles_Errorrequest.Message);
                            AddUpdateRoles_Scriptcall.Numeric_InputValue(record.id);
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

        //                                          ------------------- PublishGuid ----------------
        // 1- GetPublishedGuid Endpoint Check
        public bool GetPublishedGuid()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/PublishGuid/GetPublishedGuid -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/PublishGuid/GetPublishedGuid", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_GetRolesGird = restClient.Get(restRequest);
                var GetRolesGird_Scriptcall = new TestScripts_GetPublishedGuid();
                if (response_GetRolesGird.StatusCode == HttpStatusCode.OK)
                {
                    // Deserialize as a List if the response is an array
                    var EventType_list_request = JsonConvert.DeserializeObject<Root_GetPublishedGuid_Response>(response_GetRolesGird.Content);
                    ApiResponse_GetPublishedGuid.set_GetPublishedGuid(EventType_list_request);
                    if (EventType_list_request.isSuccessful == true && EventType_list_request.statusCode == 200)
                    {
                        Console.WriteLine("API Response: " + response_GetRolesGird.Content);
                        GetRolesGird_Scriptcall.ValidResponse();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_GetRolesGird.Content);
                    GetRolesGird_Scriptcall.InValidReponse();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }


        //                                          ----------------- Board ------------------
        // 1- student Endpoint Check
        public Root_Board_student_Response Board_Student()
        {
            Login();
            Console.WriteLine("----------------- /api/Board/student -----------------\n");
            var Board_student_RF = new Board_student_DataRead();
            var getfile_Board_student = Board_student_RF.Getfile_Board_student();
            Root_Board_student_Response finalResult = null;

            // If no records in Getfile_GetMenus, you may want to handle that case.
            if (getfile_Board_student == null || !getfile_Board_student.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_Board_student)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    Console.WriteLine($"FilterType: {record.FilterType} , OptionType: {record.OptionType}");
                    string student_Board_student = $"FilterType={record.FilterType}&OptionType={record.OptionType}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/Board/student?{student_Board_student}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_Board_student = restClient.Execute(restRequest);
                    var GetMenus_Scriptcall = new TestScripts_student();
                    if (response_Board_student.StatusCode == HttpStatusCode.OK)
                    {
                        var Board_student_request = JsonConvert.DeserializeObject<Root_Board_student_Response>(response_Board_student.Content);
                        ApiResponse_student.set_student(Board_student_request);
                        if (Board_student_request.isSuccessful == true && Board_student_request.response.Count > 0)
                        {
                            Console.WriteLine("API Response: \n\n" + response_Board_student.Content);
                            GetMenus_Scriptcall.ValidResponse();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_Board_student.Content);
                            GetMenus_Scriptcall.InValidReponse();
                        }
                        finalResult = Board_student_request;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                }
            }
            return finalResult;
        }

        // 2- staff Endpoint Check
        public Root_Board_student_Response Board_staff()
        {
            Login();
            Console.WriteLine("----------------- /api/Board/staff -----------------\n");
            var Board_student_RF = new Board_student_DataRead();
            var getfile_Board_student = Board_student_RF.Getfile_Board_student();
            Root_Board_student_Response finalResult = null;

            // If no records in Getfile_Board_student, you may want to handle that case.
            if (getfile_Board_student == null || !getfile_Board_student.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_Board_student)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    Console.WriteLine($"FilterType: {record.FilterType} , OptionType: {record.OptionType}");
                    string student_Board_student = $"FilterType={record.FilterType}&OptionType={record.OptionType}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/Board/staff?{student_Board_student}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_Board_student = restClient.Execute(restRequest);
                    var GetMenus_Scriptcall = new TestScripts_student();
                    if (response_Board_student.StatusCode == HttpStatusCode.OK)
                    {
                        var Board_student_request = JsonConvert.DeserializeObject<Root_Board_student_Response>(response_Board_student.Content);
                        ApiResponse_student.set_student(Board_student_request);
                        if (Board_student_request.isSuccessful == true && Board_student_request.response.Count > 0)
                        {
                            Console.WriteLine("API Response: \n\n" + response_Board_student.Content);
                            GetMenus_Scriptcall.ValidResponse();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_Board_student.Content);
                            GetMenus_Scriptcall.InValidReponse();
                        }
                        finalResult = Board_student_request;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                }
            }
            return finalResult;
        }

        // 3- class Endpoint Check
        public Root_Board_student_Response Board_Class()
        {
            Login();
            Console.WriteLine("----------------- /api/Board/class -----------------\n");
            var Board_student_RF = new Board_student_DataRead();
            var getfile_Board_student = Board_student_RF.Getfile_Board_student();
            Root_Board_student_Response finalResult = null;

            // If no records in Getfile_Board_student, you may want to handle that case.
            if (getfile_Board_student == null || !getfile_Board_student.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_Board_student)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    Console.WriteLine($"FilterType: {record.FilterType} , OptionType: {record.OptionType}");
                    string student_Board_student = $"FilterType={record.FilterType}&OptionType={record.OptionType}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/Board/class?{student_Board_student}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_Board_student = restClient.Execute(restRequest);
                    var GetMenus_Scriptcall = new TestScripts_student();
                    if (response_Board_student.StatusCode == HttpStatusCode.OK)
                    {
                        var Board_student_request = JsonConvert.DeserializeObject<Root_Board_student_Response>(response_Board_student.Content);
                        ApiResponse_student.set_student(Board_student_request);
                        if (Board_student_request.isSuccessful == true && Board_student_request.response.Count > 0)
                        {
                            Console.WriteLine("API Response: \n\n" + response_Board_student.Content);
                            GetMenus_Scriptcall.ValidResponse();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_Board_student.Content);
                            GetMenus_Scriptcall.InValidReponse();
                        }
                        finalResult = Board_student_request;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                }
            }
            return finalResult;
        }

        // 4- getFilterTypeValue Endpoint Check
        public Root_getFilterTypeValue getFilterTypeValue()
        {
            Login();
            Console.WriteLine("----------------- /api/Board/getFilterTypeValue -----------------\n");
            var getFilterTypeValue_RF = new getFilterTypeValue_DataRead();
            var getfile_getFilterTypeValue = getFilterTypeValue_RF.Getfile_getFilterTypeValue();
            Root_getFilterTypeValue finalResult = null;

            // If no records in Getfile_getFilterTypeValue, you may want to handle that case.
            if (getfile_getFilterTypeValue == null || !getfile_getFilterTypeValue.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_getFilterTypeValue)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    Console.WriteLine($"FilterType: {record.FilterType} , IsClassBoard: {record.IsClassBoard}");
                    string student_Board_student = $"FilterType={record.FilterType}&IsClassBoard={record.IsClassBoard}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/Board/getFilterTypeValue?{student_Board_student}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_Board_student = restClient.Execute(restRequest);
                    var GetMenus_Scriptcall = new TestScripts_getFilterTypeValue();
                    if (response_Board_student.StatusCode == HttpStatusCode.OK)
                    {
                        var Board_student_request = JsonConvert.DeserializeObject<Root_getFilterTypeValue>(response_Board_student.Content);
                        ApiResponse_getFilterTypeValue.set_getFilterTypeValue(Board_student_request);
                        if (Board_student_request.isSuccessful == true && Board_student_request.response.Count > 0)
                        {
                            Console.WriteLine("API Response: \n\n" + response_Board_student.Content);
                            GetMenus_Scriptcall.ValidResponse();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_Board_student.Content);
                            GetMenus_Scriptcall.InValidReponse();
                        }
                        finalResult = Board_student_request;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                }
            }
            return finalResult;
        }

        //                                         ----------------- Classes -----------------
        // 1- online-classes Endpoint Check
        public Root_onlineclasses_Response onlineclasses()
        {
            Login();
            Console.WriteLine("----------------- /api/classes/onlineclasses -----------------\n");
            var onlineclasses_RF = new onlineclasses_DataRead();
            var getfile_onlineclasses = onlineclasses_RF.Getfile_onlineclasses();
            Root_onlineclasses_Response finalResult = null;

            // If no records in Getfile_onlineclasses, you may want to handle that case.
            if (getfile_onlineclasses == null || !getfile_onlineclasses.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_onlineclasses)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    Console.WriteLine($"studentId: {record.studentId}");
                    string queryString_onlineclasses = $"studentId={record.studentId}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/Classes/online-classes?{queryString_onlineclasses}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_onlineclasses = restClient.Execute(restRequest);
                    var onlineclasses_Scriptcall = new TestScripts_onlineclasses();
                    if (response_onlineclasses.StatusCode == HttpStatusCode.OK)
                    {
                        var onlineclasses_request = JsonConvert.DeserializeObject<Root_onlineclasses_Response>(response_onlineclasses.Content);
                        ApiResponse_onlineclasses.set_onlineclasses(onlineclasses_request);
                        if (onlineclasses_request.isSuccessful == true && onlineclasses_request.response.Count > 0)
                        {
                            Console.WriteLine("API Response: \n\n" + response_onlineclasses.Content);
                            onlineclasses_Scriptcall.ValidResponse();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_onlineclasses.Content);
                            onlineclasses_Scriptcall.InValidReponse();
                        }
                        finalResult = onlineclasses_request;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                }
            }
            return finalResult;
        }

        // 2- join-class Endpoint Check
        public joinclass_Response joinclass()
        {
            Login();
            Console.WriteLine("----------------- /api/Classes/join-class -----------------\n");
            var joinclass_RF = new joinclass_DataRead();
            var getfile_joinclass = joinclass_RF.Getfile_joinclass();
            joinclass_Response finalResult = null;

            // If no records in Getfile_joinclass, you may want to handle that case.
            if (getfile_joinclass == null || !getfile_joinclass.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_joinclass)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    var bodyContent = new
                    {
                        classID = record.classID,
                        studentName = record.studentName
                    };
                    Console.WriteLine($"classID: {record.classID},studentName: {record.studentName}");
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/Classes/join-class", Method.Post);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    restRequest.AddJsonBody(bodyContent);
                    var response_joinclass = restClient.Execute(restRequest);
                    var joinclass_Scriptcall = new TestScripts_joinclass();
                    if (response_joinclass.StatusCode == HttpStatusCode.OK)
                    {
                        var AddUpdateRoles_request = JsonConvert.DeserializeObject<joinclass_Response>(response_joinclass.Content);
                        ApiResponse_joinclass.set_joinclass(AddUpdateRoles_request);
                        if (AddUpdateRoles_request.isSuccessful == true && AddUpdateRoles_request.statusCode == 200)
                        {
                            Console.WriteLine("API Response: \n\n" + response_joinclass.Content);
                            joinclass_Scriptcall.ValidResponse();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_joinclass.Content);
                            joinclass_Scriptcall.InValidReponse();
                        }
                        finalResult = AddUpdateRoles_request;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                }
            }
            return finalResult;
        }

        // 3- getCourseTypeClasses Endpoint Check
        public Root_getCourseTypeClasses_Response getCourseTypeClasses()
        {
            Login();
            Console.WriteLine("----------------- /api/Classes/getCourseTypeClasses -----------------\n");
            var joinclass_RF = new getCourseTypeClasses_DataRead();
            var getfile_joinclass = joinclass_RF.Getfile_getCourseTypeClasses();
            Root_getCourseTypeClasses_Response finalResult = null;

            // If no records in Getfile_getCourseTypeClasses, you may want to handle that case.
            if (getfile_joinclass == null || !getfile_joinclass.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_joinclass)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    var bodyContent = new
                    {
                        courseTypeIds = JsonConvert.DeserializeObject<List<int>>(record.courseTypeIds)
                    };
                    Console.WriteLine($"courseTypeIds: {record.courseTypeIds}");
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/Classes/getCourseTypeClasses", Method.Post);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    restRequest.AddJsonBody(bodyContent);
                    var response_getCourseTypeClasses = restClient.Execute(restRequest);
                    var getCourseTypeClasses_Scriptcall = new TestScripts_getCourseTypeClasses();
                    if (response_getCourseTypeClasses.StatusCode == HttpStatusCode.OK)
                    {
                        var AddUpdateRoles_request = JsonConvert.DeserializeObject<Root_getCourseTypeClasses_Response>(response_getCourseTypeClasses.Content);
                        ApiResponse_getCourseTypeClasses.set_getcourseTypeClasses(AddUpdateRoles_request);
                        if (AddUpdateRoles_request.isSuccessful == true && AddUpdateRoles_request.response.Count > 0)
                        {
                            Console.WriteLine("API Response: \n\n" + response_getCourseTypeClasses.Content);
                            getCourseTypeClasses_Scriptcall.ValidResponse();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_getCourseTypeClasses.Content);
                            getCourseTypeClasses_Scriptcall.InValidReponse();
                        }
                        finalResult = AddUpdateRoles_request;
                    }
                }
                catch (Exception ex)
                {
                    var getCourseTypeClasses_Scriptcall = new TestScripts_getCourseTypeClasses();
                    Console.WriteLine("\nTest Script Error Message : " + ex.Message);
                    getCourseTypeClasses_Scriptcall.InValidReponse();
                }
            }
            return finalResult;
        }

        //                                              ---------------- SISForm ----------------
        // 1- getStudentInformationList Endpoint Check
        public bool getStudentInformationList()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/SISForm/getStudentInformationList -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/SISForm/getStudentInformationList", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_GetRolesGird = restClient.Get(restRequest);
                var GetRolesGird_Scriptcall = new TestScripts_getStudentInformationList();
                if (response_GetRolesGird.StatusCode == HttpStatusCode.OK)
                {
                    // Deserialize as a List if the response is an array
                    var EventType_list_request = JsonConvert.DeserializeObject<Root_getStudentInformationList_Response>(response_GetRolesGird.Content);
                    ApiResponse_getStudentInformationList.set_getStudentInformationList(EventType_list_request);
                    if (EventType_list_request.isSuccessful == true && EventType_list_request.response.Count > 0)
                    {
                        Console.WriteLine("API Response: " + response_GetRolesGird.Content);
                        GetRolesGird_Scriptcall.ValidResponse();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_GetRolesGird.Content);
                    GetRolesGird_Scriptcall.InValidReponse();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }

        // 2- createStudentInformationForm Endpoint Check
        public createStudentInformationForm_Response createStudentInformationForm()
        {
            Login();
            Console.WriteLine("----------------- /api/SISForm/createStudentInformationForm -----------------\n");
            var createStudentInformationForm_RF = new createStudentInformationForm_DataRead();
            var getfile_createStudentInformationForm = createStudentInformationForm_RF.Getfile_createStudentInformationForm();
            createStudentInformationForm_Response finalResult = null;

            // If no records in Getfile_createStudentInformationForm, you may want to handle that case.
            if (getfile_createStudentInformationForm == null || !getfile_createStudentInformationForm.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_createStudentInformationForm)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    var bodyContent = new
                    {
                        id = record.id,
                        formName = record.formName,
                        isActive = record.isActive,
                        active = record.active,
                        description = record.description
                    };
                    Console.WriteLine($"id: {record.id},formName: {record.formName},isActive: {record.isActive},active: {record.active},description: {record.description}");
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/SISForm/createStudentInformationForm", Method.Post);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    restRequest.AddJsonBody(bodyContent);
                    var response_AddUpdateRoles = restClient.Execute(restRequest);
                    var AddUpdateRoles_Scriptcall = new TestScripts_createStudentInformationForm();
                    if (response_AddUpdateRoles.StatusCode == HttpStatusCode.OK)
                    {
                        var AddUpdateRoles_request = JsonConvert.DeserializeObject<createStudentInformationForm_Response>(response_AddUpdateRoles.Content);
                        ApiResponse_createStudentInformationForm_Response.set_createStudentInformationForm(AddUpdateRoles_request);
                        if (AddUpdateRoles_request.isSuccessful == true && AddUpdateRoles_request.statusCode == 200)
                        {
                            Console.WriteLine("API Response: \n\n" + response_AddUpdateRoles.Content);
                            AddUpdateRoles_Scriptcall.ValidInputValues();
                        }
                        finalResult = AddUpdateRoles_request;
                    }
                    else
                    {
                        var AddUpdateRoles_Errorrequest = JsonConvert.DeserializeObject<ErrorHandle_PartnerEnroll>(response_AddUpdateRoles.Content);
                        ErrorHandler_setStudentstatus.Set_setstudentsStatus(AddUpdateRoles_Errorrequest);
                        string pattern = @"[%\^\*\'\[\]\(\)\!\@\?\&\+\$\~\`]";
                        string Alphabetpattern = @"([a-zA-Z]+)";
                        string Null_testInput = @"^,$";
                        string testInputs = @"^\s*$";
                        var abc = Regex.IsMatch(record.id, Alphabetpattern);

                        if (Regex.IsMatch(record.id, pattern))
                        {
                            Console.WriteLine("API Response: " + response_AddUpdateRoles.Content);
                            AddUpdateRoles_Scriptcall.SpecialCharacter(record.id);
                        }
                        else if (Regex.IsMatch(record.id, testInputs))
                        {
                            Console.WriteLine("API Response: " + AddUpdateRoles_Errorrequest.Message);
                            AddUpdateRoles_Scriptcall.Null_Values(record.id);
                        }
                        else if (Regex.IsMatch(record.id, Alphabetpattern))
                        {
                            Console.WriteLine("API Response: " + AddUpdateRoles_Errorrequest.Message);
                            AddUpdateRoles_Scriptcall.ContainsAlphabetValue(record.id);
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + AddUpdateRoles_Errorrequest.Message);
                            AddUpdateRoles_Scriptcall.Numeric_InputValue(record.id);
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

        //                                            --------------- AddOnsManage ---------------
        // 1- getFeeList Endpoint Check
        public bool getFeeList()
        {
            try
            {
                Login();
                Console.WriteLine("----------------- /api/AddOnsManage/getFeeList -----------------\n");
                var restClient = new RestClient("https://angular-api.calibermatrix.com");
                var restRequest = new RestRequest($"/api/AddOnsManage/getFeeList", Method.Get);
                restRequest.AddHeader("Accept", "application/json");
                restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                restRequest.RequestFormat = DataFormat.Json;
                var response_getFeeList = restClient.Get(restRequest);
                var getFeeList_Scriptcall = new TestScripts_getFeeList();
                if (response_getFeeList.StatusCode == HttpStatusCode.OK)
                {
                    // Deserialize as a List if the response is an array
                    var EventType_list_request = JsonConvert.DeserializeObject<Root_getFeeList_Response>(response_getFeeList.Content);
                    Apiresponse_getFeeList.set_getFeeList(EventType_list_request);
                    if (EventType_list_request.isSuccessful == true && EventType_list_request.response.Count > 0)
                    {
                        Console.WriteLine("API Response: " + response_getFeeList.Content);
                        getFeeList_Scriptcall.ValidResponse();
                    }
                }
                else
                {
                    Console.WriteLine("API Response: " + response_getFeeList.Content);
                    getFeeList_Scriptcall.InValidReponse();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAPI Response : " + ex.Message);
            }
            return false;
        }

        // 2- getNewFee Endpoint Check
        public Root_getNewFee_Response getNewFee()
        {
            Login();
            Console.WriteLine("----------------- /api/AddOnsManage/getNewFee -----------------\n");
            var getNewFee_RF = new getNewFee_DataRead();
            var getfile_getNewFee = getNewFee_RF.Getfile_getNewFee();
            Root_getNewFee_Response finalResult = null;

            // If no records in Getfile_getNewFee, you may want to handle that case.
            if (getfile_getNewFee == null || !getfile_getNewFee.Any())
            {
                Console.WriteLine("No records found.");
                // Return null or handle as appropriate
                return finalResult;
            }
            foreach (var record in getfile_getNewFee)
            {
                try
                {
                    Console.WriteLine("\nInput Value : ");
                    Console.WriteLine($"studentFeeId: {record.studentFeeId}");
                    string queryString_onlineclasses = $"studentFeeId={record.studentFeeId}";
                    var restClient = new RestClient("https://angular-api.calibermatrix.com");
                    var restRequest = new RestRequest($"api/AddOnsManage/getNewFee?{queryString_onlineclasses}", Method.Get);
                    restRequest.AddHeader("Accept", "application/json");
                    restRequest.AddHeader("Authorization", $"Bearer {bearerToken}");
                    restRequest.RequestFormat = DataFormat.Json;
                    var response_getNewFee = restClient.Execute(restRequest);
                    var onlineclasses_getNewFee = new TestScripts_getNewFee();
                    if (response_getNewFee.StatusCode == HttpStatusCode.OK)
                    {
                        var onlineclasses_request = JsonConvert.DeserializeObject<Root_getNewFee_Response>(response_getNewFee.Content);
                        ApiResponse_getNewFee.set_getNewFee(onlineclasses_request);
                        if (onlineclasses_request.isSuccessful == true && onlineclasses_request.statusCode == 200)
                        {
                            Console.WriteLine("API Response: \n\n" + response_getNewFee.Content);
                            onlineclasses_getNewFee.ValidResponse();
                        }
                        else
                        {
                            Console.WriteLine("API Response: " + response_getNewFee.Content);
                            onlineclasses_getNewFee.InValidReponse();
                        }
                        finalResult = onlineclasses_request;
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