using Commons.DTO_s.CourseReview.GetReviewedCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Department.getDepartments
{
    public class getDepartment_Response
    {
        public int deptId { get; set; }
        public string deptName { get; set; }
        public bool statusCode { get; set; }
    }
    public class Root_getDepartment_Response
    {
        public List<getDepartment_Response> response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    public class ApiResponse_Root_getDepartment
    {
        // Public property to store the Main_Response value
        public static Root_getDepartment_Response Sets_getDepartment { get; set; }

        // Method to set the Main_Response value
        public static void Set_getDepartment(Root_getDepartment_Response value)
        {
            Sets_getDepartment = value;
        }
    }
}
