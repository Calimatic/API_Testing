using Commons.DTO_s.Dashboards.announcement_response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Student
{
    public class getEnrollmentDropdown
    {
        public int value { get; set; }
        public string label { get; set; }
        public bool isChecked { get; set; }
    }
    public class Response_getEnrollmentDropdown
    {
         public List<getEnrollmentDropdown> response { get; set; }
         public bool isSuccessful { get; set; }
         public int statusCode { get; set; }
    }
    public class ApiResponse_getEnrollmentDropdown
    {
        // Public property to store the Main_Response value
        public static Response_getEnrollmentDropdown Sets_getEnrollmentDropdown { get; set; }

        // Method to set the Main_Response value
        public static void Set_getEnrollmentDropdown(Response_getEnrollmentDropdown value)
        {
            Sets_getEnrollmentDropdown = value;
        }
    }
}
