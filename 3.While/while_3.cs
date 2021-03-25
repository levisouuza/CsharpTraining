using System;
using System.Globalization;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o combustível abastecido: ");
            Console.WriteLine("1. Álcool ");
            Console.WriteLine("2. Gasolina ");
            Console.WriteLine("3. Diesel ");
            Console.WriteLine("4. Fim ");

            int combustivel = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (combustivel != 4)
            {
                while (combustivel != 1 && combustivel != 2 && combustivel != 3)
                {
                    Console.Write("Informe um combustível válido: ");
                    combustivel = int.Parse(Console.ReadLine());
                }

                if (combustivel == 1)
                {
                    alcool = ++alcool;
                }
                else if (combustivel == 2)
                {
                    gasolina = ++gasolina;
                }
                else if (combustivel == 3)
                {
                    diesel = ++diesel;
                }

                Console.Write("Informe o combustível abastecido: ");
                combustivel = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Álcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
