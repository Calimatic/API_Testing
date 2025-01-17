using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.PortalUserRoles.AddUpdateRoleAccess
{
    public class AddUpdateRoleAccess_Response
    {
        public bool isSuccessful { get; set; }
        public string response { get; set; }
    }
    public class Root_AddUpdateRoleAccess
    {
        public AddUpdateRoleAccess_Response response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_AddUpdateRoleAccess
    {
        public static Root_AddUpdateRoleAccess sets_AddUpdateRoleAccess {  get; set; }
        public static void set_AddUpdateRoleAccess(Root_AddUpdateRoleAccess value)
        {
            sets_AddUpdateRoleAccess = value;
        }
    }
}