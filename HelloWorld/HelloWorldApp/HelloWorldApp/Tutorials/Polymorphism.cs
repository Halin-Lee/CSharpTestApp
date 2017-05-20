using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.Tutorials
{
    sealed class Polymorphism : TestCase
    {
        public override void Test()
        {
        }
        String BaseMethod() {
            return "";
        }

        //重载的方法可以有不同的返回
        void BaseMethod(int i) {
        }
    }


    sealed class SealedClass { }

    // sealed相当于JAVA的final
    //class SubClass : SealedClass { }

    abstract class AbstractClass {
        public abstract void AbstractMethod();
    }

    abstract class AbstractClass1 : AbstractClass { }
    class SubAbstractClass : AbstractClass
    {
        public override void AbstractMethod()
        {
        }
    }


    class VirtualClass {
        public virtual void VirturalMehtod() { }
        public void NormalMethod() { }
    }

    class SubVirtualClass : VirtualClass {
        public override void VirturalMehtod()
        {
            base.VirturalMehtod();
        }
    }

}
