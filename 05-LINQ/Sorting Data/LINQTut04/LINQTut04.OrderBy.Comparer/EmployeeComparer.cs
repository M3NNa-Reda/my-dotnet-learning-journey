using LINQTut04.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQTut04.OrderBy.Comparer
{
    public class EmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee? e1, Employee? e2)
        {
            // "2017-FI-1343"  => "2017", "FI", "1343"
            var e1Year=Convert.ToInt32(e1.EmployeeNo.Split('-')[0]);
            var e2Year = Convert.ToInt32(e2.EmployeeNo.Split('-')[0]);

            var e1YSeq = Convert.ToInt32(e1.EmployeeNo.Split('-')[2]);
            var e2Seq = Convert.ToInt32(e2.EmployeeNo.Split('-')[2]);

            if(e1Year == e2Year )
            {
                return e1YSeq.CompareTo(e2Seq);
            }
            else
            {
                return e1Year.CompareTo(e2Year);
            }

        }
    }
}
