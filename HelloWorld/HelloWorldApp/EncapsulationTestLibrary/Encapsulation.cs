using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.NameSpace
{
    #region 命名空间下允许的修饰符

    
    
    //默认修饰符，不限制访问，所有工程都可以访问
    public class PublicNameSpaceClass : Object { }

    //只能在本工程访问
    internal class InternalNameSpaceClass : Object { }
    
    //默认修饰符为internal
    class NormalNameSpaceClass : Object { }

    //类不允许使用的三种定义（因为没意义）
    //protected internal class ProtectedInternalClass : Object { }
    //private class PrivateClass : Object { }
    //protected class ProtectedClass : Object { }

    #endregion


    public class ProjectEncapsulationSample
    {
        public class PublicInnerClass { }
        internal class InternalInnerClass { }
        private class PrivateInnerClass { }
        protected class ProtectedInnerClass { }
        protected internal class ProtectedInternalInnerClass { }
        class NormalInnerClass { }
        

        public int publicMember;
        internal int internalMember;
        private int privateMember;
        protected int protectedMember;
        protected internal int protectedInternalMember;
        int normalMember;

        public void PublicMethod() { }
        private void PrivateMethod() { }
        protected void ProtectedMethod() { }
        internal void InternalMethod() { }
        protected internal void ProtectedInternalMethod() { }
        void NormalMethod() { }

    }

}
