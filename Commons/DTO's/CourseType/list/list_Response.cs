using Commons.DTO_s.CourseReview.GetReviewedCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.CourseType.list
{
    public class list_Response
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public class Root_course_list
    {
        public List<list_Response> response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    public class ApiResponse_course_list
    {
        // Public property to store the Main_Response value
        public static Root_course_list Sets_course_list { get; set; }

        // Method to set the Main_Response value
        public static void Set_course_list(Root_course_list value)
        {
            Sets_course_list = value;
        }
    }
}
