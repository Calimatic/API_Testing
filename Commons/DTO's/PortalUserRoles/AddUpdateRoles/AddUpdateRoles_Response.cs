using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.PortalUserRoles.AddUpdateRoles
{
    public class AddUpdateRoles_Response
    {
        public bool isSuccessful { get; set; }
        public string response { get; set; }
    }
    public class Root_AddUpdateRoles
    {
        public AddUpdateRoles_Response response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_AddUpdateRoles
    {
        public static Root_AddUpdateRoles sets_AddUpdateRoles { get; set; }
        public static void set_AddUpdateRoles(Root_AddUpdateRoles value)
        {
            sets_AddUpdateRoles = value;
        }
    }
}