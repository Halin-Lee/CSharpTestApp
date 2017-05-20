using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.Tutorials
{
    class Class : TestCase
    {
        public override void Test()
        {
        }

        //析构函数，回收时调用
        ~Class() {
            
        }
    }


    class SampleClass  {
        public SampleClass(int i) : this(i, 1) { }
        public SampleClass(int i, int j) { }
    }


    class SampleSubClass : SampleClass
    {

        public SampleSubClass() : this(0, 0) { }

        public SampleSubClass(int i,int j) : base(i)
        {
        }

     
    }


}
