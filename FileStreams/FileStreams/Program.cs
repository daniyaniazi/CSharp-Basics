using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\fileStreamsDemo.txt";
            //Create open reead writw through fileStream class
            //FileStream fileobj = new FileStream(path ,FileMode.Create , FileAccess.Write ); //File Created  //IF already created then it replace the content with new empty file
            FileStream fileobj = new FileStream(path, FileMode.Create, FileAccess.Write); //File Created

            fileobj.WriteByte(65); //A
            Console.WriteLine("Appending");
            fileobj.WriteByte(68);

            string data = "WELCOME TO C#";
            byte[] write_data = Encoding.UTF8.GetBytes(data);
            fileobj.Write(write_data, 0, (data.Length - 1));
            Console.WriteLine("DATA WRITTEN DONE");
            Console.ReadLine();

            fileobj.Close(); //close
        }
    }
}
/*
OR 

using(FileStream fileobj = new FileStream(path , FileMode.Create );)
{ //open file
 
} // close file */