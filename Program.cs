
using Castle.DynamicProxy;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Chloe;
using Chloe.MySql;
using Chloe_test.Castle;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Chloe_test
{
    class Program
    {
        static void Main(string[] args)
        {

            var choleTest = new Chloe.Chloe();
            choleTest.RunTest();

            var castleTest = new Castle.Castle();
            castleTest.PreRun();
            castleTest.RunTest();

            while (true)
            {
                var key = Console.ReadKey();
            }
        }
    }
}
