using Commons.DTO_s.CourseReview.AddCourseReview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Department.saveDepartment
{
    public class saveDepartment_Response
    {
        public int deptId { get; set; }
        public string deptName { get; set; }
        public bool statusCode { get; set; }
    }
    public class Root_saveDepartment
    {
        public saveDepartment_Response response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    public class ApiResponse_saveDepartment
    {
        // Public property to store the Main_Response value
        public static Root_saveDepartment Sets_saveDepartment { get; set; }

        // Method to set the Main_Response value
        public static void Set_saveDepartment(Root_saveDepartment value)
        {
            Sets_saveDepartment = value;
        }
    }
}
