﻿using ApiTesting_Calimatic;
using ApiTesting_Calimatic.AppLoginClass;
using ApiTesting_Calimatic.Dashboard_RF.PartnerEnrollment_RF;
using ApiTesting_Calimatic.Forgot_PasswordAttempt;
using TestProject1.Dashboard.Partner_Enrollment;


//                                                  -------------AUTH------------
/*
//AppLogin endpoint
Api_AppLogin appLogin = new Api_AppLogin();
appLogin.MainAppLogin();

//Forgot Password endpoint
var login_data_read = new ApiStudents();
login_data_read.ForgotPassword();

//ForgotPasswordOtpVerification endpoint
var Otp_endpoint = new ApiStudents();
Otp_endpoint.OtpForgotPassword();

//getCompanyUrl endpoint
var geturl = new ApiStudents();
geturl.GetCompanyUrl();

//getCompanyUrl endpoint
var resetPassword_1 = new ApiStudents();
resetPassword_1.ResetPassword();


//Forgot Password
Forgot_Password_Dataget FP = new Forgot_Password_Dataget();
FP.ForgotGetData();
*/

//                                                  ----------Dashboard----------
//Widgets Endpoint
var dashbboardWidgets_P = new ApiStudents();
dashbboardWidgets_P.Widgets();

//Partner Enrollment Endpoint
var partnerenrollment_P = new ApiStudents();
partnerenrollment_P.PartnerEnrollment();

//ClassEnrollmentCountByType Endpoint
var ClassEnrollmentCountBytype_P = new ApiStudents();
ClassEnrollmentCountBytype_P.ClassEnrollmentCountByType();

//var testing = new PartnerEnroll_RF();
//testing.testing();
//var ApiStudents = new ApiStudents();
//ApiStudents.TestLogin();

//var ApiStudents = new ApiStudents();
////
//ApiStudents.checkduplicateusername();
//Console.WriteLine("Successfully Executed checkduplicateusername");
//Console.ReadLine();
////
//ApiStudents.Login();
//Console.WriteLine("Successfully Executed Login");
//Console.ReadLine();
////
//ApiStudents.GetStudents();
//Console.WriteLine("Successfully Executed GetStudents");
//Console.ReadLine();