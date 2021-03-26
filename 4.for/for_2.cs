using System;

namespace lacofor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um valor: ");

            int N = int.Parse(Console.ReadLine());
            
            int inn = 0;
            int outt = 0;

            for (int i = 1; i <= N+1; i++)
            {
                Console.Write("Número {0} = ", i);
                int num = int.Parse(Console.ReadLine());

                if (10 <= num && num <= 20)
                {
                    inn = ++inn;
                }

                else
                {
                    outt = ++outt;

                }

            }

            Console.WriteLine(inn + " in");
            Console.WriteLine(outt + " out");
        }
    }
}
