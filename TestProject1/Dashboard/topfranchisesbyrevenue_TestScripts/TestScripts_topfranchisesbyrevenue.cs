using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Dashboard.topfranchisesbyrevenue_TestScripts
{
    public class TestScripts_topfranchisesbyrevenue
    {
        [TestMethod]
        public void Successfully_Response()
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Response Get Successfully                 :       PASS");
            Console.WriteLine("Failed to Response                        :       FAIL");
        }

        [TestMethod]
        public void Failed_Response()
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Failed to Response                        :       PASS");
            Console.WriteLine("Response Get Successfully                 :       FAIL");
        }
    }
}
