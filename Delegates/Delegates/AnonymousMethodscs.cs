using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public delegate string greetDel(string name);
    class AnonymousMethodscs
    {

        static void Main()
        {
            //Anonymous method
            greetDel obj = delegate (string name)
            {
                return "Hello" + name;
            };
            Console.Write(obj("namae"));
        }
    }
}
