using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.CompanyMenu
{
    public class CompanyMenu_Response
    {
        public bool isSuccessful { get; set; }
        public string response { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_CompanyMenu
    {
        public static CompanyMenu_Response sets_CompanyMenu { get; set; }
        public static void set_CompanyMenu(CompanyMenu_Response value)
        {
            sets_CompanyMenu = value;
        }
    }
}