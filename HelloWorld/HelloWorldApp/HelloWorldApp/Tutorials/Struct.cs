using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.Tutorials
{

    struct Song {
        public String name;
        public String style;
        //允许使用方法初始化结构体，但不允许有默认值
        //String singer = "";
        public Song(String name) {
            this.name = name;
            style = null;
        }

        public void Reset() {
            this.name = null;
        }
    }
    class Struct : TestCase
    {
        public override void Test()
        {
            Song song = new Song();
            Console.WriteLine("Song's name : {0}", song.name);
            song = new Song("123");
            Console.WriteLine("Song's name : {0}", song.name);
            song.Reset();
            Console.WriteLine("Song's name : {0}", song.name);
        }
    }
}
