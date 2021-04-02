
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesClass
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double AumentoSalario(double taxa)
        {
            return (Salario * taxa) / 100;
        }
    }
}



////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Globalization;

namespace ExercisesClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.WriteLine("Informe Nome, Salário Bruto e imposto do funcionário: ");
            
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            func.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario_liquido_inicial = func.Salario - func.Imposto;
            
            Console.WriteLine();
            Console.WriteLine("Funcionário: {0}, $ {1}", func.Nome, salario_liquido_inicial.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double aumento_salarial = func.AumentoSalario(tax);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: {0}, $ {1}", func.Nome, (salario_liquido_inicial + aumento_salarial).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
