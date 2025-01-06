using Commons.DTO_s.Course_Category.getCourseCategoriesByTypeId;
using Commons.DTO_s.Dashboards.ClassEnrollmentCountByType;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.CourseCategory.getCourseCategoriesByTypeId_RF
{
    public class getCourseCategoriesByTypeId_DataReadFile
    {
        public List<getCourseCategoriesByTypeId_InputParams> Getfile_getCourseCategoriesByTypeId()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "getCourseCategoriesByTypeId.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<getCourseCategoriesByTypeId_InputParams>();
            }
        }
        private static List<getCourseCategoriesByTypeId_InputParams> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<getCourseCategoriesByTypeId_InputParams>(csv.GetRecords<getCourseCategoriesByTypeId_InputParams>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<getCourseCategoriesByTypeId_InputParams>();
            }
        }
    }
}
