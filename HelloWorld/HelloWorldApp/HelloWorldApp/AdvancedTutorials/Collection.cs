using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.AdvancedTutorials
{
    class Collection : TestCase
    {
        public override void Test()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add("Text");

            foreach (Object obj in arrayList)
            {
                Console.WriteLine("打印ArrayList " + obj);
            }


            Hashtable hashTable = new Hashtable();
            hashTable.Add(1, "Text");
            hashTable.Add("Text", 2);
            //调用Add需要判断是否重复,使用索引方式不用
            //hashTable.Add(1, "Text2");
            hashTable[1] = "Text2";

            foreach (Object obj in hashTable.Keys)
            {
                Console.WriteLine("打印Hashtable " + obj + " " + hashTable[obj]);
            }
            Console.WriteLine("打印Hashtable " + hashTable["Text"]);


            SortedList sortedList = new SortedList();
            sortedList.Add("1", "Text");
            sortedList.Add("2", 1);

            //调用Add需要判断是否重复,使用索引方式不用
            //sortedList.Add(1, "Text2"); 
            sortedList["1"] = "Text 2";

            ICollection collection = sortedList.Keys;

            foreach (Object obj in collection)
            {
                Console.WriteLine("打印SortedList " + obj +" " + sortedList[obj]);
            }

            Console.WriteLine("打印SortedList " + sortedList["1"]);
            Console.WriteLine("打印SortedList " + sortedList.GetByIndex(1));

            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine("打印Stack " + stack.Peek());
            Console.WriteLine("打印Stack " + stack.Peek());
            Console.WriteLine("打印Stack " + stack.Pop());
            Console.WriteLine("打印Stack " + stack.Pop());


            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            foreach (int i in queue)
            {
                Console.WriteLine("打印Queue " + i);
            }

            Console.WriteLine("打印Queue " + queue.Peek());
            Console.WriteLine("打印Queue " + queue.Peek());
            Console.WriteLine("打印Queue " + queue.Dequeue()); 
            Console.WriteLine("打印Queue " + queue.Dequeue());

            BitArray bitArray = new BitArray(1);
           

        }
    }
}
