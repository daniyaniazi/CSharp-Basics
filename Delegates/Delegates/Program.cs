using System;

namespace Delegates
{
    public delegate int AddNumD(int a, int b);
    public delegate string SayMessage(string name);

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
        public static string SayBuy(string name)
        {
            return "Buy " + name;
        }
        static void Main(string[] args)
        {
            

            Program p = new Program();
            // Creating Instance of delegate 
            AddNumD adel = new AddNumD(p.AddNum);
            // static members
            SayMessage hellomsg = new SayMessage(SayHello);
            SayMessage buymsg = new SayMessage(SayBuy);

            //calling Methods using delegates
            adel.Invoke(10, 33);
            Console.WriteLine( adel(3,6));
            Console.WriteLine(hellomsg("Saniya"));
            Console.WriteLine(buymsg("Saniya"));
            Console.Read();
        }
    }
} 
