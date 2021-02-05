using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public delegate string greetDel(string name);
    public delegate void delAnon(string name);
    class AnonymousMethodscs
    {
        public static void method(delAnon del, string name)
        {
            //ONE WAY PASSED AS A FUNCTION
            name = name + "added";
            del.Invoke(name);

        }
        static void Main()
        {
           
            //Anonymous method
            greetDel obj = delegate (string name)
            {
                return "Hello" + name;
            };
            Console.Write(obj("daniya"));

            delAnon delobj = delegate (string name)
            {
               Console.Write( "buy" + name);
            };

            AnonymousMethodscs.method(delobj, "Daniya");
        }
    }
}
