using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented
{// public abstract .... -> Abstract Classes that cannot be instantiated
    public class Student : User
    {
        public Student(string fname, string lname) 
        {
            FirstName = fname;
            LastName = lname;
        }

        public override void HelloToConsole()
        {
            Console.WriteLine("This is a Student class");
        }

    }
}
