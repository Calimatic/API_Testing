﻿using ApiTesting_Calimatic;
using ApiTesting_Calimatic.AppLoginClass;
using ApiTesting_Calimatic.Dashboard_RF.PartnerEnrollment_RF;
using ApiTesting_Calimatic.Dashboard_RF.restoreWidgetsToDefault_RF;
using ApiTesting_Calimatic.Forgot_PasswordAttempt;
using Commons.DTO_s.PaymentCommon;
using System.Reflection;
using TestProject1.Dashboard.Partner_Enrollment;
using static System.Net.Mime.MediaTypeNames;


/*                                                -------------AUTH------------

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


////Forgot Password
//Forgot_Password_Dataget FP = new Forgot_Password_Dataget();
//FP.ForgotGetData();
*/

/*                                                  ----------Dashboard----------
//Widgets Endpoint
var dashbboardWidgets_P = new ApiStudents();
dashbboardWidgets_P.Widgets();

//Partner Enrollment Endpoint
var partnerenrollment_P = new ApiStudents();
partnerenrollment_P.PartnerEnrollment();

//ClassEnrollmentCountByType Endpoint
var ClassEnrollmentCountBytype_P = new ApiStudents();
ClassEnrollmentCountBytype_P.ClassEnrollmentCountByType();

//Enrollment Performance Endpoint
var Enrollment_Performance_P = new ApiStudents();
Enrollment_Performance_P.EnrollmentPerformance();

//EventEnrollmentCountByType Endpoint
var eventenrollcountbyttype_P = new ApiStudents();
eventenrollcountbyttype_P.EventEnrollmentCountByType();

//studentAttendance Endpoint
var studentAttendance_P = new ApiStudents();
studentAttendance_P.studentAttendance();

// GetActiveCourseCountByType Endpoint
var GetActiveCourseCountByType_P = new ApiStudents();
GetActiveCourseCountByType_P.GetActiveCourseCountByType();

// listofleadscount Endpoints
var listofleadscount_P = new ApiStudents();
listofleadscount_P.listofleadscount();

// topfranchisesbyrevenue Endpoint
var topfranchisesbyrevenue_P = new ApiStudents();
topfranchisesbyrevenue_P.topfranchisesbyrevenue();

// getStudentPointsCounter Endpoint
var getStudentPointsCounter_P = new ApiStudents();
getStudentPointsCounter_P.getStudentPointsCounter();

// restoreWidgetsToDefault Endpoint
var restoreWidgetsToDefault_P = new ApiStudents();
restoreWidgetsToDefault_P.restoreWidgetsToDefault();

// leadsGeneration Endpoint
var leadsGeneration_P = new ApiStudents();
leadsGeneration_P.leadsGeneration();


//ClassDropOffCountByType Endpoint
var ClassDropOffCountByType_P = new ApiStudents();
ClassDropOffCountByType_P.ClassDropOffCountByType();

//EventDropOffCountByType Endpoint
var EventDropOffCountByType_P = new ApiStudents();
EventDropOffCountByType_P.EventDropOffCountByType();

// currentmonthwidgetscount Endpoint
var currentmonthwidgetscount_P = new ApiStudents();
currentmonthwidgetscount_P.currentmonthwidgetscount();

// response_triowidgetscount Endpoint
var triowidgetscount_P = new ApiStudents();
triowidgetscount_P.triowidgetscount();

// Calender Endpoint
var Calender_P =new ApiStudents().Calendar();


// studentDemographics Endpoint
var studentDemographics_P = new ApiStudents().studentDemographics();

// announcement Endpoint
var announcement_P = new ApiStudents().Announcement_Endpoint();
*/

/*                                                  -----------Students---------
                                                 
//1- getEnrollmentDropdown Ebdpoint
var getEnrollmentDropdown_P = new ApiStudents().getEnrollmentDropdown();

//2- students Endpoint
var Student_students_P = new ApiStudents().Student_students();

//3- setStudentStatus
var setStudentStatus_P = new ApiStudents().setStudentStatus();
*/

/*                                            ------------PaymentCommon----------
// 1- DuplicateUserName Endpoint
//var Duplicateusername_P =new ApiStudents().DuplicateUserName();

// 2- GetTransactionConfig
//var GetTransactionConfig_P = new ApiStudents().GetTransactionConfig();

// 3- GetAllEnrolledCourses Endpoint
//var GetAllEnrolledCourses_P = new ApiStudents().GetAllEnrolledCourses();

// 4- GetPortalEnrolledCourses Endpoint
var GetPortalEnrolledCourses_P = new ApiStudents().GetPortalEnrolledCourses();

// 5- 
var GetStudentCoursesViewDetails_P = new ApiStudents().GetStudentCoursesViewDetails();

*/

/*                                                ----------CourseCategory-----------
// getCourseCategoriesByTypeId Endpoint
var getCourseCategoriesByTypeId_P = new ApiStudents().getCourseCategoriesByTypeId();
*/

/*                      -----------------------Courses---------------------
// 1- central Endpoint
//var central_P = new ApiStudents().central();

// 2- getCoursesByTypeAndCategory Endpoint
var getCoursesByTypeAndCategory_P = new ApiStudents().getCoursesByTypeAndCategory();
*/

/*                                               ------------CourseReview-------------
// 1- GetReviewedCourse
var GetReviewCourse_P = new ApiStudents().GetReviewedCourse();

// 2- AddCourseReview
var AddCourseReview_P = new ApiStudents().AddCourseReview();

// 3- IsReviewAddedByUser Endpoint Check
var IsReviewAddedByUser_P = new ApiStudents().IsReviewAddedByUser();
*/

