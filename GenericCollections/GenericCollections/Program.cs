using System;

namespace GenericCollections
{
    class Program
    { //A singke genral function declare for any data type parameter
        public bool Compare<T>(T a, T b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            bool res = obj.Compare<float>(12.43f, 33.5f);
            Console.WriteLine(res);

            bool res2 = obj.Compare<int>(12, 33);
            Console.WriteLine(res);

            // Dynamic Dtatype
            DanymicDatatype DtObj = new DanymicDatatype();
            DtObj.Add<int>(12, 4);
            DtObj.Add<float>(12.4f, 4.44f);

            //OR
            DynamicClass<int> DtObjint = new DynamicClass<int>();
            DtObjint.Add(12, 4);

            DynamicClass<float> DtObjfloat= new DynamicClass<float>();
            DtObjfloat.Add(12.5f, 4.90f);
            Console.Read();
        }
    }
}
