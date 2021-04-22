using System.Collections.Generic;
using System.Globalization;
using System;

namespace ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int nr_employee = int.Parse(Console.ReadLine());

            List<Employee> employee = new List<Employee>();

            for (int i = 0; i < nr_employee; i++)
            {
                Console.WriteLine("\nEmployee #" + (i+1));
                
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employee.Add(new Employee(id, name, salary));

            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int searchid = int.Parse(Console.ReadLine());

            Employee emp = employee.Find(x => x.Id == searchid);

            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            
            else
            {
                Console.WriteLine("This id does not exist!");
            }


            Console.WriteLine("\nUpdated list of employees:");
            foreach (Employee obj in employee)
            {
                Console.WriteLine(obj);
            }   
            
        }
    }
}
