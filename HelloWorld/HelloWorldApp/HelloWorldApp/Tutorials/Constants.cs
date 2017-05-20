using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.Tutorials
{
    class Constants : TestCase
    {
        public override void Test()
        {
            String str = "可以用\"+\"" +
                "链接";
            String aStr = @"
            @ 可以换多行 ,但会取消字符串转义符
            ";

            Console.WriteLine(str);
            Console.WriteLine(aStr);
        }
    }
}
