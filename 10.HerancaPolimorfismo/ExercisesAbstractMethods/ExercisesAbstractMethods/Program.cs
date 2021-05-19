using ExercisesAbstractMethods.Entities;
using System.Collections.Generic;
using System.Globalization;
using System;

namespace ExercisesAbstractMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> list = new List<TaxPayer>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");

                Console.Write("Individual or company (i/c)? ");

                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {                    
                    Console.Write("Health Expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, employees));
                }
            }
           
            Console.WriteLine("\nTAXES PAID: ");

            double totalTax = 0.0;

            foreach(TaxPayer payer in list)
            {
                Console.WriteLine(payer.Name + ": $" + payer.Tax().ToString("F2", CultureInfo.InvariantCulture));
                totalTax += payer.Tax();
            }

            Console.Write("\nTOTAL TAXES: " + totalTax.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
