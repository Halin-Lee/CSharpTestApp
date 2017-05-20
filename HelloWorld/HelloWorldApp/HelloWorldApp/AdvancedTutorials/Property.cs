using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.AdvancedTutorials
{
    class PropertySample : AbstractPropertySample
    {
        public string readWrite
        {
            get; set;
        }
        public string readOnly
        {
            get { return "2"; }
        }

        public override string str => "777";
    }


    abstract class AbstractPropertySample{
        public abstract string str {
            get;
        }
    }

    class Property : TestCase
    {
        public override void Test()
        {
            PropertySample propertySample = new PropertySample();
            propertySample.readWrite = "1";
            Console.WriteLine(propertySample.readWrite);

            //propertySample.readOnly = "2";
            Console.WriteLine(propertySample.readOnly);



        }
    }
}
