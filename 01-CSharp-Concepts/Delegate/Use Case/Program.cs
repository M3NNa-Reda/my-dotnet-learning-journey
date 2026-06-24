using CSharp.ConsoleApp1;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;
namespace CSharp.ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var employees = new Employee[]
            {
                new Employee{Id=1, Name="Menna",Totalsales=5646.9m,Gender="F"},
                new Employee{Id=2, Name="Momen",Totalsales=4646.9m,Gender="M"},
                new Employee{Id=3, Name="Mai",Totalsales=8646.9m,Gender="F"},
                new Employee{Id=4, Name="Ahmed",Totalsales=1646.9m,Gender="M"},
                new Employee{Id=5, Name="Mona",Totalsales=68846.9m,Gender="F"}

            };
            var report = new Report();
            report.ProcessEmployee(employees, "Employee With 6000+ Sales", greterthanOrEqual6000); // Named Method
            report.ProcessEmployee(employees, "Employee With 6000+ Sales", delegate (Employee e) { return e.Totalsales >= 6000; }); //Anonymous Delegate
            report.ProcessEmployee(employees, "Employee With 6000+ Sales", e => e.Totalsales >= 6000); // Lambda Expression

            Console.ReadKey();
        }
        static bool greterthanOrEqual6000(Employee e)
        {
            return e.Totalsales >= 6000;
        }

    }    
   
}



