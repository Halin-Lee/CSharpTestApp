using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.Tutorials
{
    class NameSpace
    {
    }


    namespace Nested{
        class NameSpace { }
    }
}


namespace HelloWorldApp.Tutorials.Other {

    class NameSpace {
    }
}


namespace HelloWorldApp.Tutorials {

    class NameSpaceSample {
         void Test() {
            NameSpace nameSpace = new NameSpace();
            Other.NameSpace otherNameSpace = new Other.NameSpace();
            Nested.NameSpace nestedNameSpace = new Nested.NameSpace();
        }   
    }
}
