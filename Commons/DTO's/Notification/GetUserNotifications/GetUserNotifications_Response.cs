using Commons.DTO_s.Department.deleteDepartments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Notification.GetUserNotifications
{
    public class GetUserNotifications_Response
    {
        public int id { get; set; }
        public int to { get; set; }
        public int from { get; set; }
        public string message { get; set; }
        public string icon { get; set; }
        public string url { get; set; }
        public int companyId { get; set; }
        public object connectionID { get; set; }
        public object userName { get; set; }
        public string time { get; set; }
        public bool visited { get; set; }
        public int notificationType { get; set; }
        public object pageIdentifier { get; set; }
        public string iconColor { get; set; }
        public int itemId { get; set; }
    }
    public class Root_GetUserNotification
    {
        public List<GetUserNotifications_Response> response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_GetUserNotification
    {
        // Public property to store the Main_Response value
        public static Root_GetUserNotification Sets_GetUserNotification { get; set; }

        // Method to set the Main_Response value
        public static void Set_GetUserNotification(Root_GetUserNotification value)
        {
            Sets_GetUserNotification = value;
        }
    }
}
