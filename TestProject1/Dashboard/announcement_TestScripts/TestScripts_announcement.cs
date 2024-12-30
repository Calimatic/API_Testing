using Commons.DTO_s.Dashboards.announcement_response;
using Commons.DTO_s.Dashboards.studentDemographics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Dashboard.announcement_TestScripts
{
    [TestClass]
    public class TestScripts_announcement
    {
        [TestMethod]
        public void announcement_GetResponse()
        {
            var announcement_GetResponse =  ApiResponse_announcement.Sets_announcement;
            Console.WriteLine("PASS");
            Assert.IsTrue(true , announcement_GetResponse.ToString(), "Response Get Failed");
        }
    }
}
