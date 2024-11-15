using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTtesting_Calimatic
{
    public partial class Duplicateusername
    {
        public Duplicateusername response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public bool isExist { get; set; }
    }
    public class duplusername
    {
        public Duplicateusername response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
}

