using System;
/*class Program
{
   // Value Type
    static void Main()
    {
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

        Program obj = new Program();
        obj.value = 10;
        programRef ob2j = new programRef();
        ob2j.funcTest(obj); //passing object
        Console.WriteLine(obj.value);
        Console.ReadLine();
    }
    void funcTest(Program obj)
    {
        obj.value = 200;
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
