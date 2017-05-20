using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.AdvancedTutorials
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ClassAttributeSample : System.Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    class MethodAttributeSample : System.Attribute
    {
        private int error;
        private String message;
        public MethodAttributeSample(int error,String message) {
            this.error = error;
            this.message = message;
        }
    }

    [ClassAttributeSample]
    class Attribute : TestCase
    {
        [MethodAttributeSample(0,"写入消息")]
        public override void Test()
        {
            ConditionalDebug();
            ConditionalRelease();
            new ObsoleteClass().ObsoleteMethod();

        }

        [Conditional("DEBUG")]
        void ConditionalDebug (){
            Console.WriteLine("DEBUG");
        }

        //Debug运行时不被调用
        [Conditional("RELEASE")]
        void ConditionalRelease()
        {
            Console.WriteLine("RELEASE");
        }

    }



    [Obsolete("被调用时会生成警告")]
    class ObsoleteClass {
        [Obsolete("被调用时会生成警告")]
        public void ObsoleteMethod (){ }
    }




}
