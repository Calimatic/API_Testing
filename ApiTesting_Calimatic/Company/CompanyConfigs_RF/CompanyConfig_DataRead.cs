using ApiTesting_Calimatic.Notification_RF.GetUserActivityLogs_RF;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.Company.CompanyConfigs_RF
{
    public class CompanyConfig_DataRead
    {
        public List<CompanyConfig_InpurParams> Getfile_CompanyConfig()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "CompanyConfigs.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<CompanyConfig_InpurParams>();
            }
        }
        private static List<CompanyConfig_InpurParams> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<CompanyConfig_InpurParams>(csv.GetRecords<CompanyConfig_InpurParams>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<CompanyConfig_InpurParams>();
            }
        }
    }
}