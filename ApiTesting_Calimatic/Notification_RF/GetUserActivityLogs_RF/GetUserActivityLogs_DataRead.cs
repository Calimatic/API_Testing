using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.Notification_RF.GetUserActivityLogs_RF
{
    public class GetUserActivityLogs_DataRead
    {
        public List<GetUserActivityLog_InputValue> Getfile_GetUserActivityLogs()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "GetUserActivityLogs.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<GetUserActivityLog_InputValue>();
            }
        }
        private static List<GetUserActivityLog_InputValue> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<GetUserActivityLog_InputValue>(csv.GetRecords<GetUserActivityLog_InputValue>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<GetUserActivityLog_InputValue>();
            }
        }
    }
}