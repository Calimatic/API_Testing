using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Dashboards.leadsGeneration_Response
{
    public class Response_leadsGeneration
    {
        public int? type { get; set; }
        public int? companyId {  get; set; }
    }
    public class NullableIntConverter : DefaultTypeConverter
    {
        // Custom converter to handle empty strings for integers
        public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
        {
            // If the string is empty, return null
            if (string.IsNullOrWhiteSpace(text))
            {
                return null;
            }

            // Try to parse the integer, if successful return the value
            if (int.TryParse(text, out int result))
            {
                return result;
            }

            // If parsing fails, return null (or handle it as needed, e.g., throwing an exception)
            return null;
        }
    }
}
