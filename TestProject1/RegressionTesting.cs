using ApiTesting_Calimatic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using ApiTesting_Calimatic.AppLoginClass;

namespace TestProject1
{
    [TestClass]
    public class login_Testscripts
    {
        [TestMethod]
        public void ValidLoginCredential()
        {
            var login = new Api_AppLogin();
            var student = new ApiStudents();
            var data = login.GetTestCaseData();
            // Check if the file exists
            foreach (var entry in data)
            {
                // Console.WriteLine(entry);
                Console.WriteLine($"userName: {entry.userName}, password: {entry.password}");
                var response = student.TestLogin(entry);
                Assert.AreEqual(true, response.IsSuccessful);
            }
        }
        [TestMethod]
        public void InvalidLoginCredential()
        {
           // var obj2 = new Api_AppLogin();
          //  obj2.MainAppLogin();
            Assert.AreEqual(false, true);
        }
    }
    //GET Method (/api/Student/students)
    //Test Script 1
    //[TestMethod]
    //public void VerifyStudent()
    //{
    //    var ApiTesting_Calimatic = new ApiStudents();
    //    var response = ApiTesting_Calimatic.GetStudents();
    //    Assert.AreEqual(200, response.statusCode);
    //    //Check If Student is Enrolled Or Not
    //    var verifystudent = response.response.Where(x => x.StudentName == "Troy Dickerson Dickerson").ToList();
    //}
    ////Test Script 2
    //[TestMethod]
    //public void ActiveEnrollment()
    //{
    //    var ApiTesting_Calimatic = new ApiStudents();
    //    var response = ApiTesting_Calimatic.GetStudents();
    //    Assert.AreEqual(200, response.statusCode);
    //    //Show All Enrolled/Approved Students 
    //    var approvedOrEnrolled = response.response.Where(x => x.EnrollmentStatus == "Approved/Enrolled").ToList();
    //}

    ////Post Method (/api/PaymentCommon/DuplicateUserName)
    ////Test Script 1
    //[TestMethod]
    //public void duplicateusername()
    //{
    //    var ApiTesting_Calimatic = new ApiStudents();
    //    var response = ApiTesting_Calimatic.checkduplicateusername();
    //    Assert.AreEqual(200, response.statusCode);
    //    //Check Against Admin username First name will be match in this Test Scripts
    //    Assert.AreEqual("Allistair", response.response.response.firstName);
    //}

}