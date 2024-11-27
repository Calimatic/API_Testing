using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ApiTesting_Calimatic.AppLoginFolder;

namespace ApiTesting_Calimatic.AppLoginClass
{
    public class Api_AppLogin
    {
     /*   public void MainAppLogin()
        {
            Console.WriteLine("--------------- /api/Auth/Applogin ---------------\n");
            var data = GetTestCaseData();

            foreach (var entry in data)
            {
                Console.WriteLine("Input Value");
                Console.WriteLine($"userName: {entry.userName}, \npassword: {entry.password}");
                var ApiStudents = new ApiStudents();
                ApiStudents.TestLogin(entry);
            }
        }
        public List<csvData> GetTestCaseData()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "Applogin.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<csvData>();
            }
        }
        //
        private static List<csvData> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<csvData>(csv.GetRecords<csvData>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<csvData>();
            }
        }*/
    }
}
