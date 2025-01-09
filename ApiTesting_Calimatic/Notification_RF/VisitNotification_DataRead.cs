using ApiTesting_Calimatic.CourseType.list;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.Notification_RF
{
    public class VisitNotification_DataRead
    {
        public List<VisitNotification_InputValues> Getfile_VisitNotification()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "VisitNotification.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<VisitNotification_InputValues>();
            }
        }
        private static List<VisitNotification_InputValues> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<VisitNotification_InputValues>(csv.GetRecords<VisitNotification_InputValues>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<VisitNotification_InputValues>();
            }
        }
    }
}