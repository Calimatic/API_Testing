using Commons.DTO_s.Company.franchises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Company.Permissions
{
    public class Permissions_Response
    {
        public int permission { get; set; }
        public bool canView { get; set; }
        public bool canAdd { get; set; }
        public bool canEdit { get; set; }
        public bool canDelete { get; set; }
    }
    public class Root_Permssion_Response
    {
        public List<Permissions_Response> response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_Permissions
    {
        // Public property to store the Main_Response value
        public static Root_Permssion_Response Sets_Permissions { get; set; }

        // Method to set the Main_Response value
        public static void Set_Permissions(Root_Permssion_Response value)
        {
            Sets_Permissions = value;
        }
    }
}