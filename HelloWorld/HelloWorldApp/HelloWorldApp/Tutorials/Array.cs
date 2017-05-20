using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.Tutorials
{
    class Array : TestCase
    {
        public override void Test()
        {
            PrintDivider("Normal");
            NormalTest();
            PrintDivider("Multidimensional");
            MultidimensionalTest();
            PrintDivider("Jagged");
            JaggedTest();
            PrintDivider("Params");
            ParamsTest();


        }

        void NormalTest()
        {
            int[] intArray = new int[] { 1, 2, 3 };
            intArray = new int[3];

            //数组默认值是0，不是null
            foreach (int i in intArray)
            {
                Console.WriteLine("{0}", i);
            }
        }

        //多维数组
        void MultidimensionalTest() {
            int[,] a = new int[3, 3] { { 3, 3, 3 }, { 3, 3, 3 }, { 3, 3, 3 } };
            /* 输出数组中每个元素的值 */
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
                }
            }
        }

        //交错数组
        void JaggedTest() {
            //构造时只能指定第一维长度
            //int[][] a = new int[3][3];
            
            int[][] a = new int[2][] { new int[] { 0, 0 }, new int[] { 1, 2 }};
            int i, j;
            
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0}][{1}] = {2}", i, j, a[i][j]);
                }
            }

        }

        void ParamsTest(params int[] input) {
            if (input == null)
            {
                ParamsTest(1, 2, 3, 4);
            }
        }

        void ArrayTest() {

            //Array 是所有 数组基类，所以也可以这么声明
            System.Array array = new int[1];
            int[] intArray = new int[1] ;
            

        }


    }
}
