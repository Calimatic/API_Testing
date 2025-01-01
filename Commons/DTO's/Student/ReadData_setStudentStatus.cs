using ApiTesting_Calimatic.AppLoginFolder;
using Commons.DTO_s.Dashboards.studentDemographics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Student
{
    public class ReadData_setStudentStatus
    {
        public string studentIds {  get; set; }
        public bool? activateStudent { get; set; }
    }
}
