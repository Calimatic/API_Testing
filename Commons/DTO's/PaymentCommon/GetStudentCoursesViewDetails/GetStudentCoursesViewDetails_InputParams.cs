using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.PaymentCommon.GetStudentCoursesViewDetails
{
    public class GetStudentCoursesViewDetails_InputParams
    {
        public int courseId { get; set; }
        public int classId { get; set; }
        public string className { get; set; }
        public string courseName { get; set; }
        public double price { get; set; }
        public int proratedPrice { get; set; }
        public int proratedFee { get; set; }
        public int prorateAdjustment { get; set; }
        public string couponName { get; set; }
        public double classFee { get; set; }
    }
    public class Response
    {
        public List<GetStudentCoursesViewDetails_InputParams> enrollmentDetails { get; set; }
    }
    public class Root_GetStudentCoursesViewDetails
    {
        public Response response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
}
