using Commons.DTO_s.Auth;
using Commons.DTO_s.Dashboards.restoreWidgets_DatareadFile;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.Dashboard_RF.restoreWidgetsToDefault_RF
{
    public class restoreWidgetsTo_Default
    {
        public List<ReadData_restoreWdgets> restoreWidgetsToDefault_FP()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "restoreWidgetsToDefault.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<ReadData_restoreWdgets>();
            }
        }
        //
        private static List<ReadData_restoreWdgets> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<ReadData_restoreWdgets>(csv.GetRecords<ReadData_restoreWdgets>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<ReadData_restoreWdgets>();
            }
        }
    }
}
