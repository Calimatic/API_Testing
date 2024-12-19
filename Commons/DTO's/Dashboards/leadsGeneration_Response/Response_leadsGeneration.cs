using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Commons.DTO_s.Dashboards.leadsGeneration_Response
{
    public class Response_leadsGeneration
    {
        [TypeConverter(typeof(NullableIntConverter))]
        public int? type { get; set; }

        [TypeConverter(typeof(NullableIntConverter))]
        public int? companyId {  get; set; }
    }
    //public class NullableIntConverter : DefaultTypeConverter
    //{
    //    // Custom converter to handle empty strings for integers
    //    public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
    //    {
    //        // If the string is empty, return null
    //        if (string.IsNullOrWhiteSpace(text))
    //        {
    //            return null;
    //        }

    //        // Try to parse the integer, if successful return the value
    //        if (int.TryParse(text, out int result))
    //        {
    //            return result;
    //        }

    //        // If parsing fails, return null (or handle it as needed, e.g., throwing an exception)
    //        return null;
    //    }
    //}

    public class NullableIntConverter : DefaultTypeConverter
    {
        // Custom converter to handle empty strings, alphabets, and special characters for integers
        public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
        {
            // Check if the string is null, empty or contains only whitespace
            if (string.IsNullOrWhiteSpace(text))
            {
                // Return null if the value is empty or whitespace
                return null;
            }

            // Check if the string contains only alphabets (no numbers)
            string alphabetPattern = @"^[a-zA-Z]+$";
            if (Regex.IsMatch(text, alphabetPattern))
            {
                // Return null if the string contains alphabets (no numeric values)
                return null;
            }

            // Check for special characters (anything that is not a digit or letter)
            string specialCharPattern = @"[^\w\s]";  // Matches special characters like *&^%$
            if (Regex.IsMatch(text, specialCharPattern))
            {
                // Return null if the string contains special characters
                return null;
            }

            // Attempt to parse the string as an integer. If it succeeds, return the integer.
            if (int.TryParse(text, out int result))
            {
                return result;
            }

            // If parsing fails, return null (indicating invalid data)
            return null;
        }
    }
}
