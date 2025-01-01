using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Student
{
    public class students
    {
       public int order { get; set; }
       public string level { get; set; }
       public string course { get; set; }
       public string familyName { get; set; }
       public string studentEmail { get; set; }
       public string studentAge { get; set; }
       public DateTime? studentDOB { get; set; }
       public string primaryPhone { get; set; }
       public int studentId { get; set; }
       public string status { get; set; }
       public string userGuid { get; set; }
       public string franchise { get; set; }
       public int franchiseID { get; set; }
       public string studentName { get; set; }
       public string contatn1Name { get; set; }
       public string contact1Phone { get; set; }
       public string contact1Email { get; set; }
       public int billedAmount { get; set; }
       public DateTime paidDateTime { get; set; }
       public object totalRecords { get; set; }
       public string className { get; set; }
       public string courseCategory { get; set; }
       public string courseType { get; set; }
       public object parentCompanyId { get; set; }
       public string enrollmentStatus { get; set; }
       public string grade { get; set; }
       public bool selected { get; set; }
    }
    public class GetResponse_students
    {
       public List<students> response { get; set; }
       public bool isSuccessful { get; set; }
       public int? statusCode { get; set; }
    }
    public class ApiResponse_students
    {
        // Public property to store the Main_Response value
        public static GetResponse_students Sets_students { get; set; }

        // Method to set the Main_Response value
        public static void Set_students(GetResponse_students value)
        {
            Sets_students = value;
        }
    }
}
