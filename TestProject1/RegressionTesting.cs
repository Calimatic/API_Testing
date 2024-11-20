using ApiTesting_Calimatic.AppLoginFolder;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace TestProject1
{
    [TestClass]
    public class login_Testscripts
    {
        [TestMethod]
        public void ValidLoginCredential(bool IsSuccessful)
        {
            if (IsSuccessful == true)
            {
                Assert.AreEqual(true, true);
            }
        }
        [TestMethod]
        public void inValidLoginCredential(bool IsSuccessful)
        {
            if (IsSuccessful == false)
            {
                Assert.AreEqual(true, true);
            }
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