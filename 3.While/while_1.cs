using System;
using System.Globalization;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua senha: ");
            double senha = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (senha != 2002)
            {
                 Console.WriteLine("Senha Inválida ");
                 Console.Write("Digite sua senha: ");
                 senha = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Acesso Permitido");

        }
    }
}
