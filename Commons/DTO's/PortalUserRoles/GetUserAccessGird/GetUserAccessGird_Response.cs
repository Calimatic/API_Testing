using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.PortalUserRoles.GetUserAccessGird
{
    public class GetUserAccessGird_Response
    {
        public int id { get; set; }
        public string username { get; set; }
        public object userkey { get; set; }
        public string roleName { get; set; }
        public string authKey { get; set; }
        public object franchisesName { get; set; }
        public object createdBy { get; set; }
        public int companyKey { get; set; }
        public List<FranchisesDropdown> franchisesDropdown { get; set; }
        public RolesDropdown rolesDropdown { get; set; }
        public int role { get; set; }
    }
    public class RolesDropdown
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public class FranchisesDropdown
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public class Root_GetUserAccessGird
    {
        public List<GetUserAccessGird_Response> response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_GetUserAccessGird
    {
        public static Root_GetUserAccessGird sets_GetUserAccessGird {  get; set; }
        public static void set_GetUserAccessGird(Root_GetUserAccessGird value) 
        {
            sets_GetUserAccessGird = value;
        }
    }
}