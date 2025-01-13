using Commons.DTO_s.Company.ResendActivationEmail;
using Commons.DTO_s.Company.saveBrandings;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.Company.ResendActivationEmail_RF
{
    public class ResendActivationEmail_DataRead
    {
        public List<ResendActivationEmail_InputValue> Getfile_ResendActivationEmail()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "ResendActivationEmail.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<ResendActivationEmail_InputValue>();
            }
        }
        private static List<ResendActivationEmail_InputValue> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<ResendActivationEmail_InputValue>(csv.GetRecords<ResendActivationEmail_InputValue>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<ResendActivationEmail_InputValue>();
            }
        }
    }
}