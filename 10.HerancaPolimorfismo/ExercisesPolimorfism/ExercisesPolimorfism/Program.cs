using ExercisesPolimorfism.Entities;
using System.Collections.Generic;
using System.Globalization;
using System;

namespace ExercisesPolimorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i<=n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char tipo = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tipo == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, date));

                }

                else if (tipo == 'i' )
                {
                    Console.Write("Custom fee: " );
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, customFee));
                }

                else
                {
                    products.Add(new Product(name, price));
                }
                
            }

            Console.WriteLine("PRICE TAGS: ");

            foreach (Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }

         

    }
    
}
