using System;
using System.Linq;

namespace LINQS
{
    class Program
    {
        static void Main(string[] args)

        {
            
            int[] arr = { 12, 33, 44, 55, 66, 77, 88, 32, 34, 23, 54, 5, 676, 78, 87, 65, 9 };
            var barr = from i in arr where i > 40 orderby i select i;

            foreach (int x in barr)
                Console.Write(x + " ");
            Console.Read();
        }
    }
}
