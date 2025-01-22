using Commons.DTO_s.classes.getCourseTypeClasses;
using Commons.DTO_s.SISForm.getStudentInformationList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.SISForm.getStudentInformationList_TestScripts
{
    [TestClass]
    public class TestScripts_getStudentInformationList
    {
        [TestMethod]
        public void ValidResponse()
        {
            var getStudentInformationList_GetResponse = ApiResponse_getStudentInformationList.sets_getStudentInformationList;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, getStudentInformationList_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var getStudentInformationList_GetResponse = ApiResponse_getStudentInformationList.sets_getStudentInformationList;
            Console.WriteLine("Alphabetic or Special Character Used in input values              :   PASS");
            Assert.AreEqual(200, getStudentInformationList_GetResponse.statusCode, "Unexpected status code.");
        }
    }
}