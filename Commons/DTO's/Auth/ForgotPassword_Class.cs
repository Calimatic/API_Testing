using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Auth
{
    public partial class ForgotPassword_Class
    {
            public string Response { get; set; }
            public bool IsSuccessful { get; set; }
            public long StatusCode { get; set; }
    }
}
