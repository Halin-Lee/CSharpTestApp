using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HelloWorldApp.Tutorials
{
    class FileIO:TestCase
    {
        
        public override void Test()
        {
            using (StreamReader streamReader = new StreamReader("C:\\Users\\Halin\\Desktop\\key.txt")) {

                string line;
                // 从文件读取并显示行，直到文件的末尾 
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
