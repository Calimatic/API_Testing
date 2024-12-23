using Commons.DTO_s.Dashboards.ClassDropOffCountByType_ResponseData;
using Commons.DTO_s.Dashboards.leadsGeneration_Response;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.Dashboard_RF.ClassDropOffCountByType_RF
{
    public class ClassDropOffCountByType_DataRead
    {
        public List<ClassDropOffCountByType_data> Getfile_ClassDropOffCountByType()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "ClassDropOffCountByType.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<ClassDropOffCountByType_data>();
            }
        }
        private static List<ClassDropOffCountByType_data> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<ClassDropOffCountByType_data>(csv.GetRecords<ClassDropOffCountByType_data>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<ClassDropOffCountByType_data>();
            }
        }
        //private static List<Response_leadsGeneration> ReadCsv(string relativePath)
        //{
        //    try
        //    {
        //        using (var reader = new StreamReader(relativePath))
        //        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        //        {
        //            // Register custom converter for nullable ints
        //            csv.Context.TypeConverterCache.AddConverter<int?>(new NullableIntConverter());
        //            // Reading records
        //            return new List<Response_leadsGeneration>(csv.GetRecords<Response_leadsGeneration>());
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error reading CSV file: {ex.Message}");
        //        return new List<Response_leadsGeneration>();
        //    }
        //}

    }
}
