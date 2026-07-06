using System;
using System.Collections.Generic;
using System.Text;

namespace LINQTut03.Shared
{
    public class Employee
    {
        public Employee() { }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<string> Skills { get; set; } = new List<string>();
        
        public override string ToString()
        {
            return string.Format($"" +
                   $"{Id}\t" +
                   $"{String.Concat(LastName, ", ", FirstName).PadRight(15, ' ')}\t" +
                   $"{Email.PadRight(15, ' ')}\t" +
                   $"[{string.Join(", ",Skills)}]");
        }


    }
}
