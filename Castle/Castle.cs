using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chloe_test.Castle
{
    public class Castle : ITest
    {
        public void PreRun()
        {
           
        }

        public void RunTest()
        {
           Console.WriteLine(this.GetType());
            



        }
    }
}
