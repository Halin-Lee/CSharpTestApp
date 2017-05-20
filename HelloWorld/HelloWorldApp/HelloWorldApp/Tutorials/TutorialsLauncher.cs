using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.Tutorials
{
    class TutorialsLauncher : TestLauncher
    {
        public override void Launch()
        {
            new TypeConversion().Start();
            new Constants().Start();
            new Method().Start();
            new Nullable().Start();
            new Array().Start();
            new Struct().Start();
            new OperatorOverloading().Start();
            new FileIO().Start();
            //访问修饰符测试在Encapsulation类中，没有执行方法
        }
    }
}
