using Commons.DTO_s.CourseReview.GetReviewedCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.CourseReview.AddCourseReview
{
    public class AddCourseReview_Response
    {
        public string response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_AddCourseReview
    {
        // Public property to store the Main_Response value
        public static AddCourseReview_Response Sets_AddCourseReview { get; set; }

        // Method to set the Main_Response value
        public static void Set_AddCourseReview(AddCourseReview_Response value)
        {
            Sets_AddCourseReview = value;
        }
    }
}
