using EnumComposicoes.Entities.Enums;
using EnumComposicoes.Entities;
using System.Globalization;
using System;

namespace EnumComposicoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            
            Console.Write("Name: ");
            string clientName = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client client = new Client(clientName, email, date);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");

            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, orderStatus, client);

            Console.Write("How many items to this order? ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem order_item = new OrderItem(quantity, price, product);

                order.AddItem(order_item);

            }

            Console.WriteLine(order);

        }
    }
}
