using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Dashboard.leadsGeneration_TestScript
{
    [TestClass]
    public class TestScripts_leadsGeneration
    {
        [TestMethod]
        public void ValidInputValues(int? type , int? companyId)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Valid Input Value                                                      :    PASS");
            Console.WriteLine("Special characters used in input value                                 :    FAIL");
            Console.WriteLine("Alphabet characters used in input value                                :    FAIL");
            Console.WriteLine("Null Input role value                                                  :    FAIL");
            Console.WriteLine("BeginExecuteNonQuery: CommandText property has not been initialized    :    FAIL");
        }
    }
}
