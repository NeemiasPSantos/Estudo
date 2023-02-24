using a03.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace a03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Products> p1 = new List<Products>();
            Console.Write("How many employee will be registred?");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Emproyee #{0}", i);
                Console.Write("id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p1.Add(new Products(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter id that will have salary increase: ");
            int idFind = int.Parse(Console.ReadLine());
            Products v = p1.Find(x => x.Id == idFind);
            if (v != null)
            {
                Console.Write("Enter the percentage: ");
                double increase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                v.IcreaseSalary(increase);
            }
            else 
            {
                Console.WriteLine("Id does not exist!");
            }

            Console.WriteLine("Update list of employees: ");
            foreach (Products obj in p1)
            {
                Console.WriteLine(obj);
            }

        }
    }
}