using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
//collections are not type save 
namespace Collections
{
    class HashTablesProgram
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("name", "Josh");
            ht.Add("roll no", 26);

            foreach (object key in ht.Keys)
                Console.WriteLine(key + " : " + ht[key]);
            Console.Read();
        }
    }
}
