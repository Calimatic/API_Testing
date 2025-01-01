using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Dashboards.Partner_Enrollment
{
    public class ErrorHandle_PartnerEnroll
    {
        public string Message { get; set; }
        public string Code { get; set; }
    }
    //Error handler
    public class ErrorHandler_setStudentstatus
    {
        // Public property to store the Main_Response value
        public static ErrorHandle_PartnerEnroll Error_setstudentsStatus { get; set; }

        // Method to set the Main_Response value
        public static void Set_setstudentsStatus(ErrorHandle_PartnerEnroll value)
        {
            Error_setstudentsStatus = value;
        }
    }
}
