using ApiTesting_Calimatic;
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

//                                     ---------------------- Company -------------------
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