using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace SteamWriters
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\fileStreamsDemo.txt";
            
           using (FileStream filestremobj = new FileStream(path, FileMode.Append, FileAccess.Write))
            { //NOW WE DONT WRITE EITH THE HELP OF FILE STREAM BUT WITH STREAM WRITER

               
                using(StreamWriter writer = new StreamWriter(filestremobj ,Encoding.UTF8)){
                    writer.Write("Writing with stream Writer");
                    writer.WriteLine("Statement no 2");
                    writer.WriteLine("Statement no 3");
                    writer.WriteLine("Statement no 4");
                }
                //writer.Close();
                Console.WriteLine("FILE WRITER .. ");

            }

            Console.Read();
        }
    }
}
