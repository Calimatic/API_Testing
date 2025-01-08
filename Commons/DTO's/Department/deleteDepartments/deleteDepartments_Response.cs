using Commons.DTO_s.Department.saveDepartment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Department.deleteDepartments
{
    public class deleteDepartments_Response
    {
        public string response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    public class ApiResponse_deleteDepartments
    {
        // Public property to store the Main_Response value
        public static deleteDepartments_Response Sets_deleteDepartments { get; set; }

        // Method to set the Main_Response value
        public static void Set_deleteDepartments(deleteDepartments_Response value)
        {
            Sets_deleteDepartments = value;
        }
    }
}
