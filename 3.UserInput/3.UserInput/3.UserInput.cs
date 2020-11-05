using System;

namespace _3.UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            var y = "hello";
            //Expression 
            Console.WriteLine(x + "is odd number "); 
            // "" ->Literal 

            var input = Console.ReadLine();  //Return a String

            // Console.WriteLine("Hello Dear " + input + "!");
            Console.WriteLine($"Hello Dear {input}");
            // Console.WriteLine(input);
            Console.Read();
        }
    }
}
// Identifiers  -> Variable
// Start with _ , Dont start with numbers