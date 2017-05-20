using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.Tutorials
{
    class Method : TestCase
    {
        public override void Test()
        {
            PrintDivider("Ref测试");
            RefTest();
            PrintDivider("Out测试");
            OutTest();
        }

        #region ref
        private void RefTest()
        {
            int aVal = 0;
            int bVal = 1;
            Console.WriteLine("交换前数值,aVal:{0},bVal:{1}", aVal, bVal);
            swap(ref aVal, ref bVal);
            Console.WriteLine("交换后数值,aVal:{0},bVal:{1}", aVal, bVal);
        }

        private void swap(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }

        #endregion

        #region out

        private void OutTest() {

            int aVal = 0;
            int bVal = 1;
            Console.WriteLine("交换前数值,aVal:{0},bVal:{1}", aVal, bVal);
            outMethod(out aVal,out  bVal);
            Console.WriteLine("交换后数值,aVal:{0},bVal:{1}", aVal, bVal);

        }

        private void outMethod(out int i,out int j) {
            //int error = i;
            i = 1;
            j = 2;
        }

        #endregion


        #region overload
        private void overload(int i) { }
        private void overload(ref int i) { }
        //out 和 ref 的编译方式相同，所以不能重载，
        //private void overload(out int i) { }

        #endregion

    }
}
