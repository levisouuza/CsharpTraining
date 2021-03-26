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

            for (int i = 1; i <= N; ++i)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
