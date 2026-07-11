using System;
using System.Collections.Generic;
using System.Text;

namespace LINQTut05.Shared
{
    public class Employee
    {
        public Employee() { }

        public int Index { get; set; }
        public string EmployeeNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public List<string> Skills { get; set; } = new List<string>();
        
        public override string ToString()
        {
            return string.Format($"" +
                   $"{Index}\t" +
                   $"{EmployeeNo.PadRight(15, ' ')}\t" +
                   $"{String.Concat(LastName, ", ", FirstName).PadRight(15, ' ')}\t" +
                   $"{Email.PadRight(15, ' ')}\t" +
                    $"${Salary.ToString("0.00")}\t" +
                   $"[{string.Join(", ", Skills)}]");
        }


    }
}
