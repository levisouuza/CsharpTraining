using System;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o horário inicial e final do jogo: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                int duracao = (24 - a) + b;
                Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);  
            }
            else if (a < b)
            {
                int duracao = b - a;
                Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);
            }
            else
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }

        }
    }
}
