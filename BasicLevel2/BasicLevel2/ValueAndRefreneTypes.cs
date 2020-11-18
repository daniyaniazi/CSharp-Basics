using System;
/*class Program
{
   // Value Type
    static void Main()
    {
        int a = -5;
        int b=a; //copy of a 

        Console.WriteLine(a);
        Console.WriteLine(b);

        b=10 //change in b will not change a value

        Console.WriteLine(a);
        Console.WriteLine(b);

        int value = 10;
        Program obj = new Program();
        obj.functionTest(value);
        Console.WriteLine(value);
        Console.ReadLine();
    }

    void functionTest(int value)
    {
        value = 200;
    }

}*/
// Refrence Type
class Program
{
    public int value;
}
class programRef
{
    static void Main()
    {
        //Arrays
        int[] a = { -5 };
        int[] b = a; // a and b both points to same refrence
        Console.WriteLine(a[0]);
        Console.WriteLine(b[0]);
        b[0] = 10;
        Console.WriteLine(a[0]);
        Console.WriteLine(b[0]);

        Program obj = new Program();
        obj.value = 10;
        programRef ob2j = new programRef();
        ob2j.funcTest(obj); //passing object
        Console.WriteLine(obj.value);
        Console.ReadLine();
    }
    void funcTest(Program obj)
    {
        obj.value = 200; //refrence type can chnage inside a method
    }
}












/*namespace BasicLevel2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}*/
