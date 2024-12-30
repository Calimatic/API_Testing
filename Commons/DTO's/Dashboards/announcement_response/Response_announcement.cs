using ApiTesting_Calimatic.AppLoginFolder;
using Commons.DTO_s.Dashboards.studentDemographics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Dashboards.announcement_response
{
    public class Response_announcement
    {
       public int id { get; set; }
       public string title { get; set; }
       public string description { get; set; }
       public bool expanded { get; set; }
    }
    public class Response1
    {
       public bool expandSection { get; set; }
       public List<Response_announcement> announcements { get; set; }
    }

    public class Main_Response
    {
       public Response1 response { get; set; }
       public bool isSuccessful { get; set; }
       public int statusCode { get; set; }
    }
    public class ApiResponse_announcement
    {
        // Public property to store the Main_Response value
        public static Main_Response Sets_announcement { get; set; }

        // Method to set the Main_Response value
        public static void Set_announcement(Main_Response value)
        {
        Sets_announcement = value;
        }
    }
}
