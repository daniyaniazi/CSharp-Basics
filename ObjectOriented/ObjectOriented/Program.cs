using System;
using System.Collections.Generic;

namespace ObjectOriented
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProg = new Program(); //instantiate class
            myProg.doSomething(); //invoke method
            Console.WriteLine("Hello World!");
            Console.Read();
        }
        // method
        public void doSomething()
        {
            User myUser1 = new User();
            //myUser.Name = "Daniya Niazi";
            myUser1.FirstName = "Daniya ";
            myUser1.LastName = "Niazi";
            string mes =myUser1.Output(1);
            //Console.Write(mes);
            //Console.WriteLine(myUser1.ReadMe); // no paranthesis
            myUser1.ReadMe = "Object ORIENTED";
            //Console.WriteLine(myUser1.ReadMe);


            //--------lIST OF USER--------//
            User myUser2 = new User();
            myUser2.FirstName = "Fareeha ";
            myUser2.LastName = "Niazi";

            List<User> users = new List<User>();
            users.Add(myUser1);
            users.Add(myUser2);

            foreach (User usr in users)
            {
                Console.WriteLine(usr.FirstName);
            }

            User.PrintUser(myUser1); //static
            Console.WriteLine(myUser1.Output());
            //overriding
            Console.WriteLine("Override" + myUser1.ToString());
            Student stu1 = new Student("Neha","Ahmed");
            //stu1.FirstName = "Neha"; //Access user class members 
            stu1.HelloToConsole();
        }

    }
}
