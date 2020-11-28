using System;

namespace Delegates
{
    public delegate int AddNumD(int a, int b);
    public delegate string SayHelloD(string name);

    class Program
    {
        public int AddNum(int a,int b)
        {
            return a + b;
        }
        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
       static void Main(string[] args)
        {
            

            Program p = new Program();
            // Creating Instance of delegate 
            AddNumD adel = new AddNumD(p.AddNum);
            // static members
             SayHelloD sdel = new SayHelloD(SayHello);

            //calling Methods using delegates
            Console.WriteLine( adel(3,6));
            Console.WriteLine(sdel("Saniya"));
            Console.Read();
        }
    }
} 
