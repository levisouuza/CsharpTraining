using System;
using System.Globalization;

namespace lacofor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");

            int N = int.Parse(Console.ReadLine());
            int fatorial = 1;

            if (N == 0 || N == 1)
            {
                Console.WriteLine(1);
            }

            else
            {
                fatorial = N;

                for (int i = 1; i <= N-1; ++i)
                {
                    fatorial *= i;
                }
                
                Console.WriteLine("Fatorial: " + fatorial);
            }

            

        }
    }
}
