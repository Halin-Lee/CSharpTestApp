using System;
using Encapsulation.NameSpace;


//命名空间下的访问权限在EncapsulationTestLibrary中
//总结：
//
//    访问修饰符只和是否在同个Project下以及是否是子类有关
//
//    public 任何位置可以访问
//    protected internal 在子类或者在Project内，可以访问到
//    internal 只在Project内部可以访问
//    protected 只在子类可以访问
//    private 只在内部能访问到
//  
//    方法，变量，内部类默认都是private


namespace HelloWorldApp.Tutorials
{
    public class EncapsulationSample {
        public class PublicInnerClass { }
        internal class InternalInnerClass { }
        protected class ProtectedInnerClass { }
        protected internal class ProtectedInternalInnerClass { }
        private class PrivateInnerClass { }
        class NormalInnerClass { }

        public int publicMember;
        internal int internalMember;
        protected int protectedMember;
        protected internal int protectedInternalMember;
        private int privateMember;
        int normalMember;

        public void PublicMethod() { }
        protected void ProtectedMethod() { }
        internal void InternalMethod() { }
        protected internal void ProtectedInternalMethod() { }
        private void PrivateMethod() { }
        void NormalMethod() { }


        //所有方法与变量在类内部都能访问（废话）
        void Visiable()
        {
            publicMember = 1;
            protectedMember = 1;
            internalMember = 1;
            protectedInternalMember = 1;
            privateMember = 1;
            normalMember = 1;

            PublicMethod();
            ProtectedMethod();
            InternalMethod();
            ProtectedInternalMethod();
            PrivateMethod();
            NormalMethod();

            new PublicInnerClass();
            new ProtectedInnerClass();
            new InternalInnerClass();
            new ProtectedInternalInnerClass();
            new PrivateInnerClass();
            new NormalInnerClass();
        }
    }

    //同一命名空间下的不同类，不能访问private
    class SameNameSpaceSubClass : EncapsulationSample
    {

        void Visiable()
        {
            publicMember = 1;
            protectedMember = 1;
            internalMember = 1;
            protectedInternalMember = 1;
            //privateMember = 1;
            //normalMember = 1;

            PublicMethod();
            ProtectedMethod();
            InternalMethod();
            ProtectedInternalMethod();
            //PrivateMethod();
            //NormalMethod();

            new PublicInnerClass();
            new ProtectedInnerClass();
            new InternalInnerClass();
            new ProtectedInternalInnerClass();
            //new PrivateInnerClass();
            //new NormalInnerClass();
        }

    }

    //同一命名空间下的不同类，不能访问protected方法
    class SameNameSpaceClass {
        void Visiable() {
            EncapsulationSample sample = new EncapsulationSample();
            sample.publicMember = 1;
            sample.internalMember = 1;
            sample.protectedInternalMember = 1;
            //sample.protectedMember = 1;
            //sample.privateMember = 1;
            //sample.normalMember = 1;

            sample.PublicMethod();
            sample.InternalMethod();
            sample.ProtectedInternalMethod();
            //sample.PrivateMethod();
            //sample.ProtectedMethod();
            //sample.NormalMethod();

            new EncapsulationSample.PublicInnerClass();
            new EncapsulationSample.InternalInnerClass();
            new EncapsulationSample.ProtectedInternalInnerClass();
            //new EncapsulationSample.PrivateInnerClass();
            //new EncapsulationSample.ProtectedInnerClass();
            //new EncapsulationSample.NormalInnerClass();
        }

    }


   

}

//这部分与同个命名空间下是完全相同的
namespace DifferentNameSpace {

    using HelloWorldApp.Tutorials;

    //不同命名空间下的不同类，不能访问private，（与同一命名空间下相同）
    class DifferentNameSpaceSubClass : EncapsulationSample
    {

        void Visiable()
        {
            publicMember = 1;
            protectedMember = 1;
            internalMember = 1;
            protectedInternalMember = 1;
            //privateMember = 1;
            //normalMember = 1;

            PublicMethod();
            ProtectedMethod();
            InternalMethod();
            ProtectedInternalMethod();
            //PrivateMethod();
            //NormalMethod();

            new PublicInnerClass();
            new ProtectedInnerClass();
            new InternalInnerClass();
            new ProtectedInternalInnerClass();
            //new PrivateInnerClass();
            //new NormalInnerClass();
        }

    }

    //不同命名空间下的不同类，不能访问protected方法（与同一命名空间下相同）
    class DifferentNameSpaceClass
    {
        void Visiable()
        {
            EncapsulationSample sample = new EncapsulationSample();
            sample.publicMember = 1;
            sample.internalMember = 1;
            sample.protectedInternalMember = 1;
            //sample.protectedMember = 1;
            //sample.privateMember = 1;
            //sample.normalMember = 1;

            sample.PublicMethod();
            sample.InternalMethod();
            sample.ProtectedInternalMethod();
            //sample.PrivateMethod();
            //sample.ProtectedMethod();
            //sample.NormalMethod();

            new EncapsulationSample.PublicInnerClass();
            new EncapsulationSample.InternalInnerClass();
            new EncapsulationSample.ProtectedInternalInnerClass();
            //new EncapsulationSample.PrivateInnerClass();
            //new EncapsulationSample.ProtectedInnerClass();
            //new EncapsulationSample.NormalInnerClass();
        }

    }
   
}

namespace DifferentProject {

    using Encapsulation.NameSpace;
    //不同工程下的子类，能访问protected，（与同一命名空间下相同）
    class DifferentProjectSubClass : ProjectEncapsulationSample
    {
        

        void Visiable()
        {
            publicMember = 1;
            protectedMember = 1;
            protectedInternalMember = 1;
            //internalMember = 1;
            //privateMember = 1;
            //normalMember = 1;

            PublicMethod();
            ProtectedMethod();
            ProtectedInternalMethod();
            //InternalMethod();
            //PrivateMethod();
            //NormalMethod();

            new PublicInnerClass();
            new ProtectedInnerClass();
            new ProtectedInternalInnerClass();
            //new InternalInnerClass();
            //new PrivateInnerClass();
            //new NormalInnerClass();
        }

    }

    //不同工程下的不同类，只能访问public（与同一命名空间下相同）
    class DifferentProjectClass
    {
        void Visiable()
        {
            ProjectEncapsulationSample sample = new ProjectEncapsulationSample();
            sample.publicMember = 1;
            //sample.internalMember = 1;
            //sample.protectedInternalMember = 1;
            //sample.protectedMember = 1;
            //sample.privateMember = 1;
            //sample.normalMember = 1;

            sample.PublicMethod();
            //sample.InternalMethod();
            //sample.ProtectedInternalMethod();
            //sample.PrivateMethod();
            //sample.ProtectedMethod();
            //sample.NormalMethod();

            new ProjectEncapsulationSample.PublicInnerClass();
            //new ProjectEncapsulationSample.InternalInnerClass();
            //new ProjectEncapsulationSample.ProtectedInternalInnerClass();
            //new EncapsulationSample.PrivateInnerClass();
            //new EncapsulationSample.ProtectedInnerClass();
            //new EncapsulationSample.NormalInnerClass();
        }

    }
}
