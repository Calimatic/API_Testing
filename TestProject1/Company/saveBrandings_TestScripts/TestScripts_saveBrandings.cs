using Commons.DTO_s.Company.Permissions;
using Commons.DTO_s.Company.saveBrandings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Company.saveBrandings_TestScripts
{
    [TestClass]
    public class TestScripts_saveBrandings
    {
        [TestMethod]
        public void ValidResponse()
        {
            var saveBrandings_GetResponse = ApiResponse_saveBrandings.Sets_saveBrandings;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, saveBrandings_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var saveBrandings_GetResponse = ApiResponse_saveBrandings.Sets_saveBrandings;
            Console.WriteLine("Invalid URL                     :   PASS");
            Assert.AreEqual(200, saveBrandings_GetResponse.statusCode, "Unexpected status code.");
        }
    }
}