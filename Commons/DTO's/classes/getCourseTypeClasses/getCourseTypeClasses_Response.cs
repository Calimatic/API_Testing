using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.classes.getCourseTypeClasses
{
    public class getCourseTypeClasses_Response
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public class Root_getCourseTypeClasses_Response
    {
        public List<getCourseTypeClasses_Response> response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_getCourseTypeClasses
    {
        public static Root_getCourseTypeClasses_Response sets_getcourseTypeClasses {  get; set; }
        public static void set_getcourseTypeClasses(Root_getCourseTypeClasses_Response value)
        {
            sets_getcourseTypeClasses = value;
        }
    }
}