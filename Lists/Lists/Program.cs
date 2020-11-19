using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{ // Resizable
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>();
            grades.Add(6);
            grades.Add(5);
            grades.Add(16);
            //------OR--------
            var grades2 = new List<int>() {2,4,5};
            //methods
            grades.Insert(1, 13);
            grades.Remove(16);
            bool found = grades.Contains(89);
            int index =grades.IndexOf(6);

            if (grades == grades2)
            {
                Console.WriteLine("Hello World!");
            }
            //grades2 = grades;
            if (grades.Equals(grades2))
            {
                Console.WriteLine("Same! if same entity not value");

            }
            grades2 = new List<int>() { 2, 4, 5 };
            // Comparing Values
            if (grades.SequenceEqual(grades2))
            {
                Console.WriteLine("Equal Value");

            }
            //LOOPING THROUGH A LIST
            for ( int i =0; i < grades.Count(); i++)
            {
                grades[i] *=2;
                Console.Write(grades[i]);
            }
            foreach (int grade in grades)
            {
                Console.Write(grade);
            }
            Console.WriteLine(grades[1]);
            Console.WriteLine(grades[2]);
            grades.Clear(); // OR -> grades = new List<int>();
            //Nesting
            List<List<int>> nestL = new List<List<int>>() {
                new List<int>{ 1, 2, 34, 5 },
                new List<int>  { 2,3,4,5,4,5,} };
            foreach (List<int> lists in nestL)
            {
                foreach (int list in lists) { 
                    Console.Write(list + "\t");
                }
                Console.WriteLine();
            }
            // Conversion between lists to array and vice versa
            grades2 = new List<int>() { 2, 4, 5 };
            int[] grdArr = grades2.ToArray();
            int[] stuArr = new int[] { 3, 5, 6 };
            List<int> stuList = stuArr.ToList();

            Console.ReadLine();
        }
    }
}
