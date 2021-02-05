using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //file class
namespace FILEHANDLING
{
    class Program
    {
        //CREATING DIRECTORIES

        static void Main(string[] args)
        {
            string Path = @"F:\DemoDir";
            string path1 = @"F:\DemoDir2";
            // DirectoryInfo dir = new DirectoryInfo(Path);
            // dir.MoveTo(path1); //DemoDir content mover to new dir and hot deleted

            //dir.Create();
            //Console.WriteLine("Directory Created");

            //dir.CreateSubdirectory("DemoSubDir");

            //DirectoryInfo dir = new DirectoryInfo(path1);
            //dir.Delete();//delete only empty directory
            //dir.Delete(true);

            string path3 = @"F:\subdirdemo";
            DirectoryInfo dir = new DirectoryInfo(path3);
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach(var item in dirs)
            {
                Console.WriteLine(item + "  "+ item.FullName+ " " + item.LastAccessTime + " "+ item.Attributes + " " + item.CreationTime+ " " + item.Parent+ " " + item.Root);
                Console.WriteLine(item.GetFiles() + " " + item.GetFiles().Length);
            }
            Console.Read();


        }
            /*
            static void Main(string[] args)
            {
                string path = @"F:\GitProjects\C#Basics\DemoFile.txt"; //raw string
                //check if file exist in the path
                if (File.Exists(path))
                {
                    Console.Write("FILE FOUND");
                    //READING TEXT
                    string data = File.ReadAllText(path);
                    Console.WriteLine(data);
                    //MAKING COPY
                    string path2= @"F:\GitProjects\C#Basics\DemoFileCopy.txt";
                    //File.Copy(path, path2);  //Overloaded 2nd method doesnot allow owerite data of file
                    //copy second overloaded version
                    File.Copy(path, path2 , true);

                }
                else
                {
                    Console.Write("FILE NOT  FOUND");
                }
                Console.Read();
            }*/
        }
}
