using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileInfoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fi = new FileInfo(@"F:\fileinfoDemo.txt");
            //FileStream fs = fi.Create();
            //created

            string inputtext = Console.ReadLine();
            
            //textmethod
            StreamWriter strwr = fi.CreateText();
            strwr.WriteLine(inputtext);
            strwr.Close();


            //Delete 
            fi.Delete();

        }
    }
}
