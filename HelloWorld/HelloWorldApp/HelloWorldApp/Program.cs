using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //打印支持的字符集
            //foreach (EncodingInfo encoding in Encoding.GetEncodings())
            //{
            //    Console.WriteLine(encoding.DisplayName);
            //}

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello World!");

            new Tutorials.TutorialsLauncher().Launch();
            new AdvancedTutorials.AdvancedTutorialsLauncher().Launch();
            Thread.Sleep(10000);


        }
    }
}
