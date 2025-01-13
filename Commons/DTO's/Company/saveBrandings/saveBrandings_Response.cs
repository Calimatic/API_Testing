using Commons.DTO_s.Company.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Company.saveBrandings
{
    public class saveBrandings_Response
    {
        public bool response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_saveBrandings
    {
        // Public property to store the Main_Response value
        public static saveBrandings_Response Sets_saveBrandings { get; set; }

        // Method to set the Main_Response value
        public static void Set_saveBrandings(saveBrandings_Response value)
        {
            Sets_saveBrandings = value;
        }
    }
}