using ApiTesting_Calimatic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTtesting_Calimatic
{
   public partial class Students
    {
            public long Order { get; set; }
            public string Level { get; set; }
            public string Course { get; set; }
            public string FamilyName { get; set; }
            public string StudentEmail { get; set; }
            public string StudentAge { get; set; }
            public object StudentDob { get; set; }
            public object PrimaryPhone { get; set; }
            public long StudentId { get; set; }
            public string Status { get; set; }
            public Guid UserGuid { get; set; }
            public string Franchise { get; set; }
            public long FranchiseId { get; set; }
            public string StudentName { get; set; }
            public string Contatn1Name { get; set; }
            public string Contact1Phone { get; set; }
            public string Contact1Email { get; set; }
            public long BilledAmount { get; set; }
            public DateTimeOffset PaidDateTime { get; set; }
            public object TotalRecords { get; set; }
            public string ClassName { get; set; }
            public string CourseCategory { get; set; }
            public string CourseType { get; set; }
            public object ParentCompanyId { get; set; }
            public string EnrollmentStatus { get; set; }
            public object Grade { get; set; }
            public bool Selected { get; set; }
    }

    public class StudentResponse
    {
        public List<Students> response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }

}
