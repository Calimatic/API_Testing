using Commons.DTO_s.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Course_Category.getCourseCategoriesByTypeId
{
    public class getCourseCategoriesByTypeId_Response
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public class Root_getCourseCategoriesByTypeId_Response
    {
        public List<getCourseCategoriesByTypeId_Response> response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_getCourseCategoriesByTypeId
    {
        // Public property to store the Main_Response value
        public static Root_getCourseCategoriesByTypeId_Response Sets_getCourseCategoriesByTypeId { get; set; }

        // Method to set the Main_Response value
        public static void Set_getCourseCategoriesByTypeId(Root_getCourseCategoriesByTypeId_Response value)
        {
            Sets_getCourseCategoriesByTypeId = value;
        }
    }
}
