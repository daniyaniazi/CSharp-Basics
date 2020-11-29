using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesPart2
{
    class GenericDelegates
    {
        // Function with return 
        public static double DelegateRet(int x, float y, double z)
        {
            return x + y + z;
        }
        // Function with void return 
        public static void DelegateVoid(int x, float y, double z)
        {
            Console.WriteLine( x + y + z);
        }
        // Function with Bool return 
        public static bool DelegateBool(string str)
        {
            if (str.Length > 5)
            {
                return true;
            }
            return false;
        }
        static void Main() {
		//Predefined Delegates 
            Func<int,float,double,double> obj1 = DelegateRet;
            double result1 = obj1.Invoke(12, 44, 555);

            Action<int,float,double> obj2 = DelegateVoid;
            obj2.Invoke(12, 44, 555);

            Predicate<string> obj3 = DelegateBool;
            Console.Write(obj3("Daniya"));
            Console.Read();
        }


    }
}
