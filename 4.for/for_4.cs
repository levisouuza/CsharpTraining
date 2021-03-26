using System;
using System.Globalization;

namespace lacofor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de pares de números: ");

            int N = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Informe os valores: ");

                string[] vet = Console.ReadLine().Split(" ");
                
                if (int.Parse(vet[1]) == 0)
                {
                    Console.WriteLine("Divisão impossível");
                }
                else
                {
                    double div = double.Parse(vet[0], CultureInfo.InvariantCulture) / double.Parse(vet[1], CultureInfo.InvariantCulture);
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}
