using System;
using System.Diagnostics;
using System.Globalization;
using Course.Entities;
using Course.Entities.Enum;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);//isso foi add antes do final(alteração)

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            CultureInfo CI = CultureInfo.InvariantCulture;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter #" + i +" item data:");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine(), CI);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(prodName, prodPrice);
                OrderItem item = new OrderItem(quantity, prodPrice, product);
                
                order.AddItem(item);
                Console.WriteLine();
            }

            Console.WriteLine(order);
        }
    }
}