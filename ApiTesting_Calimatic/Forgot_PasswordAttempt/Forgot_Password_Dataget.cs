using Commons.DTO_s.Auth;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.Forgot_PasswordAttempt
{
    public class Forgot_Password_Dataget
    {
        //public void ForgotGetData()
        //{
        //    var data = Getfile_FP();
        //    // Check if the file exists
        //    foreach (var entry in data)
        //    {
        //        Console.WriteLine("Input Value");
        //        Console.WriteLine($"\nEmail: {entry.email}, \nusername: {entry.username}, \nurl: {entry.url}");
        //        var ApiStudents = new ApiStudents();
        //  //      ApiStudents.ForgotPassword(entry);
        //    }
        //}

        public List<csv_FP_Data> Getfile_FP()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "Forgot Password.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<csv_FP_Data>();
            }
        }
        //
        private static List<csv_FP_Data> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<csv_FP_Data>(csv.GetRecords<csv_FP_Data>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<csv_FP_Data>();
            }
        }
    }
}
