using System;

namespace DelegatesPart2
   
{
    public delegate string greetDel(string name); 
    //ShortHand of Anonymous Functions
    class LambdaEcpression
    { 
   
        static void Main()
        {
            //lambda Expressions
            //Delegate already lnow th return type and parameters type
            greetDel obj = (name) =>
            {
                return "hello " + name + "Good Day!";
            };
            Console.WriteLine(obj("Daniya"));
            Console.Read();
        }
    }
}
