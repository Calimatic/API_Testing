using Commons.DTO_s.Dashboards.ClassDropOffCountByType_ResponseData;
using Commons.DTO_s.Dashboards.studentDemographics;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.Dashboard_RF.studentDemographics
{
    public class studentDemographics_RF
    {
        public List<studentDemographics_InputParams> Getfile_EventDropOffCountByType()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "studentDemographics.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<studentDemographics_InputParams>();
            }
        }
        private static List<studentDemographics_InputParams> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<studentDemographics_InputParams>(csv.GetRecords<studentDemographics_InputParams>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<studentDemographics_InputParams>();
            }
        }
    }
}
