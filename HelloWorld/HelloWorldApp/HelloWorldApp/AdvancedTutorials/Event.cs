using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.AdvancedTutorials
{
    class Event : TestCase
    {

        public delegate void EventDelegate(int i);
        public event EventDelegate Events;
        public override void Test()
        {
            EventDelegate eventDelegate = new EventDelegate(DelegateImpl);
            Events += eventDelegate;
            Events += (int i) =>
            {
                Console.WriteLine("Block Called " + 1);
            };

            if (Events != null)
                Events(1);


        }


        public void DelegateImpl(int i)
        {
            Console.WriteLine("DelegateImpl Called " + i);
        }
    }
}
