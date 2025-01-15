using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.FileUpload
{
    public class FileUpload_Response
    {
        public string Response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_Fileupload
    {
        public static FileUpload_Response sets_FileUpload { get; set; }
        public static void set_FileUpload(FileUpload_Response value)
        {
            sets_FileUpload = value;
        }
    }
}