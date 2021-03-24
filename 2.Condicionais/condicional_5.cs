using System;
using System.Globalization;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o códigod o produto e sua quantidade: ");
            string[] vet = Console.ReadLine().Split(" ");

            int cod = int.Parse(vet[0]);
            int qtd = int.Parse(vet[1]);

            if (cod == 1)
            {
                double valor = qtd * 4.0;
                Console.WriteLine("Total: R$  {0}", valor.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if (cod == 2)
            {
                double valor = qtd * 4.5;
                Console.WriteLine("Total: R$  {0}", valor.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if (cod == 3)
            {
                double valor = qtd * 5.0;
                Console.WriteLine("Total: R$  {0}", valor.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if (cod == 4)
            {
                double valor = qtd * 2.0;
                Console.WriteLine("Total: R$  {0}", valor.ToString("F2", CultureInfo.InvariantCulture));
            }

            else
            {
                double valor = qtd * 2.0;
                Console.WriteLine("Total: R$  {0}", valor.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
