using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace StreamReaders
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\fileStreamsDemo.txt";
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                Console.WriteLine("Opened");
                using (StreamReader reader = new StreamReader(fs))
                {
                    Console.WriteLine("Reader");


                    //string line = reader.ReadLine(); //read one by cahracter and retirn string
                    //Console.WriteLine(line);
                    //string line ="";
                    //while ((line = reader.ReadLine()) != null)
                    //{
                    //    Console.WriteLine(line);
                    //}

                    //foreach(var item in reader.ReadLine())
                    //{
                    //    Console.WriteLine(item); //character by chaarcter
                    //}

                    //string[] names = new string[3];
                    //for (int i =0; i < names.Length; i++)
                    //{
                    //    names[i] = reader.ReadLine();
                    //}         
                    //foreach (var item in names)
                    //{
                    //    Console.WriteLine(item); 
                    //}

                    string lines = reader.ReadToEnd();
                    Console.WriteLine(lines);
                                                                        
                }

            }
            Console.Read();
        }
    }
}
