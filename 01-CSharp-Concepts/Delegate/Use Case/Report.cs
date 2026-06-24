using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.ConsoleApp1
{
    public class Report
    {
        public delegate bool EligibleSales(Employee e);
        public void ProcessEmployee(Employee[] employees, string title, EligibleSales eligible)
        {
            Console.WriteLine(title);
            Console.WriteLine("----------------------------------");
            foreach (Employee employee in employees)
            {
                if (eligible(employee)) 
                {
                    Console.WriteLine(employee);
                }
            }
            Console.WriteLine("\n");
        }
        // وخلاص مش محتاج كل دا 

        //public void ProcessEmployeeWith6000PlusSales(Employee[] employees)
        //{
        //    Console.WriteLine("Employee With 6000+ Sales");
        //    Console.WriteLine("----------------------------------");
        //    foreach (Employee employee in employees)
        //    {
        //        if (employee.Totalsales >= 6000) 
        //        {
        //            Console.WriteLine(employee);
        //        }
        //    }
        //    Console.WriteLine("\n");
        //}

        //public void ProcessEmployeeWithSalesBetween3000and5999(Employee[] employees)
        //{
        //    Console.WriteLine("Employee With Sales Between 3000and 5999");
        //    Console.WriteLine("----------------------------------");
        //    foreach (Employee employee in employees)
        //    {
        //        if (employee.Totalsales >= 3000 && employee.Totalsales <= 5999) 
        //        {
        //            Console.WriteLine(employee);
        //        }
        //    }
        //    Console.WriteLine("\n");
        //}

        //public void ProcessEmployeeWithSalesLessThan3000(Employee[] employees)
        //{
        //    Console.WriteLine("Employee With Sales Less Than 3000");
        //    Console.WriteLine("----------------------------------");
        //    foreach (Employee employee in employees)
        //    {
        //        if (employee.Totalsales < 3000)
        //        {
        //            Console.WriteLine(employee);
        //        }
        //    }
        //    Console.WriteLine("\n");
        //}


    }
}
