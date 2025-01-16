using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.PortalUserRoles.AddUpdateRoles
{
    public class AddUpdateRoles_InputValues
    {
        public string id { get; set; }
        public string roleName { get; set; }
        public string roleActions { get; set; }
        public string permissions { get; set; }
    }
}