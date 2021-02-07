using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexerdemo
{
    class Program
    {
        class Student
        {
            private static int countId = 0;
            private int _stdId;
            private string _StdNm;


            public Student(){
                Student.countId = Student.countId + 1;
                this._stdId = Student.countId;
                }
            public int StdId
            {//ReadOnly 

                get
                {
                    return _stdId;
                }
            }
            public string StdName
            {//ReadOnly 
                set
                {
                    this._StdNm = value;
                }
                get
                {

                    return _StdNm;
                }
            }

        }
        class Employee
        {
           
            private int[] Age = new int[3];

            public int this[int index]
            {
                get { return Age[index]; }
                set {
                    if (value >= 0)
                        Age[index] = value;
                    else
                        Console.WriteLine("Value is invalid");
                }

            }
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp[1] = 1;
            emp[2] = 2;
            emp[0] = 3;
            Console.WriteLine(emp[1]);
            Student stud1 = new Student();
            stud1.StdName = "DANIYA";
            Student stud2 = new Student();
            stud2.StdName = "Fareeha";

            Console.WriteLine(stud1.StdId + " : " + stud1.StdName);
            Console.WriteLine(stud2.StdId + " : " + stud2.StdName);
           
            Console.Read();
        }
    }
}
