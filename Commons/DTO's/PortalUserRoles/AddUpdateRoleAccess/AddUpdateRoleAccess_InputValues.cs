using Commons.DTO_s.PortalUserRoles.GetUserAccessGird;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.PortalUserRoles.AddUpdateRoleAccess
{
    public class AddUpdateRoleAccess_InputValues
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public class Root_FranchisesDropdown_InputValues
    {
        public string id { get; set; }
        public string franchisesDropdown { get; set; }
        public int role { get; set; }
        public string username { get; set; }
    }
}