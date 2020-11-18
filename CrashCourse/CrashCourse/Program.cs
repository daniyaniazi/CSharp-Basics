using System;
// Nmaespace is just like a containerminsiding  having multiple classes
namespace CrashCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Null Variable - we can console it without error
            int? n = null;
            Console.WriteLine(n);
            Console.WriteLine("Hello World!");
            Console.Write(" Write line without newline");
            Console.WriteLine(" Hello Testing!");

            // DATA TYPES //
            /*
             int name; -> 4 bytes
             float dec; -> 4 bytes
             char abc; -> 2 bytes
             string word; -> 2 bytes per character
             bool ishappy=true; -> 1 bit
             long whole; -> 8 bytes
             double big; ->8 bytes
             */
             /*
             'C' -> Character
             "C" -> String
             */

            //TYPE CASTING //
            int a = -34;
            uint x1 = 32;
            float b = 34.4F;
            double d = 34.5D;
            decimal e = 5.5M; //decimal is trust worthy with exact precision
            char c = 'c';
            int charInNum = 'c';
            
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(d);
            
            // There are 2 types of casting
            // 1 . Implicit  -> char to int to long to float to double
            int y=3;
            double z = y;
            // error -> char c = z;
            // 2. Explicit
            int x = (int)3.5;
            char letter = (char)977;
            Console.WriteLine(letter);
            // method casting 
            float varr = Convert.ToInt32(3.66);
            //
            double dob = double.NaN;
            Console.WriteLine(double.IsNaN(dob));
            // STRINGS
            char[] characters = { 'D', 'a', 'n', 'i', 'y', 'a' };
            string greeting = new string(characters);
            Console.WriteLine(greeting);
            //interpolation
            Console.WriteLine($"Hello user {greeting}");
            //property
            Console.WriteLine(greeting.Length);
            //Methods
            Console.WriteLine(greeting.CompareTo("Daniya")); // 0 = same , -1= name comes before , 1= name comes after
            Console.WriteLine(greeting.IndexOf("an",1));
            Console.WriteLine(greeting.Remove(1,2)); // remove 2 characte from index 1
            Console.WriteLine(greeting.Trim()); // remove extra spaces
            string[] words =greeting.Split( ' ');
            // String Concatenation
            Console.WriteLine("How Many Candies you want !");
            string candies = Console.ReadLine();
            Console.WriteLine("You will get 4 more candies i,e !"+candies+4);
            Console.WriteLine("You will get 4 more candies i,e !" +( Convert.ToInt32(candies) + 4));
            // LOGICAL OPERATOR
            Console.WriteLine("true & false " + (true && false));
            Console.WriteLine("true & true " + (true && true));
            Console.WriteLine("false & false " + (false && false));
            Console.WriteLine("true || false " + (true || false));
            Console.WriteLine("true || true  " + (true || true));
            Console.WriteLine("false || false " + (false || false));
            //Comparision Operators
            Console.WriteLine(345 > 555);
            Console.WriteLine(345 <= 555);
            Console.WriteLine(345 >= 555);
            Console.WriteLine(345 != 555);
            Console.WriteLine(5 == 5);

            // MATH CLASS//
            double m = 50.5;
            Console.WriteLine(Math.Round(m));
            Console.WriteLine(Math.Ceiling(m));
            Console.WriteLine(Math.Sign(m)); // -1 for - ,0 for 0, 1 for +
            int max = Math.Max(34, 55); //Min
            double dob = Math.Sqrt(44);
            int abs = Math.Abs(-44);
            Console.WriteLine(max);

            //STRINGS //
            String dummystr = "Learning c#";
            Console.WriteLine(dummystr.Length);
            Console.WriteLine(dummystr.ToLower());
            Console.WriteLine(dummystr.ToUpper());
            Console.WriteLine(string.Concat(dummystr, "Concat"));
            //string interpolation
            Console.WriteLine($"You Enter {candies} no of Candies");
            Console.WriteLine(dummystr[9]);
            Console.WriteLine(dummystr.IndexOf("ear"));
            Console.WriteLine(dummystr.Substring(4));
            // Escape characters --> \' \n \t
            Great();
            Console.WriteLine(Add(8, 9));
            // objects
            Student stud1 = new Student();
            stud1.setMarks(30);
            Console.WriteLine(stud1.marks);
            // private member cannot be accessed directly
            Console.WriteLine(stud1.getRoll());
            //
            Person p1 = new Person();
            p1.Firstname="caleb";
            p1.Lastname = "hook";
            Console.WriteLine(p1.Fullname());
            Console.ReadLine();
        }
        //FUNCTIONS DECLARATION
        static void Great()
        {
            Console.WriteLine("Good Evening dear sir");
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
