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
    public class FPass_OTP_Verification_RF
    {
        //public void Otp_FPass()
        //{
        //    var data = Get_Otpfile_FP();
        //    // Check if the file exists
        //    foreach (var entry in data)
        //    {
        //        Console.WriteLine("Input Value");
        //        Console.WriteLine($"\nOtp: {entry.otp}, \nuserGuid: {entry.userGuid}, \nurl: {entry.url}");
        //        var ApiStudents = new ApiStudents();
        //        //      ApiStudents.ForgotPassword(entry);
        //    }
        //}

        public List<csv_Otp_FPass_Data> Get_Otpfile_FP()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "Forgot Password OTP Verification.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<csv_Otp_FPass_Data>();
            }
        }
        //
        private static List<csv_Otp_FPass_Data> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<csv_Otp_FPass_Data>(csv.GetRecords<csv_Otp_FPass_Data>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<csv_Otp_FPass_Data>();
            }
        }
    }
}
