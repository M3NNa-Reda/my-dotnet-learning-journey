using LINQTut07.Shared;

namespace LINQTut07.GroupingData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunGroupBy();
            RunToLookup();
        }
        private static void RunGroupBy()
        {
            var emps = Repository.LoadEmployees();
            // Method syntax
            var groups = emps.GroupBy(x => x.Department);
            foreach (var group in groups)
            {
                group.Print($"Employees in Department: {group.Key}");
            }

            // Query syntax
            var groups02 = from e in emps
                           group e by e.Department;
            foreach (var group in groups02)
            {
                group.Print($"Employees in Department: {group.Key}");
            }

        }

        private static void RunToLookup()
        {
            var emps = Repository.LoadEmployees();
           
            var groups = emps.ToLookup(x => x.Department);
            foreach (var group in groups)
            {
                group.Print($"Employees in Department: {group.Key}");
            }

            
        }
    }
}
