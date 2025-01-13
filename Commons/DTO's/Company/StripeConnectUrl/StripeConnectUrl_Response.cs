using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Company.StripeConnectUrl
{
    public class StripeConnectUrl_Response
    {
        public string connectUrl { get; set; }
        public bool isConnected { get; set; }
    }
    public class Root_StripeConnectUrl_Response
    {
        public StripeConnectUrl_Response response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_StripeConnectUrl
    {
        public static Root_StripeConnectUrl_Response sets_StripeConnectUrl {  get; set; }
        public static void set_StripeConnectUrl (Root_StripeConnectUrl_Response value)
        {
            sets_StripeConnectUrl = value;
        }
    }
}