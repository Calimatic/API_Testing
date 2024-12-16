using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Dashboards.getStudentPointsCounter_resposne
{
    public class EndpointResponse_getStudentPointsCunter
    {
        public bool IsSuccessful { get; set; }
        public Response_getStudentPointsCounter Response { get; set; }
    }
}
