using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.PaymentCommon.GetStudentCoursesViewDetails
{
    public class GetStudentCourseViewDetails_InputValues
    {
        public List<StudentEnrolledCourse> studentEnrolledCourses { get; set; }
        public string cmpGuid { get; set; }
        public int studentCount { get; set; }
    }
    public class StudentEnrolledCourse
    {
        public int courseId { get; set; }
        public int classId { get; set; }
        public string className { get; set; }
        public string courseName { get; set; }
        public int price { get; set; }
        public int proratedPrice { get; set; }
        public int proratedFee { get; set; }
        public int prorateAdjustment { get; set; }
        public string couponName { get; set; }
        public int classFee { get; set; }
    }
}
