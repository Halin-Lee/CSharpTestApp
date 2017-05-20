using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.AdvancedTutorials
{
    class Indexer : TestCase
    {
        public override void Test()
        {
            Console.WriteLine(this[51]);
            Console.WriteLine(this[51L]);
            Console.WriteLine(this["now",1]);
        }

        public string this[int index]
        {
            get
            {
                return Convert.ToString(index);
            }
        }
        public string this[long index]
        {
            get
            {
                return index+"L";
            }
        }

        public string this[string str,int i] {
            get {
                return str + i;
            }
        }
    }
}
