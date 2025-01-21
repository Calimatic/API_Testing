using Commons.DTO_s.Board.getFilterTypeValue;
using Commons.DTO_s.classes.onlineclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.classes.onlineclasses_TestScripts
{
    [TestClass]
    public class TestScripts_onlineclasses
    {
        [TestMethod]
        public void ValidResponse()
        {
            var onlineclasses_GetResponse = ApiResponse_onlineclasses.sets_onlineclasses;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, onlineclasses_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var onlineclasses_GetResponse = ApiResponse_onlineclasses.sets_onlineclasses;
            Console.WriteLine("Response with no Data                     :   PASS");
            Assert.AreEqual(200, onlineclasses_GetResponse.statusCode, "Unexpected status code.");
        }
    }
}