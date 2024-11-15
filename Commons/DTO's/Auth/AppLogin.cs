using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting_Calimatic.AppLoginFolder
{
    public partial class AppLogin
    {
        public string Response { get; set; }
        public bool IsSuccessful { get; set; }
        public long StatusCode { get; set; }
    }
}

