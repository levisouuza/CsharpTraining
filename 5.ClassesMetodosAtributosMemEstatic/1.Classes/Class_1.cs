
namespace ClassExercises
{
    class Pessoa
    {
        public string name;
        public int age;
    }
}

/////////////////////////////////////////////////////////
using System;

namespace ClassExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoaOne, pessoaTwo;

            pessoaOne = new Pessoa();
            pessoaTwo = new Pessoa();

            Console.WriteLine("Informe nome e idade de duas pessoas: ");

            string[] vet = Console.ReadLine().Split(" ");

            pessoaOne.name = vet[0];
            pessoaOne.age = int.Parse(vet[1]);

            pessoaTwo.name = vet[2];
            pessoaTwo.age = int.Parse(vet[3]);

            Console.WriteLine();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            Console.WriteLine(pessoaOne.name);
            Console.Write("Idade: ");
            Console.WriteLine(pessoaOne.age);

            Console.WriteLine("Dados da segunda pessoa:");

            Console.Write("Nome: ");
            Console.WriteLine(pessoaTwo.name);
            Console.Write("Idade: ");
            Console.WriteLine(pessoaTwo.age);

            Console.Write("Pessoa mais velha: ");
            if (pessoaOne.age > pessoaTwo.age)
            {                
                Console.WriteLine(pessoaOne.name);
            }
            else
            {
                Console.WriteLine(pessoaTwo.name);
            }
        }
    }
}
