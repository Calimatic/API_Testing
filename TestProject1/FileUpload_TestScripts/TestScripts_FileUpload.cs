using Commons.DTO_s.EventType;
using Commons.DTO_s.FileUpload;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.FileUpload_TestScripts
{
    [TestClass]
    public class TestScripts_FileUpload
    {
        [TestMethod]
        public void ValidResponse()
        {
            var FileUpload_GetRespons = ApiResponse_Fileupload.sets_FileUpload;
            Console.WriteLine("Get File Uploaded Successfully            :   PASS");
            Assert.AreEqual(200, FileUpload_GetRespons.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InValidReponse()
        {
            var FileUpload_GetRespons = ApiResponse_Fileupload.sets_FileUpload;
            Console.WriteLine("Invalid Response                    :   PASS");
            Assert.AreEqual(200, FileUpload_GetRespons.statusCode, "Unexpected status code.");
        }
    }
}