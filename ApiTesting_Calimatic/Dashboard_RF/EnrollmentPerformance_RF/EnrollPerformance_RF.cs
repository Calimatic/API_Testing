using Commons.DTO_s.Dashboards.ClassEnrollmentCountByType;
using Commons.DTO_s.Dashboards.EnrollmentPerformance;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.Dashboard_RF.EnrollmentPerformance_RF
{
    public class EnrollPerformance_RF
    {
        public List<EnrollmentPerformance_Data> Getfile_EnrollmentPerformance()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "Enrollment Performance.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<EnrollmentPerformance_Data>();
            }
        }
        private static List<EnrollmentPerformance_Data> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<EnrollmentPerformance_Data>(csv.GetRecords<EnrollmentPerformance_Data>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<EnrollmentPerformance_Data>();
            }
        }
    }
}
