using Commons.DTO_s.Company.CompanyConfigs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Company.CompanyNameByUserName
{
    public class CompanyNameByUserName_Response
    {
        public string response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_CompanyNameByUserName
    {
        // Public property to store the Main_Response value
        public static CompanyNameByUserName_Response Sets_CompanyNameByUserName { get; set; }

        // Method to set the Main_Response value
        public static void Set_CompanyNameByUserName(CompanyNameByUserName_Response value)
        {
            Sets_CompanyNameByUserName = value;
        }
    }
}
