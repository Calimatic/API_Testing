using Commons.DTO_s.PortalUserRoles.AddUpdateRoleAccess;
using Commons.DTO_s.PortalUserRoles.AddUpdateRoles;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.PortalUserRoles.AddUpdateRoleAccess_RF
{
    public class AddUpdateRoleAccess_DataRead
    {
        public List<Root_FranchisesDropdown_InputValues> Getfile_AddUpdateRoleAccess()
        {
            string baseDirectory = AppContext.BaseDirectory;
            // Go up two levels from "bin/Debug/net8.0" to the project directory and then to the desired path
            string projectPath = Path.Combine(baseDirectory, "..", "..", "..");
            // Construct the relative path to the CSV file
            string relativePath = Path.Combine(projectPath, "Dataset_files", "AddUpdateRoleAccess.csv");

            // Check if the file exists
            if (File.Exists(relativePath))
            {
                return ReadCsv(relativePath);
            }
            else
            {
                Console.WriteLine("File not found.");
                return new List<Root_FranchisesDropdown_InputValues>();
            }
        }
        private static List<Root_FranchisesDropdown_InputValues> ReadCsv(string relativePath)
        {
            try
            {
                using (var reader = new StreamReader(relativePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return new List<Root_FranchisesDropdown_InputValues>(csv.GetRecords<Root_FranchisesDropdown_InputValues>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
                return new List<Root_FranchisesDropdown_InputValues>();
            }
        }
    }
}