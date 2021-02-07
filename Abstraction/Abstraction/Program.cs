using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        abstract class Person
        {
            public string name;
            public long number;
            public abstract void PrintDetails();
            public void show() {
                Console.Write("YOU ARE A PERSON");
            }
        }
        class Student :Person
        {
            public int rollno;
            public int clas;

            public override void PrintDetails()
            {
                Console.WriteLine("NAME : " + name + "\n RollNo :"+rollno);
            }
            /*
            public override void show()
            {
                throw new NotImplementedException();
            }*/

        }
       abstract  class Staff : Person
        {
            public string designation;
            public int salary;
            //no method body because it is abstrcat
        }
        static void Main(string[] args)
        {
            Student Daniya = new Student();
            Daniya.name = "Daniya";
            Daniya.rollno = 0001;
            Daniya.PrintDetails();
            Console.Read();
        }
    }
}
