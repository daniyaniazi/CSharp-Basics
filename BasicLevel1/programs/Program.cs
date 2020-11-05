using System; // class contain Console Class

// namespace programs
//{
    class Program
    { 
    static void Main(string[] args)   
        {
        int num;
        num = 10;
        // using reserved word as a varibale
        int @int;
        @int = 5;
        Console.WriteLine("The value of num is = {0} and int number is {1}", num, @int);
        // Arrays
        int[] myArray = new int[3]; //default initiliazed as 0
        Console.WriteLine("My array is {0} ", 100 + myArray[1]);
        // Taking Input
        int input1;
        Console.WriteLine("Enter Any Number");
        // Readline by default read strings so we have to convert data type to integar using  Convert class
        input1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The varible you enter is {0}",input1);
        //DateTime dob;
        //Console.WriteLine("Enter your date of birth");
        //dob = Convert.ToDateTime(Console.ReadLine());
        //Console.WriteLine("Date Of Birth {0}", dob);

        // Conditional Branching
        if (num==10)
        {
            System.Console.WriteLine("The value is 10");

        }
        else
        {
            System.Console.WriteLine("The value has been changed");
        }
        // Switch Statements
        int choice;
        System.Console.WriteLine("Choose one number");
        choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                System.Console.WriteLine("You choose one");
                break;
            case 2:
                System.Console.WriteLine("You choose two");
                break;
            default:
                System.Console.WriteLine("Default option is none");
                break;

        }
        while (choice < 5)
        {
            Console.WriteLine("while loop {0}", choice);
            choice = choice + 1;
        }
        do
        {
            Console.WriteLine("do while loop {0}", choice);
            choice = choice + 1;
        }
        while (choice < 10);
        for (choice = 1; choice < 5; choice++)
        {
            Console.WriteLine("for loop {0}", choice);
        }
        // For EACH LOOP
        // -> Numbers were also accepted as strings
        foreach(string item in args)
        {
            Console.WriteLine("foreach loop {0}", item);
        }
        Console.ReadLine();
    }
    }
//}
// Default Values of the common datatypes
// numeric(int,float,short) = 0
// Bool= False
// Char = '\0'
// Enum = 0
// Refrence = null