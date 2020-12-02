using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollections
{
    class DanymicDatatype
    {
        public void Add<T>(T a, T b)
        {
            // c#2.0 -> Datatype of variable is identified at run time 
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }
        public void Mul<T>(T a, T b)
        {
            // c#2.0 -> Datatype of variable is identified at run time 
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }


    }
    class DynamicClass<T> {
        public void Add(T a, T b)
        {
            // c#2.0 -> Datatype of variable is identified at run time 
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }
        public void Mul(T a, T b)
        {
            // c#2.0 -> Datatype of variable is identified at run time 
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
    }

}
