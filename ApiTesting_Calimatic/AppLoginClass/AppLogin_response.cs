using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.AppLoginClass
{
    public class AppLogin_response
    {
        public string response {  get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }

    }
}
