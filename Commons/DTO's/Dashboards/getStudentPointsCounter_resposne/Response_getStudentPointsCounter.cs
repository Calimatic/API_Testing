using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Dashboards.getStudentPointsCounter_resposne
{
    public class Response_getStudentPointsCounter
    {
        public int availablePoints { get; set; }
        public int studentTotalBonusPoints { get; set; }
        public int studentTotalRedeemedPoints { get; set; }
        public int studentAchievedChallengesPoints { get; set; }
        public List<object> studentCourseWisePointsList { get; set; }
    }
}