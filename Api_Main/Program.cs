using ApiTesting_Calimatic;
using ApiTesting_Calimatic.AppLoginClass;
using ApiTesting_Calimatic.Forgot_PasswordAttempt;



//AppLogin
Api_AppLogin appLogin = new Api_AppLogin();
appLogin.MainAppLogin();

//Forgot Password
//Forgot_Password_Dataget FP = new Forgot_Password_Dataget();
//FP.ForgotGetData();

var login_data_read = new ApiStudents();
login_data_read.ForgotPassword();

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