using Lista;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int loopQtd = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < loopQtd; i++)
            {
                Console.WriteLine($"Emplyoee #{i + 1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salario: ");
                double salary = double.Parse(Console.ReadLine());

                Employee employee = new Employee();
                employee.Id = id;
                employee.Name = name;
                employee.Salary = salary;

                employees.Add(employee);
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int idUsuario = int.Parse(Console.ReadLine());

            Employee emp = employees.Find(x => x.Id == idUsuario);

            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percentage);
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