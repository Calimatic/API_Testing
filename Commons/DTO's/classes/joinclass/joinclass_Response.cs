using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.classes.joinclass
{
    public class joinclass_Response
    {
        public string response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_joinclass
    {
        public static joinclass_Response sets_joinclass { get; set; }
        public static void set_joinclass(joinclass_Response value)
        {
            sets_joinclass = value;
        }
    }
}