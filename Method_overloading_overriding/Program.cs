using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overloading_overriding
{

    public class Calculator 
    {
        public int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        //method overloading
        public int Add(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }
        public decimal Add(decimal n1, decimal n2)
        {
            return n1 + n2;
        }

    }


    class Employee
    {
        public decimal Salary;
        public virtual decimal CalculateSalary()
        {
            return Salary;
        }
    }

    class SalesEmployee : Employee
    {
        public decimal SalesBonus;
        public override decimal CalculateSalary()
        {
            return Salary + SalesBonus;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            //method overloading
            Calculator cal = new Calculator();
            int result = cal.Add(2, 50);
            int result1 = cal.Add(5, 6, 10);
            //decimal result2 = cal.Add(0.3, 0.35);
            Console.WriteLine(result);
            Console.WriteLine(result1);


            //method overriding

            SalesEmployee salesEmployee = new SalesEmployee();
            salesEmployee.Salary = 10000;
            salesEmployee.SalesBonus = 1500;
            decimal salesSalary = salesEmployee.CalculateSalary();
            Console.WriteLine(salesSalary);

            Employee baseEmployee = new Employee();
            baseEmployee.Salary = 60000;
            decimal baseSalary = baseEmployee.CalculateSalary();
            Console.WriteLine(baseSalary);


        }
    }
}
