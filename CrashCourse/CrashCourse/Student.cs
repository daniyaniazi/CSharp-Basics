using System;
using System.Collections.Generic;
using System.Text;

namespace CrashCourse
{
    class Student
    {
        // properties
        public string name = "daniya";
        public int marks = 89;
        private int rollNo=26;
        // methods
        public void setMarks(int m)
        {
            marks = m;
        }
        public int getRoll()
        {
            return rollNo;
        }
    }
    public class Person
    {
        //Feild names
        string _idNo = "DEE45G";
        public string Firstname
        {
            get;
            set;
        }
        public string Lastname
        {
            get;
            set;
        }
        public string Fullname
        {
            get
            {
                return Firstname + Lastname;
            }
        }
    }
}
