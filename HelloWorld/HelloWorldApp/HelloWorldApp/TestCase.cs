using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    abstract class TestCase
    {

        public abstract void Test();


        void BeforeTest()
        {
            PrintDivider(GetType().ToString() + " Test Begin");
        }
        void AfterTest()
        {
            PrintDivider(GetType().ToString() + " Test Finish");
        }


        public void Start() {
            BeforeTest();
            Test();
            AfterTest();
        }

        public void PrintDivider(String str)
        {
            Console.WriteLine("-----------------" + str +"---------------");
        }

    }

    abstract class TestLauncher {
        public abstract void Launch();
    }
}
