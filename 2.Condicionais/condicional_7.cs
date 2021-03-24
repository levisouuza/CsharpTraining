using System;
using System.Globalization;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe dois números ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }

            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }

            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }

            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }

            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
