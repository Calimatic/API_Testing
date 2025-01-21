using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.classes.onlineclasses
{
    public class onlineclasses_Response
    {
        public int classId { get; set; }
        public string className { get; set; }
        public int classType { get; set; }
        public string classUrl { get; set; }
    }
    public class Root_onlineclasses_Response
    {
        public List<onlineclasses_Response> response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_onlineclasses
    {
        public static Root_onlineclasses_Response sets_onlineclasses {  get; set; }
        public static void set_onlineclasses(Root_onlineclasses_Response value)
        {
            sets_onlineclasses = value;
        }
    }
}