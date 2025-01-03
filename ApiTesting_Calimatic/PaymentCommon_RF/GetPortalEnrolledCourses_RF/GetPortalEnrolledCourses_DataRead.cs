using Commons.DTO_s.PaymentCommon.GetPortalEnrolledCourses;
using Commons.DTO_s.PaymentCommon.GetTransactionConfig;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.PaymentCommon_RF.GetPortalEnrolledCourses_RF
{
    public class GetPortalEnrolledCourses_DataRead
    {
        public List<GetPortalEnrolledCourses_InputParams> Getfile_GetPortalEnrolledCourses()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "GetPortalEnrolledCourses.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<GetPortalEnrolledCourses_InputParams>();
            }
        }
        private static List<GetPortalEnrolledCourses_InputParams> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<GetPortalEnrolledCourses_InputParams>(csv.GetRecords<GetPortalEnrolledCourses_InputParams>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<GetPortalEnrolledCourses_InputParams>();
            }
        }

    }
}
