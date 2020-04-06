using System;
using System.Linq;
using BusinessLevel;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StoreManager store = new StoreManager())
            {
                Console.WriteLine("Category - Milk");
                store.GetProductsByCategory("Milk").ToList().ForEach(x => Console.WriteLine(x.Name));

                Console.WriteLine("Provider - MeatCompany");
                store.GetProductsByProvider("MeatCompany").ToList().ForEach(x => Console.WriteLine(x.Name));

                Console.ReadLine();
            }
        }
    }
}
