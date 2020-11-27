using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface ItestInterface
    {
        void add(int a , int b); //By default public and are abstract
      
    }
    interface ItestInherit
    {
        void sub(int a,int b);
    }
    class ImplementationClass : ItestInherit
    {
        public void add(int a, int b) {
            Console.WriteLine(a+b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }
        static void Main()
        {
            ImplementationClass obj = new ImplementationClass();
            obj.add(29, 90);
            obj.sub(34, 8);
            Console.Read();
            // We can also creafe refrence interfaces
            ItestInherit i = obj; //obj is class object


        }
    }
}
