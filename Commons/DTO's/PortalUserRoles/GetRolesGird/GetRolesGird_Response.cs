using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.PortalUserRoles.GetRolesGird
{
    public class GetRolesGird_Response
    {
        public int id { get; set; }
        public string roleName { get; set; }
        public object userkey { get; set; }
        public string roleActions { get; set; }
        public List<int> permissions { get; set; }
        public string permissionsList { get; set; }
    }
    public class Root_GetRolesGird
    {
        public List<GetRolesGird_Response> response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_GetRolesGird
    {
        public static Root_GetRolesGird sets_GetRolesGird {  get; set; }
        public static void set_GetRolesGird (Root_GetRolesGird value)
        {
            sets_GetRolesGird = value;
        }
    }
}