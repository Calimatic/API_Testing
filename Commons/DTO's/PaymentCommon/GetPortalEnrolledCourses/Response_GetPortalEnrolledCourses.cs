using Commons.DTO_s.Dashboards.Calender;
using Commons.DTO_s.PaymentCommon.GetAllEnrolledCourses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.PaymentCommon.GetPortalEnrolledCourses
{
    public class Response_GetPortalEnrolledCourses
    {
        public string response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    public class Root_GetPortalEnrolledCourses
    {
        public Response_GetPortalEnrolledCourses response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    public class ApiResponse_GetPortalEnrolledCourses
    {
        // Public property to store the Main_Response value
        public static Root_GetPortalEnrolledCourses Sets_GetPortalEnrolledCourses { get; set; }

        // Method to set the Main_Response value
        public static void Set_GetAllEnrolledCourses(Root_GetPortalEnrolledCourses value)
        {
            Sets_GetPortalEnrolledCourses = value;
        }
    }
}
