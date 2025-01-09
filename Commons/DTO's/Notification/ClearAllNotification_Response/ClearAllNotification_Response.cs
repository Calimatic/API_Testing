using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Notification.ClearAllNotification_Response
{
    public class ClearAllNotification_Response
    {
        public bool response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_ClearAllNotification
    {
        // Public property to store the Main_Response value
        public static ClearAllNotification_Response Sets_ClearAllNotification { get; set; }

        // Method to set the Main_Response value
        public static void Set_ClearAllNotification(ClearAllNotification_Response value)
        {
            Sets_ClearAllNotification = value;
        }
    }
    // GetNoticationCounts_Response
    public class GetNoticationCounts_Response
    {
        public int response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    public class ApiResponse_GetNoticationCounts
    {
        // Public property to store the Main_Response value
        public static GetNoticationCounts_Response Sets_GetNoticationCounts { get; set; }

        // Method to set the Main_Response value
        public static void Set_GetNoticationCounts(GetNoticationCounts_Response value)
        {
            Sets_GetNoticationCounts = value;
        }
    }
}