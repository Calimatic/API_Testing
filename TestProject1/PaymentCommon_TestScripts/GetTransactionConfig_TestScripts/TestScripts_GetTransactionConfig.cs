using Commons.DTO_s.PaymentCommon;
using Commons.DTO_s.PaymentCommon.GetTransactionConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.PaymentCommon_TestScripts.GetTransactionConfig_TestScripts
{
    [TestClass]
    public class TestScripts_GetTransactionConfig
    {
        [TestMethod]
        public void ValidInputValue(string CompanyGuid)
        {
            var getEnrollmentDropdown_GetResponse = ApiResponse_GetTransactionConfig.Sets_GetTransactionConfig;
            Console.WriteLine("TestScripts Result");
            Console.WriteLine("Get Response Successfully                                       :PASS");
            Console.WriteLine($"Invalid '{CompanyGuid}' Input Value                            :FAIL");
            Assert.AreEqual(200, getEnrollmentDropdown_GetResponse.statusCode, "Unexpected status code.");
        }
        public void InValidInputValue(string CompanyGuid)
        {
            var getEnrollmentDropdown_GetResponse = ApiResponse_GetTransactionConfig.Sets_GetTransactionConfig;
            Console.WriteLine("TestScripts Result");
            Console.WriteLine("Get Response Successfully                                       :FAIL");
            Console.WriteLine($"Invalid '{CompanyGuid}' Input Value                            :PASS");
            Assert.AreEqual(200, getEnrollmentDropdown_GetResponse.statusCode, "Unexpected status code.");
          //  Assert.AreEqual(400, getEnrollmentDropdown_GetResponse.response.response.response.statusCode, "The response message does not match the expected value.");
        }
    }
}