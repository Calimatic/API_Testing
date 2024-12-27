using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Dashboards.Calender
{
    public class Class
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string days { get; set; }
    }

    public class Event
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
    }

    public class Response
    {
        public List<Class> classes { get; set; }
        public List<Event> events { get; set; }
    }

    public class General_Response
    {
        public Response response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
}