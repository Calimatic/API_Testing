using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Auth
{
    public class csv_ResetPassword_Data
    {
        public string password { get; set; }
        public string confirmPassword { get; set; }
        public string userGuid { get; set; }
        public string companyUrl { get; set; }

    }
}
