using System;
using System.Globalization;

namespace lacofor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de casos de testes: ");

            int N = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Informe os valores: ");
                string[] vet = Console.ReadLine().Split(" ");

                double resultado = ((double.Parse(vet[0],CultureInfo.InvariantCulture) * 2) + (double.Parse(vet[1], CultureInfo.InvariantCulture) * 3) 
                                   + (double.Parse(vet[2], CultureInfo.InvariantCulture) * 5)) / 10;
                                   

                Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
