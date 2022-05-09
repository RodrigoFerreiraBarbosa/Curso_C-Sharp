using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio17_Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered?");
            int m = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Employee#" +(i+1)+ ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }
            Console.Write("Enter the employee id that will have salary increase :");
            int idIn = int.Parse(Console.ReadLine());

            Employee emplo = employees.Find(e => e.Id == idIn);
            if(emplo != null){
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                emplo.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();

            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in employees)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
