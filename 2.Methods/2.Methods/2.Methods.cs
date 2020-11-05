using System;

namespace _2.Methods
{
    class Program
    {
        static void Main(string[] args) //Program class method
        {
            //Here we call out functions
            Program myProgram = new Program(); //instance
            myProgram.Print();
        }
        void Print()
        {
            Console.WriteLine("Hello World!"); // WriteLine member of Console class invoke here
            Console.Read();
        }
    }
}
// Create Method
// Invoke Method
// Static method can be called directly don't have to make an instance
