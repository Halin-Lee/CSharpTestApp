using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.AdvancedTutorials
{

    delegate string DelegateSample(String text);
    class Delegate:TestCase
    {


        static string StaticImplGetText(String text)
        {
            Console.WriteLine("StaticImplGetText Called");
            return "ImplGetText";
        }
         string ImplGetText(String text)
        {
            Console.WriteLine("ImplGetText Called");
            return text + text;
        }

        public override void Test()
        {
            DelegateSample getText = new DelegateSample(StaticImplGetText);
            Console.WriteLine(getText(""));

            getText += new DelegateSample(ImplGetText);

            Console.WriteLine(getText(""));


        }
    }
}
