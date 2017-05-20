using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.Tutorials
{
    class OperatorOverloading : TestCase
    {
        public override void Test()
        {
            OperatorOverloading obj = new OperatorOverloading();
            Console.WriteLine("Output:{0}, {1}, {2}, {3},", obj + obj, obj + null, obj + new Object(), obj + 1);


        }
        public static bool operator +(OperatorOverloading b, Object c)
        {
            return false;
        }
        public static bool operator +(OperatorOverloading b, OperatorOverloading c)
        {
            return true;
        }
        public static bool operator +(OperatorOverloading b, bool c)
        {
            return c;
        }
        public static int operator +(OperatorOverloading b, int c)
        {
            return c;
        }
    }




}
