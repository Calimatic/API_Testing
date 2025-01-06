using Commons.DTO_s.Course_Category.getCourseCategoriesByTypeId;
using Commons.DTO_s.CourseReview.GetReviewedCourse;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.CourseReview.GetReviewedCourse_RF
{
    public class GetReviewedCourse_DataRead
    {
        public List<GetReviewedCourse_InputParams> Getfile_GetReviewedCourse()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "GetReviewedCourse.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<GetReviewedCourse_InputParams>();
            }
        }
        private static List<GetReviewedCourse_InputParams> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<GetReviewedCourse_InputParams>(csv.GetRecords<GetReviewedCourse_InputParams>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<GetReviewedCourse_InputParams>();
            }
        }

    }
}
