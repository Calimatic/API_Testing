using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Company.VerifyActivationEmail
{
    public class VerifyActivationEmail_InputValues
    {
        public string companyGuid { get; set; }
        public string activationCode { get; set; }
    }
}