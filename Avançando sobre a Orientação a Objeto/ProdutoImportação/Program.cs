using System;
using Alfadega.Entities;
using System.Globalization;

namespace Alfadega
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            
            List<Product> list = new List<Product>();
            CultureInfo CI = CultureInfo.InvariantCulture;
            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Product {i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char choose = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CI);
                
                if (choose == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsfee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsfee));
                }
                if(choose == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                if(choose == 'c')
                {
                    list.Add(new Product(name, price));
                }

                Console.WriteLine();
            }

            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in list) {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}