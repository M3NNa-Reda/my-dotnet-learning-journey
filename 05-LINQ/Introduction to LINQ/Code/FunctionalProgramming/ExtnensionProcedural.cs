using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    public class ExtnensionProcedural
    {
        public static IEnumerable<Employee> GetEmployeesWithFirstNameStartsWith(string value)
        {
            var employees = Repository.LoadEmployees();
            foreach (var employee in employees)
            {
                if(employee.FirstName.ToLower().StartsWith(value.ToLower()))
                {
                    yield return employee;
                }
        }
        }
        public static IEnumerable<Employee> GetEmployeesWithSalaryGreaterThan(decimal minSalary)
        {
            var employees = Repository.LoadEmployees();
            foreach (var employee in employees)
            {
                if (employee.Salary > minSalary)
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesByDepartment(string deptName)
        {
            var employees = Repository.LoadEmployees();
            foreach (var employee in employees)
            {
                if (employee.Department.Equals(deptName, StringComparison.OrdinalIgnoreCase))
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesHiredAfter(DateTime date)
        {
            var employees = Repository.LoadEmployees();
            foreach (var employee in employees)
            {
                if (employee.HireDate > date)
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesWithInsuranceAndNoPension()
        {
            var employees = Repository.LoadEmployees();
            foreach (var employee in employees)
            {
                if (employee.HasHealthInsurance && !employee.HasPensionPlan)
                {
                    yield return employee;
                }
            }
        }

        
        public static void Print<T>(IEnumerable<T> source,string title)
        {
            if (source == null)
                return;
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"|   {title.PadRight(52,' ')}|");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();
            foreach (var item in source) 
                Console.WriteLine(item);
        }
    }
}
