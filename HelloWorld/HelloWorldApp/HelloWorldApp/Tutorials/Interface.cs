using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.Tutorials
{
    interface Interface
    {
        void InterfaceMethod();
    }
    interface Interface1
    {
        void InterfaceMethod();
    }


    class InterfaceImpl : Interface,Interface1
    {
        public void InterfaceMethod()
        {
        }
    }
}
