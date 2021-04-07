using System;
using System.Globalization;

namespace ExercicioEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string sn_deposito = Console.ReadLine();

            ContaBancaria contabank = new ContaBancaria(conta, nome);

            if (sn_deposito.ToUpper() == 'S'.ToString())
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double valor_inicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                contabank.Deposito(valor_inicial);


            }
            
            Console.WriteLine();

            Console.WriteLine( "Dados da conta:\n" +
                    "Conta " + contabank._conta.ToString()
                   + ", Titular: " + contabank._nome +
                   ", Saldo: $ " + contabank._saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            contabank.Deposito(deposito);

            Console.WriteLine(contabank);

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contabank.Saque(saque);

            Console.WriteLine(contabank);
         

        }
    }
}
