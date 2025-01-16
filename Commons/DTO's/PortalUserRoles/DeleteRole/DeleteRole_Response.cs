using Commons.DTO_s.PortalUserRoles.AddUpdateRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.PortalUserRoles.DeleteRole
{
    public class DeleteRole_Response
    {
        public bool isSuccessful { get; set; }
        public string response { get; set; }
    }
    public class Root_DeleteRole
    {
        public DeleteRole_Response response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_DeleteRole
    {
        public static Root_DeleteRole sets_DeleteRole { get; set; }
        public static void set_DeleteRole(Root_DeleteRole value)
        {
            sets_DeleteRole = value;
        }
    }
}