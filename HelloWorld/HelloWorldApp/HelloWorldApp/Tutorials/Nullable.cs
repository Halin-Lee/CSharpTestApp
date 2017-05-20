using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.Tutorials
{
    class Nullable : TestCase
    {
        public override void Test()
        {
            //定义成可空，则可以赋值为空，否则不可以
            //int num = null;
            int? nullNum = null;
            int? nullNum1 = new int();
            int? nullNum2 = new int?();

            //??如果左侧为空，则等于右侧
            int value = nullNum ?? 77;
            int value1 = nullNum1 ?? 88;
            Object obj = this ?? null;

            Console.WriteLine("显示可空类型的值： {0}, {1}, {2}, {3}, {4}, {5}",
                            nullNum, nullNum1, nullNum2,value,value1,obj);
            


        }
    }
}
