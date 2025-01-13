using Commons.DTO_s.Company.saveBrandings;
using Commons.DTO_s.Company.StripeConnectUrl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Company.StripeConnectUrl_TestScripts
{
    [TestClass]
    public class TestScripts_StripeConnectUrl
    {
        [TestMethod]
        public void ValidResponse()
        {
            var StripeConnectUrl_GetResponse = ApiResponse_StripeConnectUrl.sets_StripeConnectUrl;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, StripeConnectUrl_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var StripeConnectUrl_GetResponse = ApiResponse_StripeConnectUrl.sets_StripeConnectUrl;
            Console.WriteLine("Invalid URL                     :   PASS");
            Assert.AreEqual(200, StripeConnectUrl_GetResponse.statusCode, "Unexpected status code.");
        }
    }
}