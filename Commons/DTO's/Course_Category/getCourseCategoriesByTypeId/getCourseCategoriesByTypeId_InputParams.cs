using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Course_Category.getCourseCategoriesByTypeId
{
    public class getCourseCategoriesByTypeId_InputParams
    {
        public int? typeId {  get; set; }
    }
    public class getCoursesByTypeAndCategory_InputParams
    {
        public int? typeId { get; set; }
        public int? categoryId { get; set; }

    }
}
