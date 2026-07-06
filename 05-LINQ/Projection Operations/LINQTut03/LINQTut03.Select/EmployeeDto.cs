using System;
using System.Collections.Generic;
using System.Text;

namespace LINQTut03.Select
{
    public class EmployeeDto
    {
        public string Name { get; set; }
        public int ToatalSkills { get; set; }

        public override string ToString()
        {
            return $"{Name.PadRight(15)} | {ToatalSkills}";
        }

    }
}
