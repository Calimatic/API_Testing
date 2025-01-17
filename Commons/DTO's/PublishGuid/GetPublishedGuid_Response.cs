using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.PublishGuid
{
    public class GetPublishedGuid_Response
    {
        public int id { get; set; }
        public string publishedGuid { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updatedDate { get; set; }
    }
    public class Root_GetPublishedGuid_Response
    {
        public GetPublishedGuid_Response response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_GetPublishedGuid
    {
        public static Root_GetPublishedGuid_Response sets_GetPublishedGuid {  get; set; }
        public static void set_GetPublishedGuid(Root_GetPublishedGuid_Response value)
        {
            sets_GetPublishedGuid = value;
        }
    }
}