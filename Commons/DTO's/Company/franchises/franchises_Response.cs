using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Company.franchises
{
    public class franchises_Response
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public class Root_franchises
    {
        public List<franchises_Response> response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_franchises
    {
        // Public property to store the Main_Response value
        public static Root_franchises Sets_franchises { get; set; }

        // Method to set the Main_Response value
        public static void Set_franchises(Root_franchises value)
        {
            Sets_franchises = value;
        }
    }
}