using Commons.DTO_s.CourseReview.AddCourseReview;
using Commons.DTO_s.Department.saveDepartment;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.Department.saveDepartment_RF
{
    public class saveDepartment_DataRead
    {
        public List<saveDepartment_InputParams> Getfile_saveDepartment()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "saveDepartment.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<saveDepartment_InputParams>();
            }
        }
        private static List<saveDepartment_InputParams> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<saveDepartment_InputParams>(csv.GetRecords<saveDepartment_InputParams>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<saveDepartment_InputParams>();
            }
        }
    }
}
