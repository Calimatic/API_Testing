using Commons.DTO_s.Course_Category.getCourseCategoriesByTypeId;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.Courses.getCoursesByTypeAndCategory_RF
{
    public class getCoursesByTypeAndCategory_DataRead
    {
        public List<getCoursesByTypeAndCategory_InputParams> Getfile_getCoursesByTypeAndCategory_DataRead()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "getCoursesByTypeAndCategory.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<getCoursesByTypeAndCategory_InputParams>();
            }
        }
        private static List<getCoursesByTypeAndCategory_InputParams> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<getCoursesByTypeAndCategory_InputParams>(csv.GetRecords<getCoursesByTypeAndCategory_InputParams>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<getCoursesByTypeAndCategory_InputParams>();
            }
        }
    }
}
