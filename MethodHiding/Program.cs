using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    class Employee
    {
        public decimal Salary;
        public decimal CalculateSalary()
        {
            return Salary;   
        }
    }
    class SalesEmployee : Employee
    {
        public decimal SalesSalary;
        public new decimal CalculateSalary()
        {
            return SalesSalary + Salary;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SalesEmployee emp = new SalesEmployee();
            emp.Salary = 13000;
            emp.SalesSalary = 100;

            decimal sal = emp.CalculateSalary();
            Console.WriteLine(sal);
        }
    }
}
