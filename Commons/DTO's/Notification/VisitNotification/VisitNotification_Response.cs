using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Notification.VisitNotification
{
    public class VisitNotification_Response
    {
        public bool response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_VisitNotification
    {
        // Public property to store the Main_Response value
        public static VisitNotification_Response Sets_VisitNotification { get; set; }

        // Method to set the Main_Response value
        public static void Set_VisitNotification(VisitNotification_Response value)
        {
            Sets_VisitNotification = value;
        }
    }
}