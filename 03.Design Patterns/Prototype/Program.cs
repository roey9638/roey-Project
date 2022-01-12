using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cus1 = new Customer("Gal",22);

            Customer cus2 = cus1.Clone();

            Customer cus3 = new Customer("Dor",21);

            Bill bill1 = new Bill(cus1 , cus3);

            //Console.WriteLine(bill1);

            cus1.Name = "Bar";

            //Console.WriteLine("----------------------------------------");

            Bill bill2 = bill1.Clone();


            //Console.WriteLine(bill2);

            //[DeepCopy]--------------------------------------------------------------------------------------------
            //Dosen't Work!!!
            Bill afterSerialized = DeepCopy<Bill>(bill1);
            bill1.customer1.Name = "Daniel";
            afterSerialized.customer1.Name = "elad";
            Console.WriteLine(bill1.customer1.Name);
            Console.WriteLine(afterSerialized.customer1.Name);


        }

        //Dosen't Work!!!
        public static T DeepCopy<T>(T self)
        {
            var json = System.Text.Json.JsonSerializer.Serialize(self);
            T obj = System.Text.Json.JsonSerializer.Deserialize<T>(json);
            return obj;
        }
    }
}
