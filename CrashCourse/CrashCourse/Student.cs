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
}
