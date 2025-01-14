using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Company.VerifyActivationEmail
{
    public class VerifyActivationEmail_Response
    {
        public bool isSuccessful { get; set; }
        public bool isLinkExpired { get; set; }
        public string message { get; set; }
        public string portalUrl { get; set; }
    }
    public class Root_VerifyActivationEmail
    {
        public VerifyActivationEmail_Response response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_VerifyActivationEmail
    {
        public static Root_VerifyActivationEmail sets_VerifyActivationEmail {  get; set; }
        public static void set_VerifyActivationEmail(Root_VerifyActivationEmail value)
        {
            sets_VerifyActivationEmail = value;
        }
    }
}