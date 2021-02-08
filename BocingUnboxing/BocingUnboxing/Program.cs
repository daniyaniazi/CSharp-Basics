using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BocingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            //Implicit
            Console.WriteLine("boxing");
            Object obj = i;
           
            //Explicit
            int num2 = (int)obj;
            Console.WriteLine("Unboxing");

        }
    }
}
