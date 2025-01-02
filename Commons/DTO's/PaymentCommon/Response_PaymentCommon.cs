using Commons.DTO_s.Dashboards.announcement_response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.PaymentCommon
{
    public class Response_PaymentCommon
    {
        public Response_PaymentCommon response { get; set; }
        public bool isSuccessful { get; set; }
        public int? statusCode { get; set; }
        public int? id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public bool isExist { get; set; }
    }

    public class Root_PaymentCommon
    {
        public Response_PaymentCommon response { get; set; }
        public bool isSuccessful { get; set; }
        public int? statusCode { get; set; }
    }
    //Deserialize Class
    public class ApiResponse_PaymentCommon
    {
        // Public property to store the Main_Response value
        public static Root_PaymentCommon Sets_PaymentCommont { get; set; }

        // Method to set the Main_Response value
        public static void Set_PaymentCommon(Root_PaymentCommon value)
        {
            Sets_PaymentCommont = value;
        }
    }
}
