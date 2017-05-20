using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp.Tutorials
{
    class ExceptionHandling : TestCase
    {
        public override void Test()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (NotImplementedException e)
            {

            }
            finally
            {
                throw new NotImplementedException();

            }
        }
    }
}
