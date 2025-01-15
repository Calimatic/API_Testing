using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Profile.GetEmailPreferences
{
    public class GetEmailPreferences_Response
    {
        public bool response {  get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_GetEmailPreference
    {
        public static GetEmailPreferences_Response sets_GetEmailPreferences {  get; set; }
        public static void set_GetEmailPreferences(GetEmailPreferences_Response value)
        {
            sets_GetEmailPreferences = value;
        }
    }
}