
using System;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com dois números inteiro: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a % b == 0)
                {
                    Console.WriteLine("São Múltiplos");
                }
                else
                {
                    Console.WriteLine("Não são múltiplos");
                }
            }
            else if (a < b)
            {
                if (b % a == 0)
                {
                    Console.WriteLine("São Múltiplos");
                }
                else
                {
                    Console.WriteLine("Não são múltiplos");
                }
            }
            else
            {
                Console.WriteLine("Números iguais. Tente novamente");
            }

        }
    }
}
