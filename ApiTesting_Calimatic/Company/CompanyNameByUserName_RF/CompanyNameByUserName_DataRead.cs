using ApiTesting_Calimatic.Company.CompanyConfigs_RF;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.Company.CompanyNameByUserName_RF
{
    public class CompanyNameByUserName_DataRead
    {
        public List<CompanyNameByUserName_InpurParams> Getfile_CompanyNameByUserName()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "CompanyNameByUserName.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<CompanyNameByUserName_InpurParams>();
            }
        }
        private static List<CompanyNameByUserName_InpurParams> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<CompanyNameByUserName_InpurParams>(csv.GetRecords<CompanyNameByUserName_InpurParams>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<CompanyNameByUserName_InpurParams>();
            }
        }
    }
}
