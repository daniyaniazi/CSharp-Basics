using System;
using System.Collections;
namespace ArrayListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);

            //Adding items
            al.Add(200); al.Add(300);
            Console.WriteLine(al.Capacity); // Capacity increased
            ArrayList al2 = new ArrayList(10); //specifying capacity
            //Insert in an arraylist
            al.Insert(1, 350);
            foreach (object obj in al)
                Console.WriteLine(obj + "");

            //removing an item'al
            al.Remove(200);
            // by index position
            al.RemoveAt(1);
            Console.Read();
        }
                    
    }
}
