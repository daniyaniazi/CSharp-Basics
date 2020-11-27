using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IMultipleInheritance1
    {
        void Test();
        void show();
    }
    interface IMultipleInheritance2
    {
        void Test();
        void show();
    }
    class MulInteritTest : IMultipleInheritance1, IMultipleInheritance2
    {//Explicit implementation
        void IMultipleInheritance1.show()
        {
            Console.WriteLine("Interface show method of I1");
        }
        void IMultipleInheritance2.show()
        {
            Console.WriteLine("Interface show method of I2");
        }
        public void Test() // No ambiguity
        {
            Console.WriteLine("Interface test method implemented");
        }
        static void Main()
        {
            MulInteritTest obj = new MulInteritTest();
            obj.Test();
            //obj.show(); cannot execute
            // Create refrence 
            IMultipleInheritance1 i1 = obj;
            i1.show();
            Console.Read();
            Console.Read();
        }
    }
}
