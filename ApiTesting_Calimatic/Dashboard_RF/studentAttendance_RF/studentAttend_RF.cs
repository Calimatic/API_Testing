using Commons.DTO_s.Dashboards.EventEnrollmentCountByType;
using Commons.DTO_s.Dashboards.studentAttendance_Response;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.Dashboard_RF.studentAttendance_RF
{
    public class studentAttend_RF
    {
        public List<Response_studentAttendance> Getfile_studentAttendance()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "studentAttendance.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<Response_studentAttendance>();
            }
        }
        private static List<Response_studentAttendance> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<Response_studentAttendance>(csv.GetRecords<Response_studentAttendance>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<Response_studentAttendance>();
            }
        }

    }
}
