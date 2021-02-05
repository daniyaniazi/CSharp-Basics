using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    static class MyStaticClass
    {//binding parameter 
        public static void func3(this Program p )
        {

            Console.Write("Extented Function 3");
        }
        public static void functionPara(this Program p , int i)
        {

            Console.Write("Extented Function 4 with parameters : "+ i);
        }

        public static bool IsGreaterThan(this int i , int value)
        {
            return i > value;
        }
    }
}
