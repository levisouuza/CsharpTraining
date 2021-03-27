
namespace ClassExercises
{
    class Funcionario
    {
        public string funcionario;
        public double salario;
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Globalization;

namespace ClassExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Funcionario FuncOne = new Funcionario();
            Funcionario FuncTwo = new Funcionario();
                   
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Funcionário: ");
            FuncOne.funcionario = Console.ReadLine();
            Console.Write("Salário: ");
            FuncOne.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Funcionário: ");
            FuncTwo.funcionario = Console.ReadLine();
            Console.Write("Salário: ");
            FuncTwo.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double avgSalary = (FuncOne.salario + FuncTwo.salario) / 2;

            Console.WriteLine();

            Console.Write("Salário Médio = ");
            Console.WriteLine(avgSalary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
