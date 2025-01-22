using ApiTesting_Calimatic.classes.getCourseTypeClasses_RF;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.SISForm.createStudentInformationForm_RF
{
    public class createStudentInformationForm_DataRead
    {
        public List<createStudentInformationForm_InputValues> Getfile_createStudentInformationForm()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "createStudentInformationForm.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<createStudentInformationForm_InputValues>();
            }
        }
        private static List<createStudentInformationForm_InputValues> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<createStudentInformationForm_InputValues>(csv.GetRecords<createStudentInformationForm_InputValues>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<createStudentInformationForm_InputValues>();
            }
        }
    }
}