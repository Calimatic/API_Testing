using Commons.DTO_s.Company.StripeConnectUrl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Company.ResendActivationEmail
{
    public class ResendActivationEmail_Response
    {
        public bool response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_ResendActivationEmail_Response
    {
        public static ResendActivationEmail_Response sets_ResendActivationEmail {get; set;}
        public static void set_ResendActivationEmail(ResendActivationEmail_Response value)
        {
        sets_ResendActivationEmail = value;
        }
    }
}