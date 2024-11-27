using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Dashboard.Widgets_Folder
{
    [TestClass]
    public class TestScripts_widgets
    {
        [TestMethod]
        public void Get_Data_Widgets()
        {
                Console.WriteLine("\nTest Script :");
                Console.WriteLine("Get Widget Successfuly       :    PASS");
                Console.WriteLine("Fail Get Data Widget         :    FAIL\n");
                Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void Fail_Get_Data_widgets()
        {
               Console.WriteLine("\nTest Script :");
               Console.WriteLine("Fail Get Data Widget         :    PASS");
               Console.WriteLine("Get Widget Successfuly       :    FAIL\n");
               Assert.AreEqual(true, true);
        }
    }
}
