using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class TestExtension
    {
        static void Main(string[] args)
        {
            Program progobj = new Program();
            progobj.func1();
            progobj.func3();
            progobj.functionPara(3);

            int i = 32;
            Console.WriteLine(i.IsGreaterThan(9));
            Console.Read();
        }
    }
}
