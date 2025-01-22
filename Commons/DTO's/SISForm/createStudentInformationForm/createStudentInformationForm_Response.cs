using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.SISForm.createStudentInformationForm
{
    public class createStudentInformationForm_Response
    {
        public string response {  get; set; }
        public bool isSuccessful {  get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_createStudentInformationForm_Response
    {
        public static createStudentInformationForm_Response sets_createStudentInformationForm {  get; set; }
        public static void set_createStudentInformationForm(createStudentInformationForm_Response value)
        {
            sets_createStudentInformationForm = value;
        }
    }
}