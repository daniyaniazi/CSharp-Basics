using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollections
{
    public class Customer
    {
        public int custID { get ; set; }
        public string custName { get; set; }
        public string custCity { get; set; }
        public double  Balance { get; set; }
    }
    class DictionaryCollection

    {
        static void Main()
        {
            Dictionary<string, object> dt = new Dictionary<string, object>();
            dt.Add("EmployeeID", 1010); //int
            dt.Add("ENmae", "Jhon"); //string

            //Acess
            foreach (string key in dt.Keys)
                Console.WriteLine(key + " : " + dt[key]); //Store in sequence unlike HashTable


            //User defned type collection
            List<Customer> ListCust = new List<Customer>();
            Customer custObj1 = new Customer { custID = 101,
                custName ="Marry" ,
                custCity ="Karachi" 
                , Balance = 3399.00
            };
            Customer custObj2 = new Customer
            {
                custID = 101,
                custName = "Jhon",
                custCity = "Karachi",
                Balance= 2399.00
            };
            Customer custObj3 = new Customer
            {
                custID = 101,
                custName = "Sid",
                custCity = "Karachi",
                Balance = 2149.00
            };
            ListCust.Add(custObj1);
            ListCust.Add(custObj2);
            ListCust.Add(custObj3);

            foreach(Customer obj in ListCust)
            {
                Console.WriteLine(obj.custID + " | " + obj.custName + " | " + obj.custCity + " | " + obj.Balance);
            }
            Console.Read();
        }
    }
}

// In generic collection the values that can be stored in collection can not only be predefined type like int,float etc 
// it can be user defined class also