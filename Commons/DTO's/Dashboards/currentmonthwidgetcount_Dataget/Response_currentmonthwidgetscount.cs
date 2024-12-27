using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Dashboards.currentmonthwidgetcount_Dataget
{
    public class Response_currentmonthwidgetscount()
    {
    // First response type
        public int today { get; set; }
        public int current { get; set; }
        public int previous { get; set; }
    }

    // Second response type
    public class Root
    {
        public string response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }

    // Generalized API response wrapper
    public class ApiResponse_Response<T>
    {
        public T response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
}
