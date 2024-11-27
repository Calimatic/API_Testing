using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Widget
{
    public class WidgetResponse
    {
        public int id { get; set; }
        public string title { get; set; }
        public int code { get; set; }
        public string icon { get; set; }
        public string description { get; set; }
        public int category { get; set; }
        public object link { get; set; }
        public int role { get; set; }
        public bool isEnabled { get; set; }
        public double width { get; set; }
        public double height { get; set; }
        public double xaxis { get; set; }
        public double yaxis { get; set; }
    }
}
