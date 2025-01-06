using Commons.DTO_s.Course_Category.getCourseCategoriesByTypeId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.CourseReview.GetReviewedCourse
{
    public class GetReviewedCourse_Response
    {
        public int totalNumberOfReviews { get; set; }
        public int numberOfFiveStar { get; set; }
        public int numberOfFourStar { get; set; }
        public int numberOfThreeStar { get; set; }
        public int numberOfTwoStar { get; set; }
        public int numberOfOneStar { get; set; }
        public object currentUserReviewed { get; set; }
        public string numberOfFiveStarPercentage { get; set; }
        public string numberOfFourStarPercentage { get; set; }
        public string numberOfThreeStarPercentage { get; set; }
        public string numberOfTwoStarPercentage { get; set; }
        public string numberOfOneStarPercentage { get; set; }
        public int finalRating { get; set; }
        public string finalRatingPercentage { get; set; }
    }
    public class Root_GetReviewCourse
    {
        public GetReviewedCourse_Response response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_GetReviewCourse
    {
        // Public property to store the Main_Response value
        public static Root_GetReviewCourse Sets_GetReviewCourse { get; set; }

        // Method to set the Main_Response value
        public static void Set_GetReviewCourse(Root_GetReviewCourse value)
        {
            Sets_GetReviewCourse = value;
        }
    }
}
