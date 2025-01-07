using Commons.DTO_s.CourseReview.GetReviewedCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.CourseReview.AddCourseReview
{
    public class AddCourseReview_InputValues
    {
        public string id { get; set; }
        public string courseId { get; set; }
        public string rating { get; set; }
        public string review { get; set; }
        public bool isShow { get; set; }
        public string createdDate { get; set; }
    }
}
