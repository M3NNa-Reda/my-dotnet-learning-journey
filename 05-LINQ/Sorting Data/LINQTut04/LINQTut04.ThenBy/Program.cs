using LINQTut04.Shared;

namespace LINQTut04.ThenBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();
            var sortedemp01 = employees.OrderBy(x => x.FirstName.Length)
                .ThenBy(x => x.Salary);
            sortedemp01.Print("sortedemp01");

            var sortedemp02 = employees.OrderBy(x => x.FirstName.Length)
                .ThenByDescending(x => x.Salary);
            sortedemp02.Print("sortedemp02");

        }
    }
}
