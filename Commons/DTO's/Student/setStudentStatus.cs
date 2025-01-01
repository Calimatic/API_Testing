using Commons.DTO_s.Dashboards.Partner_Enrollment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Student
{
    public class setStudentStatus
    {
        public bool response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    public class ApiResponse_setStudentstatus
    {
        // Public property to store the Main_Response value
        public static setStudentStatus Sets_setstudentsStatus { get; set; }

        // Method to set the Main_Response value
        public static void Set_setstudentsStatus(setStudentStatus value)
        {
            Sets_setstudentsStatus = value;
        }
    }
}
