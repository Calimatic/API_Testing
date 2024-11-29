using Commons.DTO_s.Dashboards.Partner_Enrollment;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Dashboard.Partner_Enrollment;

namespace ApiTesting_Calimatic.Dashboard_RF.PartnerEnrollment_RF
{
    public class PartnerEnroll_RF
    {
        //public void testing()
        //{
        //    Console.WriteLine("--------------- /api/Auth/Applogin ---------------\n");
        //    var data = Getfile_PartnerEnroll();

        //    foreach (var entry in data)
        //    {
        //        Console.WriteLine("Input Value");
        //        Console.WriteLine($"franchises: {entry.franchises}");
        //        var testscript = new TestScripts_PartnerEnrollment();
        //        testscript.testscript(entry.franchises);
        //        var ApiStudents = new ApiStudents();
        //        ApiStudents.PartnerEnrollment(entry);
        //    }
        //}

        public List<csv_PartnerEnrollment_Data> Getfile_PartnerEnroll()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "Partner Enrollments.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<csv_PartnerEnrollment_Data>();
            }
        }
        //
        private static List<csv_PartnerEnrollment_Data> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<csv_PartnerEnrollment_Data>(csv.GetRecords<csv_PartnerEnrollment_Data>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<csv_PartnerEnrollment_Data>();
            }
        }
    }
}
