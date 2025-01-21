using Commons.DTO_s.classes.joinclass;
using Commons.DTO_s.classes.onlineclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.classes.joinclass_TestScripts
{
    [TestClass]
    public class TestScripts_joinclass
    {
        [TestMethod]
        public void ValidResponse()
        {
            var joinclass_GetResponse = ApiResponse_joinclass.sets_joinclass;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, joinclass_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var joinclass_GetResponse = ApiResponse_joinclass.sets_joinclass;
            Console.WriteLine("No meeting found                     :   PASS");
            Assert.AreEqual(400, joinclass_GetResponse.statusCode, "Unexpected status code.");
        }
    }
}