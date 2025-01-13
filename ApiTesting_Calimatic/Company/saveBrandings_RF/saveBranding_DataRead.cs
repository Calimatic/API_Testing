using Commons.DTO_s.Company.saveBrandings;
using Commons.DTO_s.Course_Category.getCourseCategoriesByTypeId;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.Company.saveBrandings_RF
{
    public class saveBranding_DataRead
    {
        public List<saveBrandings_InputValue> Getfile_SaveBrandings()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "saveBrandings.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<saveBrandings_InputValue>();
            }
        }
        private static List<saveBrandings_InputValue> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<saveBrandings_InputValue>(csv.GetRecords<saveBrandings_InputValue>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<saveBrandings_InputValue>();
            }
        }
    }
}