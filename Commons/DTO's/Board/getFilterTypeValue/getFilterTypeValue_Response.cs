using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Board.getFilterTypeValue
{
    public class getFilterTypeValue_Response
    {
        public bool disabled { get; set; }
        public object group { get; set; }
        public bool selected { get; set; }
        public string text { get; set; }
        public string value { get; set; }
    }
    public class Root_getFilterTypeValue
    {
        public List<getFilterTypeValue_Response> response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_getFilterTypeValue
    {
        public static Root_getFilterTypeValue sets_getFilterTypeValue {  get; set; }
        public static void set_getFilterTypeValue(Root_getFilterTypeValue value)
        {
            sets_getFilterTypeValue = value;
        }
    }
}