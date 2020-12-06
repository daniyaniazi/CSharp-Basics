using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollections 
{
    public class Student : IComparable<Student>
    {
        public int stuID { get; set; }
        public string stuName { get; set; }
        public int Class { get; set; }
        public double stuMarks { get; set; }
        // Implement interface methods
        public int CompareTo(Student other)
        {
            if (this.stuID > other.stuID)
                return 1;
            else if (this.stuID < other.stuID)
                return -1;
            else
                return 0;
        }
    }
    class CompareMarks : IComparer<Student>
    {
        public int Compare ( Student x ,Student y)
        {
            if (x.stuMarks > y.stuMarks)
                return 1;
            else if (x.stuMarks < y.stuMarks)
                return -1;
            else
                return 0;
        }
    }
    class IComparableCollection
    {
        static void Main()
        {
            Student s1 = new Student { stuID = 109, stuName = "Selena", Class = 10, stuMarks = 78 };
            Student s2 = new Student { stuID = 129, stuName = "Jhon", Class = 9, stuMarks = 99 };
            Student s3 = new Student { stuID = 119, stuName = "Jack", Class = 9, stuMarks = 79 };
            List<Student> studentList = new List<Student>() { s1, s2,s3 };
            CompareMarks obj = new CompareMarks();
            studentList.Sort(obj);
            studentList.Reverse();
            foreach (Student student in studentList ){
                Console.WriteLine(student.stuID + " | " + student.stuName + " | " + student.stuMarks + " | " + student.Class);
            }
            Console.Read();
        }
    }
}
