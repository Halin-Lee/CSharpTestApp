using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.Tutorials
{
    class TypeConversion : TestCase
    {
        public override void Test()
        {
            double doubleVal = 1.7;
            int intVal = (int)doubleVal;
            Console.WriteLine(intVal);
        }
    }
}
