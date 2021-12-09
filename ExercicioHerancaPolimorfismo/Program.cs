using ExercicioHerancaPolimorfismo.Entities;
using System;
using System.Collections.Generic;

namespace ExercicioHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees:");
            int numberOfEmployees = int.Parse(Console.ReadLine());
            List<Employee> employeesList = new List<Employee>();

            string name;
            int hours;
            double valuePerHour;

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine($"Employee #{i+1} data:");
                Console.Write("Outsourced? (y/n) ");
                string outsourced = Console.ReadLine();

                if(outsourced == "y")
                {
                    GetData(out name, out hours, out valuePerHour);
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());

                    OutsourcedEmployee outsourcedEmployee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    employeesList.Add(outsourcedEmployee);
                }
                else
                {
                    GetData(out name, out hours, out valuePerHour);
                    Employee employee = new Employee(name, hours, valuePerHour);
                    employeesList.Add(employee);
                }
            }

            Console.WriteLine("PAYMENTS:");
            foreach (var item in employeesList)
            {
                Console.WriteLine($"{item.Name} - ${item.Payment()}");
            }
        }

        private static void GetData(out string name, out int hours, out double valuePerHour)
        {
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Hours: ");
            hours = int.Parse(Console.ReadLine());
            Console.Write("Value Per Hour: ");
            valuePerHour = double.Parse(Console.ReadLine());
        }
    }
}
