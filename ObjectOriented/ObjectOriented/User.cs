using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented
{
    public class User
    {
        public User(string fname, string lname) : base(fname, lname) //constructor 
        {
            FirstName = fname;
            LastName = lname;
        }
        //public string Name; // Accessible outside class
        public string FirstName { get;  }
        public string LastName { get;  }

        //Methods
        public string Output(int times) //Parameters 
        {
            string mes = "";
            for(int i=0; i < times; i++) {
                mes += FirstName + " " + LastName+"\n";
            }
            return mes;
        }
        public string Output()
        {
            //Method overloading
            return "Output Overload";
        }
       string _read="DANIYA";
        public string ReadMe
        {
            get //Getters
            {
                return _read.ToLower();
            }
            set //setters
            {
                _read = value;
            }
        }
        public static void PrintUser(User user) //static methods
        {
            Console.WriteLine("Static Method");
        }
        //Overridng
        public override string ToString()
        {
            return FirstName + " " + LastName;
            //return base.ToString();
        }
        //Virtual Method
        virtual public void HelloToConsole()
        {
            Console.WriteLine("This is a User class");
        }
        //public abstract void noBody(); //Abstarct Methods
        // should be in abstract class
        }
    }
}
