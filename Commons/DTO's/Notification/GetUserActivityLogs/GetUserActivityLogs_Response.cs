using Commons.DTO_s.Notification.ClearAllNotification_Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Notification.GetUserActivityLogs
{
    public class GetUserActivityLogs_Response
    {
        public DateTime logDate { get; set; }
        public string activity { get; set; }
        public string performedBy { get; set; }
        public int performedByRole { get; set; }
        public string performedFor { get; set; }
        public int performedForRole { get; set; }
        public string familyName { get; set; }
        public int activityType { get; set; }
        public object type { get; set; }
        public int userKey { get; set; }
    }
    public class Root_GetUserActivityLogs
    {
        public List<GetUserActivityLogs_Response> response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_GetUserActivityLogs
    {
        // Public property to store the Main_Response value
        public static Root_GetUserActivityLogs Sets_GetUserActivityLogs { get; set; }
       
        // Method to set the Main_Response value
        public static void Set_GetUserActivityLogs(Root_GetUserActivityLogs value)
        {
            Sets_GetUserActivityLogs = value;
        }
    }
}