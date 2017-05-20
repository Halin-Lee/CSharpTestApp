using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.AdvancedTutorials
{
    class Generic : TestCase
    {
        public override void Test()
        {
            GenericClass<String> genericClass = new GenericClass<string>();
            genericClass.obj = "Test";
            //genericClass.obj = 1;
            GenericClass<GenericClass<String>> genericClassChain = new GenericClass<GenericClass<string>>();
            genericClassChain.obj = genericClass;

            List<GenericClass<String>> genericList = new List<GenericClass<string>>();
            genericList.Add(genericClass);
        }

    }


    class GenericClass<T> {
        internal T obj { get; set; }
    }


}
