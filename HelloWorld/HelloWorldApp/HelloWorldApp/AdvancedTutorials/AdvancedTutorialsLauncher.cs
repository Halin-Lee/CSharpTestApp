using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.AdvancedTutorials
{
    class AdvancedTutorialsLauncher : TestLauncher
    {
        public override void Launch()
        {
            new Attribute().Start();
            new Reflection().Start();
            new Property().Start();
            new Indexer().Start();
            new Delegate().Start();
            new Event().Start();
            new Collection().Start();
        }
    }
}
