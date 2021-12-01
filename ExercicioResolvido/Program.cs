using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioResolvido.Entities;

namespace ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + " data:");
                Console.Write("Outsorced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'y' || ch == 'Y')
                {
                    Console.Write("Aditional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());

                    list.Add(new OutsourcedEmployee(name, hours, valuePerHours, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHours));
                }
                Console.Clear();
            }

            Console.WriteLine("PAYMENTS:");
            foreach(Employee obj in list)
            {
                Console.WriteLine(obj.Name + ": R$ " + obj.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
