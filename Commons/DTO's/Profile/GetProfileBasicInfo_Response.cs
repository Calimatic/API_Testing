using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Profile
{
    public class GetProfileBasicInfo_Response
    {
        public int roleType { get; set; }
        public string company { get; set; }
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
    }
    public class Root_GetProfileBasicInfo
    {
        public GetProfileBasicInfo_Response response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }

    //
    public class ApiResponse_GetProfileBasicInfo
    {
         public static Root_GetProfileBasicInfo sets_GetProfileBasicInfo {  get; set; }
        public static void set_GetProfileBasicInfo(Root_GetProfileBasicInfo value)
        {
            sets_GetProfileBasicInfo = value;
        }
    }
}