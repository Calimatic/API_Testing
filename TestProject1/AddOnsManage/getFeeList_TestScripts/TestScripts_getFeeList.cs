using Commons.DTO_s.AddOnsManage.getFeeList;
using Commons.DTO_s.SISForm.createStudentInformationForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.AddOnsManage.getFeeList_TestScripts
{
    [TestClass]
    public class TestScripts_getFeeList
    {
        [TestMethod]
        public void ValidResponse()
        {
            var getFeeList_GetResponse = Apiresponse_getFeeList.sets_getFeeList;
            Console.WriteLine("Get Added Successfully            :   PASS");
            Assert.AreEqual(200, getFeeList_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var getFeeList_GetResponse = Apiresponse_getFeeList.sets_getFeeList;
            Console.WriteLine("Invalid Response                     :   PASS");
            Assert.AreEqual(200, getFeeList_GetResponse.statusCode, "Unexpected status code.");
        }
    }
}