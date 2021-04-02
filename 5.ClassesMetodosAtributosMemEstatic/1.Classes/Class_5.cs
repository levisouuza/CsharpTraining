using System;
using System.Globalization;

namespace ExercisesClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do Aluno: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double nota_final = n1 + n2 + n3;

            if (nota_final >= 60.0)
            {
                Console.Write("Nota Final = ");
                Console.WriteLine(nota_final.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO");
            }

            else
            {
                Console.Write("Nota Final = ");
                Console.WriteLine(nota_final.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM {0} PONTOS", ((nota_final - 60.0) * -1).ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