/*                                              -------------CourseType---------------
var course_list_P = new ApiStudents().list();
*/

/*                                             --------------Department--------------
// 1- getDepartment Endpoint
var getDepartment_P = new ApiStudents().getDepartments();

// 2- saveDepartment Endpoint
var saveDepartment_P = new ApiStudents().saveDepartments();

// 3- deleteDepartments Endpoint
var deleteDepartments_P = new ApiStudents().deleteDepartments();
*/

/*                                                -----------------------Notification----------------------
// 1- GetUserNotifications Endpoint
//var notification_P = new ApiStudents().GetUserNotifications();

// 2- ClearAllNotification Endpoint
//var ClearAllNotification_P = new ApiStudents().ClearAllNotification();

// 3- VisitNotification Endpoint
var VisitNotification_P = new ApiStudents().VisitNotification();

// 4- GetNoticationCounts Endpoint
var GetNoticationCounts_P = new ApiStudents().GetNotificationCounts();

// 5- GetUserActivityLogs Endpoint Check
var GetUserActivityLogs_P = new ApiStudents().GetUserActivityLogs();
*/

/*                                     ---------------------- Company -------------------
// 1- CompanyConfigs Endpoint
var CompanyConfigs_P = new ApiStudents().CompanyConfigs();

// 2- CompanyNameByUserName Endpoint
var CompanyNameByUserName_P = new ApiStudents().CompanyNameByUserName();

// 3- Menus Endpoint
var Menus_P = new ApiStudents().Menus();

// 4- franchises Endpoint
var franchises_P = new ApiStudents().franchises();

// 5- Permisions Endpoint
var Permisions_P = new ApiStudents().Permissions();

// 6- saveBrandings Endpoint
var saveBrandings_P = new ApiStudents().saveBrandings();

// 7- StripeConnectUrl Endpoint
var StripeConnectUrl_P = new ApiStudents().StripeConnectUrl();

// 8- ResendActivationEmail Endpoint
var ResendActivationEmail_P = new ApiStudents().ResendActivationEmail();

// 9- VerifyActivationEmail Endpoint
//var VerifyActivationEmail_P = new ApiStudents().VerifyActivationEmail();

// 10- GetMenus Endpoint
var GetMenus_P = new ApiStudents().GetMenus();
*/

/*                              ------------------EventType----------------
var EventType_list_P = new ApiStudents().EventType_list();
*/


/*                                                ------------------FileUpload-----------------
// 1- FileUpload Endpoint
var FileUpload_P = new ApiStudents().FileUpload();
*/

/*                                              -------------------- Profile -------------------
// 2- GetProfileBasicInfo Endpoint
var GetProfileBasicInfo_P = new ApiStudents().GetProfileBasicInfo();

// 3- GetEmailPreferences Endpoint
var GetEmailPreferences_P = new ApiStudents().GetEmailPreferences();
*/

/*                                               ------------------- PortalUserRoles ------------------
// 1- GetRolesGrid Endpoint
var GetRolesGrid_P = new ApiStudents().GetRolesGird();

// 2- GetUserAccessGird Endpoint
var GetUserAccessGird_P = new ApiStudents().GetUserAccessGird();

// 3- AddUpdateRoles Endpoint
var AddUpdateRoles_P = new ApiStudents().AddUpdateRoles();

// 4- DeleteRole Endpoint
var DeleteRole_P = new ApiStudents().DeleteRole();

// 5- AddUpdateRoleAccess
var AddUpdateRoleAccess_P = new ApiStudents().AddUpdateRoleAccess();

// 6- DeleteRoleAccess Endpoint
var DeleteRoleAccess_P = new ApiStudents().DeleteRoleAccess();
*/

/*                                              -----------------PublishGuid-------------------- 
// 1- GetPublishedGuid Endpoint
var GetPublishedGuid_P = new ApiStudents().GetPublishedGuid();
*/

/*                      ---------------- Board ----------------
// 1- student Endpoint
var Board_Student_P = new ApiStudents().Board_Student();

// 2- staff Endpoint
var Board_staff_P = new ApiStudents().Board_staff();

// 3- class Endpoint
var class_P = new ApiStudents().Board_Class();

// 4- getFilterTypeValue Endpoint Check
var getFilterTypeValue_P = new ApiStudents().getFilterTypeValue();
*/

/*                                  ------------------ Classes -------------------
// 1- online-classes Endpoint
//var onlineclasses_P = new ApiStudents().onlineclasses();

// 2- join-class Endpoint 
//var joinclass_P = new ApiStudents().joinclass();

// 3- 
var getCourseTypeClasses_P = new ApiStudents().getCourseTypeClasses();
*/

/*                                  --------------- SISForm ---------------
// 1- getStudentInformationList Endpoint
//var getStudentInformationList_P = new ApiStudents().getStudentInformationList();

// 2- createStudentInformationForm Endpoint
var createStudentInformationForm_P = new ApiStudents().createStudentInformationForm();
*/

//                          ------------------ AdsOnManage ------------------
// 1- getFeeList Endpoint
//var getFeeList_P = new ApiStudents().getFeeList();

// 2- getNewFee Endpoint
var getNewFee_P = new ApiStudents().getNewFee();




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
//Console.ReadLine();7