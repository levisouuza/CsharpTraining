using System;
using System.Globalization;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe as coordenadas X, Y ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            while (x !=0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro Quadrante");
                }

                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo Quadrante");
                }

                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro Quadrante");
                }

                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quarto Quadrante");
                }

                Console.WriteLine("Informe as coordenadas X, Y ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("");

        }
    }
}
