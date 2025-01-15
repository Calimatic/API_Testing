using Commons.DTO_s.Profile;
using Commons.DTO_s.Profile.GetEmailPreferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Profile_TestScripts.GetEmailPreferences_TestScripts
{
    [TestClass]
    public class TestScripts_GetEmailPreferences
    {
        [TestMethod]
        public void ValidResponse()
        {
            var GetEmailPreferences_GetRespons = ApiResponse_GetEmailPreference.sets_GetEmailPreferences;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, GetEmailPreferences_GetRespons.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var GetEmailPreferences_GetRespons = ApiResponse_GetEmailPreference.sets_GetEmailPreferences;
            Console.WriteLine("Invalid Response                    :   PASS");
            Assert.AreEqual(200, GetEmailPreferences_GetRespons.statusCode, "Unexpected status code.");
        }
    }
}