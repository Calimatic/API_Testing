using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.SISForm.getStudentInformationList
{
    public class getStudentInformationList_Response
    {
        public int id { get; set; }
        public string formName { get; set; }
        public string isActive { get; set; }
        public object active { get; set; }
        public object description { get; set; }
    }
    public class Root_getStudentInformationList_Response
    {
        public List<getStudentInformationList_Response> response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_getStudentInformationList
    {
        public static Root_getStudentInformationList_Response sets_getStudentInformationList {  get; set; }
        public static void set_getStudentInformationList(Root_getStudentInformationList_Response value)
        {
            sets_getStudentInformationList = value;
        }
    }
}