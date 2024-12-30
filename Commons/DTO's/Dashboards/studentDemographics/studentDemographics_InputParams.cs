using ApiTesting_Calimatic.AppLoginFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Dashboards.studentDemographics
{
    public class studentDemographics_InputParams
    {
        public string type { get; set; }
        public string state { get; set; }
        public string companyId { get; set; }
    }
    public class ApiResponseHandler
    {
        // Public property to store the EventDrop_request value
        public static ApiResponse<List<studentDemographics_Response>> EventDropRequest { get;  set; }

        // Method to set the EventDropRequest value
        public static void SetEventDropRequest(ApiResponse<List<studentDemographics_Response>> value)
        {
            EventDropRequest = value;
        }
    }
}
