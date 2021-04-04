
using System;
using System.Globalization;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valor_final = ConversorDeMoeda(cotacao, quantidade);
            
            Console.WriteLine("Valor a ser pago em reais = " + valor_final.ToString("F2", CultureInfo.InvariantCulture));

        }

        static double ConversorDeMoeda(double cot, double qtd)
        {
            return (cot * qtd) + (cot * qtd * 0.06);
        }
    }
}
