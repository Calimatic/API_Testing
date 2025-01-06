using Commons.DTO_s.Course_Category.getCourseCategoriesByTypeId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Courses.central
{
    public class central_Response
    {
        public List<Course> courses { get; set; }
        public List<column> columns { get; set; }
    }
    public class column
    {
        public int columnId { get; set; }
        public string columnName { get; set; }
        public int columnOrder { get; set; }
        public int columnWidth { get; set; }
        public int columnMinWidth { get; set; }
        public object colType { get; set; }
        public string columnType { get; set; }
        public bool isVisible { get; set; }
        public bool isMandatory { get; set; }
        public int minimumWidth { get; set; }
        public string gridName { get; set; }
        public string columnFilterId { get; set; }
        public string columnNameText { get; set; }
        public int defaultColumnId { get; set; }
        public object htmlId { get; set; }
        public object htmlWidth { get; set; }
        public object htmlHeight { get; set; }
        public object htmlTitle { get; set; }
        public object htmlIconClass { get; set; }
        public object htmlbkgColor { get; set; }
        public object chartData { get; set; }
        public bool isDynamic { get; set; }
        public object displayName { get; set; }
        public int moduleId { get; set; }
    }
    public class Course
    {
        public int id { get; set; }
        public int type { get; set; }
        public int? parentId { get; set; }
        public string title { get; set; }
        public string ages { get; set; }
        public int userStoryStepsCount { get; set; }
        public object points { get; set; }
        public List<string> courseType { get; set; }
        public List<string> courseCategory { get; set; }
        public List<object> tags { get; set; }
        public string state { get; set; }
        public string stage { get; set; }
    }
    public class Root_central
    {
        public central_Response response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_central
    {
        // Public property to store the Main_Response value
        public static Root_central Sets_central { get; set; }

        // Method to set the Main_Response value
        public static void Set_central(Root_central value)
        {
            Sets_central = value;
        }
    }
}
