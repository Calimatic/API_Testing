using Commons.DTO_s.AddOnsManage.getFeeList;
using Commons.DTO_s.AddOnsManage.getNewFee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.AddOnsManage.getNewFee_TestScripts
{
    [TestClass]
    public class TestScripts_getNewFee
    {
        [TestMethod]
        public void ValidResponse()
        {
            var getNewFee_GetResponse = ApiResponse_getNewFee.sets_getNewFee;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, getNewFee_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var getNewFee_GetResponse = ApiResponse_getNewFee.sets_getNewFee;
            Console.WriteLine("Invalid Response                     :   PASS");
            Assert.AreEqual(200, getNewFee_GetResponse.statusCode, "Unexpected status code.");
        }
    }
}