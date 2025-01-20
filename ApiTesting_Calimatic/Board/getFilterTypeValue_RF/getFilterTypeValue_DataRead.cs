using ApiTesting_Calimatic.Board.student_RF;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.Board.getFilterTypeValue_RF
{
    public class getFilterTypeValue_DataRead
    {
        public List<getFilterTypeValue_InputParams> Getfile_getFilterTypeValue()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "getFilterTypeValue.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<getFilterTypeValue_InputParams>();
            }
        }
        private static List<getFilterTypeValue_InputParams> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<getFilterTypeValue_InputParams>(csv.GetRecords<getFilterTypeValue_InputParams>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<getFilterTypeValue_InputParams>();
            }
        }
    }
}