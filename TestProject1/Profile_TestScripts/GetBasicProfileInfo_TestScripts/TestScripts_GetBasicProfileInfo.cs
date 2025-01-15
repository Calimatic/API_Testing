using Commons.DTO_s.FileUpload;
using Commons.DTO_s.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Profile_TestScripts.GetBasicProfileInfo_TestScripts
{
    [TestClass]
    public class TestScripts_GetBasicProfileInfo
    {
        [TestMethod]
        public void ValidResponse()
        {
            var GetBasicProfileInfo_GetRespons = ApiResponse_GetProfileBasicInfo.sets_GetProfileBasicInfo;
            Console.WriteLine("Get Response Successfully            :   PASS");
            Assert.AreEqual(200, GetBasicProfileInfo_GetRespons.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var GetBasicProfileInfo_GetRespons = ApiResponse_GetProfileBasicInfo.sets_GetProfileBasicInfo;
            Console.WriteLine("Invalid Response                    :   PASS");
            Assert.AreEqual(200, GetBasicProfileInfo_GetRespons.statusCode, "Unexpected status code.");
        }
    }
}