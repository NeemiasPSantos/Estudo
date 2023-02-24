using System;
using System.Globalization;


namespace a03.Entities
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Products(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IcreaseSalary(double percentage) 
        {
            Salary += ( Salary / percentage);
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                +", "
                + Salary.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
