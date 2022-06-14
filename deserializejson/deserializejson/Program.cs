using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.IO;

namespace deserializejson
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customers = ExampleOneSimpleClassObject();

            if (customers != null)
            {
                for (int i = 0; i < customers.Count; i++)
                {
                    /* System.Diagnostics.Debug.Print(customers[i].Name , customers[i].age, customers[i].email);*/
                    Console.WriteLine("Name  : " + customers[i].Name);
                    Console.WriteLine("age   : " + customers[i].age);
                    Console.WriteLine("Email : " + customers[i].email);
                    Console.WriteLine("");
                }
            }
        }

        static List<Customer> ExampleOneSimpleClassObject()
        {
            string filename = @"D:\\xmlfile\\jsonfileseriali.json";   // path of the json file

            if (File.Exists(filename))
            {
                var customers = JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText(filename));
                return customers;
             
            }
            return null;
        }
    }
}
