using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.ConsoleApp1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Totalsales { get; set; }
        public string Gender { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} | Name: {Name} | Totalsales: {Totalsales} | Gender: {Gender}";
        }
    }
}
