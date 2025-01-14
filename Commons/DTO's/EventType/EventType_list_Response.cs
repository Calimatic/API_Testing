using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.EventType
{
    public class EventType_list_Response
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public class Root_EventType_list_Response
    {
        public List<EventType_list_Response> response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_EventType_list
    {
        public static Root_EventType_list_Response sets_EventType_list {  get; set; }
        public static void set_EventType_list(Root_EventType_list_Response value) 
        {
            sets_EventType_list = value;
        }
    }
}