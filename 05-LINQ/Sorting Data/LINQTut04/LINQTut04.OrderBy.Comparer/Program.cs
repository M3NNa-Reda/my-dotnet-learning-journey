using LINQTut04.Shared;

namespace LINQTut04.OrderBy.Comparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();
            var sortedEmps = employees.OrderBy(x => x, new EmployeeComparer());
            sortedEmps.Print("sortedEmps");
        }
    }
}
