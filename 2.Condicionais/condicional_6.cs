using System;
using System.Globalization;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número ");
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            if (num < 0)
            {
                Console.WriteLine("Fora do intevalo");
            }

            else if (num <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }

            else if (num <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }

            else if (num <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }

            else if (num <= 100.0)
            {
                Console.WriteLine("Intervalo (75,100]");
            }

            else
            {
                Console.WriteLine("Fora do intevalo");
            }
        }
    }
}
