using Commons.DTO_s.Dashboards.ClassEnrollmentCountByType;
using Commons.DTO_s.Dashboards.leadsGeneration_Response;
using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.Dashboard_RF.leadsGeneration_RF
{
    public class leadsGeneration_DataRead
    {
        public List<Response_leadsGeneration> Getfile_leadsGeneration()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "leadsGeneration.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<Response_leadsGeneration>();
            }
        }
        //private static List<Response_leadsGeneration> ReadCsv(string relativePath)
        //{
        //    try
        //    {
        //        using (var reader = new StreamReader(relativePath))
        //        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        //        {
        //            return new List<Response_leadsGeneration>(csv.GetRecords<Response_leadsGeneration>());
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error reading CSV file: {ex.Message}");
        //        return new List<Response_leadsGeneration>();
        //    }
        //}
        private static List<Response_leadsGeneration> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    // Register custom converter for nullable ints
                    csv.Context.TypeConverterCache.AddConverter<int?>(new NullableIntConverter());
                    // Reading records
                    return new List<Response_leadsGeneration>(csv.GetRecords<Response_leadsGeneration>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<Response_leadsGeneration>();
            }
        }
    }
}
