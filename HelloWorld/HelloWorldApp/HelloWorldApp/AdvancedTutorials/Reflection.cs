using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.AdvancedTutorials
{
    [AttributeUsage(AttributeTargets.All)]
    class ReflectionAttribute : System.Attribute{ }

    [ReflectionAttribute]
    class Reflection:TestCase
    {
        public override void Test()
        {
            MemberInfo info = typeof(Reflection);
            object[] attributes = info.GetCustomAttributes(true);
            foreach (object attribute in attributes) {
                Console.WriteLine(attribute);
            }
        }
    }
}
