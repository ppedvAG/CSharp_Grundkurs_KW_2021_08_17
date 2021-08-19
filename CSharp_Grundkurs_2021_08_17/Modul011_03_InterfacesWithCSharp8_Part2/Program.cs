using System;

namespace Modul011_03_InterfacesWithCSharp8_Part2
{
    class Program
    {
        //https://codeshare.io/QnZ6YQ
        
        static void Main(string[] args)
        {
            IBaseInterface _iBaseClass = new BaseClass();
            Console.WriteLine("\n\n ****** Base Class Method Invocation ******* \n");
            _iBaseClass.BaseInterfaceVirtualMethod();
            _iBaseClass.BaseInterfaceDefaultVirtualMethod();

            IDerivedInterface _iDerivedClass = new DerivedClass();
            DerivedClass _DerivedClass = new DerivedClass();
            Console.WriteLine("\n\n ****** Derived Class Method Invocation ******* \n");
            _iDerivedClass.BaseInterfaceVirtualMethod();
            _iDerivedClass.BaseInterfaceDefaultVirtualMethod();
            _iDerivedClass.DerivedInterfaecVirtualMethod();
            _DerivedClass.DerivedInterfaecVirtualMethod();
            _iDerivedClass.BaseInterfaceDefaultMethod();
        }
    }

    public interface IBaseInterface
    {
        public virtual void BaseInterfaceVirtualMethod()
        {
            Console.WriteLine("This is Base Interface - BaseInterfaceVirtualMethod()");
        }

        protected internal void BaseInterfaceDefaultVirtualMethod()
        {
            Console.WriteLine("This is Base Interface : BaseInterfaceDefaultVirtualMethod()");
        }

        public void BaseInterfaceDefaultMethod()
        {
            Console.WriteLine("This is Base Interface : BaseInterfaceDefaultMethod()");
        }
    }

    interface IDerivedInterface : IBaseInterface
    {
        void IBaseInterface.BaseInterfaceVirtualMethod()
        {
            Console.WriteLine("This is Derived Interface : BaseInterfaceVirtualMethod() overridden");
        }

        abstract void IBaseInterface.BaseInterfaceDefaultVirtualMethod();

        public new void BaseInterfaceDefaultMethod()
        {
            Console.WriteLine("This is Derived Interface : BaseInterfaceDefaultMethod() hidden");
        }

        virtual void DerivedInterfaecVirtualMethod()
        {
            Console.WriteLine("This is Derived Interface : DerivedInterfaecVirtualMethod()");
        }
    }

    class BaseClass : IBaseInterface
    {
        void IBaseInterface.BaseInterfaceVirtualMethod()
        {
            Console.WriteLine("This is Base Class : BaseInterfaceVirtualMethod() overridden");
        }
    }


    class DerivedClass : IDerivedInterface
    {
        void IBaseInterface.BaseInterfaceDefaultVirtualMethod()
        {
            Console.WriteLine("This is Derived Class : abstract BaseInterfaceDefaultVirtualMethod() overridden");
        }

        public void DerivedInterfaecVirtualMethod()
        {
            Console.WriteLine("This is Derived Class : DerivedInterfaecVirtualMethod()");
        }
    }
}
