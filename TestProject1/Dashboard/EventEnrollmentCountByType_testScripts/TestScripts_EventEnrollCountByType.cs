using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Dashboard.EventEnrollmentCountByType_testScripts
{
    public class TestScripts_EventEnrollCountByType
    {
        [TestMethod]
        public void ValidInputValues(string type, string franchises)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Valid All Input Values                                            :       PASS");
            Console.WriteLine("Response with no Data                                             :       FAIL");
            Console.WriteLine("Special Character used in 'franchiseIds' input values             :       FAIL");
            Console.WriteLine("'types' or 'franchisesIds' is null or empty                       :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'types')                            :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'franchisesIds')                    :       FAIL");
        }
        [TestMethod]
        public void InvalidInputValues(string type, string franchises)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Response with no Data                                             :       PASS");
            Console.WriteLine("Alphabet Character used in 'franchiseIds' input values            :       FAIL");
            Console.WriteLine("Valid All Input Values                                            :       FAIL");
            Console.WriteLine("Special Character used in 'franchiseIds' input values             :       FAIL");
            Console.WriteLine("'types' or 'franchisesIds' is null or empty                       :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'types')                            :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'franchisesIds')                    :       FAIL");
        }
    }
}
